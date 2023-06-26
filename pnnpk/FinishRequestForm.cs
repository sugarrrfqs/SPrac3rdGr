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
    public partial class FinishRequestForm : Form
    {
        private int reqID;
        private int itemID;
        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public FinishRequestForm(int rID, int iID)
        {
            InitializeComponent();

            reqID = rID;
            itemID = iID;       
        }

        private void finish_button_Click(object sender, EventArgs e)
        {
            //завершаем заявку
            string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            string query = $"UPDATE [Ремонт] SET [СтатусЗаявки] = 'Закрыта', [ДатаОкончанияРемонта] = '{date}', [ОтчетОРемонте] = '{result_box.Text}'" +
                            $"WHERE [ID] = {reqID}";
            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            if (radioButton1.Checked)
            {
                //починено            
                query = $"UPDATE [Оборудование] SET [Статус] = 'На складе'" +
                                $"WHERE [ID] = {itemID}";                
            }
            else if (radioButton2.Checked)
            {
                //списано
                query = $"UPDATE [Оборудование] SET [Статус] = 'Списано'" +
                                $"WHERE [ID] = {itemID}";
            }
            dataAdapter.InsertCommand = new SqlCommand(query, MainForm.connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();
            Close();
        }
    }
}
