namespace SistemaVendas.Forms.Forms
{
    partial class frmEstoque
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
            this.lblUltimaMov = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSituacaoEstoque = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstoqueAtual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaidaProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEntradaProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMovimentaEstoque = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtPrecoVenda);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPrecoCusto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtCodProduto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtEstoqueAtual);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSaidaProduto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEntradaProduto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 141);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do produto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUltimaMov);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblSituacaoEstoque);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblPorcentagem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(655, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 121);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Análise";
            // 
            // lblUltimaMov
            // 
            this.lblUltimaMov.AutoSize = true;
            this.lblUltimaMov.Location = new System.Drawing.Point(131, 73);
            this.lblUltimaMov.Name = "lblUltimaMov";
            this.lblUltimaMov.Size = new System.Drawing.Size(33, 15);
            this.lblUltimaMov.TabIndex = 26;
            this.lblUltimaMov.Text = "Data";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "Ultima Movimentação:";
            // 
            // lblSituacaoEstoque
            // 
            this.lblSituacaoEstoque.AutoSize = true;
            this.lblSituacaoEstoque.Location = new System.Drawing.Point(172, 48);
            this.lblSituacaoEstoque.Name = "lblSituacaoEstoque";
            this.lblSituacaoEstoque.Size = new System.Drawing.Size(30, 15);
            this.lblSituacaoEstoque.TabIndex = 24;
            this.lblSituacaoEstoque.Text = "Não";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Estoque em situação crítica:";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(120, 24);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(81, 15);
            this.lblPorcentagem.TabIndex = 22;
            this.lblPorcentagem.Text = "Porcentagem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Margem de Lucro:";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Enabled = false;
            this.txtPrecoVenda.Location = new System.Drawing.Point(413, 71);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(89, 24);
            this.txtPrecoVenda.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Preço Venda";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Enabled = false;
            this.txtPrecoCusto.Location = new System.Drawing.Point(413, 31);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(89, 24);
            this.txtPrecoCusto.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 36;
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
            this.txtDescricao.Size = new System.Drawing.Size(329, 24);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(131, 31);
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
            this.label3.TabIndex = 32;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Código Produto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Descrição";
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.Enabled = false;
            this.txtEstoqueAtual.Location = new System.Drawing.Point(580, 111);
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.Size = new System.Drawing.Size(69, 24);
            this.txtEstoqueAtual.TabIndex = 7;
            this.txtEstoqueAtual.TextChanged += new System.EventHandler(this.txtEstoqueAtual_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estoque atual";
            // 
            // txtSaidaProduto
            // 
            this.txtSaidaProduto.Enabled = false;
            this.txtSaidaProduto.Location = new System.Drawing.Point(580, 73);
            this.txtSaidaProduto.Name = "txtSaidaProduto";
            this.txtSaidaProduto.Size = new System.Drawing.Size(69, 24);
            this.txtSaidaProduto.TabIndex = 6;
            this.txtSaidaProduto.TextChanged += new System.EventHandler(this.txtSaidaProduto_TextChanged);
            this.txtSaidaProduto.Enter += new System.EventHandler(this.txtSaidaProduto_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(524, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Saída";
            // 
            // txtEntradaProduto
            // 
            this.txtEntradaProduto.Enabled = false;
            this.txtEntradaProduto.Location = new System.Drawing.Point(580, 31);
            this.txtEntradaProduto.Name = "txtEntradaProduto";
            this.txtEntradaProduto.Size = new System.Drawing.Size(69, 24);
            this.txtEntradaProduto.TabIndex = 5;
            this.txtEntradaProduto.TextChanged += new System.EventHandler(this.txtEntradaProduto_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Entrada";
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.MarcaProduto,
            this.PCusto,
            this.PVenda,
            this.Data,
            this.descProduto,
            this.Entrada,
            this.Saida,
            this.EstoqueAtual,
            this.Movimentacao});
            this.dgvEstoque.Location = new System.Drawing.Point(14, 159);
            this.dgvEstoque.MultiSelect = false;
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEstoque.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(909, 215);
            this.dgvEstoque.TabIndex = 1;
            this.dgvEstoque.TabStop = false;
            this.dgvEstoque.Click += new System.EventHandler(this.dgvEstoque_Click);
            // 
            // CodProduto
            // 
            this.CodProduto.HeaderText = "Codigo do Produto";
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.ReadOnly = true;
            this.CodProduto.Visible = false;
            // 
            // MarcaProduto
            // 
            this.MarcaProduto.HeaderText = "Marca";
            this.MarcaProduto.Name = "MarcaProduto";
            this.MarcaProduto.ReadOnly = true;
            this.MarcaProduto.Visible = false;
            // 
            // PCusto
            // 
            this.PCusto.HeaderText = "Custo";
            this.PCusto.Name = "PCusto";
            this.PCusto.ReadOnly = true;
            this.PCusto.Visible = false;
            // 
            // PVenda
            // 
            this.PVenda.HeaderText = "Venda";
            this.PVenda.Name = "PVenda";
            this.PVenda.ReadOnly = true;
            this.PVenda.Visible = false;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Visible = false;
            // 
            // descProduto
            // 
            this.descProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.descProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.descProduto.HeaderText = "Produto";
            this.descProduto.Name = "descProduto";
            this.descProduto.ReadOnly = true;
            this.descProduto.Width = 80;
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            // 
            // Saida
            // 
            this.Saida.HeaderText = "Saída";
            this.Saida.Name = "Saida";
            this.Saida.ReadOnly = true;
            // 
            // EstoqueAtual
            // 
            this.EstoqueAtual.HeaderText = "Estoque Atual";
            this.EstoqueAtual.Name = "EstoqueAtual";
            this.EstoqueAtual.ReadOnly = true;
            this.EstoqueAtual.Width = 150;
            // 
            // Movimentacao
            // 
            this.Movimentacao.HeaderText = "Última Movimentação";
            this.Movimentacao.Name = "Movimentacao";
            this.Movimentacao.ReadOnly = true;
            this.Movimentacao.Width = 170;
            // 
            // btnMovimentaEstoque
            // 
            this.btnMovimentaEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentaEstoque.Location = new System.Drawing.Point(12, 380);
            this.btnMovimentaEstoque.Name = "btnMovimentaEstoque";
            this.btnMovimentaEstoque.Size = new System.Drawing.Size(222, 34);
            this.btnMovimentaEstoque.TabIndex = 10;
            this.btnMovimentaEstoque.Text = "Movimentar Estoque";
            this.btnMovimentaEstoque.UseVisualStyleBackColor = true;
            this.btnMovimentaEstoque.Click += new System.EventHandler(this.btnMovimentaEstoque_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(776, 380);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(147, 34);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(613, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(935, 426);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnMovimentaEstoque);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoque";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimenta Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstoqueAtual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaidaProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEntradaProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Button btnMovimentaEstoque;
        private System.Windows.Forms.Button btnSalvar;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUltimaMov;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSituacaoEstoque;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movimentacao;
    }
}