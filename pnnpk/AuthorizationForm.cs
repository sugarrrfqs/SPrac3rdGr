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
    public partial class AuthorizationForm : Form
    {
        private SqlConnection connection = null;
        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();

        private string query;

        public AuthorizationForm()
        {
            InitializeComponent();
            error_label.Text = "Неверный логин или пароль";

            try
            {
                connection = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=equipment accounting;Persist Security Info=True;User ID=EquipmentAccountingUser;Password=123");
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = $"SELECT * FROM [ЮзерыСистемы] WHERE [Логин] = '{login_textbox.Text}'";

            try
            {
                dataAdapter = new SqlDataAdapter(query, connection);
                builder = new SqlCommandBuilder(dataAdapter);
                dataTable.Clear();
                dataTable.Columns.Clear();
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (password_textbox.Text == dataTable.Rows[0][2].ToString())
            {
                this.Hide();
                MainForm.userID = Convert.ToInt32(dataTable.Rows[0][0]);
                MainForm.userType = Convert.ToString(dataTable.Rows[0][3]);
                MainForm mainForm = new MainForm();               
                mainForm.Show();
            }
            else error_label.Visible = true;
        }
    }
}
