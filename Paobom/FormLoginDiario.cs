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
    public partial class FormLoginDiario : Form
    {
        private string tentativaSenha;
        public FormLoginDiario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
               tentativaSenha = textBox1.Text;
               this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setTentativa(string tentativa)
        {
            this.tentativaSenha = tentativa;
        }

        public string getTentativa()
        {
            return this.tentativaSenha;
        }
    }
}
