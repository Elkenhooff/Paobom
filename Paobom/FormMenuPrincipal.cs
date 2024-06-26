﻿//using NonInvasiveKeyboardHookLibrary;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Policy;
using System.Windows.Forms;

//MercadoPagoConfig.AccessToken = "ENV_ACCESS_TOKEN";

//var client = new PaymentMethodClient();
//ResourcesList<PaymentMethod> paymentMethods = await client.ListAsync();



namespace Paobom
{
    public partial class FormMenuPrincipal : Form
    {
        private double qrcode = -1;
        private int numCaixa = 0;
        private decimal descontinho = 0;
        private string formadepagamento = "";
        private string voucher = "";
        private int parcelas = 0;
        private decimal total = 0;
        DataTable dtProdutos = new DataTable();

        public FormMenuPrincipal()
        {
            InitializeComponent();
            lblCaixa.ForeColor = lblNumCaixa.ForeColor = lblHora.ForeColor = lblTotal.ForeColor = lbTotal.ForeColor = lblData.ForeColor = Color.FromArgb(0x9a, 0x7b, 0x4d);
            //dGVVendas.BackgroundColor = lblData.BackColor = lblHora.BackColor = lbTotal.BackColor = lblTotal.BackColor = Color.FromArgb(0x6d, 0x5d, 0x2a);

            /* Essa podridão do nonInvasiveKeyBoard não presta. */


            // KeyboardHookManager keyboardHookManager = new KeyboardHookManager();
            // keyboardHookManager.Start();
            // keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, (int)Keys.F8, fecharAplicacao);
            // keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, (int)Keys.Enter, finalizarCompra);
            // keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, (int)Keys.L, limparCarrinho);
            // keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, (int)Keys.R, removerProduto);



            //this.FormClosing -= FormMenuPrincipal_FormClosing; // Evitar de ficar apertando CTRL F8 para efetuar os testes na aplicação
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBCódigo.Text != "")
                {
                    qrcode = Convert.ToInt32(tBCódigo.Text);
                }


