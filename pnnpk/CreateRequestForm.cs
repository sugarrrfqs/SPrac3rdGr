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
    public partial class CreateRequestForm : Form
    {
        private int itemID;

        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public CreateRequestForm(int i)
        {
            InitializeComponent();

            itemID = i;
            item_id_label.Text = itemID.ToString();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            //отменить заявку
            Close();
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            //отправить заявку

            string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            string query = $"INSERT INTO [ИсторияСобытий] VALUES ('ЗаявкаНаРемонт', '{date}', {itemID}, {MainForm.userID})";
            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            Close();
        }
    }
}
