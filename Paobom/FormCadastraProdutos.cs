using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paobom
{
    public partial class FormCadastraProdutos : Form
    {
        public FormCadastraProdutos()
        {
            InitializeComponent();
           // comboBox1.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lblValor.Text = "Valor";
            }
            else if (comboBox1.SelectedIndex == 1) {
                lblValor.Text = "Valor (100g)";
            }
        }
    }
}
