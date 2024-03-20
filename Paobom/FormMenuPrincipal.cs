using NonInvasiveKeyboardHookLibrary;
using System.Data;
using System.Data.SqlClient;

//MercadoPagoConfig.AccessToken = "ENV_ACCESS_TOKEN";

//var client = new PaymentMethodClient();
//ResourcesList<PaymentMethod> paymentMethods = await client.ListAsync();



namespace Paobom
{
    public partial class FormMenuPrincipal : Form
    {
        private double qrcode = -1;
        DataTable dtProdutos = new DataTable();

        public FormMenuPrincipal()
        {
            InitializeComponent();
            KeyboardHookManager keyboardHookManager = new KeyboardHookManager();
            keyboardHookManager.Start();
            keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, (int)Keys.F8, fecharAplicacao);
            keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, (int)Keys.Enter, finalizarCompra);
            keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, (int)Keys.L, limparCarrinho);
            keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, (int)Keys.R, removerProduto);
            lbTotal.BackColor = lblTotal.BackColor = Color.FromArgb(0xFF, 0xDE, 0x59);
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

            dGVVendas.Columns[0].Width = 120;
            dGVVendas.Columns[1].Width = 587;
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
            SqlConnection conexao = new SqlConnection(BD.StringConexao);
            conexao.Open();

            string sql = $"SELECT pro_codigo, pro_nome, pro_valor FROM produtos WHERE pro_codigo = {qrcode};";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao);
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
            decimal total = 0;

            foreach (DataGridViewRow linha in dGVVendas.Rows)
            {
                if (linha.Cells[2].Value != null)
                {
                    string totalString = linha.Cells[2].Value.ToString();
                    totalString = totalString.Substring(3);

                    total += Convert.ToDecimal(totalString);
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

            if (tBCódigo.Text.Length == 13)
            {
                qrcode = Convert.ToDouble(tBCódigo.Text);


                buscarValor();
                inserirProduto();
                tBCódigo.Clear();
            }
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
                MessageBox.Show("Compra finalizada");
            }
            else
            {
                // faz nada :thumbsup
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
