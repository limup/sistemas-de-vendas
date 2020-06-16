using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.Forms.Forms
{
    public partial class Gerenciamento : Form
    {
        private Controllers.Controller.GerenciamentoController gerenciamentoController;

        /// <summary>
        /// Variável responsável por identificar a solicitação do usuário
        /// Caso 3 - Entrada
        /// Caso 4 - Retirada
        /// </summary>
        private string Solicitacao = string.Empty;

        public Gerenciamento(int Solicitacao)
        {
            InitializeComponent();

            switch (Solicitacao)
            {
                case 3:
                    this.Solicitacao = ((Models.SolicitacaoForm)Convert.ToInt32(Solicitacao.ToString())).ToString();
                    break;
                case 4:
                    this.Solicitacao = ((Models.SolicitacaoForm)Convert.ToInt32(Solicitacao.ToString())).ToString();
                    break;
            }
        }

        private void Gerenciamento_Load(object sender, EventArgs e)
        {
            gerenciamentoController = new Controllers.Controller.GerenciamentoController();

            this.inicializaForm();
        }

        private void inicializaForm()
        {
            lblData.Text = DateTime.Now.ToShortDateString();
            lblElemento.Text = Solicitacao;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            #region Popula Gerenciamento

            Models.GerenciamentoModel gerenciamento = new Models.GerenciamentoModel()
            {

                dataGerenciamento = Convert.ToDateTime(lblData.Text),
                elementoGerenciamento = this.Solicitacao,
                valorGerenciamento = Convert.ToDecimal(txtValor.Text),
                vendedorGerenciamento = lblVendedor.Text,
                motivoGerenciamento = txtMotivo.Text
            };

            #endregion

            gerenciamento.Retorno = gerenciamentoController.CadastrarGerenciamento(gerenciamento);

            if (gerenciamento.Retorno.Situacao)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao salvar! /n Erro: " + gerenciamento.Retorno.Erro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

