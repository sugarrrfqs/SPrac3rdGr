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
    public partial class BrowseItemForm : Form
    {
        string type;
        List<string> stringFiltersColumns;
        AddItemForm main;

        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();
        string descriptionQuery = $"SELECT * FROM [Справочник";
        public BrowseItemForm(string t)
        {
            InitializeComponent();
            type = t;
            

            switch (type)
            {
                case "Системный блок":
                    descriptionQuery += "СистемныеБлоки]";
                    stringFiltersColumns = new List<string>
                    {
                        "[СправочникСистемныеБлоки].[ID]",
                        "[Процессор]",
                        "[Видеокарта]",
                        "[ОперативнаяПамять]",
                        "[ЖесткийДиск]"
                    };
                    break;
                case "Монитор":
                    descriptionQuery += "Мониторы]";
                    stringFiltersColumns = new List<string>
                    {
                        "[СправочникМониторы].[ID]",
                        "[СправочникМониторы].[Марка]",
                        "[СправочникМониторы].[Модель]",
                        "[Диагональ]"
                    };
                    break;
                case "Принтер":
                    descriptionQuery += "Принтеры]";
                    stringFiltersColumns = new List<string>
                    {
                        "[СправочникПринтеры].[ID]",
                        "[СправочникПринтеры].[Марка]",
                        "[СправочникПринтеры].[Модель]",
                        "[ФорматПечати]"
                    };
                    break;
            }

            LoadDataInDataGridView(descriptionQuery);
        }

        private void LoadDataInDataGridView(string query)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(query, MainForm.connection);
                builder = new SqlCommandBuilder(dataAdapter);
                dataTable.Clear();
                dataTable.Columns.Clear();
                dataAdapter.Fill(dataTable);
                item_list.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            //поиск по всем фильтрам
            string query = descriptionQuery;

            bool addAnd = false;
            bool addOr = false;
            bool filtersSpecified = false;

            List<string> stringFilters = new List<string> {
                search_box1.Text,
                search_box2.Text,
                search_box3.Text,
                search_box4.Text };

            foreach (string filter in stringFilters) if (filter != "") filtersSpecified = true;

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

        private void choose_button_Click(object sender, EventArgs e)
        {
            //выбрать характеристику

            string description = "";

            for (int i = 1; i < item_list.ColumnCount - 1; i++)
            {
                description += item_list[i, item_list.CurrentRow.Index].Value.ToString() + "---";
            } 
            description += item_list[item_list.ColumnCount - 1, item_list.CurrentRow.Index].Value.ToString();

            main = this.Owner as AddItemForm;
            if (main != null)
            {
                main.itemID = int.Parse(item_list[0, item_list.CurrentRow.Index].Value.ToString());
                main.description_box.Text = description;
            }
            Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            //добавить характеристику из в справочник

            //this.Hide();
            CreateItemForm createItemForm = new CreateItemForm(type);
            createItemForm.ShowDialog();

            LoadDataInDataGridView(descriptionQuery);
        }

        private void item_list_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            choose_button_Click(null, null);
        }
    }
}
