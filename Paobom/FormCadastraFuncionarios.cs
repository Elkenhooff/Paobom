using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paobom
{
    public partial class FormCadastraFuncionarios : Form
    {
        public FormCadastraFuncionarios()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(BD.StringConexao)
                conexao.Open();

                string sql = "INSERT INTO funcionarios("
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Erro ao inserir no banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
