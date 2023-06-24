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
    public partial class RequestListForm : Form
    {
        public RequestListForm()
        {
            InitializeComponent();
            
            login_label.Text = extern_variables.login;
            //сделать привязку ФИО по логину

        }

        private void open_request_Click(object sender, EventArgs e)
        {
            //открытие выделенной в таблице заявки
            RequestForm requestForm = new RequestForm();
            requestForm.Show();
        }

        private void search_req_button_Click(object sender, EventArgs e)
        {
            //поиск по id заявки
        }

        private void search_req_clear_Click(object sender, EventArgs e)
        {
            search_req_id_box.Text = "";

            search_req_button_Click(null,null);
        }

        private void request_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //открытие заявки по DoubleClick
        }
    }
}
