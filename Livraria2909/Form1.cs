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
    public partial class Form1 : Form
    {
        Conexao conexao;

        public Form1()
        {
            InitializeComponent();
            conexao = new Conexao();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnAcessar.Enabled = false;
            txtUsuario.Focus();
        }

        void Acessar()
        {
            try
            {
                string consulta = $"SELECT login_usuario, senha_usuario FROM Usuario " +
                    $"WHERE login_usuario LIKE '{txtUsuario.Text}' AND senha_usuario LIKE '{txtSenha.Text}';";

                conexao.comando = new SqlCommand(consulta, conexao.conn);
                conexao.conn.Open();
                //conexao.comando.ExecuteNonQuery();
                conexao.reader = conexao.comando.ExecuteReader();

                if (conexao.reader.HasRows)
                {
                    frmMenu menu = new frmMenu(conexao);
                    menu.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.conn.Close();
            }
        }
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            Acessar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtSenha.Text != "") btnAcessar.Enabled = true;
            else btnAcessar.Enabled = false;

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Acessar();
            }
        }
    }
}
