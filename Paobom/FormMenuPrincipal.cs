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
        private KeyboardHookManager keyboardHookManager;
        public FormMenuPrincipal()
        {
            InitializeComponent();
            KeyboardHookManager keyboardHookManager = new KeyboardHookManager();
            keyboardHookManager.Start();
            keyboardHookManager.RegisterHotkey((int)Keys.A, impedirFechamento);

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
        }

        public void impedirFechamento()
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Close();
            });
            FormMenuPrincipal formPrincipal = new FormMenuPrincipal();
            formPrincipal.ShowDialog();
            MessageBox.Show("Você não pode fechar a aplicação sem a permissão", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var impedirFechamento = MessageBox.Show("Você não pode fechar a aplicação sem a permissão", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            e.Cancel = (impedirFechamento == DialogResult.OK);
        }
    }
}
