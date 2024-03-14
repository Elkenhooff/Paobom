using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NonInvasiveKeyboardHookLibrary;


namespace Paobom
{
    public partial class FormMenuPrincipal : Form
    {
        private int qrcode = -1;

        public FormMenuPrincipal()
        {
            InitializeComponent();
            KeyboardHookManager keyboardHookManager = new KeyboardHookManager();
            keyboardHookManager.Start();
            keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, (int)Keys.F8, fecharAplicacao);

            this.FormClosing -= FormMenuPrincipal_FormClosing; // Evitar de ficar apertando CTRL F8 para efetuar os testes na aplicação
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(BD.StringConexao);

                conexao.Open();
                MessageBox.Show(BD.caminhoBanco, "Conexão bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception abc)
            {
                MessageBox.Show(abc.Message, "Teste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }

            try
            {
                qrcode = Convert.ToInt32(tBCódigo.Text);

                buscarValor();
                inserirProduto();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Teste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        public void fecharAplicacao()
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
            dGVVendas.DataSource = buscarValor();

            dGVVendas.ColumnHeadersVisible = false;
            dGVVendas.RowHeadersVisible = false;

            dGVVendas.Columns[0].Width = 120;
            dGVVendas.Columns[1].Width = 600;
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
        }

        public DataTable buscarValor()
        {
            SqlConnection conexao = new SqlConnection(BD.StringConexao);
            conexao.Open();

            string sql = $"SELECT pro_codigo, pro_nome, pro_valor FROM produtos WHERE pro_codigo = {qrcode};";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao);
            adapter.Fill(dt);

            return dt;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dGVVendas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow linhas in  dGVVendas.SelectedRows)
                {
                    dGVVendas.Rows.Remove(linhas);
                }
            }
        }
    }
}
