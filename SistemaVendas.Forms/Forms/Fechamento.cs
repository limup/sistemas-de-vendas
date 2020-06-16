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
    public partial class Fechamento : Form
    {
        private Controllers.Controller.GerenciamentoController gerenciamentoController;
        private Controllers.Controller.VendaController vendaController;

        public Fechamento()
        {
            InitializeComponent();
        }

        private void Fechamento_Load(object sender, EventArgs e)
        {
            gerenciamentoController = new Controllers.Controller.GerenciamentoController();
            vendaController = new Controllers.Controller.VendaController();

            lblData.Text = DateTime.Now.ToShortDateString();
            decimal total = new decimal();

            string Where1 = string.Format(" WHERE ger_data between #" + Convert.ToDateTime(lblData.Text).ToString("MM/dd/yyyy") + " 00:00:00# and #"
                                                                     + Convert.ToDateTime(lblData.Text).ToString("MM/dd/yyyy") + " 23:59:59#");

            string Where2 = string.Format(" WHERE dataVenda between #" + Convert.ToDateTime(lblData.Text).ToString("MM/dd/yyyy") + " 00:00:00# and #"
                                                                     + Convert.ToDateTime(lblData.Text).ToString("MM/dd/yyyy") + " 23:59:59#");

            var gerenciamentoEspelho = gerenciamentoController
                .ListarGerenciamentos()
                .Where(x => x.dataGerenciamento >= Convert.ToDateTime(lblData.Text + " 00:00:00") && x.dataGerenciamento <= Convert.ToDateTime(lblData.Text + " 23:59:59"))
                .ToList();

            if (gerenciamentoEspelho.Count != 0)
            {
                lblEntrada.Text = String.Format("{0:C}", gerenciamentoEspelho.Sum(row => row.elementoGerenciamento.Equals("Entrada") ? row.valorGerenciamento : 0));
                lblRetirada.Text = String.Format("{0:C}", gerenciamentoEspelho.Sum(row => row.elementoGerenciamento.Equals("Retirada") ? row.valorGerenciamento : 0));

                total += gerenciamentoEspelho.Sum(row => row.elementoGerenciamento.Equals("Entrada") ? row.valorGerenciamento : 0);
                total -= gerenciamentoEspelho.Sum(row => row.elementoGerenciamento.Equals("Retirada") ? row.valorGerenciamento : 0);
            }
            else
            {
                lblEntrada.Text = "Sem registro";
                lblRetirada.Text = "Sem registro";
                lblTotal.Text = "Sem registro";
            }

            var vendasEspelho = vendaController
               .ListarVendas()
               .Where(x => x.dataVenda >= Convert.ToDateTime(lblData.Text + " 00:00:00") && x.dataVenda <= Convert.ToDateTime(lblData.Text + " 23:59:59"))
               .ToList();


            if (vendasEspelho.Count != 0)
            {
                lblVendas.Text = String.Format("{0:C}", vendasEspelho.Sum(row => row.totalVenda));

                total += vendasEspelho.Sum(row => row.totalVenda);
            }
            else
            {
                lblVendas.Text = "Sem registro";
            }

            lblTotal.Text = String.Format("{0:C}", total);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
