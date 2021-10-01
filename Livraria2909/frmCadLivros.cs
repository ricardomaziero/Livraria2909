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
    public partial class frmCadLivros : Form
    {
        Conexao conexao;
        public frmCadLivros(Conexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
            txtNomeAutor.Focus();
            AtualizarCBox();
        }

        private void AtualizarCBox()
        {
            try
            {
                string selecionar = "SELECT nome_editora FROM Editoras;";
                conexao.comando = new SqlCommand(selecionar, conexao.conn);
                

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = conexao.comando;
                conexao.conn.Open();
                da.Fill(dt);

                foreach (DataRow linha in dt.Rows)
                {
                    cbEditora.Items.Add(linha[0].ToString());
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

        private void btnLimparLivro_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            int idEditora = 0;

            if (txtNomeAutor.Text == "" || txtTituloLivro.Text == "" || txtValorLivro.Text == ""
               || cbEditora.Text == "")
            {
                MessageBox.Show("FAVOR PREENCHER TODOS OS CAMPOS");
            }

            try
            {
                //pegando ID editora
                string selecionar = $"SELECT id_editora FROM Editoras WHERE nome_editora LIKE '{cbEditora.Text}';";
                conexao.comando = new SqlCommand(selecionar, conexao.conn);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = conexao.comando;
                conexao.conn.Open();
                da.Fill(dt);

                idEditora = int.Parse(dt.Rows[0][0].ToString());

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, erro.StackTrace);
            }
            finally
            {
                conexao.conn.Close();
            }
            
            try
            {
                string inserir = $"INSERT INTO Livros(titulo_livro, autor_livro, id_editora, valor_livro)" +
                    $"VALUES ('{txtTituloLivro.Text}','{txtNomeAutor.Text}', '{idEditora}', {txtValorLivro.Text.Replace(',','.')});";

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
            txtTituloLivro.Text = "";
            txtNomeAutor.Text = "";
            cbEditora.Text = "";
            txtValorLivro.Text = "";
            txtTituloLivro.Focus();
        }
    }
}