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
    public partial class EmployeeListForm : Form
    {
        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();

        ChangeEmpForm main;

        string query = $"SELECT * FROM [Пользователи]";
        public EmployeeListForm()
        {
            InitializeComponent();

            LoadDataInDataGridView(query);
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
                emp_list.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            //смена пользователя по выбранному в таблице сотруднику

            string number = "";
            string name = "";
            number = emp_list[0, emp_list.CurrentRow.Index].Value.ToString();
            name = emp_list[1, emp_list.CurrentRow.Index].Value.ToString();

            main = this.Owner as ChangeEmpForm;
            if (main != null)
            {
                main.emp_new_id_box.Text = number;
                main.emp_new_name_label.Text = name;
            }
            Close();
        }
    }
}