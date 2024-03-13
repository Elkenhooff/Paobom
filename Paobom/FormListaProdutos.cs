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
    public partial class FormListaProdutos : Form
    {
        public FormListaProdutos()
        {
            InitializeComponent();
            atualizarGrid();
        }

        public DataTable listaProdutos()
        {
            SqlConnection conexao = new SqlConnection(BD.StringConexao);
            conexao.Open();
            string sql = "SELECT * FROM produtos ORDER BY pro_nome";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conexao);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        public void atualizarGrid()
        {
            dGVProdutos.DataSource = listaProdutos();
            dGVProdutos.Columns[0].HeaderText = "Código de Barra";
            dGVProdutos.Columns[1].HeaderText = "Nome";
            dGVProdutos.Columns[2].HeaderText = "Medida";
            dGVProdutos.Columns[3].HeaderText = "Valor";
            dGVProdutos.Columns[4].HeaderText = "Fabricação";
            dGVProdutos.Columns[5].HeaderText = "Validade";
            dGVProdutos.Columns[6].HeaderText = "Categoria";
            dGVProdutos.Columns[7].HeaderText = "Observação";



            dGVProdutos.Columns[0].Width = 100;
            dGVProdutos.Columns[1].Width = 250;
            dGVProdutos.Columns[2].Width = 95;
            dGVProdutos.Columns[3].Width = 120;
            dGVProdutos.Columns[4].Width = 115;
            dGVProdutos.Columns[5].Width = 115;
            dGVProdutos.Columns[6].Width = 200;
            dGVProdutos.Columns[7].Width = 400;

            dGVProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVProdutos.AllowUserToAddRows = false;
            dGVProdutos.AllowUserToDeleteRows = false;
            dGVProdutos.ReadOnly = true;
            dGVProdutos.AllowUserToResizeColumns = false;
            dGVProdutos.AllowUserToOrderColumns = false;
            dGVProdutos.AllowUserToResizeColumns = true;
            dGVProdutos.AllowUserToResizeRows = false;
            for (int i = 0; i < dGVProdutos.ColumnCount; i++)
            {
                dGVProdutos.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dGVProdutos.RowHeadersWidth = 25;


        }
    }
}
