namespace SistemaVendas.ReportViewer.FormsRdlc
{
    partial class relVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpViewVendas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.VendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VendasBindingSource
            // 
            this.VendasBindingSource.DataMember = "Vendas";
            // 
            // rpViewVendas
            // 
            this.rpViewVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpViewVendas.DocumentMapWidth = 1;
            reportDataSource1.Name = "DataSetVendas";
            reportDataSource1.Value = this.VendasBindingSource;
            this.rpViewVendas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpViewVendas.LocalReport.ReportEmbeddedResource = "SistemaVendas.ReportViewer.Rdlc.Vendas.rdlc";
            this.rpViewVendas.Location = new System.Drawing.Point(0, 0);
            this.rpViewVendas.Name = "rpViewVendas";
            this.rpViewVendas.ServerReport.BearerToken = null;
            this.rpViewVendas.Size = new System.Drawing.Size(800, 450);
            this.rpViewVendas.TabIndex = 0;
            this.rpViewVendas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rpViewVendas_KeyDown);
            // 
            // relVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpViewVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "relVendas";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.relVendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.relVendas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.VendasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpViewVendas;
        private System.Windows.Forms.BindingSource VendasBindingSource;
    }
}