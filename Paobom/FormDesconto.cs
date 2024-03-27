using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paobom
{
    public partial class FormDesconto : Form
    {
        private decimal desconto;
        public FormDesconto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool descont;
            if (checkBox1.Checked)
            {
                descont = true;
            }
            else
            {
                descont = false;
            }
            if (textBox1.Text != "")
            {
                desconto = Convert.ToDecimal(textBox1.Text);
                if (descont)
                {
                    desconto = desconto / 100;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor preencha o campo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        public decimal getDesconto()
        {
            return this.desconto;
        }
    }
}
