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
    public partial class FormCadastraProdutos : Form
    {
        public FormCadastraProdutos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxMedida.SelectedIndex == 1)
            {
                lblValor.Text = "Valor (100g)";
            }
            else
            {
                lblValor.Text = "Valor";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(mTBoxValor.Text.Substring(3), "teste", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlConnection conexao = new SqlConnection(BD.StringConexao);
                conexao.Open();

                string sql = "INSERT INTO produtos(pro_codigo, pro_nome, pro_medida, pro_valor, pro_fabricacao, pro_validade, pro_categoria, pro_observacao) VALUES (@codigo, @nome, @medida, @valor, @fabricacao, @validade, @categoria, @observacao);";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.Add("@codigo", SqlDbType.Int).Value = Convert.ToInt32(txtBarra.Text);
                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("@medida", SqlDbType.VarChar).Value = cBoxMedida.Text;
                comando.Parameters.Add("@valor", SqlDbType.Decimal).Value = Convert.ToDecimal(mTBoxValor.Text.Substring(3));
                comando.Parameters.Add("@fabricacao", SqlDbType.Date).Value = Convert.ToDateTime(dTPFabricacao.Text);
                comando.Parameters.Add("@validade", SqlDbType.Date).Value = Convert.ToDateTime(dTPValidade.Text);
                comando.Parameters.Add("@categoria", SqlDbType.VarChar).Value = cBCategoria.Text;
                comando.Parameters.Add("@observacao", SqlDbType.VarChar).Value = rTBObservacao.Text;

                comando.ExecuteNonQuery();
                MessageBox.Show("Produto inserido com sucesso", "Paobom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Erro no banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
