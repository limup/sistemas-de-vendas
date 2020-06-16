namespace SistemaVendas.Forms.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    /// <summary>
    /// Classe responsável por manipular informações referentes ao Produto
    /// </summary>
    public partial class Produtos : Form
    {
        private Controllers.Controller.ProdutoController produtoController;
        private Controllers.Controller.EstoqueController estoqueController;

        /// <summary>
        /// Variável responsável por identificar a solicitação do usuário
        /// Caso 1 - Consulta de produto
        /// Caso 2 - Cadastro de produto
        /// </summary>
        private string Solicitacao = string.Empty;

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

        #region Eventos

        /// <summary>
        /// Instanciamento do formulário para carregar componentes/Itens
        /// </summary>
        /// <param name="Solicitacao">Solicitação do usuário/Formulário</param>
        public Produtos(int Solicitacao)
        {
            InitializeComponent();

            switch (Solicitacao)
            {
                case 1:
                    this.Solicitacao = ((Models.SolicitacaoForm)Convert.ToInt32(Solicitacao.ToString())).ToString();
                    break;
                case 2:
                    this.Solicitacao = ((Models.SolicitacaoForm)Convert.ToInt32(Solicitacao.ToString())).ToString();
                    break;
            }
        }

        /// <summary>
        /// Método responsável por carregar inicializar o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void Produtos_Load(object sender, EventArgs e)
        {
            produtoController = new Controllers.Controller.ProdutoController();
            estoqueController = new Controllers.Controller.EstoqueController();

            inicializaForm();
        }

        /// <summary>
        /// Método responsável por executar quando o item txtCodProduto houver alteração em sua caixa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(txtCodProduto.Text, exNumeros);

            if (!match.Success)
            {
                txtCodProduto.Text = "";
                this.Focus();
            }
            else
            {
                if (this.Solicitacao.Equals("Consulta"))
                {
                    if (!Acao.Equals(Models.SolicitacaoButtom.Editar))
                    {
                        #region Inicializa DatagridView
                        dgvProduto.Rows.Clear();
                        #endregion
                        this.pesquisaProduto("txtCodProduto");
                    }
                }
                else
                {
                    #region Valida se o código já existe
                    var teste = produtoController.ListarProdutos().Where(x => x.idProduto == txtCodProduto.Text).ToList();

                    if (teste.Count != 0)
                    {
                        MessageBox.Show("Este código do produto já está relacionado.", "Código do produto existente.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Selecionao campo novamente
                        txtCodProduto.SelectAll();

                        //Bloqueia o botão
                        btnConfirmar.Enabled = false;
                    }
                    else { btnConfirmar.Enabled = true; }
                    #endregion
                }
            }
        }

        /// <summary>
        /// Método responsável por executar quando o item txtCodProduto houver alteração em sua caixa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (this.Solicitacao.Equals("Consulta"))
            {
                if (!Acao.Equals(Models.SolicitacaoButtom.Editar))
                {
                    #region Inicializa DatagridView
                    dgvProduto.Rows.Clear();
                    #endregion
                    if (!string.IsNullOrEmpty(txtDescricao.Text.Trim())) this.pesquisaProduto("txtDescricao");
                }
            }
        }

        /// <summary>
        /// Método responsável por executar quando o item txtCodProduto houver alteração em sua caixa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            if (this.Solicitacao.Equals("Consulta"))
            {
                if (!Acao.Equals(Models.SolicitacaoButtom.Editar))
                {
                    #region Inicializa DatagridView
                    dgvProduto.Rows.Clear();
                    #endregion
                    if (!string.IsNullOrEmpty(txtMarca.Text.Trim())) this.pesquisaProduto("txtMarca");
                }
            }
        }

        /// <summary>
        /// Método responsável por carregar informações do produto no formulário, quando clicado em uma linha do datagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void dgvProduto_SelectionChanged(object sender, EventArgs e)
        {
            if (this.Solicitacao.Equals("Consulta"))
            {
                Models.ProdutoModel produto = new Models.ProdutoModel();

                txtPrecoCusto.Text = dgvProduto.Rows[dgvProduto.CurrentRow.Index].Cells[3].Value.ToString();
                txtPrecoVenda.Text = dgvProduto.Rows[dgvProduto.CurrentRow.Index].Cells[4].Value.ToString();

                //Valida se tem imagem
                if (!string.IsNullOrEmpty(dgvProduto.Rows[dgvProduto.CurrentRow.Index].Cells[6].Value.ToString()))
                {
                    picProduto.Load("ProdutoFotos\\" + dgvProduto.Rows[dgvProduto.CurrentRow.Index].Cells[6].Value.ToString());
                }
                else { picProduto.Load("ProdutoFotos\\Erro.png"); };

                //Calcula o Percentual
                this.calculaPercentual();

                //Ativa botão Editar
                btnEditar.Visible = true;
            }
        }

        /// <summary>
        /// Método responsável por editar o produto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void btnEditar_Click(object sender, EventArgs e)
        {

            #region Bloqueia Itens
            //Libera Campos
            txtPrecoCusto.Enabled = true;
            txtPrecoVenda.Enabled = true;
            txtCodProduto.Enabled = false;

            //Exibe e oculta Botões
            btnEditar.Visible = false;
            btnCancelar.Visible = true;
            btnConfirmar.Visible = true;

            //Libera Foto
            picProduto.Enabled = true;

            //Bloqueia o DatagridView
            dgvProduto.Enabled = false;
            #endregion

            #region Popula os textboxs a linha selecionada
            txtCodProduto.Text = dgvProduto.SelectedRows[0].Cells[0].Value.ToString();
            txtMarca.Text = dgvProduto.SelectedRows[0].Cells[1].Value.ToString();
            txtDescricao.Text = dgvProduto.SelectedRows[0].Cells[2].Value.ToString();
            #endregion

            //Seta para Editar
            Acao = Models.SolicitacaoButtom.Editar;
        }

        /// <summary>
        /// Método responsável por cancelar a edição do produto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.inicializaForm();
        }

        /// <summary>
        /// Método responsável por selecionar o item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtPrecoCusto_Enter(object sender, EventArgs e)
        {
            this.txtPrecoCusto.SelectAll();
        }

        /// <summary>
        /// Método responsável por selecionar o item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtPrecoCusto_MouseEnter(object sender, EventArgs e)
        {
            this.txtPrecoCusto.SelectAll();
        }

        /// <summary>
        /// Método responsável por selecionar o item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtPrecoCusto_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtPrecoCusto.SelectAll();
        }

        /// <summary>
        /// Método responsável por selecionar o item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtPrecoVenda_MouseEnter(object sender, EventArgs e)
        {
            this.txtPrecoVenda.SelectAll();
        }

        /// <summary>
        /// Método responsável por selecionar o item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtPrecoVenda_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtPrecoVenda.SelectAll();
        }

        /// <summary>
        /// Método responsável por selecionar o item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtPrecoVenda_Enter(object sender, EventArgs e)
        {
            this.txtPrecoVenda.SelectAll();
        }

        /// <summary>
        /// Método responsável por verificar que tipo de salvar o formulário pede
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Validação de números Reais
            if (!string.IsNullOrEmpty(txtPrecoCusto.Text))
            {
                if (!ValidaCampoReal(txtPrecoCusto.Text)) { txtPrecoCusto.Text = String.Format("{0:C}", Convert.ToDecimal(0)); }
                else
                {
                    if (!txtPrecoCusto.Text.Contains(NumberFormatInfo.CurrentInfo.CurrencySymbol))
                    { txtPrecoCusto.Text = String.Format("{0:C}", Convert.ToDecimal(txtPrecoCusto.Text)); }
                    this.calculaPercentual();
                };
            }

            if (!this.Solicitacao.Equals("Consulta"))
            {
                //Seta para Salvar
                Acao = Models.SolicitacaoButtom.Salvar;
            }

            //Valida campos
            if (string.IsNullOrEmpty(txtCodProduto.Text) ||
                string.IsNullOrEmpty(txtDescricao.Text) ||
                string.IsNullOrEmpty(txtPrecoCusto.Text) ||
                string.IsNullOrEmpty(txtPrecoVenda.Text))
            {
                MessageBox.Show("Os campos principais não podem ser vazios!", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Chama o método para salvar o registro
                this.salvarProduto();
            }
        }

        /// <summary>
        /// Evento responsável por atribuir a imagem escolhida pelo usuário e carregar no item Picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void picProduto_Click(object sender, EventArgs e)
        {
            this.carregaImagemSalvar = new OpenFileDialog();
            DialogResult acao = this.carregaImagemSalvar.ShowDialog();

            if (acao.Equals(System.Windows.Forms.DialogResult.OK))
            {
                picProduto.Load(this.carregaImagemSalvar.FileName);
            }
        }

        /// <summary>
        /// Evento responsável por validar se o textbox está de acordo com a regra de decimais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtPrecoCusto_Leave(object sender, EventArgs e)
        {
            //Validação de números Reais
            if (!string.IsNullOrEmpty(txtPrecoCusto.Text))
            {
                if (!ValidaCampoReal(txtPrecoCusto.Text)) { txtPrecoCusto.Text = String.Format("{0:C}", Convert.ToDecimal(0)); }
                else
                {
                    if (!txtPrecoCusto.Text.Contains(NumberFormatInfo.CurrentInfo.CurrencySymbol))
                    { txtPrecoCusto.Text = String.Format("{0:C}", Convert.ToDecimal(txtPrecoCusto.Text)); }
                    this.calculaPercentual();
                };
            }

        }

        /// <summary>
        /// Evento responsável por validar se o textbox está de acordo com a regra de decimais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            //Validação de números Reais
            if (!string.IsNullOrEmpty(txtPrecoVenda.Text))
            {
                if (!ValidaCampoReal(txtPrecoVenda.Text)) { txtPrecoVenda.Text = String.Format("{0:C}", Convert.ToDecimal(0)); }
                else
                {
                    if (!txtPrecoVenda.Text.Contains(NumberFormatInfo.CurrentInfo.CurrencySymbol))
                    { txtPrecoVenda.Text = String.Format("{0:C}", Convert.ToDecimal(txtPrecoVenda.Text)); }
                    this.calculaPercentual();
                };
            }

        }
        #endregion

        /// <summary>
        /// Método Responsável por inicializar o Formulário
        /// </summary>
        private void inicializaForm()
        {
            Acao = Models.SolicitacaoButtom.Null;

            if (this.Solicitacao.Equals("Consulta"))
            {
                #region Inicializa Itens

                #region TextBoxs
                txtCodProduto.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                txtMarca.Text = string.Empty;
                txtPrecoVenda.Text = string.Empty;
                txtPrecoCusto.Text = string.Empty;
                #endregion

                #region Imagens
                picProduto.Image = null;
                #endregion

                #region Labels
                lblPorcentagem.Text = string.Empty;
                #endregion

                #region Focus
                txtCodProduto.Focus();
                #endregion

                #region Inicializa DatagridView
                dgvProduto.Rows.Clear();
                #endregion

                #endregion

                #region Libera DatagridView
                dgvProduto.Enabled = true;
                #endregion

                #region Bloqueia Itens
                //Bloqueia Campos
                txtPrecoCusto.Enabled = false;
                txtPrecoVenda.Enabled = false;
                txtCodProduto.Enabled = true;

                //Oculta Botões
                btnEditar.Visible = false;
                btnCancelar.Visible = false;
                btnConfirmar.Visible = false;

                //Bloqueia Foto
                picProduto.Enabled = false;
                #endregion
            }
            else
            {
                #region Bloqueia Itens

                //Oculta Botões
                btnEditar.Visible = false;
                #endregion

                #region Inicializa Itens

                #region Imagens
                picProduto.Image = null;
                #endregion

                #region Labels
                lblPorcentagem.Text = string.Empty;
                #endregion

                #region TextBoxs
                txtCodProduto.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                txtMarca.Text = string.Empty;
                txtPrecoVenda.Text = string.Empty;
                txtPrecoCusto.Text = string.Empty;
                #endregion

                #region Focus
                txtCodProduto.Focus();
                #endregion

                #endregion
            }
        }

        /// <summary>
        /// Método responsável por pesquisar o produto solicitado
        /// </summary>
        private void pesquisaProduto(string txtEscolhido)
        {
            #region Tratamento Filtro Dinâmico

            List<Models.ProdutoModel> produtoEspelho = new List<Models.ProdutoModel>();

            switch (txtEscolhido)
            {
                case "txtCodProduto":
                    {

                        produtoEspelho = produtoController
                            .ListarProdutos()
                            .Where(x => x.idProduto.Contains(txtCodProduto.Text))
                            .ToList();

                        break;
                    }
                case "txtMarca":
                    {
                        produtoEspelho = produtoController
                            .ListarProdutos()
                            .Where(x => x.marcaProduto.Contains(txtMarca.Text))
                            .ToList();

                        break;
                    }
                case "txtDescricao":
                    {
                        produtoEspelho = produtoController
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

            if (produtoEspelho.Count != 0)
            {
                foreach (var rowProduto in produtoEspelho)
                {
                    dgvProduto.AllowUserToAddRows = true;
                    DataGridViewRow row = (DataGridViewRow)dgvProduto.Rows[0].Clone();

                    row.Cells[0].Value = rowProduto.idProduto;
                    row.Cells[1].Value = rowProduto.marcaProduto;
                    row.Cells[2].Value = rowProduto.descricaoProduto;
                    row.Cells[3].Value = String.Format("{0:C}", (decimal)rowProduto.custoProduto);
                    row.Cells[4].Value = String.Format("{0:C}", (decimal)rowProduto.vendaProduto);
                    row.Cells[5].Value = (DateTime)rowProduto.dataCadastroProduto;
                    row.Cells[6].Value = rowProduto.caminhoFotoProduto;

                    dgvProduto.Rows.Add(row);
                    dgvProduto.AllowUserToAddRows = false;
                }
            }
        }

        /// <summary>
        /// Método responsável por calcular o percentual
        /// </summary>
        private void calculaPercentual()
        {

            if (txtPrecoCusto.Text.Equals(string.Empty)) return;
            if (txtPrecoVenda.Text.Equals(string.Empty)) return;

            if (decimal.Parse(txtPrecoCusto.Text, NumberStyles.Currency).Equals(decimal.Parse("0.00", NumberStyles.Currency))) return;

            //Insere o Percentual
            double Percentual = (double.Parse(txtPrecoVenda.Text, NumberStyles.Currency)
                                    - double.Parse(txtPrecoCusto.Text, NumberStyles.Currency))
                                    / double.Parse(txtPrecoCusto.Text, NumberStyles.Currency);

            lblPorcentagem.Text = Percentual.ToString() == "NaN (Não é um número)" ? "0%" : Percentual.ToString("P", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Método responsável direto ao banco para salvar as alterações do produto e cadastro
        /// </summary>
        private void salvarProduto()
        {
            #region Popula objeto Produto

            Models.ProdutoModel produto = new Models.ProdutoModel();

            produto.idProduto = txtCodProduto.Text;
            produto.descricaoProduto = txtDescricao.Text;
            produto.marcaProduto = txtMarca.Text;
            produto.custoProduto = decimal.Parse(txtPrecoCusto.Text, NumberStyles.Currency);
            produto.vendaProduto = decimal.Parse(txtPrecoVenda.Text, NumberStyles.Currency);
            produto.caminhoFotoProduto = picProduto.ImageLocation == null ? "pPadrao.png" : Path.GetFileName(picProduto.ImageLocation);
            produto.dataCadastroProduto = DateTime.Now;

            #endregion

            //Copiar o arquivo escolhido para o caminho da foto de produtos
            //TODO: Validar se uma pasta existe ou não
            if (!System.IO.File.Exists("ProdutoFotos\\" + Path.GetFileName(picProduto.ImageLocation)))
            {
                if (!string.IsNullOrEmpty(picProduto.ImageLocation))
                {
                    if (!System.IO.File.Exists("ProdutoFotos"))
                    {
                        System.IO.Directory.CreateDirectory("ProdutoFotos");
                    }

                    System.IO.File.Copy(picProduto.ImageLocation, "ProdutoFotos\\" + Path.GetFileName(picProduto.ImageLocation), true);
                }
            }

            switch (Acao)
            {
                case Models.SolicitacaoButtom.Salvar:

                    produto.Retorno = produtoController.CadastrarProduto(produto);

                    if (produto.Retorno.Situacao)
                    {
                        MessageBox.Show("Produto Salvo com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        #region Inicia o estoque zerado

                        Models.EstoqueModel estoque = new Models.EstoqueModel()
                        {
                            idProdutoEstoque = produto.idProduto,
                            entradaEstoque = 0,
                            saidaEstoque = 0,
                            atualEstoque = 0,
                            dataUltMovimentacaoEstoque = produto.dataCadastroProduto,
                            situacaoEstoque = "S"
                        };


                        estoqueController.CadastrarEstoque(estoque);

                        #endregion

                        dgvProduto.AllowUserToAddRows = true;
                        DataGridViewRow row = (DataGridViewRow)dgvProduto.Rows[0].Clone();

                        row.Cells[0].Value = txtCodProduto.Text;
                        row.Cells[1].Value = txtMarca.Text;
                        row.Cells[2].Value = txtDescricao.Text;
                        row.Cells[3].Value = String.Format("{0:C}", (decimal)produto.custoProduto);
                        row.Cells[4].Value = String.Format("{0:C}", (decimal)produto.vendaProduto);
                        row.Cells[5].Value = DateTime.Now;

                        dgvProduto.Rows.Add(row);
                        dgvProduto.AllowUserToAddRows = false;
                    }
                    else
                    {
                        MessageBox.Show("Houve uma falha ao salvar o produto. /n Erro: " + produto.Retorno.Erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case Models.SolicitacaoButtom.Editar:
                    produto.Retorno = produtoController.AtualizarProduto(produto);

                    if (produto.Retorno.Situacao)
                    {
                        MessageBox.Show("Produto Editado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Houve uma falha ao salvar o produto. \nErro: " + produto.Retorno.Erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

            this.inicializaForm();
        }


        private bool ValidaCampoReal(string Valor)
        {
            try
            {
                Valor = String.Format("{0:0.00}", decimal.Parse(Valor, NumberStyles.Currency).ToString());
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
    }
}
