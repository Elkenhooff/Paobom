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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
            configuracaodGD();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
        }
        public DataTable inserirDados()
        {
            SqlConnection conexao = new SqlConnection(BD.StringConexao);
            conexao.Open();

            string sql = "SELECT * FROM vendas ORDER BY vend_codigo";
            DataTable dt = new DataTable();
            SqlDataAdapter sqldata = new SqlDataAdapter(sql, conexao);
            sqldata.Fill(dt);
            return dt;
        }
        public void configuracaodGD()
        {
            dGVVendas.DataSource = inserirDados();
            dGVVendas.Columns[0].HeaderText = "Identificação da Venda";
            dGVVendas.Columns[1].HeaderText = "Data / Hora";
            dGVVendas.Columns[2].HeaderText = "Valor Total";
            dGVVendas.Columns[3].HeaderText = "Desconto";
            dGVVendas.Columns[4].HeaderText = "Voucher";
            dGVVendas.Columns[5].HeaderText = "Caixa";
            dGVVendas.Columns[6].HeaderText = "Parcelas";
            dGVVendas.Columns[7].HeaderText = "Forma de Pagamento";

            dGVVendas.Columns[0].Width = 255;
            dGVVendas.Columns[1].Width = 300;
            dGVVendas.Columns[2].Width = 135;
            dGVVendas.Columns[3].Width = 135;
            dGVVendas.Columns[4].Width = 135;
            dGVVendas.Columns[5].Width = 100;
            dGVVendas.Columns[6].Width = 100;
            dGVVendas.Columns[7].Width = 225;

            dGVVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVVendas.AllowUserToAddRows = false;
            dGVVendas.AllowUserToDeleteRows = false;
            dGVVendas.ReadOnly = true;
            dGVVendas.AllowUserToResizeColumns = false;
            dGVVendas.AllowUserToOrderColumns = false;
            dGVVendas.AllowUserToResizeColumns = true;
            dGVVendas.AllowUserToResizeRows = false;
            for (int i = 0; i < dGVVendas.ColumnCount; i++)
            {
                dGVVendas.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dGVVendas.RowHeadersWidth = 25;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
