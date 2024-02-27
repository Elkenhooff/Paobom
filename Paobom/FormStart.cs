namespace Paobom
{
    public partial class FormPaoBom : Form
    {
        public FormPaoBom()
        {
            InitializeComponent();
        }

        public void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
            menuPrincipal.ShowDialog();
        }
    }
}
