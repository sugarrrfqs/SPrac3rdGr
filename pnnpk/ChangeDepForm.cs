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
    public partial class ChangeDepForm : Form
    {
        private int depID;
        private string depName;
        private string cab;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();

        private SqlCommandBuilder builder = null;

        private int ID;
        public ChangeDepForm(int d, string ds, string c, int id)
        {
            InitializeComponent();
            depID = d;
            dep_id_label.Text = d.ToString();
            depName = ds;

            cab = c;
            cab_num_label.Text = c;
            dep_name_label.Text = ds;

            ID = id;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            //отмена перемещения
            this.Hide();
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            //провести перемещение оборудования 
            DataTable tempTable = new DataTable();

            string query = $"UPDATE [Оборудование] SET [IDОтдела] = '{Convert.ToInt32(dep_new_id.Text)}', [Кабинет] = '{cap_new_num_box.Text}' " +
                $"WHERE [ID] = {ID}";
            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            query = $"INSERT INTO [ИсторияСобытий] VALUES('Перемещение', '{date}',{ID},{MainForm.userID})";

            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            query = $"INSERT INTO [ИсторияСобытий] VALUES('Перемещение', '{date}',{ID},{MainForm.userID})";

            query = "SELECT * FROM [ИсторияСобытий] ORDER BY [ID] DESC offset 0 rows fetch first 1 row only";
            dataAdapter = new SqlDataAdapter(query, MainForm.connection);
            builder = new SqlCommandBuilder(dataAdapter);
            tempTable.Clear();
            tempTable.Columns.Clear();
            dataAdapter.Fill(tempTable);

            query = $"INSERT INTO [Перемещение] VALUES({depID},'{cab}',{Convert.ToInt32(dep_new_id.Text)},'{cap_new_num_box.Text}', '{tempTable.Rows[0][0]}')";
            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            query = $"SELECT * FROM [Оборудование] WHERE [ID] = {ID}";
            dataAdapter = new SqlDataAdapter(query, MainForm.connection);
            builder = new SqlCommandBuilder(dataAdapter);
            tempTable.Clear();
            tempTable.Columns.Clear();
            dataAdapter.Fill(tempTable);

            /*if (tempTable.Rows[0][1] == "Системный блок")
            {

            }*/

            this.Hide();
        }

        private void browse_dep_button_Click(object sender, EventArgs e)
        {
            //выбор отдела из имеющихся
            DepartmentListForm departmentListForm = new DepartmentListForm();
            departmentListForm.Owner = this;
            departmentListForm.Show();
        }
    }
}
