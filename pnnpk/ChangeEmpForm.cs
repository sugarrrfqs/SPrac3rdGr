﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pnnpk
{
    public partial class ChangeEmpForm : Form
    {
        public ChangeEmpForm()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            //отмена смена пользователя
            this.Hide();
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            //смена пользователя
            this.Hide();
        }

        private void browse_emp_button_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            employeeListForm.Show();
        }
    }
}
