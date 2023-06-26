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
            "[Ремонт].[ID]," +
            "[СтатусЗаявки]," +
            "[ДатаСозданияЗаявки]," +
            "[ДатаПринятияЗаявки]," +
            "[ДатаОкончанияРемонта]," +
            "[Оборудование].[Тип] AS [ТипОборудования]," +
            "[НеисправностьВЗаявке]," +
            "[ОтчетОРемонте]," +
            "[ЮзерыСистемы].[Логин] AS [ЗаявкаОт]," +
            "[ИсторияСобытий].[IDОборудования]," +
            "CONCAT_WS(' --- ', " +
                    "[Процессор], [Видеокарта], [ОперативнаяПамять], [ЖесткийДиск], " +
                    "[СправочникПринтеры].[Марка], [СправочникПринтеры].[Модель], [ФорматПечати], " +
                    "[СправочникМониторы].[Марка], [СправочникМониторы].[Модель], [Диагональ]) AS [Характеристика] " +
            

                    "from [Ремонт]" +


            "left join [ИсторияСобытий] on [ИсторияСобытий].[ID] = [Ремонт].[IDСобытия] " +

            "LEFT JOIN [СистемныеБлоки] ON [ИсторияСобытий].[IDОборудования] = [СистемныеБлоки].[IDОборудования] " +
            "LEFT JOIN [СправочникСистемныеБлоки] ON [СистемныеБлоки].[IDЗаписиСправочника] = [СправочникСистемныеБлоки].[ID] " +

            "LEFT JOIN [Принтеры] ON [ИсторияСобытий].[IDОборудования]  = [Принтеры].[IDОборудования] " +
            "LEFT JOIN [СправочникПринтеры] ON [Принтеры].[IDЗаписиСправочника] = [СправочникПринтеры].[ID] " +

            "LEFT JOIN [Мониторы] ON [ИсторияСобытий].[IDОборудования]  = [Мониторы].[IDОборудования] " +
            "LEFT JOIN [СправочникМониторы] ON [Мониторы].[IDЗаписиСправочника] = [СправочникМониторы].[ID] " +

            "LEFT JOIN [ЮзерыСистемы] ON [ИсторияСобытий].[IDЮзера] = [ЮзерыСистемы].[ID]" +

            "left join [Оборудование] on [Оборудование].[ID] = [ИсторияСобытий].[IDОборудования]";

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

            status_box.Items.Add("Ждет принятия");
            status_box.Items.Add("В работе");
            status_box.Items.Add("Закрыта");

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
            RequestForm requestForm = new RequestForm(Convert.ToInt32(dataTable.Rows[request_list.CurrentRow.Index]["ID"]),
                Convert.ToInt32(dataTable.Rows[request_list.CurrentRow.Index]["IDОборудования"]),
                dataTable.Rows[request_list.CurrentRow.Index]["ТипОборудования"].ToString(),
                dataTable.Rows[request_list.CurrentRow.Index]["Характеристика"].ToString(),
                dataTable.Rows[request_list.CurrentRow.Index]["НеисправностьВЗаявке"].ToString(),
                dataTable.Rows[request_list.CurrentRow.Index]["СтатусЗаявки"].ToString());
            requestForm.FormClosed += RequestForm_FormClosed;
            
            requestForm.Show();
        }

        private void RequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDataInDataGridView(applicationsQuery);
        }

        private void search_req_button_Click(object sender, EventArgs e)
        {
            //поиск по id заявки
            string query;
            if (search_req_id_box.Text != "") query = applicationsQuery + $" Where [ИсторияСобытий].[IDОборудования] = '{Convert.ToInt32(search_req_id_box.Text)}' AND [СтатусЗаявки] LIKE '%{status_box.Text}%'";
            else query = applicationsQuery + $" Where [СтатусЗаявки] LIKE '%{status_box.Text}%'";
            LoadDataInDataGridView(query);
        }

        private void search_req_clear_Click(object sender, EventArgs e)
        {
            search_req_id_box.Text = "";
            status_box.Text = "";

            search_req_button_Click(null,null);
        }

        private void request_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //открытие заявки по DoubleClick
            open_request_Click(null, null);
        }

        private void search_req_id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
