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

        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();
        public PurchaseForm()
        {
            InitializeComponent();
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
        }

        private void edit_item_button_Click(object sender, EventArgs e)
        {
            //изменить запись в таблице (можно новым конструктором AddItemForm)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //произвести закупку
        }

        private void add_item_button_Click(object sender, EventArgs e)
        {
            //добавить запись в таблицу
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.Owner = this;
            addItemForm.ShowDialog();
            sum_label.Text = sum.ToString();


        }
    }
}
