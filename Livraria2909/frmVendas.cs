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
    public partial class frmVendas : Form
    {
        Conexao conexao;
        public frmVendas(Conexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
            AtualizarCBox();
            AbrirTabela();
        }

        private void btnLimparVenda_Click(object sender, EventArgs e)
        {
            LimparCampos();
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
                    cbLivroVenda.Items.Add(linha[0].ToString());
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

        private void btnSalvarVenda_Click(object sender, EventArgs e)
        {
            int idLivro = 0;

            if (cbLivroVenda.Text == "" || txtNomeCliente.Text == "" || txtContatoCliente.Text == "" ||
                numQtdVenda.Value == 0 || msktxtData.Text == "")
            {
                MessageBox.Show("FAVOR PREENCHER TODOS OS CAMPOS || QUANTIDADE NÃO DEVE SER 0");
            }

            try
            {
                //pegando ID Livro
                string selecionar = $"SELECT id_livro FROM Livros WHERE titulo_livro LIKE '{cbLivroVenda.Text}';";
                conexao.comando = new SqlCommand(selecionar, conexao.conn);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = conexao.comando;
                conexao.conn.Open();
                da.Fill(dt);

                idLivro = int.Parse(dt.Rows[0][0].ToString());
                //AbrirTabela();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
            finally
            {
                conexao.conn.Close();
            }

            try
            {
                string inserir = $"INSERT INTO LivrosVendas(id_livro, nmcliente_livrosvenda, contatocliente_livrosvenda, qtd_livrosvenda, data_livrosvenda)" +
                    $"VALUES ('{idLivro}','{txtNomeCliente.Text}', '{txtContatoCliente.Text}', '{numQtdVenda.Value}', '{msktxtData.Text}');";

                conexao.comando = new SqlCommand(inserir, conexao.conn);
                conexao.conn.Open();
                conexao.comando.ExecuteNonQuery();

                LimparCampos();
                MessageBox.Show("Cadastrado com sucesso");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + "\n\nERRO" + erro.StackTrace);
            }
            finally
            {
                conexao.conn.Close();
            }
             
        }

        private void LimparCampos()
        {
            cbLivroVenda.Text = "";
            txtNomeCliente.Text = "";
            txtContatoCliente.Text = "";
            numQtdVenda.Value = 0;
            msktxtData.Text = "";
            txtTotal.Text = "";
            cbLivroVenda.Focus();
        }

        private void AbrirTabela()
        {
            try
            {
                string tabela = "SELECT nmcliente_livrosvenda, contatocliente_livrosvenda, qtd_livrosvenda, " +
                    "data_livrosvenda, total_livrosvenda FROM LivrosVendas;";
                
                conexao.comando = new SqlCommand(tabela, conexao.conn);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = conexao.comando;
                conexao.conn.Open();
                da.Fill(dt);

                dtgvVendas.DataSource = dt;

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

        private void numQtdVenda_ValueChanged(object sender, EventArgs e)
        {
            float valor = 0;
            try
            {
                string selecionar = $"SELECT valor_livro FROM Livros WHERE titulo_livro LIKE '{cbLivroVenda.Text}';";
                conexao.comando = new SqlCommand(selecionar, conexao.conn);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = conexao.comando;
                conexao.conn.Open();
                da.Fill(dt);

                valor = float.Parse(dt.Rows[0][0].ToString());

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.conn.Close();
            }

            txtTotal.Text = ((int)numQtdVenda.Value * valor).ToString("C2");
        }
    }
}
