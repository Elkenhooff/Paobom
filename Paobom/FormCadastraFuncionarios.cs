using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
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
            MySqlConnection conexao = new MySqlConnection(BD.StringConexao);
            conexao.Open();

            string sql = "SELECT func_nome FROM funcionarios WHERE func_cargo = 'Gerente';";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                string cargos = leitor["func_nome"].ToString();
                cbSupervisor.Items.Add(cargos);
            }
            conexao.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int valorValidacao = 0;
            string[] campos = { tbCodigo.Text, tBNome.Text, cBCargo.Text, rTBEndereco.Text, mTBTelefone.Text, cBHorario.Text, cbSupervisor.Text, cBStatus.Text };

            foreach (string validacao in campos) {
                if (validacao != "")
                {
                    valorValidacao++;
                }
            }

            if (valorValidacao == 8 && Convert.ToDouble(mTBSalario.Text.Substring(6)) > 0)
            {

                try
                {
                    MySqlConnection conexao = new MySqlConnection(BD.StringConexao);
                    conexao.Open();

                    string sql = $"INSERT INTO funcionarios(func_codigo, func_nome, func_dtnasc, func_endereco, func_telefone, func_telefoneemergencia, func_cargo, func_salario, func_horario, func_dtadmissao, func_beneficios, func_supervisor, func_status) VALUES (@codigo, @nome, @dtnasc, @endereco, @telefone, @telefoneemerg, @cargo, @salario, @horario, @dtadmissao, @beneficios, @supervisor, @status);";
                    
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    // 
                    // Lembrete para resolver o parametro do supervisor e beneficios
                    //

                    comando.Parameters.Add("@codigo", MySqlDbType.Int32).Value = Convert.ToInt32(tbCodigo.Text);
                    comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = tBNome.Text;
                    comando.Parameters.Add("@dtnasc", MySqlDbType.Date).Value = Convert.ToDateTime(dTPNasc.Text);
                    comando.Parameters.Add("@endereco", MySqlDbType.Text).Value = rTBEndereco.Text;
                    comando.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = mTBTelefone.Text;
                    comando.Parameters.Add("@telefoneemerg", MySqlDbType.VarChar).Value = mTBTelefoneEmerg.Text;
                    comando.Parameters.Add("@cargo", MySqlDbType.VarChar).Value = cBCargo.Text;
                    comando.Parameters.Add("@salario", MySqlDbType.VarChar).Value = (mTBSalario.Text);
                    comando.Parameters.Add("@horario", MySqlDbType.VarChar).Value = cBHorario.Text;
                    comando.Parameters.Add("@dtadmissao", MySqlDbType.Date).Value = Convert.ToDateTime(dTPAdmissao.Text);

                    plano = cBPlano.Checked ? cBPlano.Text : string.Empty;
                    vale = cBVale.Checked ? cBVale.Text : string.Empty;
                    auxilio = cBAuxilio.Checked ? cBAuxilio.Text : string.Empty;

                    // MessageBox.Show($"{plano} {vale} {auxilio}");

                    comando.Parameters.Add("@beneficios", MySqlDbType.VarChar).Value = $"{plano} \n{vale} \n{auxilio}";
                    comando.Parameters.Add("@supervisor", MySqlDbType.VarChar).Value = cbSupervisor.Text;
                    comando.Parameters.Add("@status", MySqlDbType.VarChar).Value = cBStatus.Text;
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Funcionário inserido com sucesso", "Cadastrado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();

                    conexao.Close();

                }

                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Erro ao inserir no banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limparCampos()
        {
            tBNome.Text = "";
            dTPNasc.Text = dTPNasc.MaxDate.ToString();
            rTBEndereco.Text = "";
            mTBTelefone.Text = "";
            mTBTelefoneEmerg.Text = "";
            tbCodigo.Text = "";
            cBCargo.Text = "";
            mTBSalario.Text = "";
            tBSetor.Text = "";
            cBHorario.Text = "";
            cbSupervisor.Text = "";
            cBStatus.Text = "";
            cBPlano.Checked = false;
            cBVale.Checked = false;
            cBAuxilio.Checked = false;
            tBNome.Focus();
        }
    }
}
