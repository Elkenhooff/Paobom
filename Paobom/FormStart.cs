namespace Paobom
{
    public partial class FormPaoBom : Form
    {
        bool sistema = false;
        string senhaSistema = "";
        public FormPaoBom()
        {
            InitializeComponent();
            BD.ProcurarArquivo("BDPaoBom.mdf");


            // Podridão abaixo.

            //KeyboardHookManager atalho = new KeyboardHookManager();
            //atalho.Start();
            //atalho.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, (int)Keys.F9, ativarSistema);
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastraProdutos cadastraProdutos = new FormCadastraProdutos();
            cadastraProdutos.ShowDialog();

        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastraFuncionarios cadastraFuncionarios = new FormCadastraFuncionarios();
            cadastraFuncionarios.ShowDialog();
        }

        private void listaFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaFuncionarios listaFuncionarios = new FormListaFuncionarios();
            listaFuncionarios.ShowDialog();
        }

        private void listaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaProdutos listaProdutos = new FormListaProdutos();
            listaProdutos.ShowDialog();
        }

        private void menuPrincipalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
            menuPrincipal.ShowDialog();
        }

        private void ativarSistema()
        {
            if (senhaSistema == "")
            {
                MessageBox.Show("Senha não definida.", "Sistema");
                FormSenhaDiaria senha = new FormSenhaDiaria();
                senha.ShowDialog();
                senhaSistema = senha.getSenha();
            }
            else
            {
                MessageBox.Show("Por favor insira a senha do sistema", "Sistema");
                FormLoginDiario loginDiario = new FormLoginDiario();
                loginDiario.ShowDialog();
                if (loginDiario.getTentativa() == senhaSistema)
                {
                    if (sistema)
                    {
                        sistemaToolStripMenuItem.Visible = false;
                        sistema = false;
                    }
                    else
                    {
                        sistemaToolStripMenuItem.Visible = true;
                        sistema = true;
                    }
                }
                else
                {
                    MessageBox.Show("Senha inválida", "Sistema");
                }
            }

        }

        private void FormPaoBom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F9)
            {
                ativarSistema();
            }
        }
    }
}
