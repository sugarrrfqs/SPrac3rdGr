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
    public partial class PurchaseForm : Form
    {
        public double sum;
        public double price;
        public int count;
        public int itemID;
        public string type;
        public string description;
        public bool canceled = false;

        private int rowsCount = 0;

        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();
        private string query = "";
        public PurchaseForm()
        {
            InitializeComponent();

            DataColumn column;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ID";
            column.Unique = true;
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "IDЗаписиСправочника";
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Тип";
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Характеристика";
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Количество";
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Цена";
            dataTable.Columns.Add(column);

            purchase_list.DataSource = dataTable;
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
                purchase_list.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_item_button_Click(object sender, EventArgs e)
        {
            //удалить запись в таблице
            if (purchase_list.CurrentRow != null)
            {
                DataRow row = dataTable.Rows[purchase_list.CurrentRow.Index];

                sum -= Convert.ToDouble(row["Цена"]) * Convert.ToInt32(row["Количество"]);
                rowsCount--;

                row.Delete();
                sum_label.Text = sum.ToString();
            }
        }

        private void edit_item_button_Click(object sender, EventArgs e)
        {
            //изменить запись в таблице (можно новым конструктором AddItemForm)
            if (purchase_list.CurrentRow != null)
            {
                DataRow row = dataTable.Rows[purchase_list.CurrentRow.Index];
                canceled = true;
                AddItemForm addItemForm = new AddItemForm
                    (Convert.ToInt32(row["IDЗаписиСправочника"]),
                    row["Тип"].ToString(),
                    row["Характеристика"].ToString(),
                    Convert.ToInt32(row["Количество"]),
                    Convert.ToDouble(row["Цена"]),
                    Convert.ToInt32(row["Количество"]) * Convert.ToDouble(row["Цена"]));

                addItemForm.Owner = this;
                addItemForm.ShowDialog();
                if (!canceled)
                {
                    row["IDЗаписиСправочника"] = itemID;
                    row["Тип"] = type;
                    row["Характеристика"] = description;
                    row["Количество"] = count;
                    row["Цена"] = price;

                    sum_label.Text = sum.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //произвести закупку
            if (rowsCount > 0)
            {
                DataTable tempTable = new DataTable();
                string query = "";

                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < Convert.ToInt32(row[4]); i++)
                    {
                        query = $"INSERT INTO [Оборудование] VALUES ('{row[2]}', 'На Складе', NULL, NULL, '', NULL)";
                        dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
                        dataAdapter.InsertCommand.ExecuteNonQuery();

                        query = "SELECT * FROM [Оборудование] ORDER BY [ID] DESC offset 0 rows fetch first 1 row only";
                        dataAdapter = new SqlDataAdapter(query, MainForm.connection);
                        builder = new SqlCommandBuilder(dataAdapter);
                        tempTable.Clear();
                        tempTable.Columns.Clear();
                        dataAdapter.Fill(tempTable);

                        switch (row[2])
                        {
                            case "Системный блок":                        
                                query = $"INSERT INTO [СистемныеБлоки] VALUES('{itemID}', '{tempTable.Rows[0][0]}')";
                                break;

                            case "Монитор":
                                query = $"INSERT INTO [Мониторы] VALUES('{itemID}', '{tempTable.Rows[0][0]}')";
                                break;

                            case "Принтер":
                                query = $"INSERT INTO [Принтеры] VALUES('{itemID}', '{tempTable.Rows[0][0]}')";
                                break;
                        }

                        dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
                        dataAdapter.InsertCommand.ExecuteNonQuery();

                        string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
                        query = $"INSERT INTO [ИсторияСобытий] VALUES('Закупка', '{date}',{tempTable.Rows[0][0]},{MainForm.userID})";
                        dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
                        dataAdapter.InsertCommand.ExecuteNonQuery();

                        query = "SELECT * FROM [ИсторияСобытий] ORDER BY [ID] DESC offset 0 rows fetch first 1 row only";
                        dataAdapter = new SqlDataAdapter(query, MainForm.connection);
                        builder = new SqlCommandBuilder(dataAdapter);
                        tempTable.Clear();
                        tempTable.Columns.Clear();
                        dataAdapter.Fill(tempTable);

                        query = $"INSERT INTO [Закупка] VALUES('{sum}', '{tempTable.Rows[0][0]}')";
                        dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
                        dataAdapter.InsertCommand.ExecuteNonQuery();
                    }
                    Close();
                }
            }
        }

        private void add_item_button_Click(object sender, EventArgs e)
        {
            //добавить запись в таблицу
            canceled = true;
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.Owner = this;
            addItemForm.ShowDialog();
            sum_label.Text = sum.ToString();
            if (!canceled)
            {
                DataRow row;
                rowsCount++;
         
                row = dataTable.NewRow();
                row["ID"] = rowsCount;
                row["IDЗаписиСправочника"] = itemID;
                row["Тип"] = type;
                row["Характеристика"] = description;
                row["Количество"] = count;
                row["Цена"] = price;
                dataTable.Rows.Add(row);
            }
        }

        private void purchase_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edit_item_button_Click(null, null);
        }
    }
}
