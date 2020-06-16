using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.ReportViewer.Forms
{
    public partial class Estoque : Form
    {
        /// <summary>
        /// Variável responsável por identificar a solicitação do usuário
        /// Caso 1 - Consulta de estoque
        /// Caso 2 - Consulta de histórico de estoque
        /// </summary>
        private string Solicitacao = string.Empty;

        private List<KeyValuePair<string, string>> listaOpcoes =
            new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("0", "Selecione")};

        private Controllers.Controller.ProdutoController produtoController;
        private Controllers.Controller.EstoqueController estoqueController;

        public Estoque(int Solicitacao)
        {
            InitializeComponent();

            switch (Solicitacao)
            {
                case 1:
                    this.Solicitacao = ((Models.SolicitacaoForm)Convert.ToInt32(Solicitacao.ToString())).ToString();
                    break;
                case 5:
                    this.Solicitacao = ((Models.SolicitacaoForm)Convert.ToInt32(Solicitacao.ToString())).ToString();
                    break;
            }
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            #region Inicializa os controllers

            produtoController = new Controllers.Controller.ProdutoController();
            estoqueController = new Controllers.Controller.EstoqueController();

            #endregion

            this.ConfigReport();
            this.btnPesquisar.Focus();
            this.CarregaCombo();
        }

        private void CarregaCombo()
        {
            List<Models.ProdutoModel> ListaProdutos = produtoController.ListarProdutos().ToList();

            foreach (Models.ProdutoModel rowProduto in ListaProdutos)
            {
                listaOpcoes.Add(new KeyValuePair<string, string>(rowProduto.idProduto.ToString(), rowProduto.marcaProduto));
            }

            cmbProduto.DataSource = listaOpcoes.Select(row => row.Value).ToList();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<Models.Relatorios.Estoque> estoqueRelatorio = new List<Models.Relatorios.Estoque>();
            List<Models.EstoqueModel> Estoques = new List<Models.EstoqueModel>();

            switch (Solicitacao)
            {
                case "Consulta":
                    Estoques = estoqueController.ListarEstoques()
                        .Where(x => x.dataUltMovimentacaoEstoque >= Convert.ToDateTime(txtDataInicial.Text) && x.dataUltMovimentacaoEstoque <= Convert.ToDateTime(txtDataFinal.Text))
                        .ToList();
                    break;
                case "Historico":
                    Estoques = estoqueController.ListarEstoques();
                    Estoques = estoqueController.ListarEstoques()
                        .Where(x => x.dataUltMovimentacaoEstoque >= Convert.ToDateTime(txtDataInicial.Text) && x.dataUltMovimentacaoEstoque <= Convert.ToDateTime(txtDataFinal.Text))
                        .ToList();
                    break;
            }

            #region Popula Relatorio
            foreach (Models.EstoqueModel estoque in Estoques)
            {
                estoqueRelatorio.Add(new Models.Relatorios.Estoque
                {
                    Produto = estoque.idProdutoEstoque.ToString(),
                    Descricao = listaOpcoes.Where(row => row.Key.Equals(estoque.idProdutoEstoque.ToString())).First().Value,
                    Entrada = estoque.entradaEstoque.ToString(),
                    Saida = estoque.saidaEstoque.ToString(),
                    EstoqueAtual = estoque.atualEstoque.ToString(),
                    DataMovimentacao = estoque.dataUltMovimentacaoEstoque.ToString()
                });
            }
            #endregion

            EstoqueBindingSource.DataSource = estoqueRelatorio;

            this.ConfigReport();
            this.rpViewEstoque.RefreshReport();
        }

        private void ConfigReport()
        {
            #region Configurando a característica do relatório
            this.rpViewEstoque.ShowZoomControl = false;
            this.rpViewEstoque.ZoomPercent = 100;
            //this.rpViewEstoque.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.rpViewEstoque.SetPageSettings(new System.Drawing.Printing.PageSettings { Landscape = true });
            #endregion
        }
    }
}
