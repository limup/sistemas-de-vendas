namespace SistemaVendas.Forms.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class frmEstoque : Form
    {
        //private Global.Global Global = new Global.Global();
        private Controllers.Controller.ProdutoController produtoController;
        private Controllers.Controller.EstoqueController estoqueController;
        private Controllers.Controller.EstoqueHistoricoController estoqueHistoricoController;
        private int idEstoque;

        /// <summary>
        /// Variável responsável por identificar a ação do usuário dentro do formulário
        /// Null = 0 - Não entra na condição
        /// Editar = 1 - Executa o update do produto
        /// Salvar = 2 - Executa o insert do produto
        /// </summary>
        private Models.SolicitacaoButtom Acao;

        /// <summary>
        /// Expressão regular para validação somente números
        /// </summary>
        private const string exNumeros = @"^\d+$"; //Expressão para validar Numeros

        /// <summary>
        /// Expressão regular para validação somente números
        /// </summary>
        private const string exDecimais = @"^(?:[1-9](?:[\d]{0,2}(?:\.[\d]{3})*|[\d]+)|0)(?:.[\d]{0,2})?$"; //Expressão para validar Decimais

        public frmEstoque()
        {
            InitializeComponent();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            produtoController = new Controllers.Controller.ProdutoController();
            estoqueController = new Controllers.Controller.EstoqueController();
            estoqueHistoricoController = new Controllers.Controller.EstoqueHistoricoController();

            inicializaForm();
        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            if (!Acao.Equals(Models.SolicitacaoButtom.Editar))
            {
                if (txtCodProduto.TextLength.Equals(13) || txtCodProduto.Text.Equals("9999999999999"))
                {
                    Match match = Regex.Match(txtCodProduto.Text, exNumeros);
                    if (!match.Success)
                    {
                        txtCodProduto.Text = string.Empty;
                        this.Focus();
                    }
                    else
                    {
                        inicializaPesquisa();

                        //Limpa txtboxs isolados
                        txtMarca.Text = string.Empty;
                        txtDescricao.Text = string.Empty;

                        this.pesquisaProduto("txtCodProduto");
                    }
                }
            }
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            if (!Acao.Equals(Models.SolicitacaoButtom.Editar))
            {
                inicializaPesquisa();

                //Limpa txtboxs isolados
                txtCodProduto.Text = string.Empty;
                txtDescricao.Text = string.Empty;

                if (!string.IsNullOrEmpty(txtMarca.Text.Trim())) this.pesquisaProduto("txtMarca");
            }

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (!Acao.Equals(Models.SolicitacaoButtom.Editar))
            {
                inicializaPesquisa();

                //Limpa txtboxs isolados
                txtCodProduto.Text = string.Empty;
                txtMarca.Text = string.Empty;

                if (!string.IsNullOrEmpty(txtDescricao.Text.Trim())) this.pesquisaProduto("txtDescricao");
            }
        }

        private void dgvEstoque_SelectionChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Método responsável por pesquisar o produto solicitado
        /// </summary>
        private void pesquisaProduto(string txtEscolhido)
        {
            #region Tratamento Filtro Dinâmico

            List<Models.ProdutoModel> produto = new List<Models.ProdutoModel>();

            switch (txtEscolhido)
            {
                case "txtCodProduto":
                    {

                        produto = produtoController
                            .ListarProdutos()
                            .Where(x => x.idProduto.Contains(txtCodProduto.Text))
                            .ToList();

                        break;
                    }
                case "txtMarca":
                    {
                        produto = produtoController
                            .ListarProdutos()
                            .Where(x => x.marcaProduto.Contains(txtMarca.Text))
                            .ToList();

                        break;
                    }
                case "txtDescricao":
                    {
                        produto = produtoController
                             .ListarProdutos()
                             .Where(x => x.descricaoProduto.Contains(txtDescricao.Text))
                             .ToList();

                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            #endregion

            if (produto.Count != 0)
            {
                foreach (var rowProduto in produto)
                {
                    dgvEstoque.AllowUserToAddRows = true;
                    DataGridViewRow row = (DataGridViewRow)dgvEstoque.Rows[0].Clone();

                    #region Popula informações dos produtos e estoque no grid
                    row.Cells[0].Value = rowProduto.idProduto;
                    row.Cells[1].Value = rowProduto.marcaProduto;
                    row.Cells[2].Value = String.Format("{0:C}", (decimal)rowProduto.custoProduto);
                    row.Cells[3].Value = String.Format("{0:C}", (decimal)rowProduto.vendaProduto);
                    row.Cells[5].Value = rowProduto.descricaoProduto;

                    var estoque = estoqueController.BuscarEstoque(Convert.ToInt64(rowProduto.idProduto));

                    row.Cells[6].Value = estoque.entradaEstoque;
                    row.Cells[7].Value = estoque.saidaEstoque;
                    row.Cells[8].Value = estoque.atualEstoque;
                    row.Cells[9].Value = estoque.dataUltMovimentacaoEstoque;

                    #endregion

                    dgvEstoque.Rows.Add(row);

                    dgvEstoque.AllowUserToAddRows = false;

                }
            }
            else
            {
                txtEstoqueAtual.Text = string.Empty;
                txtSaidaProduto.Text = string.Empty;
                txtEntradaProduto.Text = string.Empty;
                txtPrecoCusto.Text = string.Empty;
                txtPrecoVenda.Text = string.Empty;
                lblUltimaMov.Text = string.Empty;
            }

            txtCodProduto.SelectAll();
        }

        /// <summary>
        /// Método responsável por calcular o percentual
        /// </summary>
        private void calculaPercentual()
        {
            if (txtPrecoCusto.Text.Equals(string.Empty)) return;
            if (txtEstoqueAtual.Text.Equals(string.Empty)) return;

            //Calcula Base para calculo
            decimal Base = decimal.Parse(txtEstoqueAtual.Text);

            if (Base.Equals(0)) { lblPorcentagem.Text = "0%"; return; }
            if (decimal.Parse(txtPrecoCusto.Text, NumberStyles.Currency).Equals(decimal.Parse("0.00", NumberStyles.Currency))) return;

            //Insere o Percentual
            double Percentual = (double)((decimal.Parse(txtPrecoVenda.Text, NumberStyles.Currency)
                                    - decimal.Parse(txtPrecoCusto.Text, NumberStyles.Currency)) * Base
                                    / (decimal.Parse(txtPrecoCusto.Text, NumberStyles.Currency) * Base));

            lblPorcentagem.Text = Percentual.ToString() == "NaN (Não é um número)" ? "0%" : Percentual.ToString("P", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Método Responsável por inicializar o Formulário
        /// </summary>
        private void inicializaForm()
        {
            #region Inicializa Itens

            Acao = Models.SolicitacaoButtom.Null;

            #region TextBoxs
            txtCodProduto.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPrecoVenda.Text = string.Empty;
            txtPrecoCusto.Text = string.Empty;
            txtEntradaProduto.Text = string.Empty;
            txtSaidaProduto.Text = string.Empty;
            txtEstoqueAtual.Text = string.Empty;
            #endregion

            #region DataGridView
            dgvEstoque.Rows.Clear();
            #endregion

            #region Labels
            lblPorcentagem.Text = string.Empty;
            lblSituacaoEstoque.Text = string.Empty;
            #endregion

            #region Focus
            txtCodProduto.Focus();
            #endregion

            #endregion

            #region Bloqueia Itens
            //Bloqueia Campos
            txtPrecoCusto.Enabled = false;
            txtPrecoVenda.Enabled = false;

            txtCodProduto.Enabled = true;
            txtMarca.Enabled = true;
            txtDescricao.Enabled = true;

            txtEstoqueAtual.Enabled = false;
            txtEntradaProduto.Enabled = false;
            txtSaidaProduto.Enabled = false;

            //Oculta Botões
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            btnMovimentaEstoque.Enabled = false;
            #endregion

            #region Libera DatagridView
            dgvEstoque.Enabled = true;
            #endregion

        }

        private void inicializaPesquisa()
        {

            dgvEstoque.Rows.Clear();

            lblPorcentagem.Text = string.Empty;
            lblSituacaoEstoque.Text = string.Empty;
            lblUltimaMov.Text = string.Empty;
            lblPorcentagem.Text = string.Empty;

            txtPrecoVenda.Text = string.Empty;
            txtPrecoCusto.Text = string.Empty;
            txtEntradaProduto.Text = string.Empty;
            txtSaidaProduto.Text = string.Empty;
            txtEstoqueAtual.Text = string.Empty;

            btnMovimentaEstoque.Enabled = false;
        }

        private bool ValidaCampoReal(string Valor)
        {
            try
            {
                Valor = double.Parse(Valor, NumberStyles.Currency).ToString();
                Match match = Regex.Match(Valor, exDecimais);

                if (!match.Success) return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.inicializaForm();
        }

        private void btnMovimentaEstoque_Click(object sender, EventArgs e)
        {
            Acao = Models.SolicitacaoButtom.Editar;

            if (dgvEstoque.SelectedRows.Count.Equals(0)) return;

            #region Ativa os botões
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
            #endregion

            #region Bloqueia o botão
            btnMovimentaEstoque.Enabled = false;
            #endregion

            #region Trava a DataGradeView
            dgvEstoque.Enabled = false;
            #endregion

            #region Libera os campos para edição
            txtEntradaProduto.Enabled = true;
            txtSaidaProduto.Enabled = true;
            #endregion

            #region Bloqueia campos irrelevantes
            txtCodProduto.Enabled = false;
            txtMarca.Enabled = false;
            txtDescricao.Enabled = false;
            #endregion

            #region Popula os textboxs a linha selecionada
            txtCodProduto.Text = dgvEstoque.SelectedRows[dgvEstoque.CurrentRow.Index].Cells[0].Value.ToString();
            txtMarca.Text = dgvEstoque.SelectedRows[dgvEstoque.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescricao.Text = dgvEstoque.SelectedRows[dgvEstoque.CurrentRow.Index].Cells[5].Value.ToString();
            #endregion
        }

        private void txtEntradaProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSaidaProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtEntradaProduto.Text.Equals(string.Empty)) return;
            if (txtSaidaProduto.Text.Equals(string.Empty)) return;

            txtEstoqueAtual.Text = (double.Parse(txtEntradaProduto.Text, NumberStyles.Currency)
                                    - double.Parse(txtSaidaProduto.Text, NumberStyles.Currency)).ToString();
        }

        private void txtEstoqueAtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            #region Manipula o campo Estoque atual
            txtEstoqueAtual.Text = (double.Parse(txtEntradaProduto.Text, NumberStyles.Currency)
                                    - double.Parse(txtSaidaProduto.Text, NumberStyles.Currency)).ToString();
            #endregion

            #region Popula objetos da propriedade Estoque
            Models.EstoqueModel Estoque = new Models.EstoqueModel();

            Estoque.idEstoque = idEstoque;
            Estoque.idProdutoEstoque = txtCodProduto.Text;
            Estoque.entradaEstoque = Convert.ToInt32(txtEntradaProduto.Text);
            Estoque.saidaEstoque = Convert.ToInt32(txtSaidaProduto.Text);
            Estoque.atualEstoque = Convert.ToInt32(txtEstoqueAtual.Text);
            Estoque.dataUltMovimentacaoEstoque = DateTime.Now;
            Estoque.situacaoEstoque = Convert.ToInt32(txtEstoqueAtual.Text) < 3 ? "S" : "N";

            #endregion

            #region Popula objetos da propriedade Estoque Historico
            Models.EstoqueHistoricoModel EstoqueHistorico = new Models.EstoqueHistoricoModel();

            EstoqueHistorico.IdProdutoEstoque_Historico = txtCodProduto.Text;
            EstoqueHistorico.EntradaEstoque_Historico = Convert.ToInt32(txtEntradaProduto.Text);
            EstoqueHistorico.SaidaEstoque_Historico = Convert.ToInt32(txtSaidaProduto.Text);
            EstoqueHistorico.AtualEstoque_Historico = Convert.ToInt32(txtEstoqueAtual.Text);
            EstoqueHistorico.DataUltMovimentacaoEstoque_Historico = DateTime.Now;
            EstoqueHistorico.SituacaoEstoque_Historico = Convert.ToInt32(txtEstoqueAtual.Text) < 3 ? "S" : "N";
            EstoqueHistorico.IdUsuarioEstoque_Historico = Global.Global.usuariomodel.idUsuario.ToString();

            #endregion

            try
            {
                Estoque.Retorno = estoqueController.AtualizarEstoque(Estoque);

                if (Estoque.Retorno.Situacao)
                {
                    estoqueHistoricoController.CadastrarEstoqueHistorico(EstoqueHistorico);

                    MessageBox.Show("Movimentado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {

                throw;
            }
            this.inicializaForm();
        }

        private void txtSaidaProduto_Enter(object sender, EventArgs e)
        {
            if (txtEntradaProduto.Text.Equals(string.Empty)) return;
            if (txtSaidaProduto.Text.Equals(string.Empty)) return;

            txtEstoqueAtual.Text = (double.Parse(txtEntradaProduto.Text, NumberStyles.Currency)
                                    - double.Parse(txtSaidaProduto.Text, NumberStyles.Currency)).ToString();
            //this.calculaPercentual();
        }

        private void dgvEstoque_Click(object sender, EventArgs e)
        {
            txtPrecoCusto.Text = dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[2].Value.ToString();
            txtPrecoVenda.Text = dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[3].Value.ToString();

            Int64 idProduto = Convert.ToInt64(dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[0].Value.ToString());
            var estoqueEspelho = estoqueController.BuscarEstoque(idProduto);

            if (estoqueEspelho.Retorno.Situacao)
            {
                idEstoque = estoqueEspelho.idEstoque;

                dgvEstoque.AllowUserToAddRows = true;

                dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[6].Value = estoqueEspelho.entradaEstoque;
                dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[7].Value = estoqueEspelho.saidaEstoque;
                dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[8].Value = estoqueEspelho.atualEstoque;
                dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[9].Value = (DateTime)estoqueEspelho.dataUltMovimentacaoEstoque;

                dgvEstoque.AllowUserToAddRows = false;

                txtEntradaProduto.Text = estoqueEspelho.entradaEstoque.ToString();
                txtSaidaProduto.Text = estoqueEspelho.saidaEstoque.ToString();
                txtEstoqueAtual.Text = estoqueEspelho.atualEstoque.ToString();

                lblSituacaoEstoque.Text = estoqueEspelho.situacaoEstoque == null ? string.Empty : estoqueEspelho.situacaoEstoque.Equals("S") ? "Sim" : "Não";
                lblUltimaMov.Text = estoqueEspelho.dataUltMovimentacaoEstoque.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Este produto não possui estoque!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtEstoqueAtual.Text = string.Empty;
                txtSaidaProduto.Text = string.Empty;
                txtEntradaProduto.Text = string.Empty;
            }

            //Calcula o Percentual
            calculaPercentual();

            //Ativa botão Editar
            btnMovimentaEstoque.Enabled = true;
        }
    }
}
