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
    public partial class AddItemForm : Form
    {
        public int itemID = 0;
        private double sum;
        private double oldSum = 0;
        private double price;
        private int count; 

        PurchaseForm main;
        public AddItemForm()
        {
            InitializeComponent();
            type_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            type_box.Items.Add("Системный блок");
            type_box.Items.Add("Монитор");
            type_box.Items.Add("Принтер");

            type_box.SelectedIndex = 0;
        }

        public AddItemForm(int id, string t, string d, int c, double pr, double os)
        {
            InitializeComponent();
            type_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            type_box.Items.Add("Системный блок");
            type_box.Items.Add("Монитор");
            type_box.Items.Add("Принтер");

            type_box.SelectedIndex = 0;
            
            itemID = id;
            type_box.Text = t;
            description_box.Text = d;
            count = c;
            price = pr;
            oldSum = os;

            count_box.Text = count.ToString();
            price_box.Text = pr.ToString();
            RecalculateSum(null, null);

            label1.Text = "Изменение товара:";
            add_button.Text = "Изменить";
    }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            //добавить в таблицу запись
            if (itemID != 0 && double.TryParse(price_box.Text, out price) && int.TryParse(count_box.Text, out count))
            {
                main = this.Owner as PurchaseForm;
                if (main != null)
                {
                    main.sum += sum - oldSum;
                    main.count = count;
                    main.price = price;
                    main.itemID = itemID;
                    main.type = type_box.Text;
                    main.description = description_box.Text;
                    main.canceled = false;
                }
                Close();
            }
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            //выбор характеристики
            BrowseItemForm browseItemForm = new BrowseItemForm(type_box.Text);
            browseItemForm.Owner = this;
            browseItemForm.ShowDialog();
        }

        private void RecalculateSum(object sender, EventArgs e)
        {
            if (double.TryParse(price_box.Text, out price) && int.TryParse(count_box.Text, out count))
            {
                sum = price * count;
                sum_label.Text = sum.ToString();
            }
        }
        private void count_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void price_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void type_box_TextChanged(object sender, EventArgs e)
        {
            itemID = 0;
            description_box.Text = "";
        }
    }
}
