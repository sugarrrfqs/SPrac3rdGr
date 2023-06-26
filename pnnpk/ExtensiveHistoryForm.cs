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
    public partial class ExtensiveHistoryForm : Form
    {
        private int historyID;
        private string eventType;

        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();
        public ExtensiveHistoryForm(int hID, string e)
        {
            InitializeComponent();
            historyID = hID;
            eventType = e;
           
            string query = $"select * from [{eventType}] where [IDСобытия] = '{hID}'";

            try
            {
                dataAdapter = new SqlDataAdapter(query, MainForm.connection);
                builder = new SqlCommandBuilder(dataAdapter);
                dataTable.Clear();
                dataAdapter.Fill(dataTable);
                history_list.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
