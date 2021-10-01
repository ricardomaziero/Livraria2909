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
    public partial class frmCadEditora : Form
    {
        Conexao conexao;
        public frmCadEditora(Conexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        private void btnLimparEditora_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvarEditora_Click(object sender, EventArgs e)
        {
           if (txtNomeEditora.Text == "" || txtEmailEditora.Text == "" || msktxtTelefoneEd.Text == "")
            {
                MessageBox.Show("FAVOR PREENCHER TODOS OS CAMPOS");
            }
            
            try
            {
                string inserir = $"INSERT INTO Editoras (nome_editora, email_editora, tel_editora)" +
                    $" VALUES ('{txtNomeEditora.Text}', '{txtEmailEditora.Text}', '{msktxtTelefoneEd.Text}');";

                conexao.comando = new SqlCommand(inserir, conexao.conn);
                conexao.conn.Open();
                conexao.comando.ExecuteNonQuery();

                LimparCampos();
                MessageBox.Show("Cadastrado com sucesso");
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

        private void LimparCampos()
        {
            txtNomeEditora.Text = "";
            txtEmailEditora.Text = "";
            msktxtTelefoneEd.Text = "";
            txtNomeEditora.Focus();
        }
    }
}
