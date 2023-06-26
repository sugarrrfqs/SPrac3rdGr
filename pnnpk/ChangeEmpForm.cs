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
    public partial class ChangeEmpForm : Form
    {
        private int empID;
        private string empName;

        private int ID;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();
        private SqlCommandBuilder builder = null;
        public ChangeEmpForm(int emp_id, string name, int id)
        {
            InitializeComponent();
            empID = emp_id;
            empName = name;

            ID = id;

            emp_id_label.Text = empID.ToString();
            emp_name_label.Text = empName;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            //отмена смена пользователя
            Close();
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            //смена пользователя
            DataTable tempTable = new DataTable();

            string query = $"UPDATE [Оборудование] SET [IDПользователя] = '{Convert.ToInt32(emp_new_id_box.Text)}' " +
                $"WHERE [ID] = {ID}";
            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            query = $"INSERT INTO [ИсторияСобытий] VALUES('СменаПользователя', '{date}',{ID},{MainForm.userID})";

            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            query = "SELECT * FROM [ИсторияСобытий] ORDER BY [ID] DESC offset 0 rows fetch first 1 row only";
            dataAdapter = new SqlDataAdapter(query, MainForm.connection);
            builder = new SqlCommandBuilder(dataAdapter);
            tempTable.Clear();
            tempTable.Columns.Clear();
            dataAdapter.Fill(tempTable);

            if (empID == 0)
            {
                query = $"INSERT INTO [СменаПользователя] VALUES(NULL,{Convert.ToInt32(emp_new_id_box.Text)}, '{tempTable.Rows[0][0]}')";
                dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
                dataAdapter.InsertCommand.ExecuteNonQuery();
            }
            else
            {
                query = $"INSERT INTO [СменаПользователя] VALUES({empID},{Convert.ToInt32(emp_new_id_box.Text)}, '{tempTable.Rows[0][0]}')";
                dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
                dataAdapter.InsertCommand.ExecuteNonQuery();
            }

            query = $"SELECT * FROM [Оборудование] WHERE [ID] = {ID}";
            dataAdapter = new SqlDataAdapter(query, MainForm.connection);
            builder = new SqlCommandBuilder(dataAdapter);
            tempTable.Clear();
            tempTable.Columns.Clear();
            dataAdapter.Fill(tempTable);

            if (tempTable.Rows[0][1].ToString() == "Системный блок" && tempTable.Rows[0][6] != DBNull.Value)
            {
                query = $"UPDATE [Оборудование] SET [IDПользователя] = '{Convert.ToInt32(emp_new_id_box.Text)}' WHERE [IDГруппы] = {tempTable.Rows[0][6]}";
                dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
                dataAdapter.InsertCommand.ExecuteNonQuery();
            }

            if (tempTable.Rows[0][1].ToString() == "Монитор" || tempTable.Rows[0][1].ToString() == "Принтер")
            {
                query = $"UPDATE [Оборудование] SET [IDГруппы] = NULL WHERE [ID] = {ID}";
                dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
                dataAdapter.InsertCommand.ExecuteNonQuery();
            }

            Close();
        }

        private void browse_emp_button_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            employeeListForm.Owner = this;
            employeeListForm.Show();
        }
    }
}