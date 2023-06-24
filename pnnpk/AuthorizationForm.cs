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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            error_label.Text = "Неверный логин или пароль";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((login_textbox.Text == "exp") || (login_textbox.Text == "buy") || (login_textbox.Text == "eng"))
            {
                extern_variables.login = login_textbox.Text;
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else error_label.Visible = true;
        }
    }
}
