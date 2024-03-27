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
    public partial class FormCaixa : Form
    {
        int caixa;
        public FormCaixa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                caixa = Convert.ToInt32(textBox1.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor preencha o campo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public int getCaixa()
        {
            return this.caixa;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
