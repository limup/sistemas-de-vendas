namespace SistemaVendas.Forms.Forms
{
    partial class Login
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
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcesso = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(93, 12);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(156, 20);
            this.txtCpf.TabIndex = 12;
            this.txtCpf.Enter += new System.EventHandler(this.txtCpf_Enter);
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Operador";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(93, 38);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(156, 20);
            this.txtSenha.TabIndex = 14;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Validated += new System.EventHandler(this.txtSenha_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Senha";
            // 
            // btnAcesso
            // 
            this.btnAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcesso.Location = new System.Drawing.Point(147, 86);
            this.btnAcesso.Name = "btnAcesso";
            this.btnAcesso.Size = new System.Drawing.Size(102, 43);
            this.btnAcesso.TabIndex = 15;
            this.btnAcesso.Text = "Acessar";
            this.btnAcesso.UseVisualStyleBackColor = true;
            this.btnAcesso.Click += new System.EventHandler(this.btnAcesso_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(12, 64);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 18);
            this.lblErro.TabIndex = 16;
            this.lblErro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(261, 141);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnAcesso);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcesso;
        private System.Windows.Forms.Label lblErro;
    }
}