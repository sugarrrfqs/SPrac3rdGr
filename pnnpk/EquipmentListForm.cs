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
    public partial class EquipmentListForm : Form
    {
        public EquipmentListForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //замена оборудования по DoubleClick
        }

        private void EquipmentReplacementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //если вдруг пользователь передумал, просто принимаем заявку без замены
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            //замена оборудования
        }
    }
}
