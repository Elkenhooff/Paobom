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
    public partial class FormListaFuncionarios : Form
    {
        public FormListaFuncionarios()
        {
            InitializeComponent();
            atualizarGrid();
            //MessageBox.Show(dGVFuncionarios.ColumnCount.ToString());
        }

        public DataTable listaFuncionarios()
        {
            SqlConnection conexao = new SqlConnection(BD.StringConexao);
            conexao.Open();

            string sql = "SELECT * FROM funcionarios ORDER BY func_nome;";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conexao);
            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            return dt;
        }

        public void atualizarGrid()
        {
            dGVFuncionarios.DataSource = listaFuncionarios();
            dGVFuncionarios.Columns[0].HeaderText = "Número de Identificação";
            dGVFuncionarios.Columns[1].HeaderText = "Nome";
            dGVFuncionarios.Columns[2].HeaderText = "Data de Nascimento";
            dGVFuncionarios.Columns[3].HeaderText = "Endereço";
            dGVFuncionarios.Columns[4].HeaderText = "Telefone";
            dGVFuncionarios.Columns[5].HeaderText = "Telefone de Emergência";
            dGVFuncionarios.Columns[6].HeaderText = "Cargo";
            dGVFuncionarios.Columns[7].HeaderText = "Salário";
            dGVFuncionarios.Columns[8].HeaderText = "Horario";
            dGVFuncionarios.Columns[9].HeaderText = "Data de Admissão";
            dGVFuncionarios.Columns[10].HeaderText = "Beneficios";
            dGVFuncionarios.Columns[11].HeaderText = "Supervisor";
            dGVFuncionarios.Columns[12].HeaderText = "Status";

            dGVFuncionarios.Columns[0].Width = 125;
            dGVFuncionarios.Columns[1].Width = 320;
            dGVFuncionarios.Columns[2].Width = 115;
            dGVFuncionarios.Columns[3].Width = 400;
            dGVFuncionarios.Columns[4].Width = 200;
            dGVFuncionarios.Columns[5].Width = 200;
            dGVFuncionarios.Columns[6].Width = 215;
            dGVFuncionarios.Columns[7].Width = 135;
            dGVFuncionarios.Columns[8].Width = 80;
            dGVFuncionarios.Columns[9].Width = 115;
            dGVFuncionarios.Columns[10].Width = 500;
            dGVFuncionarios.Columns[11].Width = 320;
            dGVFuncionarios.Columns[12].Width = 80;

            dGVFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVFuncionarios.AllowUserToAddRows = false;
            dGVFuncionarios.AllowUserToDeleteRows = false;
            dGVFuncionarios.ReadOnly = true;
            dGVFuncionarios.AllowUserToResizeColumns = false;
            dGVFuncionarios.AllowUserToOrderColumns = false;
            dGVFuncionarios.AllowUserToResizeColumns = true;
            dGVFuncionarios.AllowUserToResizeRows = false;
            for (int i = 0; i < dGVFuncionarios.ColumnCount; i++)
            {
                dGVFuncionarios.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dGVFuncionarios.RowHeadersWidth = 25;
        }
    }
}
    