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
    public partial class FormSenhaDiaria : Form
    {
        private string senha = "";
        public FormSenhaDiaria()
        {
            InitializeComponent();
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        public string getSenha()
        {
            return this.senha;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                this.senha = textBox1.Text;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
