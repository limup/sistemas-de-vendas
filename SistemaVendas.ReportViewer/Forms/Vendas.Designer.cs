namespace SistemaVendas.ReportViewer.Forms
{
    partial class Vendas
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
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.produtoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.txtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVendedoras = new System.Windows.Forms.ComboBox();
            this.funcionarioModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gpbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbFiltro.Controls.Add(this.label4);
            this.gpbFiltro.Controls.Add(this.cmbProdutos);
            this.gpbFiltro.Controls.Add(this.label2);
            this.gpbFiltro.Controls.Add(this.txtDataFinal);
            this.gpbFiltro.Controls.Add(this.txtDataInicial);
            this.gpbFiltro.Controls.Add(this.label1);
            this.gpbFiltro.Controls.Add(this.label3);
            this.gpbFiltro.Controls.Add(this.cmbVendedoras);
            this.gpbFiltro.Controls.Add(this.btnPesquisar);
            this.gpbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(418, 125);
            this.gpbFiltro.TabIndex = 1;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Produtos";
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.DataSource = this.produtoModelBindingSource;
            this.cmbProdutos.DisplayMember = "descricaoProduto";
            this.cmbProdutos.Location = new System.Drawing.Point(6, 93);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(150, 24);
            this.cmbProdutos.TabIndex = 8;
            this.cmbProdutos.ValueMember = "idProduto";
            // 
            // produtoModelBindingSource
            // 
            this.produtoModelBindingSource.DataSource = typeof(SistemaVendas.Models.ProdutoModel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "à";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.CustomFormat = "dd-MM-yyyy";
            this.txtDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataFinal.Location = new System.Drawing.Point(309, 45);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(102, 22);
            this.txtDataFinal.TabIndex = 2;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.CustomFormat = "dd-MM-yyyy";
            this.txtDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataInicial.Location = new System.Drawing.Point(181, 45);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(103, 22);
            this.txtDataInicial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Período";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vendedora";
            // 
            // cmbVendedoras
            // 
            this.cmbVendedoras.DataSource = this.funcionarioModelBindingSource;
            this.cmbVendedoras.DisplayMember = "nomeFuncionario";
            this.cmbVendedoras.Location = new System.Drawing.Point(6, 43);
            this.cmbVendedoras.Name = "cmbVendedoras";
            this.cmbVendedoras.Size = new System.Drawing.Size(150, 24);
            this.cmbVendedoras.TabIndex = 5;
            this.cmbVendedoras.ValueMember = "idCargoFuncionario";
            // 
            // funcionarioModelBindingSource
            // 
            this.funcionarioModelBindingSource.DataSource = typeof(SistemaVendas.Models.FuncionarioModel);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(320, 90);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 27);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Emitir";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 149);
            this.Controls.Add(this.gpbFiltro);
            this.MaximizeBox = false;
            this.Name = "Vendas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDataInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVendedoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource funcionarioModelBindingSource;
        private System.Windows.Forms.BindingSource produtoModelBindingSource;
    }
}