using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.Forms.Forms.Include
{
    public partial class frmIncProduto : Form
    {
        private Controllers.Controller.ProdutoController produtoController;

        /// <summary>
        /// Expressão regular para validação somente números
        /// </summary>
        private const string exNumeros = @"^\d+$"; //Expressão para validar Numeros

        public frmIncProduto()
        {
            produtoController = new Controllers.Controller.ProdutoController();

            InitializeComponent();
        }

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
                #region Valida se o código já existe
                this.pesquisaProduto();
                #endregion
            }
        }

        /// <summary>
        /// Método responsável por pesquisar o produto solicitado
        /// </summary>
        private void pesquisaProduto()
        {
            string Where = string.Empty;

            #region Tratamento Filtro Dinâmico

            List<KeyValuePair<string, string>> listaOpcoes = new List<KeyValuePair<string, string>>();
            listaOpcoes.Add(new KeyValuePair<string, string>("idProduto", txtCodProduto.Text));

            IEnumerable<KeyValuePair<string, string>> trataAnd;
            trataAnd = listaOpcoes.Where(x => !string.IsNullOrEmpty(x.Value));

            #endregion

            var produtoEspelho = produtoController
                .ListarProdutos()
                .Where(x => x.idProduto.Contains(txtCodProduto.Text))
                .ToList();

            if (produtoEspelho.Count != 0)
            {
                foreach (var rowProduto in produtoEspelho)
                {
                    lblValor.Text = String.Format("{0:C}", (decimal)rowProduto.vendaProduto);

                    //Valida se tem imagem
                    if (!string.IsNullOrEmpty(rowProduto.caminhoFotoProduto))
                    {
                        picProduto.Load("ProdutoFotos\\" + rowProduto.caminhoFotoProduto);
                    }
                    else { picProduto.Load("ProdutoFotos\\Erro.png"); };
                }
            }
        }

        private void txtCodProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
