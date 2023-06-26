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
    public partial class ChangeGroupForm : Form
    {
        private int itemID;

        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public ChangeGroupForm(int iID)
        {
            InitializeComponent();

            ID_label.Text = iID.ToString();
            itemID = iID;
        }

        private void group_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void change_group_button_Click(object sender, EventArgs e)
        {
            string query = "";
            if (group_box.Text != "")
            {
                query = $"UPDATE [Оборудование] SET [IDГруппы] = '{group_box.Text}' " +
                $"WHERE [ID] = {itemID}";
            }
            else
            {
                query = $"UPDATE [Оборудование] SET [IDГруппы] = NULL " +
                $"WHERE [ID] = {itemID}";
            }
            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();
            Close();
        }
    }
}
