using SistemaVendas.Controllers.Controller;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.Forms.Forms
{
    public partial class Login : Form
    {
        /// <summary>
        /// Variável responsável por identificar a solicitação do sistema
        /// Caso 3 - Entrada
        /// Caso 6 - Autenticar usuário
        /// </summary>
        private Models.SolicitacaoForm Solicitacao;

        private int IdCargo;

        public Login(Models.SolicitacaoForm solicitacao)
        {
            InitializeComponent();

            Solicitacao = solicitacao;

            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
            txtSenha.MaxLength = 14;

            Global.Global.usuariomodel = new UsuarioModel();
            Global.Global.usuariocontroller = new UsuarioController();

            Global.Global.funcionariomodel = new FuncionarioModel();
            Global.Global.funcionariocontroller = new FuncionarioController();

        }

        public Login(Models.SolicitacaoForm solicitacao, int idcargo)
        {
            InitializeComponent();

            Solicitacao = solicitacao;
            IdCargo = idcargo;

            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
            txtSenha.MaxLength = 14;

        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            if (Global.Global.usuariocontroller.ValidarAcesso(Convert.ToInt32(txtCpf.Text), txtSenha.Text) &&
                Solicitacao.Equals(Models.SolicitacaoForm.Entrada))
            {
                Principal Principal = new Principal(Convert.ToInt32(txtCpf.Text));
                Principal.Show();

                this.Visible = false;
            }
            else if ((Global.Global.usuariocontroller.ValidarAcesso(Convert.ToInt32(txtCpf.Text), txtSenha.Text, IdCargo) &&
                Solicitacao.Equals(Models.SolicitacaoForm.Autenticar)))
            {
                Forms.Vendas MovimentaVendas = new Forms.Vendas(Convert.ToInt32(txtCpf.Text));
                MovimentaVendas.Show();

                this.Visible = false;
            }
            else
            {
                lblErro.Text = "Problema na autenticação.";
                txtCpf.Focus();
            }
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            txtCpf.SelectAll();
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.SelectAll();
        }

        private void txtSenha_Validated(object sender, EventArgs e)
        {
            btnAcesso_Click(null, null);
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
