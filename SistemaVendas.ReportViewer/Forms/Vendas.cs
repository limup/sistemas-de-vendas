using SistemaVendas.ReportViewer.FormsRdlc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.ReportViewer.Forms
{
    public partial class Vendas : Form
    {
        private Controllers.Controller.VendaController vendaController;
        private Controllers.Controller.ReciboController reciboController;
        private Controllers.Controller.FuncionarioController funcionarioController;
        private Controllers.Controller.ProdutoController produtoController;

        public Vendas()
        {
            InitializeComponent();
        }

        #region Eventos

        private void Vendas_Load(object sender, EventArgs e)
        {
            #region Inicializa os controllers

            vendaController = new Controllers.Controller.VendaController();
            reciboController = new Controllers.Controller.ReciboController();
            funcionarioController = new Controllers.Controller.FuncionarioController();
            produtoController = new Controllers.Controller.ProdutoController();

            #endregion

            #region Carrega Componentes Necessários

            carregaCmbVendedoras();
            carregaCmbProdutos();

            #endregion

            this.btnPesquisar.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<Models.ReciboModel> Recibos = new List<Models.ReciboModel>();
            List<Models.Relatorios.Vendas> Relatorio = new List<Models.Relatorios.Vendas>();

            Recibos = reciboController.ListarRecibos();
            
            #region Popula Relatorio
            foreach (Models.ReciboModel recibo in Recibos)
            {
                Relatorio.Add(new Models.Relatorios.Vendas
                {
                    Numero = recibo.vendaRecibo.idVenda.ToString(),
                    Produto = recibo.produtoRecibo.descricaoProduto,
                    Quantidade = recibo.qdadeProdutoRecibo,
                    Unitario = recibo.VendaProdutoRecibo,
                    Total = recibo.qdadeProdutoRecibo * recibo.VendaProdutoRecibo
                });
            }

            decimal Base = Relatorio.Sum(row => row.Total);
            foreach (var Venda in Relatorio)
            {
                Venda.Faturamento = Convert.ToString(Math.Round((Venda.Total * 100) / Base, 1)) + "%";
            }
            #endregion

            #region Acrescenta Valor Total da Venda

            Relatorio.Add(new Models.Relatorios.Vendas()
            {
                Numero = "",
                Produto = "TOTAL DA VENDA NESTE PERÍODO",
                Quantidade = Relatorio.Sum(row => row.Quantidade),
                Unitario = Relatorio.Sum(row => row.Unitario),
                Total = Relatorio.Sum(row => row.Total),
                Faturamento = "100%"
            });

            #endregion

            #region Popula Paramentros

            List<Microsoft.Reporting.WinForms.ReportParameter> lParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            lParametros.Add(new Microsoft.Reporting.WinForms.ReportParameter("lblEmpresa", "Ravivare"));
            lParametros.Add(new Microsoft.Reporting.WinForms.ReportParameter("lblDataInicio", txtDataInicial.Text.ToString()));
            lParametros.Add(new Microsoft.Reporting.WinForms.ReportParameter("lblDataFim", txtDataFinal.Text.ToString()));
            lParametros.Add(new Microsoft.Reporting.WinForms.ReportParameter("lblDataEmissao", DateTime.Today.ToString("dd/MM/yyyy")));
            lParametros.Add(new Microsoft.Reporting.WinForms.ReportParameter("lblUsuario", "Junior"));

            #endregion
            relVendas relvendas = new relVendas(Relatorio, lParametros);
            relvendas.Show();
        }

        #endregion

        #region Métodos

        private void carregaCmbVendedoras()
        {
            var vendedoras = funcionarioController.ListarFuncionarios();

            if (vendedoras.Count != 0)
            {
                var obj = new Models.FuncionarioModel() { idCargoFuncionario = 2, nomeFuncionario = "Todos", };

                vendedoras.Add(obj);

                funcionarioModelBindingSource.DataSource = vendedoras
                    .Where(x => x.idCargoFuncionario.Equals(2))
                    .Select(x => new { x.idCargoFuncionario, x.nomeFuncionario });
            }

            cmbVendedoras.SelectedIndex = cmbVendedoras.FindStringExact("Todos");
        }

        private void carregaCmbProdutos()
        {
            var produtos = produtoController.ListarProdutos();

            if (produtos.Count != 0)
            {
                var obj = new Models.ProdutoModel() { idProduto = "0", descricaoProduto = "Todos", };

                produtos.Add(obj);

                produtoModelBindingSource.DataSource = produtos.Select(x => new { x.idProduto, x.descricaoProduto });
            }

            cmbProdutos.SelectedIndex = cmbProdutos.FindStringExact("Todos");
        }

        #endregion

    }
}
