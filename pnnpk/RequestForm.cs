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
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }

        private void accept_req_button_Click(object sender, EventArgs e)
        {
            //принять заявку
            DialogResult result = MessageBox.Show(
            "Заменить оборудование?",
            "Сообщение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                EquipmentListForm equipmentReplacementForm = new EquipmentListForm();
                equipmentReplacementForm.Show();
                this.Hide();
            }
            else
            {
                //просто принимаем заявку
            }
        }

        private void finish_req_button_Click(object sender, EventArgs e)
        {
            //завершить заявку
            FinishRequestForm finishRequestForm = new FinishRequestForm();
            finishRequestForm.Show();
            this.Hide();
        }
    }
}
