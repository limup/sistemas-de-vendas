namespace SistemaVendas.Forms
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.diárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueAtualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntradatoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.retiradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.picVendedor = new System.Windows.Forms.PictureBox();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.picEstoque = new System.Windows.Forms.PictureBox();
            this.picCaixa = new System.Windows.Forms.PictureBox();
            this.ttpDescricaoItem = new System.Windows.Forms.ToolTip(this.components);
            this.anualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.gerenciamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnConsultaProduto,
            this.estoqueToolStripMenuItem,
            this.vendedorToolStripMenuItem1,
            this.operadorToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // mnConsultaProduto
            // 
            this.mnConsultaProduto.Name = "mnConsultaProduto";
            this.mnConsultaProduto.Size = new System.Drawing.Size(124, 22);
            this.mnConsultaProduto.Text = "Produto";
            this.mnConsultaProduto.Click += new System.EventHandler(this.mnConsultaProduto_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem1
            // 
            this.vendedorToolStripMenuItem1.Name = "vendedorToolStripMenuItem1";
            this.vendedorToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.vendedorToolStripMenuItem1.Text = "Vendedor";
            this.vendedorToolStripMenuItem1.Visible = false;
            // 
            // operadorToolStripMenuItem
            // 
            this.operadorToolStripMenuItem.Name = "operadorToolStripMenuItem";
            this.operadorToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.operadorToolStripMenuItem.Text = "Operador";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProduto,
            this.vendedorToolStripMenuItem2});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // mnProduto
            // 
            this.mnProduto.Name = "mnProduto";
            this.mnProduto.Size = new System.Drawing.Size(124, 22);
            this.mnProduto.Text = "Produto";
            this.mnProduto.Click += new System.EventHandler(this.mnProduto_Click);
            // 
            // vendedorToolStripMenuItem2
            // 
            this.vendedorToolStripMenuItem2.Name = "vendedorToolStripMenuItem2";
            this.vendedorToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.vendedorToolStripMenuItem2.Text = "Vendedor";
            this.vendedorToolStripMenuItem2.Visible = false;
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relVendas,
            this.relEstoque});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relVendas
            // 
            this.relVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diárioToolStripMenuItem,
            this.mensalToolStripMenuItem,
            this.anualToolStripMenuItem});
            this.relVendas.Name = "relVendas";
            this.relVendas.Size = new System.Drawing.Size(180, 22);
            this.relVendas.Text = "Vendas";
            // 
            // diárioToolStripMenuItem
            // 
            this.diárioToolStripMenuItem.Name = "diárioToolStripMenuItem";
            this.diárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diárioToolStripMenuItem.Text = "Hoje";
            this.diárioToolStripMenuItem.Click += new System.EventHandler(this.diárioToolStripMenuItem_Click);
            // 
            // mensalToolStripMenuItem
            // 
            this.mensalToolStripMenuItem.Name = "mensalToolStripMenuItem";
            this.mensalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mensalToolStripMenuItem.Text = "Mensal";
            this.mensalToolStripMenuItem.Click += new System.EventHandler(this.mensalToolStripMenuItem_Click);
            // 
            // relEstoque
            // 
            this.relEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueAtualToolStripMenuItem,
            this.históricoToolStripMenuItem});
            this.relEstoque.Name = "relEstoque";
            this.relEstoque.Size = new System.Drawing.Size(180, 22);
            this.relEstoque.Text = "Estoques";
            // 
            // estoqueAtualToolStripMenuItem
            // 
            this.estoqueAtualToolStripMenuItem.Name = "estoqueAtualToolStripMenuItem";
            this.estoqueAtualToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.estoqueAtualToolStripMenuItem.Text = "Atual";
            this.estoqueAtualToolStripMenuItem.Click += new System.EventHandler(this.estoqueAtualToolStripMenuItem_Click);
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.históricoToolStripMenuItem.Text = "Histórico de Movimentações";
            this.históricoToolStripMenuItem.Click += new System.EventHandler(this.históricoToolStripMenuItem_Click);
            // 
            // gerenciamentoToolStripMenuItem
            // 
            this.gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntradatoolStripMenuItem1,
            this.retiradaToolStripMenuItem,
            this.fechamentoToolStripMenuItem});
            this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.gerenciamentoToolStripMenuItem.Text = "Gerenciamento";
            // 
            // EntradatoolStripMenuItem1
            // 
            this.EntradatoolStripMenuItem1.Name = "EntradatoolStripMenuItem1";
            this.EntradatoolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.EntradatoolStripMenuItem1.Text = "Entrada";
            this.EntradatoolStripMenuItem1.Click += new System.EventHandler(this.EntradatoolStripMenuItem1_Click);
            // 
            // retiradaToolStripMenuItem
            // 
            this.retiradaToolStripMenuItem.Name = "retiradaToolStripMenuItem";
            this.retiradaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.retiradaToolStripMenuItem.Text = "Retirada";
            this.retiradaToolStripMenuItem.Click += new System.EventHandler(this.retiradaToolStripMenuItem_Click);
            // 
            // fechamentoToolStripMenuItem
            // 
            this.fechamentoToolStripMenuItem.Name = "fechamentoToolStripMenuItem";
            this.fechamentoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.fechamentoToolStripMenuItem.Text = "Fechamento";
            this.fechamentoToolStripMenuItem.Click += new System.EventHandler(this.fechamentoToolStripMenuItem_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.picVendedor);
            this.flowLayoutPanel1.Controls.Add(this.picProduto);
            this.flowLayoutPanel1.Controls.Add(this.picEstoque);
            this.flowLayoutPanel1.Controls.Add(this.picCaixa);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(268, 402);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // picVendedor
            // 
            this.picVendedor.AccessibleDescription = "Vendedor";
            this.picVendedor.AccessibleName = "Vendedor";
            this.picVendedor.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.picVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVendedor.Image = global::SistemaVendas.Forms.Properties.Resources.Vendedor;
            this.picVendedor.Location = new System.Drawing.Point(3, 3);
            this.picVendedor.Name = "picVendedor";
            this.picVendedor.Size = new System.Drawing.Size(128, 128);
            this.picVendedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVendedor.TabIndex = 6;
            this.picVendedor.TabStop = false;
            this.ttpDescricaoItem.SetToolTip(this.picVendedor, "Vendedor");
            // 
            // picProduto
            // 
            this.picProduto.AccessibleDescription = "Produto";
            this.picProduto.AccessibleName = "Produto";
            this.picProduto.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.picProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProduto.Image = global::SistemaVendas.Forms.Properties.Resources.CadastroProduto;
            this.picProduto.Location = new System.Drawing.Point(3, 137);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(128, 128);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picProduto.TabIndex = 5;
            this.picProduto.TabStop = false;
            this.ttpDescricaoItem.SetToolTip(this.picProduto, "Cadastrar Produto");
            this.picProduto.Click += new System.EventHandler(this.mnConsultaProduto_Click);
            // 
            // picEstoque
            // 
            this.picEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEstoque.Image = global::SistemaVendas.Forms.Properties.Resources.CadastroEstoque;
            this.picEstoque.Location = new System.Drawing.Point(3, 271);
            this.picEstoque.Name = "picEstoque";
            this.picEstoque.Size = new System.Drawing.Size(128, 128);
            this.picEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEstoque.TabIndex = 3;
            this.picEstoque.TabStop = false;
            this.ttpDescricaoItem.SetToolTip(this.picEstoque, "Cadastrar Estoque");
            this.picEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // picCaixa
            // 
            this.picCaixa.AccessibleDescription = "Caixa";
            this.picCaixa.AccessibleName = "Caixa";
            this.picCaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.picCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCaixa.Image = global::SistemaVendas.Forms.Properties.Resources.registradora;
            this.picCaixa.Location = new System.Drawing.Point(137, 3);
            this.picCaixa.Name = "picCaixa";
            this.picCaixa.Size = new System.Drawing.Size(128, 128);
            this.picCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCaixa.TabIndex = 4;
            this.picCaixa.TabStop = false;
            this.ttpDescricaoItem.SetToolTip(this.picCaixa, "Caixa");
            this.picCaixa.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // anualToolStripMenuItem
            // 
            this.anualToolStripMenuItem.Name = "anualToolStripMenuItem";
            this.anualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anualToolStripMenuItem.Text = "Anual";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SistemaVendas.Forms.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 426);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnProduto;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relVendas;
        private System.Windows.Forms.ToolStripMenuItem relEstoque;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaProduto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox picEstoque;
        private System.Windows.Forms.PictureBox picCaixa;
        private System.Windows.Forms.ToolTip ttpDescricaoItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem2;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.PictureBox picVendedor;
        private System.Windows.Forms.ToolStripMenuItem EntradatoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem retiradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueAtualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anualToolStripMenuItem;
    }
}