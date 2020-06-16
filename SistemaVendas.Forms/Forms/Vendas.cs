namespace SistemaVendas.Forms.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Microsoft.VisualBasic;
    using System.Globalization;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Formulário responsável por entrar informações de vendas
    /// </summary>
    public partial class Vendas : Form
    {
        /// <summary>
        /// Expressão regular para validação somente números
        /// </summary>
        private const string exNumeros = @"^\d+$"; //Expressão para validar Numeros

        private Controllers.Controller.ProdutoController produtoController;
        private Controllers.Controller.EstoqueController estoqueController;
        private Controllers.Controller.VendaController vendaController;
        private Controllers.Controller.ReciboController reciboController;
        private Controllers.Controller.FormaPgtoController formaPgtoController;

        private Models.FuncionarioModel Vendedor;

        /// <summary>
        /// Inicialização do formulário, responsável por carregar os itens do formulário
        /// </summary>
        public Vendas(int usuario)
        {
            Models.UsuarioModel Usuario = new Models.UsuarioModel();
            Usuario = Global.Global.usuariocontroller.BuscarUsuario(usuario);

            Vendedor = new Models.FuncionarioModel();
            Vendedor = Global.Global.funcionariocontroller.BuscarVendedor(Usuario.idFuncionarioUsuario);

            InitializeComponent();
        }

        /// <summary>
        /// Evento responsável por inicializar os itens do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void Vendas_Load(object sender, EventArgs e)
        {
            #region Inicializa os controllers

            produtoController = new Controllers.Controller.ProdutoController();
            estoqueController = new Controllers.Controller.EstoqueController();
            vendaController = new Controllers.Controller.VendaController();
            reciboController = new Controllers.Controller.ReciboController();
            formaPgtoController = new Controllers.Controller.FormaPgtoController();

            #endregion

            this.inicializaForm();
        }

        /// <summary>
        /// Método responsável por inicializar os itens personalizados
        /// </summary>
        private void inicializaForm()
        {
            #region Cursor
            //Cursor.Hide();
            #endregion

            #region Inicializa DatagridView
            dgvRecibo.Rows.Clear();
            #endregion

            #region Inicializa rodapé
            Random rn = new Random();

            lblCodVenda.Text = DateTime.Now.Year.ToString()
                + DateTime.Now.Month.ToString()
                + DateTime.Now.Day.ToString()
                + DateTime.Now.Minute.ToString()
                + DateTime.Now.Hour.ToString()
                + rn.Next(1, 31);

            #region Vendedor

            lblVendedor.Text = Vendedor.nomeFuncionario.ToString();

            #endregion

            #endregion

            #region Inicializa Itens

            #region Imagens
            //picProduto.Image = null;
            #endregion

            #region Labels
            lblVisor.Text = string.Empty;
            lblDataVenda.Text = DateTime.Now.ToShortDateString().ToString();
            lblTotalPagar.Text = "";
            lblTroco.Text = "";
            lblCaixaLivre.Visible = true;
            #endregion

            #region TextBoxs
            txtAcrescimo.Text = "0";
            txtCodProduto.Text = "";
            txtDesconto.Text = "0";
            txtDescricao.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtQdade.Text = "";
            txtSubTotal.Text = "";
            txtValorRecebido.Text = "0";
            txtValorUnit.Text = "";
            txtQdade.Text = "1";
            #endregion

            #region Combo

            cmbFormaPgto.DataSource = formaPgtoController.ListarFormaPgto();

            #endregion

            #region Focus
            txtCodProduto.Focus();
            #endregion

            #endregion


        }

        private void ExecutaFuncoesPrincipais()
        {
            Match match = Regex.Match(txtCodProduto.Text, exNumeros);

            if (!match.Success)
            {
                txtCodProduto.Text = "";
                this.Focus();
            }
            else
            {
                #region Manipulação Principal

                lblCaixaLivre.Visible = false;
                lblVisor.Text = txtQdade.Text + " x ";

                Models.ProdutoModel produto = new Models.ProdutoModel();
                List<Models.EstoqueModel> listaEstoque = new List<Models.EstoqueModel>();

                if (!string.IsNullOrEmpty(txtCodProduto.Text))
                {
                    try
                    {
                        #region Manipulação de produto
                        var produtoEspelho = produtoController.BuscarProduto(txtCodProduto.Text);

                        if (produtoEspelho.Retorno.Situacao)
                        {
                            produto = produtoEspelho;

                            #region Manipulação de Estoque Para a validação do produto selecionado

                            listaEstoque = estoqueController.ListarEstoques().OrderBy(x => x.dataUltMovimentacaoEstoque).ToList();

                            if (listaEstoque.Count > 0 && !txtCodProduto.Text.Equals("9999999999999"))
                            {
                                int temEstoque = listaEstoque.First().atualEstoque;
                                if (temEstoque == 0)
                                {
                                    MessageBox.Show("Produto sem estoque!", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtCodProduto.Text = string.Empty; return;
                                }
                                else
                                {
                                    int somaEstoque = 0;

                                    foreach (DataGridViewRow item in dgvRecibo.Rows)
                                    {
                                        if (item.Cells[0].FormattedValue.Equals(txtCodProduto.Text))
                                        {
                                            somaEstoque += int.Parse(item.Cells[3].FormattedValue.ToString());
                                        }
                                    }

                                    somaEstoque += int.Parse(txtQdade.Text);

                                    if (somaEstoque > temEstoque)
                                    {
                                        MessageBox.Show("Estoque insuficiente!", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtCodProduto.Text = string.Empty; txtQdade.Text = "1"; return;
                                    }
                                }
                            }
                            else if (listaEstoque.Count == 0 && !txtCodProduto.Text.Equals("9999999999999"))
                            {
                                MessageBox.Show("Produto sem estoque!", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCodProduto.Text = string.Empty; return;
                            }

                            #endregion

                            #region Popula txtboxs

                            txtCodProduto.Text = produto.idProduto.ToString();
                            txtDescricao.Text = produto.descricaoProduto.ToString();
                            txtMarca.Text = produto.marcaProduto.ToString();

                            #endregion

                            #region Validação de imagem

                            if (!string.IsNullOrEmpty(produto.caminhoFotoProduto)) { picProduto.Load("ProdutoFotos\\" + produto.caminhoFotoProduto); }
                            else { picProduto.Load("ProdutoFotos\\Erro.png"); };

                            #endregion

                            #region Trata produto específico (Produto 9999999999999, espera valor)

                            //TODO: Fazer com que o codProduto seja dinamico nos produtos diversos ou constante bloqueado padrão
                            bool Valida = true;

                            if (txtCodProduto.Text.Equals("9999999999999"))
                            {
                                while (Valida)
                                {
                                    var valUnit = Interaction.InputBox("Informe o Valor Unitário", "Valor Unitário", "");

                                    if (valUnit.Equals(""))
                                    {
                                        Valida = false;
                                        break;
                                    }
                                    else
                                    {
                                        try
                                        {
                                            txtValorUnit.Text = String.Format("{0:C}", Convert.ToDecimal(valUnit));
                                            produto.vendaProduto = Convert.ToDecimal(valUnit);
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Valor informado não é válido!", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                            }
                            else { txtValorUnit.Text = String.Format("{0:C}", produto.vendaProduto); }

                            #endregion

                            #region Após Validação e insere o registro

                            if (Valida)
                            {
                                #region Inserção Obrigatória

                                //Insere Recibo
                                this.insereRecibo(produto);

                                //Calcula o total
                                this.calculaTotal();

                                //Inicia novamente o novo registro
                                txtCodProduto.Focus(); txtCodProduto.SelectAll();
                                txtQdade.Text = "1";

                                #endregion
                            }

                            #endregion

                        }
                        else
                        {
                            lblVisor.Text = "Produto não encontrado!";
                            txtCodProduto.Text = string.Empty;
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("Método: txtCodProduto_TextChanged Erro:{0}", ex.Message));
                    }
                }

                #endregion
            }
        }

        /// <summary>
        /// Método responsável por inserir as informações do recibo na datagridView
        /// </summary>
        /// <param name="produto">Objeto que contém as informáções do produto</param>
        private void insereRecibo(Models.ProdutoModel produto)
        {
            dgvRecibo.AllowUserToAddRows = true;
            DataGridViewRow row = (DataGridViewRow)dgvRecibo.Rows[0].Clone();

            row.Cells[0].Value = produto.idProduto;
            row.Cells[1].Value = produto.descricaoProduto;
            row.Cells[2].Value = String.Format("{0:C}", (decimal)produto.vendaProduto);
            row.Cells[3].Value = txtQdade.Text;
            row.Cells[4].Value = String.Format("{0:C}", (decimal)Convert.ToInt32(txtQdade.Text) * (decimal)produto.vendaProduto);
            row.Cells[5].Value = String.Format("{0:C}", (decimal)produto.custoProduto);

            dgvRecibo.Rows.Add(row);
            dgvRecibo.AllowUserToAddRows = false;

            //Visor
            lblVisor.Text = lblVisor.Text + (decimal)produto.vendaProduto + " = " + row.Cells[4].Value.ToString();
        }

        /// <summary>
        /// Método responsável por Calcular o valor total
        /// </summary>
        private void calculaTotal()
        {
            //Insere o sub-total
            txtSubTotal.Text = String.Format("{0:C}", (decimal)dgvRecibo.Rows.OfType<DataGridViewRow>()
                .Sum(row => decimal.Parse(
                    row.Cells[4].Value.ToString(), NumberStyles.Currency)));

            //Insere o Total da Venda
            decimal TotalPagar = (decimal.Parse(txtSubTotal.Text, NumberStyles.Currency)
                            + decimal.Parse(txtAcrescimo.Text, NumberStyles.Currency))
                            - decimal.Parse(txtDesconto.Text, NumberStyles.Currency);

            lblTotalPagar.Text = String.Format("{0:C}", TotalPagar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Recibo"></param>
        private void TransacaoEstoque(Models.ReciboModel Recibo)
        {
            Models.EstoqueModel estoque = new Models.EstoqueModel();

            estoque = estoqueController.BuscarEstoque(Convert.ToInt64(Recibo.idProdutoRecibo));

            estoque.entradaEstoque = estoque.atualEstoque;
            estoque.saidaEstoque = Recibo.qdadeProdutoRecibo; //Menos Qtdade estoque
            estoque.atualEstoque = estoque.entradaEstoque - estoque.saidaEstoque;
            estoque.situacaoEstoque = Convert.ToInt32(estoque.atualEstoque) < 3 ? "S" : "N";
            estoque.dataUltMovimentacaoEstoque = DateTime.Now;

            estoqueController.AtualizarEstoque(estoque);

            //using (Identidade.Estoque atualizaEstoque = new Identidade.Estoque())
            //{
            //    atualizaEstoque.CadastrarEstoqueHistorico(estoque);
            //}
        }

        #region Eventos

        /// <summary>
        /// Evento responsável por excluir o registro solicitado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void dgvRecibo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            System.Windows.Forms.DialogResult decisao = MessageBox.Show("Confirma Exclusão?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (decisao.Equals(System.Windows.Forms.DialogResult.Yes))
            {
                //Seleciona o registro solicitado e remove do datagridView
                dgvRecibo.Rows.RemoveAt(dgvRecibo.SelectedRows[0].Index);

                //Re-calcular os valores e setar
                calculaTotal();

                //Inicia novamente o novo registro
                txtCodProduto.Focus(); txtCodProduto.SelectAll();

                //limpar o visor
                lblVisor.Text = string.Empty;
            }
        }

        /// <summary>
        /// Evento responsável por salvar as informações no banco de dados, quando confirmado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvRecibo.RowCount == 0) { MessageBox.Show("Não há registros para finalizar a venda!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            // Valida Troco antes de realizar o tramite
            decimal Troco = decimal.Parse(txtValorRecebido.Text, NumberStyles.Currency)
                            - decimal.Parse(lblTotalPagar.Text, NumberStyles.Currency);

            if (Troco < 0)
            {
                MessageBox.Show("Valor recebido inferior ao valor total!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorRecebido.Focus();
                txtValorRecebido.SelectAll();
            }
            else
            {
                lblTroco.Text = String.Format("{0:C}", Troco);

                System.Windows.Forms.DialogResult decisao = MessageBox.Show("Confirma Pagamento?", "Pagamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (decisao.Equals(System.Windows.Forms.DialogResult.Yes))
                {
                    #region Transação na tabela de venda

                    #region Popula Identidade Vendas para gravar no banco
                    Models.VendaModel Vendas = new Models.VendaModel();

                    Vendas.idVenda = Convert.ToInt32(lblCodVenda.Text);
                    Vendas.valorRecebidoVenda = decimal.Parse(txtValorRecebido.Text, NumberStyles.Currency);
                    Vendas.descontoVenda = decimal.Parse(txtDesconto.Text, NumberStyles.Currency);
                    Vendas.acrescimoVenda = decimal.Parse(txtAcrescimo.Text, NumberStyles.Currency);
                    Vendas.totalVenda = decimal.Parse(lblTotalPagar.Text, NumberStyles.Currency);
                    Vendas.trocoVenda = decimal.Parse(lblTroco.Text, NumberStyles.Currency);
                    Vendas.dataVenda = Convert.ToDateTime(lblDataVenda.Text);
                    Vendas.formaPgtoVenda.idFormaPgto = Convert.ToInt32(cmbFormaPgto.SelectedItem);

                    for (int i = 0; i < dgvRecibo.RowCount; i++)
                    {
                        Models.ReciboModel recibo = new Models.ReciboModel();

                        recibo.idProdutoRecibo = dgvRecibo.Rows[i].Cells[0].Value.ToString();
                        recibo.produtoRecibo.descricaoProduto = dgvRecibo.Rows[i].Cells[1].Value.ToString();
                        recibo.idVendaRecibo = Convert.ToInt32(lblCodVenda.Text);
                        recibo.qdadeProdutoRecibo = Convert.ToInt32(dgvRecibo.Rows[i].Cells[3].Value);
                        recibo.VendaProdutoRecibo = decimal.Parse(dgvRecibo.Rows[i].Cells[2].Value.ToString(), NumberStyles.Currency);
                        recibo.CustoProdutoRecibo = decimal.Parse(dgvRecibo.Rows[i].Cells[5].Value.ToString(), NumberStyles.Currency);
                        recibo.dataRecibo = DateTime.Now;

                        Vendas.Recibo.Add(recibo);
                    }

                    #endregion

                    Vendas.Retorno = vendaController.CadastrarVenda(Vendas);

                    if (!Vendas.Retorno.Situacao)
                    {
                        MessageBox.Show("Transação não concluída, por favor tente novamente!", "Transação não concluída", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        #region transação na tabela de recibo

                        foreach (var recibo in Vendas.Recibo)
                        {
                            reciboController.CadastrarRecibo(recibo);
                            this.TransacaoEstoque(recibo);
                        }

                        #endregion
                    }
                    #endregion

                    this.inicializaForm();
                }
                else
                {
                    txtValorRecebido.SelectAll();
                }
            }
        }

        /// <summary>
        /// Evento responsável pelo cancelamento da venda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult decisao = MessageBox.Show("Confirma Cancelamento?", "Cancelar Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (decisao.Equals(System.Windows.Forms.DialogResult.Yes))
            {
                this.inicializaForm();
            }
        }

        private void Vendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                System.Windows.Forms.DialogResult decisao;

                decisao = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (decisao.Equals(System.Windows.Forms.DialogResult.Yes))
                {
                    this.Close();
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (txtCodProduto.Text.Equals("9999999999999") && txtCodProduto.TextLength.Equals(1) && !dgvRecibo.Focused)
                {
                    ExecutaFuncoesPrincipais();
                }

                if (dgvRecibo.Focused)
                {
                    dgvRecibo_RowHeaderMouseClick(null, null);
                }

                if (txtQdade.Focused)
                {
                    txtCodProduto.Focus();
                }
            }

            if (e.KeyCode == Keys.Delete)
            {
                #region Cursor

                Cursor.Show();

                #endregion

                btnCancelar_Click(null, null);
            }

            if (e.KeyCode == Keys.F12)
            {
                Match match = Regex.Match(txtValorRecebido.Text, exNumeros);

                if (!match.Success || string.Empty.Equals(txtValorRecebido.Text))
                {
                    MessageBox.Show("Valor inválido!", "Atenção - Valor recebido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtValorRecebido.Focus();
                    txtValorRecebido.SelectAll();
                }
                else
                {
                    #region Realiza a venda

                    btnConfirmar_Click(null, null);

                    #endregion
                }
            }

            if (e.KeyCode == Keys.F10)
            {
                if (dgvRecibo.Rows.Count != 0)
                {
                    txtDesconto.Focus();
                }
            }

            if (e.KeyCode == Keys.F8)
            {
                txtCodProduto.Text = string.Empty;

                txtQdade.Enabled = true;
                txtQdade.SelectAll();
                txtQdade.Focus();
            }

            if (e.KeyCode == Keys.F2)
            {
                if (dgvRecibo.Rows.Count != 0)
                {
                    lblVisor.Text = "Excluindo um item...";
                    dgvRecibo.Focus();
                }
            }

            if (e.KeyCode == Keys.F1)
            {
                Include.frmIncProduto frmProduto = new Include.frmIncProduto();
                frmProduto.Show();
            }
        }

        private void Vendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            #region Cursor
            Cursor.Show();
            #endregion
        }

        private void Vendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region Cursor
            Cursor.Show();
            #endregion
        }

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAcrescimo.Focus();
            }
        }

        /// <summary>
        /// Evento responsável por tratar a entrada do item txtDesconto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            lblVisor.Text = "Calculando o Total.";
        }

        /// <summary>
        /// Evento responsável por tratar  a saída do item txtDesconto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            Match match = Regex.Match(txtDesconto.Text, exNumeros);

            if (!match.Success)
            {
                MessageBox.Show("Valor inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDesconto.SelectAll();
                txtDesconto.Focus();
            }
            else
            {
                decimal valorReal;

                if (!string.IsNullOrEmpty(txtDesconto.Text))
                {
                    valorReal = Convert.ToDecimal(txtDesconto.Text);
                    txtDesconto.Text = String.Format("{0:C}", valorReal);
                }
                else
                {
                    valorReal = 0m;
                    txtDesconto.Text = String.Format("{0:C}", valorReal);
                }

                calculaTotal();
            }
        }

        private void txtAcrescimo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbFormaPgto.Focus();
            }
        }

        /// <summary>
        /// Evento responsável por tratar  a saída do item txtAcrescimo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtAcrescimo_Leave(object sender, EventArgs e)
        {
            Match match = Regex.Match(txtAcrescimo.Text, exNumeros);

            if (!match.Success)
            {
                MessageBox.Show("Valor inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAcrescimo.SelectAll();
                txtAcrescimo.Focus();
            }
            else
            {
                decimal valorReal;

                if (!string.IsNullOrEmpty(txtAcrescimo.Text))
                {
                    valorReal = Convert.ToDecimal(txtAcrescimo.Text);
                    txtAcrescimo.Text = String.Format("{0:C}", valorReal);
                }
                else
                {
                    valorReal = 0m;
                    txtAcrescimo.Text = String.Format("{0:C}", valorReal);
                }

                calculaTotal();
            }
        }

        private void cmbFormaPgto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValorRecebido.Focus();
            }
        }

        private void txtCodProduto_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    string entrada = txtCodProduto.Text;
            //    txtCodProduto.Text = "";
            //} 
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            //lblCaixaLivre.Visible = false;
            //lblVisor.Text = txtQdade.Text + " x ";

        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
           if (txtCodProduto.TextLength.Equals(13) || txtCodProduto.Text.Equals("9999999999999"))
            {
                ExecutaFuncoesPrincipais();
            }
        }

        /// <summary>
        /// Evento responsável por tratar a entrada do item txtValorRecebido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtValorRecebido_Enter(object sender, EventArgs e)
        {
            lblVisor.Text = "Calculando o Troco.";
        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento responsável por tratar a saída do item txtValorRecebido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtValorRecebido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTotalPagar.Text))
            {
                return;
            }

            Match match = Regex.Match(txtValorRecebido.Text, exNumeros);

            if (!match.Success)
            {
                MessageBox.Show("Valor inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDesconto.SelectAll();
                txtDesconto.Focus();
            }
            else
            {
                decimal valorReal;

                if (!string.IsNullOrEmpty(txtValorRecebido.Text))
                {
                    valorReal = decimal.Parse(txtValorRecebido.Text, NumberStyles.Currency);
                    txtValorRecebido.Text = String.Format("{0:C}", valorReal);
                }
                else
                {
                    valorReal = 0m;
                    txtValorRecebido.Text = String.Format("{0:C}", valorReal);
                }

                try
                {
                    decimal Troco = decimal.Parse(txtValorRecebido.Text, NumberStyles.Currency)
                                - decimal.Parse(lblTotalPagar.Text, NumberStyles.Currency);

                    if (Troco < 0)
                    {
                        MessageBox.Show("Valor recebido inferior ao valor total!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtValorRecebido.Focus();
                    }
                    else
                    {
                        lblTroco.Text = String.Format("{0:C}", Troco);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    throw;
                }
            }
        }

        /// <summary>
        /// Evento responsável por tratar  a saída do item txtQdade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtQdade_Leave(object sender, EventArgs e)
        {
            txtQdade.Text = string.IsNullOrEmpty(txtQdade.Text) ? "1" : txtQdade.Text;

            lblCaixaLivre.Visible = false;
            lblVisor.Text = txtQdade.Text + " x ";

            txtQdade.Enabled = false;
        }

        /// <summary>
        /// Evento responsável por tratar a entrada do item txtQdade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Evento</param>
        private void txtQdade_Enter(object sender, EventArgs e)
        {
            txtQdade.Text = string.Empty;
        }
        #endregion
    }
}
