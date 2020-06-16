using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.Forms
{
    public partial class Principal : Form
    {
        public Principal(int usuario)
        {
            Global.Global.usuariomodel = Global.Global.usuariocontroller.BuscarUsuario(usuario);
            Global.Global.funcionariomodel = Global.Global.funcionariocontroller.BuscarFuncionario(Global.Global.usuariomodel.idFuncionarioUsuario);
            
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Forms.frmEstoque MovimentaEstoque = new Forms.frmEstoque();
            MovimentaEstoque.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            //Realiza a autenticação do vendedor
            Forms.Login ValidarVendedor = new Forms.Login(Models.SolicitacaoForm.Autenticar, Convert.ToInt32(Models.Cargo.Vendedor));
            ValidarVendedor.Show();
        }

        private void mnProduto_Click(object sender, EventArgs e)
        {
            Forms.Produtos Produto = new Forms.Produtos(1);
            Produto.Show();
        }

        private void relVendas_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnConsultaProduto_Click(object sender, EventArgs e)
        {
            Forms.Produtos Produto = new Forms.Produtos(2);
            Produto.Show();
        }

        private void fechamentoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Forms.Fechamento Fechamento = new Forms.Fechamento();
            Fechamento.Show();
        }

        private void EntradatoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.Gerenciamento Gerenciamento = new Forms.Gerenciamento(3);
            Gerenciamento.Show();
        }

        private void retiradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Gerenciamento Gerenciamento = new Forms.Gerenciamento(4);
            Gerenciamento.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmEstoque MovimentaEstoque = new Forms.frmEstoque();
            MovimentaEstoque.Show();
        }

        private void estoqueAtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportViewer.Forms.Estoque RelEstoque = new ReportViewer.Forms.Estoque(1);
            RelEstoque.Show();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportViewer.Forms.Estoque RelEstoque = new ReportViewer.Forms.Estoque(5);
            RelEstoque.Show();
        }

        private void diárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportViewer.Forms.Vendas RelVendas = new ReportViewer.Forms.Vendas();
            RelVendas.Show();
        }

        private void mensalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportViewer.Forms.Vendas RelVendas = new ReportViewer.Forms.Vendas();
            RelVendas.Show();
        }
    }
}
