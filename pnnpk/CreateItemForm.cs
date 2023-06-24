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
    public partial class CreateItemForm : Form
    {
        string type;

        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public CreateItemForm(string t)
        {
            InitializeComponent();
            type = t;

            switch (type)
            {
                case "Системный блок":
                    computer_groupbox.Visible = true;
                    break;
                case "Монитор":
                    monitor_groupbox.Visible = true;
                    break;
                case "Принтер":
                    printer_groupbox.Visible = true;
                    break;
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            //добавление в справочник нового товара
            string query = "";
            switch (type)
            {
                case "Системный блок":
                    query = $"INSERT INTO [СправочникСистемныеБлоки] VALUES('{cpu_box.Text}', '{graphics_card_box.Text}', '{ram_box.Text}', '{hdd_box.Text}')";
                    break;
                case "Монитор":
                    query = $"INSERT INTO [СправочникМониторы] VALUES('{monitor_vendor_box.Text}', '{monitor_model_box.Text}', '{monitor_diagonal_box.Text}')";
                    break;
                case "Принтер":
                    query = $"INSERT INTO [СправочникПринтеры] VALUES('{printer_vendor_box.Text}', '{printer_mode_box.Text}', '{printer_format_box.Text}')";
                    break;
            }
            dataAdapter = new SqlDataAdapter();
            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();
            Close();
        }
    }
}
