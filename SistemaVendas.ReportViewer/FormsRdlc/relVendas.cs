using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.ReportViewer.FormsRdlc
{
    public partial class relVendas : Form
    {
        private List<Models.Relatorios.Vendas> relatorio;
        List<Microsoft.Reporting.WinForms.ReportParameter> parametros;

        public relVendas(List<Models.Relatorios.Vendas> Relatorio, List<Microsoft.Reporting.WinForms.ReportParameter> Parametros)
        {
            relatorio = Relatorio;
            parametros = Parametros;

            InitializeComponent();
        }

        private void relVendas_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void ConfigReport()
        {
            #region Configurando a característica do relatório

            //this.rpViewVendas.ShowZoomControl = false;
            //this.rpViewVendas.BackgroundImageLayout = ImageLayout.Center;
            this.rpViewVendas.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rpViewVendas.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.rpViewVendas.LocalReport.SetParameters(parametros);

            #endregion
        }

        private void relVendas_Load(object sender, EventArgs e)
        {
            VendasBindingSource.DataSource = relatorio;

            this.ConfigReport();
            this.rpViewVendas.RefreshReport();
        }

        private void rpViewVendas_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
