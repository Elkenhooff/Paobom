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
using System.Windows;

namespace Paobom
{
    public partial class FormCadastraFuncionarios : Form
    {
        string plano = "", auxilio = "", vale = "";
        public FormCadastraFuncionarios()
        {
            InitializeComponent();
            comboBoxSupervisor();
        }

        private void comboBoxSupervisor()
        {
            SqlConnection conexao = new SqlConnection(BD.StringConexao);
            conexao.Open();

            string sql = "SELECT func_nome FROM funcionarios WHERE func_cargo = 'Gerente';";
            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataReader leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                string cargos = leitor["func_nome"].ToString();
                cbSupervisor.Items.Add(cargos);
            }
            conexao.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(BD.StringConexao);
                conexao.Open();

                string sql = $"INSERT INTO funcionarios(func_codigo, func_nome, func_dtnasc, func_endereco, func_telefone, func_telefoneemergencia, func_cargo, func_salario, func_horario, func_dtadmissao, func_beneficios, func_supervisor, func_status) VALUES (@codigo, @nome, @dtnasc, @endereco, @telefone, @telefoneemerg, @cargo, @salario, @horario, @dtadmissao, @beneficios, @supervisor, @status);";
                SqlCommand comando = new SqlCommand(sql, conexao);

                // 
                // Lembrete para resolver o parametro do supervisor e beneficios
                //

                comando.Parameters.Add("@codigo", SqlDbType.Int).Value = Convert.ToInt32(tbCodigo.Text);
                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = tBNome.Text;
                comando.Parameters.Add("@dtnasc", SqlDbType.Date).Value = Convert.ToDateTime(dTPNasc.Text);
                comando.Parameters.Add("@endereco", SqlDbType.Text).Value = rTBEndereco.Text;
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = mTBTelefone.Text;
                comando.Parameters.Add("@telefoneemerg", SqlDbType.VarChar).Value = mTBTelefoneEmerg.Text;
                comando.Parameters.Add("@cargo", SqlDbType.VarChar).Value = cBCargo.Text;
                comando.Parameters.Add("@salario", SqlDbType.VarChar).Value = (mTBSalario.Text);
                comando.Parameters.Add("@horario", SqlDbType.VarChar).Value = cBHorario.Text;
                comando.Parameters.Add("@dtadmissao", SqlDbType.Date).Value = Convert.ToDateTime(dTPAdmissao.Text);

                plano = cBPlano.Checked ? cBPlano.Text : string.Empty;
                vale = cBVale.Checked ? cBVale.Text : string.Empty;
                auxilio = cBAuxilio.Checked ? cBAuxilio.Text : string.Empty;

                // MessageBox.Show($"{plano} {vale} {auxilio}");

                comando.Parameters.Add("@beneficios", SqlDbType.VarChar).Value = $"{plano} \n{vale} \n{auxilio}";
                comando.Parameters.Add("@supervisor", SqlDbType.VarChar).Value = cbSupervisor.Text;
                comando.Parameters.Add("@status", SqlDbType.VarChar).Value = cBStatus.Text;
                comando.ExecuteNonQuery();

                MessageBox.Show("Funcionário inserido com sucesso", "Cadastrado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                conexao.Close();

            }

            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Erro ao inserir no banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
