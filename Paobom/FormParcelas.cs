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
    public partial class FormParcelas : Form
    {
        private int parcelas = 0;
        public FormParcelas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                parcelas = Convert.ToInt32(textBox1.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor preencha o campo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public int getParcelas()
        {
            return this.parcelas;
        }
    }
}
