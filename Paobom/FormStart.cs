namespace Paobom
{
    public partial class FormPaoBom : Form
    {
        private FormMenuPrincipal menuprincipalInstancia;
        public FormPaoBom()
        {
            InitializeComponent();
            BD.ProcurarArquivo("BDPaoBom.mdf");
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
            if (menuprincipalInstancia == null || menuprincipalInstancia.IsDisposed)
            {
                menuprincipalInstancia = new FormMenuPrincipal();
            }
            menuprincipalInstancia.Show();
        }
    }
}
