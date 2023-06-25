using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pnnpk
{
    public partial class RequestListForm : Form
    {
        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();
        private string applicationsQuery = 
            "Select " +
                    "[ИсторияСобытий].[ID]," +
                    "[ТипСобытия]," +
                    "[Дата]," +
                    "[ДатаПринятияЗаявки]," +
                    "[ДатаОкончанияРемонта]," +
                    "[ИсторияСобытий].[IDОборудования]," +
                    "[ИсторияСобытий].[IDЮзера]," +
                    "[ЮзерыСистемы].[Логин]," +
                    "[НеисправностьВЗаявке]," +
                    "[ОтчетОРемонте]," +

                    "CONCAT_WS(' --- ', " +
                    "[Процессор], [Видеокарта], [ОперативнаяПамять], [ЖесткийДиск], " +
                    "[СправочникПринтеры].[Марка], [СправочникПринтеры].[Модель], [ФорматПечати], " +
                    "[СправочникМониторы].[Марка], [СправочникМониторы].[Модель], [Диагональ]) AS [Характеристика] " +


             "from [ИсторияСобытий]  " +


                    "Left join [ЗаявкаНаРемонт] on [ЗаявкаНаРемонт].[IDСобытия] = [ИсторияСобытий].[ID]" +
                    "Left join [Ремонт] on [Ремонт].[IDСобытия] = [ИсторияСобытий].[ID]" +

                    "LEFT JOIN [СистемныеБлоки] ON [ИсторияСобытий].[IDОборудования] = [СистемныеБлоки].[IDОборудования] " +
                    "LEFT JOIN [СправочникСистемныеБлоки] ON [СистемныеБлоки].[IDЗаписиСправочника] = [СправочникСистемныеБлоки].[ID] " +

                    "LEFT JOIN [Принтеры] ON [ИсторияСобытий].[IDОборудования]  = [Принтеры].[IDОборудования] " +
                    "LEFT JOIN [СправочникПринтеры] ON [Принтеры].[IDЗаписиСправочника] = [СправочникПринтеры].[ID] " +

                    "LEFT JOIN [Мониторы] ON [ИсторияСобытий].[IDОборудования]  = [Мониторы].[IDОборудования] " +
                    "LEFT JOIN [СправочникМониторы] ON [Мониторы].[IDЗаписиСправочника] = [СправочникМониторы].[ID] " +

                    "LEFT JOIN [ЮзерыСистемы] ON [ИсторияСобытий].[IDЮзера] = [ЮзерыСистемы].[ID]" +


            "where ([ТипСобытия] = 'ЗаявкаНаРемонт' or [ТипСобытия] = 'Ремонт')";
        public RequestListForm()
        {
            InitializeComponent();
            string loginQuery = $"Select * from [ЮзерыСистемы] where [ID] = {MainForm.userID}";
            dataAdapter = new SqlDataAdapter(loginQuery, MainForm.connection);
            builder = new SqlCommandBuilder(dataAdapter);
            dataTable.Clear();     
            dataAdapter.Fill(dataTable);

            login_label.Text = dataTable.Rows[0][1].ToString();
            dataTable.Columns.Clear();
            // --сделать привязку ФИО по логину-- (Фио не привязано к логину)

            LoadDataInDataGridView(applicationsQuery);
        }
        private void LoadDataInDataGridView(string query)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(query, MainForm.connection);
                builder = new SqlCommandBuilder(dataAdapter);
                dataTable.Clear();            
                dataAdapter.Fill(dataTable);
                request_list.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void open_request_Click(object sender, EventArgs e)
        {
            //открытие выделенной в таблице заявки
            RequestForm requestForm = new RequestForm();
            requestForm.Show();
        }

        private void search_req_button_Click(object sender, EventArgs e)
        {
            //поиск по id заявки
            //query = 
        }

        private void search_req_clear_Click(object sender, EventArgs e)
        {
            search_req_id_box.Text = "";

            search_req_button_Click(null,null);
        }

        private void request_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //открытие заявки по DoubleClick
        }
    }
}
