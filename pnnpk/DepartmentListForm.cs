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
    public partial class DepartmentListForm : Form
    {
        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();

        ChangeDepForm main;

        string descriptionQuery = $"SELECT * FROM [Отделы]";
        public DepartmentListForm()
        {
            InitializeComponent();

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
                dep_list.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            //смена отдела на выбранный в списке

            string number = "";
            string name = "";
            number = dep_list[0, dep_list.CurrentRow.Index].Value.ToString();
            name = dep_list[1, dep_list.CurrentRow.Index].Value.ToString();

            main = this.Owner as ChangeDepForm;
            if (main != null)
            {
                main.dep_new_id.Text = number;
                main.dep_new_name_label.Text= name;
            }
            Close();
        }
    }
}
