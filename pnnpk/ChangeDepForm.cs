using System;
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
    public partial class ChangeDepForm : Form
    {
        private int depID;
        private string depName;
        private string cab;
        public ChangeDepForm(int d, string ds, string c)
        {
            InitializeComponent();
            depID = d;
            dep_id_label.Text = d.ToString();
            depName = ds;

            cab = c;
            cab_num_label.Text = c;
            dep_name_label.Text = ds;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            //отмена перемещения
            this.Hide();
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            //провести перемещение оборудования
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
