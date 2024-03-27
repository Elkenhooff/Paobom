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
    public partial class FormFormaDePagamento : Form
    {
        private string formaDePagamento = "";
        private int parcelas;
        public FormFormaDePagamento()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormFormaDePagamento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    formaDePagamento = "Débito";
                    this.Close();
                    break;
                case Keys.NumPad2:
                    formaDePagamento = "Crédito";
                    FormParcelas parcela = FormParcelas();
                    parcela.ShowDialog();
                    parcelas = parcela.getParcelas();
                    this.Close();
                    break;
                case Keys.NumPad3:
                    formaDePagamento = "Dinhero";
                    this.Close();
                    break;
                case Keys.NumPad4:
                    formaDePagamento = "Vale Alimentação";
                    this.Close();
                    break;
            }
        }

        private FormParcelas FormParcelas()
        {
            throw new NotImplementedException();
        }

        public string getFormaDePagamento()
        {
            return formaDePagamento;
        }

        public int getParcelas()
        {
            return this.parcelas;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
