﻿using System;
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
    public partial class ItemForm : Form
    {
        private int ID;
        private int groupID;
        private string type;
        private string description;

        private SqlCommandBuilder builder = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();
        private string historyQuery;
       

        public ItemForm(string curItemID, string curItemGroupID, string curItemType, string curItemDescription)
        {
            InitializeComponent();
            //if (MainForm.userType == "Кладовщик" || MainForm.userType == "Админ") storekeeper_groupbox.Visible = true;

            ID = int.Parse(curItemID);
            if (!int.TryParse(curItemGroupID, out groupID)) groupID = -1;
            type = curItemType;
            description = curItemDescription;

            item_id_label.Text = ID.ToString();
            if (groupID != -1) item_group_id_label.Text = groupID.ToString(); else item_group_id_label.Text = "-";
            item_type_label.Text = type;
            description_box.Text = description;

            historyQuery = $"SELECT [ИсторияСобытий].[ID], [ТипСобытия] AS [Событие], [Дата], [IDЮзера], [Логин] AS [Логин юзера]  " +
                $"FROM [ИсторияСобытий] " +
                $"LEFT JOIN [ЮзерыСистемы] ON [ИсторияСобытий].[IDЮзера] = [ЮзерыСистемы].[ID] " +
                $"WHERE [IDОборудования] = {ID}";

            LoadDataInDataGridView(historyQuery);
        }
        private void LoadDataInDataGridView(string query)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(query, MainForm.connection);
                builder = new SqlCommandBuilder(dataAdapter);
                dataTable.Clear();
                dataTable.Columns.Clear();
                dataAdapter.Fill(dataTable);
                request_list.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void request_button_Click(object sender, EventArgs e)
        {
            //создание завки на ремонт
            CreateRequestForm createRequestForm = new CreateRequestForm(ID);
            createRequestForm.Show();
        }

        private void change_emp_button_Click(object sender, EventArgs e)
        {
            //смена пользователя
            //ChangeEmpForm changeEmpForm = new ChangeEmpForm();
            //changeEmpForm.Show();
        }

        private void move_button_Click(object sender, EventArgs e)
        {
            //перемещение оборудования
            string query = $"Select * from [Оборудование] where [ID] = {ID}";
            dataAdapter = new SqlDataAdapter(query, MainForm.connection);
            builder = new SqlCommandBuilder(dataAdapter);
            DataTable tempTable = new DataTable();
            tempTable.Clear();
            tempTable.Columns.Clear();
            dataAdapter.Fill(tempTable);

           // ChangeDepForm changeDepForm = new ChangeDepForm(Convert.ToInt32(tempTable.Rows[0][4]), tempTable.Rows[0][5].ToString());
            //changeDepForm.Show();
        }

        private void request_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Отображение подробностей о событии
            ExtensiveHistoryForm extensiveHistoryForm = new ExtensiveHistoryForm(Convert.ToInt32(request_list[0, request_list.CurrentRow.Index].Value),
                request_list[1, request_list.CurrentRow.Index].Value.ToString());
            extensiveHistoryForm.Show();
        }
    }
}
