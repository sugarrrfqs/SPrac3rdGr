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
    public partial class EquipmentListForm : Form
    {
        private int itemID;
        private string type;

        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();
        private string equipmentQuery =
            "SELECT " +
                    "[Оборудование].[ID], " +
                    "[Тип], " +
                    "[Статус], " +
                    "[IDПользователя] AS [ID Пользователя], " +
                    "[ФИО] AS [Пользователь], " +
                    "[IDОтдела] AS [ID Отдела], " +
                    "[НазваниеОтдела] AS [Отдел]," +
                    "[Кабинет], " +
                    "[IDГруппы] AS [ID Группы], " +

                    "CONCAT_WS(' --- ', " +
                    "[Процессор], [Видеокарта], [ОперативнаяПамять], [ЖесткийДиск], " +
                    "[СправочникПринтеры].[Марка], [СправочникПринтеры].[Модель], [ФорматПечати], " +
                    "[СправочникМониторы].[Марка], [СправочникМониторы].[Модель], [Диагональ]) AS [Характеристика] " +


                "FROM [Оборудование] " +


                    "LEFT JOIN [СистемныеБлоки] ON [Оборудование].[ID] = [СистемныеБлоки].[IDОборудования] " +
                    "LEFT JOIN [СправочникСистемныеБлоки] ON [СистемныеБлоки].[IDЗаписиСправочника] = [СправочникСистемныеБлоки].[ID] " +

                    "LEFT JOIN [Принтеры] ON [Оборудование].[ID] = [Принтеры].[IDОборудования] " +
                    "LEFT JOIN [СправочникПринтеры] ON [Принтеры].[IDЗаписиСправочника] = [СправочникПринтеры].[ID] " +

                    "LEFT JOIN [Мониторы] ON [Оборудование].[ID] = [Мониторы].[IDОборудования] " +
                    "LEFT JOIN [СправочникМониторы] ON [Мониторы].[IDЗаписиСправочника] = [СправочникМониторы].[ID] " +

                    "LEFT JOIN [Пользователи] ON [Оборудование].[IDПользователя] = [Пользователи].[ID]" +

                    "LEFT JOIN [Отделы] ON [Оборудование].[IDОтдела] = [Отделы].[ID]";
        public EquipmentListForm(int id, string t)
        {
            InitializeComponent();
            itemID = id;
            type = t;
            equipmentQuery += $" where [Оборудование].[Тип] = '{type}'";
            LoadDataInDataGridView(equipmentQuery + $" and [Оборудование].[ID] <> '{itemID}'");     
        }

        private void LoadDataInDataGridView(string query)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(query, MainForm.connection);
                builder = new SqlCommandBuilder(dataAdapter);
                dataTable.Clear();            
                dataAdapter.Fill(dataTable);
                equipment_list.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //замена оборудования по DoubleClick
            change_button_Click(null, null);
        }

        private void EquipmentReplacementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //если вдруг пользователь передумал, просто принимаем заявку без замены
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            //замена оборудования
            string query = equipmentQuery + $" and [Оборудование].[ID] = '{itemID}'";

            dataAdapter = new SqlDataAdapter(query, MainForm.connection);
            builder = new SqlCommandBuilder(dataAdapter);
            DataTable tempTable = new DataTable(); // Таблица с одной записью - сломанным оборудованием
            tempTable.Clear();
            dataAdapter.Fill(tempTable);


            DataRow row = dataTable.Rows[equipment_list.CurrentRow.Index];     // Выделенная строка      

            if (tempTable.Rows[0][8].ToString() != "")
            query = $"UPDATE [Оборудование] SET " +
                $"[Статус] = 'Используется', " +
                $"[IDПользователя] ='{tempTable.Rows[0][3]}'," +
                $"[IDОтдела] = '{tempTable.Rows[0][5]}'," +
                $"[Кабинет] = '{tempTable.Rows[0][7]}'," +
                $"[IDГруппы] = '{tempTable.Rows[0][8]}'" +
                $"WHERE [ID] = '{Convert.ToInt32(row["ID"])}'";

            else
            query = $"UPDATE [Оборудование] SET " +
                $"[Статус] = 'Используется', " +
                $"[IDПользователя] ='{tempTable.Rows[0][3]}'," +
                $"[IDОтдела] = '{tempTable.Rows[0][5]}'," +
                $"[Кабинет] = '{tempTable.Rows[0][7]}'," +
                $"[IDГруппы] = NULL " +
                $"WHERE [ID] = '{Convert.ToInt32(row["ID"])}'";

            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            Close();
        }
    }
}
