using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria2909
{
    public partial class frmMenu : Form
    {
        Conexao conexao;
        public frmMenu(Conexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        private void mnCadLivros_Click(object sender, EventArgs e)
        {
            frmCadLivros cadLivro = new frmCadLivros(conexao);
            cadLivro.Show();
        }

        private void mnCadEditoras_Click(object sender, EventArgs e)
        {
            frmCadEditora cadEditora = new frmCadEditora(conexao);
            cadEditora.Show();
        }

        private void mnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque estoque = new frmEstoque(conexao);
            estoque.Show();
        }

        private void mnVendas_Click(object sender, EventArgs e)
        {
            frmVendas vendas = new frmVendas(conexao);
            vendas.Show();
        }
    }
}