                buscarValor();
                inserirProduto();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Teste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void fecharAplicacao()
        {
            this.FormClosing -= FormMenuPrincipal_FormClosing;
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Close();
                });
            }
            else
            {
                this.Close();
            }
        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var impedirFechamento = MessageBox.Show("Você não pode fechar a aplicação sem a permissão", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            e.Cancel = (impedirFechamento == DialogResult.OK);
        }


        public void inserirProduto()
        {

            if (dtProdutos.Rows.Count == 0)
            {
                dtProdutos = buscarValor();
            }
            else
            {
                dtProdutos.Merge(buscarValor());
            }

            dGVVendas.DataSource = dtProdutos;

            dGVVendas.ColumnHeadersVisible = false;
            dGVVendas.RowHeadersVisible = false;

            dGVVendas.Columns[0].Width = 170;
            dGVVendas.Columns[1].Width = 435;
            dGVVendas.Columns[2].Width = 120;



            dGVVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVVendas.AllowUserToAddRows = false;
            dGVVendas.AllowUserToDeleteRows = false;
            dGVVendas.AllowUserToResizeColumns = false;
            dGVVendas.AllowUserToOrderColumns = false;
            dGVVendas.AllowUserToResizeColumns = false;
            dGVVendas.AllowUserToResizeRows = false;
            dGVVendas.ReadOnly = true;


            for (int i = 0; i < dGVVendas.ColumnCount; i++)
            {
                dGVVendas.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            qrcode = -1;
        }

        public DataTable buscarValor()
        {
            MySqlConnection conexao = new MySqlConnection(BD.StringConexao);
            conexao.Open();

            string sql = $"SELECT pro_codigo, pro_nome, pro_valor FROM produtos WHERE pro_codigo = {qrcode};";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
            adapter.Fill(dt);

            conexao.Close();
            return dt;
        }

        private void removerProduto()
        {
            if (dGVVendas.SelectedRows.Count > 0)
            {
                var resposta = MessageBox.Show("Você realmente deseja remover o produto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resposta == DialogResult.Yes)
                {

                    foreach (DataGridViewRow linhas in dGVVendas.SelectedRows)
                    {
                        dGVVendas.Rows.Remove(linhas);
                    }

                    if (dGVVendas.InvokeRequired)
                    {
                        dGVVendas.Invoke((MethodInvoker)delegate
                        {
                            dGVVendas.Refresh();
                        });
                    }
                    else
                    {
                        dGVVendas.Refresh();
                    }
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tBCódigo.Focus();
            foreach (DataGridViewRow linha in dGVVendas.Rows)
            {
                if (linha.Cells[2].Value != null)
                {
                    string totalString = linha.Cells[2].Value.ToString();
                    totalString = totalString.Substring(3);

                    total = Convert.ToDecimal(totalString);
                }
            }

            if (total != 0)
            {
                lbTotal.Text = "R$ " + total.ToString("F2");
                lblTotal.Text = "Valor Total";
            }
            else
            {
                lblTotal.Text = lbTotal.Text = "";
            }

            if (numCaixa != 0)
            {
                lblNumCaixa.Text = numCaixa.ToString();
            }
            else
            {
                lblNumCaixa.Text = "";
            }


            /* Inserir código de barra */
            if (tBCódigo.Text.Length == 13)
            {
                qrcode = Convert.ToDouble(tBCódigo.Text);


                buscarValor();
                inserirProduto();
                tBCódigo.Clear();
                tBCódigo.Focus();
            }

            /* Hora e Data */
            lblData.Text = DateTime.Now.ToShortDateString().Substring(0, 5);
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void limparCarrinho()
        {
            var resposta = MessageBox.Show("Você deseja limpar o carrinho?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                dGVVendas.SelectAll();
                foreach (DataGridViewRow linhas in dGVVendas.SelectedRows)
                {
                    dGVVendas.Rows.Remove(linhas);
                }
            }
        }
        private void finalizarCompra()
        {
            if (dGVVendas.Rows.Count > 0)
            {
                var resposta = MessageBox.Show("O cliente possuí desconto?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resposta == DialogResult.Yes)
                {
                    FormDesconto desconto = new FormDesconto();
                    desconto.ShowDialog();
                    descontinho = desconto.getDesconto();
                }
                FormFormaDePagamento pagamento = new FormFormaDePagamento();
                pagamento.ShowDialog();


                dGVVendas.SelectAll();
                foreach (DataGridViewRow linhas in dGVVendas.SelectedRows)
                {
                    dGVVendas.Rows.Remove(linhas); 
                }
                MySqlConnection conexao = new MySqlConnection(BD.StringConexao);
                conexao.Open();

                formadepagamento = pagamento.getFormaDePagamento();
                parcelas = pagamento.getParcelas();
                string sql = "INSERT INTO vendas(vend_datahora, vend_valortotal, vend_desconto, vend_voucher, vend_caixa, vend_parcela, vend_pagamento) VALUES (GETDATE(), @total, @desconto, @voucher, @numCaixa, @parcelas, @formadepagamento)";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@total", total);
                comando.Parameters.AddWithValue("@desconto", descontinho);
                comando.Parameters.AddWithValue("@voucher", voucher);
                comando.Parameters.AddWithValue("@numCaixa", numCaixa);
                comando.Parameters.AddWithValue("@parcelas", parcelas);
                comando.Parameters.AddWithValue("@formadepagamento", formadepagamento);
                comando.ExecuteNonQuery();
                conexao.Close();

            }
            else
            {
                // faz nada :thumbsup
            }
        }
        private void pressionarTecla(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.R:
                    if (e.Control)
                    {
                        removerProduto();
                    }
                    break;
                case Keys.L:
                    if (e.Control)
                    {
                        limparCarrinho();
                    }
                    break;
                case Keys.Enter:
                    if (e.Control)
                    {
                        finalizarCompra();
                    }
                    break;
                case Keys.F8:
                    if (e.Control)
                    {
                        fecharAplicacao();
                    }
                    break;
            }
        }

        private void lblCaixa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insira o número do caixa", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormCaixa caixa = new FormCaixa();
            caixa.ShowDialog();
            numCaixa = caixa.getCaixa();

        }
    }
}
