namespace Paobom
{
    public partial class FormPaoBom : Form
    {
        public FormPaoBom()
        {
            InitializeComponent();
            BD.ProcurarArquivo("BDPaoBom.mdf");
        }

        public void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
            menuPrincipal.ShowDialog();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastraProdutos cadastraProdutos = new FormCadastraProdutos();
            cadastraProdutos.ShowDialog();

        }

        private void cadastroDeFuncionįriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastraFuncionarios cadastraFuncionarios = new FormCadastraFuncionarios();
            cadastraFuncionarios.ShowDialog();
        }

        private void listaFuncionįriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaFuncionarios listaFuncionarios = new FormListaFuncionarios();
            listaFuncionarios.ShowDialog();
        }

        private void listaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaProdutos listaProdutos = new FormListaProdutos();
            listaProdutos.ShowDialog();
        }

        public void fecharAplicacao()
        {
            this.Close();
        }
    }
}
