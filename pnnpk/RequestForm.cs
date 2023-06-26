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
    public partial class RequestForm : Form
    {
        private int reqID;
        private int itemID;
        private string type;
        private string description;
        private string problem;
        private string status;

        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public RequestForm(int rID, int iID, string t, string d, string p, string s)
        {
            InitializeComponent();

            reqID = rID;
            req_id_label.Text = rID.ToString();

            itemID = iID;
            item_id_label.Text = iID.ToString();
            
            type = t;
            item_type_label.Text = t;

            description = d;
            description_box.Text = d;

            problem = p;
            problem_box.Text = p;

            status = s;

            switch (status)
            {
                case "Ждет принятия":
                    accept_req_button.Visible = true;
                    break;
                case "В работе":
                    finish_req_button.Visible = true;
                    break;
            }
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
                equipmentReplacementForm.FormClosed += EquipmentReplacementForm_FormClosed;
                equipmentReplacementForm.Show();
            }
            else
            {
                //просто принимаем заявку
                string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
                string query = $"UPDATE [Ремонт] SET [СтатусЗаявки] = 'В работе', [ДатаПринятияЗаявки] = '{date}' " +
                                $"WHERE [ID] = {reqID}";
                dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
                dataAdapter.InsertCommand.ExecuteNonQuery();

                query = $"UPDATE [Оборудование] SET [Статус] = 'В ремонте'" +
                $"WHERE [ID] = {itemID}";
                dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
                dataAdapter.InsertCommand.ExecuteNonQuery();
                Close();
            }
        }

        private void EquipmentReplacementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void finish_req_button_Click(object sender, EventArgs e)
        {
            //завершить заявку
            FinishRequestForm finishRequestForm = new FinishRequestForm(reqID, itemID);
            finishRequestForm.FormClosed += FinishRequestForm_FormClosed;
            finishRequestForm.Show();
        }

        private void FinishRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
