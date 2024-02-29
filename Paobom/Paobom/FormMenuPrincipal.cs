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

namespace Paobom
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(BD.StringConexao);

                conexao.Open();
                MessageBox.Show("Conexão bem sucedida", "Teste", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception abc)
            {
                MessageBox.Show(abc.Message, "Teste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }
    }
}
