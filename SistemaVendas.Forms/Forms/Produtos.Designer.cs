namespace SistemaVendas.Forms.Forms
{
    partial class Produtos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picProdutoCaminho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.carregaImagemSalvar = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtPrecoVenda);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPrecoCusto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtCodProduto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPorcentagem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(508, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 129);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Análise";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(185, 24);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(29, 15);
            this.lblPorcentagem.TabIndex = 22;
            this.lblPorcentagem.Text = "%%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Porcentagem sobre o P. Custo";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(413, 71);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(89, 24);
            this.txtPrecoVenda.TabIndex = 4;
            this.txtPrecoVenda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPrecoVenda_MouseClick);
            this.txtPrecoVenda.Enter += new System.EventHandler(this.txtPrecoVenda_Enter);
            this.txtPrecoVenda.Leave += new System.EventHandler(this.txtPrecoVenda_Leave);
            this.txtPrecoVenda.MouseEnter += new System.EventHandler(this.txtPrecoVenda_MouseEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Preço Venda";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Location = new System.Drawing.Point(413, 29);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(89, 24);
            this.txtPrecoCusto.TabIndex = 3;
            this.txtPrecoCusto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPrecoCusto_MouseClick);
            this.txtPrecoCusto.Enter += new System.EventHandler(this.txtPrecoCusto_Enter);
            this.txtPrecoCusto.Leave += new System.EventHandler(this.txtPrecoCusto_Leave);
            this.txtPrecoCusto.MouseEnter += new System.EventHandler(this.txtPrecoCusto_MouseEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Preço Custo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(131, 71);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(169, 24);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(131, 111);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(371, 24);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(131, 31);
            this.txtCodProduto.MaxLength = 13;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(169, 24);
            this.txtCodProduto.TabIndex = 0;
            this.txtCodProduto.TextChanged += new System.EventHandler(this.txtCodProduto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código Produto";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Marca,
            this.Descricao,
            this.PCusto,
            this.PVenda,
            this.DataCadastro,
            this.picProdutoCaminho});
            this.dgvProduto.Location = new System.Drawing.Point(12, 163);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProduto.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(911, 211);
            this.dgvProduto.TabIndex = 1;
            this.dgvProduto.TabStop = false;
            this.dgvProduto.SelectionChanged += new System.EventHandler(this.dgvProduto_SelectionChanged);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.MinimumWidth = 150;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 150;
            // 
            // PCusto
            // 
            this.PCusto.HeaderText = "Preço de Custo";
            this.PCusto.Name = "PCusto";
            this.PCusto.ReadOnly = true;
            this.PCusto.Width = 150;
            // 
            // PVenda
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PVenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.PVenda.HeaderText = "Preço de Venda";
            this.PVenda.Name = "PVenda";
            this.PVenda.ReadOnly = true;
            this.PVenda.Width = 150;
            // 
            // DataCadastro
            // 
            this.DataCadastro.HeaderText = "Data de Cadastro";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.ReadOnly = true;
            this.DataCadastro.Width = 150;
            // 
            // picProdutoCaminho
            // 
            this.picProdutoCaminho.HeaderText = "Imagem";
            this.picProdutoCaminho.Name = "picProdutoCaminho";
            this.picProdutoCaminho.ReadOnly = true;
            this.picProdutoCaminho.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(623, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 34);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Limpar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(776, 380);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(147, 34);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(776, 380);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(147, 34);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // picProduto
            // 
            this.picProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProduto.Location = new System.Drawing.Point(782, 22);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(141, 135);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduto.TabIndex = 20;
            this.picProduto.TabStop = false;
            this.picProduto.Click += new System.EventHandler(this.picProduto_Click);
            // 
            // carregaImagemSalvar
            // 
            this.carregaImagemSalvar.FileName = "openFileDialog1";
            this.carregaImagemSalvar.Title = "Selecionar Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Produto";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(935, 426);
            this.Controls.Add(this.picProduto);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnEditar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog carregaImagemSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn picProdutoCaminho;
        private System.Windows.Forms.Label label2;
    }
}