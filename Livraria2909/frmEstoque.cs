using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Livraria2909
{
    public partial class frmEstoque : Form
    {
        Conexao conexao;
        public frmEstoque(Conexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
            AtualizarCBox();
        }

        private void btnLimparEstoque_Click(object sender, EventArgs e)
        {
            cbLivroEstoque.Text = "";
            numQtdEstoque.Value = 0;
            cbLivroEstoque.Focus();
        }

        private void btnSalvarEstoque_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarCBox()
        {
            try
            {
                string selecionar = "SELECT titulo_livro FROM Livros;";
                conexao.comando = new SqlCommand(selecionar, conexao.conn);


                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = conexao.comando;
                conexao.conn.Open();
                da.Fill(dt);

                foreach (DataRow linha in dt.Rows)
                {
                    cbLivroEstoque.Items.Add(linha[0].ToString());
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.conn.Close();
            }
        }
    }
}
