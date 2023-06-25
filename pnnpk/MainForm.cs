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
    
    public partial class MainForm : Form
    { 
        public static SqlConnection connection = null;
        public static int userID = 0;
        public static string userType = "";

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

        public MainForm()
        {
            InitializeComponent();
            //авторизация -> вывод соответсвующего groupbox
            switch (userType)
            {
                case "Закупщик":
                    purchaser_groupbox.Visible = true;               
                    break;
                case "Кладовщик":
                    storekeeper_groupbox.Visible = true;
                    storekeeper_groupbox.Location = new Point(engineer_groupbox.Location.X, 398);
                    break;
                case "Инженер":
                    engineer_groupbox.Visible = true;
                    engineer_groupbox.Location = new Point(engineer_groupbox.Location.X, 398);
                    break;
                case "Админ":
                    purchaser_groupbox.Visible = true;
                    storekeeper_groupbox.Visible = true;
                    engineer_groupbox.Visible = true;   
                    break;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Data Source=LAPTOP-UCG1G1UG\SQLEXPRESS;Initial Catalog=equipment accounting;Integrated Security=True");
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadDataInDataGridView(equipmentQuery);

            type_box.Items.Add("Системный блок");
            type_box.Items.Add("Монитор");
            type_box.Items.Add("Принтер");

            status_box.Items.Add("Используется");
            status_box.Items.Add("На складе");
            status_box.Items.Add("Списан");
            status_box.Items.Add("В заявке");
            status_box.Items.Add("В ремонте");
        }

        private void LoadDataInDataGridView(string query)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(query, connection);
                builder = new SqlCommandBuilder(dataAdapter);
                dataTable.Clear();
                //dataTable.Columns.Clear();               
                dataAdapter.Fill(dataTable);
                equipment_list.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            //поиск по всем фильтрам
            string query = equipmentQuery;

            bool addAnd = false;
            bool addOr = false;
            bool filtersSpecified = false;

            List<string> stringFilters = new List<string> { 
                search_box1.Text, 
                search_box2.Text, 
                search_box3.Text, 
                search_box4.Text };

            List<string> stringFiltersColumns = new List<string> { 
                "[Оборудование].[ID]", 
                "[Тип]", 
                "[Статус]",
                "[IDПользователя]",
                "[ФИО]",
                "[IDОтдела]",
                "[НазваниеОтдела]",
                "[Кабинет]",
                "[IDГруппы]",
                "CONCAT_WS(' --- ', [Процессор], [Видеокарта], [ОперативнаяПамять], [ЖесткийДиск], [СправочникПринтеры].[Марка], [СправочникПринтеры].[Модель], [ФорматПечати], [СправочникМониторы].[Марка], [СправочникМониторы].[Модель], [Диагональ])" 
            };

            List<string> singularFilters = new List<string> { 
                type_box.Text, 
                status_box.Text, 
                search_item_id_box.Text, 
                search_emp_id_box.Text, 
                search_group_id_box.Text,
                search_dep_id_box.Text,
                search_cab_num_box.Text
            };

            List<string> specifiedFiltersColumns = new List<string> {
                "[Тип]",
                "[Статус]",
                "[Оборудование].[ID]",
                "[IDПользователя]",
                "[IDГруппы]",
                "[IDОтдела]",
                "[Кабинет]"
            };

            foreach (string filter in stringFilters) if (filter != "") filtersSpecified = true;
            foreach (string filter in singularFilters) if (filter != "") filtersSpecified = true;

            if (filtersSpecified)
            {
                query += " WHERE ";

                foreach (string filter in stringFilters)
                {
                    if (filter != "")
                    {
                        if (addAnd) query += " AND ";

                        addOr = false;
                        query += "(";
                        foreach (var column in stringFiltersColumns)
                        {
                            if (addOr) query += " OR ";
                            query += $"{column} LIKE '%{filter}%'";
                            addOr = true;
                        }
                        query += ") ";

                        addAnd = true;
                    }
                }

                for (int i = 0; i < singularFilters.Count; i++)
                {
                    
                    if (singularFilters[i] != "")
                    {
                        if (addAnd) query += " AND ";
                        query += $"({specifiedFiltersColumns[i]} LIKE '%{singularFilters[i]}%')";
                        addAnd = true;
                    }
                }
            }
            LoadDataInDataGridView(query); 
        }

        private void search_clear1_Click(object sender, EventArgs e)
        {
            search_box1.Text = "";
            search_box2.Text = "";
            search_box3.Text = "";
            search_box4.Text = "";

            search_button_Click(null, null);
        }

        private void search_clear2_Click(object sender, EventArgs e)
        {
            type_box.Text = "";

            search_button_Click(null, null);
        }

        private void search_clear3_Click(object sender, EventArgs e)
        {
            status_box.Text = "";

            search_button_Click(null, null);
        }

        private void search_clear4_Click(object sender, EventArgs e)
        {
            search_item_id_box.Text = "";

            search_button_Click(null, null);
        }

        private void search_clear5_Click(object sender, EventArgs e)
        {
            search_emp_id_box.Text = "";

            search_button_Click(null, null);
        }

        private void search_clear6_Click(object sender, EventArgs e)
        {
            search_group_id_box.Text = "";

            search_button_Click(null, null);
        }

        private void search_clear7_Click(object sender, EventArgs e)
        {
            search_dep_id_box.Text = "";

            search_button_Click(null, null);
        }

        private void search_clear8_Click(object sender, EventArgs e)
        {
            search_cab_num_box.Text = "";

            search_button_Click(null, null);
        }

        private void search_clear_Click(object sender, EventArgs e)
        {
            search_clear1_Click(null, null);
            search_clear2_Click(null, null);
            search_clear3_Click(null, null);
            search_clear4_Click(null, null);
            search_clear5_Click(null, null);
            search_clear6_Click(null, null);
            search_clear7_Click(null, null);
            search_clear8_Click(null, null);

            search_button_Click(null, null);
        }

        private void request_list_button_Click(object sender, EventArgs e)
        {
            RequestListForm requestListForm = new RequestListForm();
            requestListForm.Show();
        }

        private void write_off_button_Click(object sender, EventArgs e)
        {
            //списать выделенное оборудование
            string query = $"UPDATE [Оборудование] SET [Статус] = 'Списан' " +
                $"WHERE [ID] = {Convert.ToInt32 (equipment_list[0, equipment_list.CurrentRow.Index].Value)}";
            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();
            LoadDataInDataGridView(equipmentQuery);
        }

        private void buy_button_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.Show();

            purchaseForm.FormClosed += PurchaseForm_FormClosed;
        }

        private void PurchaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDataInDataGridView(equipmentQuery);
        }

        private void open_item_button_Click(object sender, EventArgs e)
        {
            //просмотр истории оборудования по ID
            
            ItemForm itemForm = new ItemForm
                (equipment_list[0, equipment_list.CurrentRow.Index].Value.ToString(),
                equipment_list[8, equipment_list.CurrentRow.Index].Value.ToString(),
                equipment_list[1, equipment_list.CurrentRow.Index].Value.ToString(),
                equipment_list[9, equipment_list.CurrentRow.Index].Value.ToString());
            itemForm.Show();
        }

        private void request_button_Click(object sender, EventArgs e)
        {
            //создание заявки на ремонт
            CreateRequestForm createRequestForm = new CreateRequestForm(Convert.ToInt32(equipment_list[0, equipment_list.CurrentRow.Index].Value));
            createRequestForm.Show();
        }

        private void change_emp_button_Click(object sender, EventArgs e)
        {
            //смена пользователя
            ChangeEmpForm changeEmpForm = new ChangeEmpForm();
            changeEmpForm.Show();
        }

        private void move_button_Click(object sender, EventArgs e)
        {
            //перемещение оборудования
            ChangeDepForm changeDepForm = new ChangeDepForm(Convert.ToInt32(equipment_list[5, equipment_list.CurrentRow.Index].Value),
                equipment_list[6, equipment_list.CurrentRow.Index].Value.ToString(),
                equipment_list[7, equipment_list.CurrentRow.Index].Value.ToString());
            changeDepForm.Show();
        }

        private void equipment_list_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            open_item_button_Click(sender, e);
        }
    }
}
