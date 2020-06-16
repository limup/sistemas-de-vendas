namespace SistemaVendas.ReportViewer.Forms
{
    partial class Estoque
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
            this.EstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpViewEstoque = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueBindingSource)).BeginInit();
            this.gpbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstoqueBindingSource
            // 
            this.EstoqueBindingSource.DataSource = typeof(SistemaVendas.Models.EstoqueModel);
            // 
            // rpViewEstoque
            // 
            this.rpViewEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpViewEstoque.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EstoqueBindingSource;
            this.rpViewEstoque.LocalReport.DataSources.Add(reportDataSource1);
            this.rpViewEstoque.LocalReport.ReportEmbeddedResource = "SistemaVendas.ReportViewer.Rdlc.Estoque.rdlc";
            this.rpViewEstoque.Location = new System.Drawing.Point(0, 91);
            this.rpViewEstoque.Name = "rpViewEstoque";
            this.rpViewEstoque.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.rpViewEstoque.ServerReport.BearerToken = null;
            this.rpViewEstoque.Size = new System.Drawing.Size(823, 171);
            this.rpViewEstoque.TabIndex = 0;
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbFiltro.Controls.Add(this.label3);
            this.gpbFiltro.Controls.Add(this.btnPesquisar);
            this.gpbFiltro.Controls.Add(this.label2);
            this.gpbFiltro.Controls.Add(this.txtDataFinal);
            this.gpbFiltro.Controls.Add(this.label1);
            this.gpbFiltro.Controls.Add(this.txtDataInicial);
            this.gpbFiltro.Controls.Add(this.cmbProduto);
            this.gpbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFiltro.Location = new System.Drawing.Point(0, 12);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(823, 73);
            this.gpbFiltro.TabIndex = 2;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Classificar Por:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(626, 40);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 27);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Gerar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(218, 44);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(200, 22);
            this.txtDataFinal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Início";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Location = new System.Drawing.Point(12, 44);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(200, 22);
            this.txtDataInicial.TabIndex = 0;
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(424, 42);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(196, 24);
            this.cmbProduto.TabIndex = 7;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 262);
            this.Controls.Add(this.gpbFiltro);
            this.Controls.Add(this.rpViewEstoque);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueBindingSource)).EndInit();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpViewEstoque;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDataInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.BindingSource EstoqueBindingSource;
    }
}