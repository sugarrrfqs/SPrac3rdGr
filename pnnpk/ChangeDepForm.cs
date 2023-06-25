﻿using System;
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

            string query = $"UPDATE [Оборудование] SET [IDОтдела] = '{Convert.ToInt32(dep_new_id.Text)}', [Кабинет] = '{cap_new_num_box.Text}' " +
                $"WHERE [ID] = {ID}";
            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();
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
