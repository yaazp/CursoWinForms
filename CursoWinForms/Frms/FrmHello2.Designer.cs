namespace CursoWinForms.Frms
{
    partial class FrmHello2
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbNovoTexto = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlteraTexto = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Visual Studio .Net Version";
            // 
            // tbNovoTexto
            // 
            this.tbNovoTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNovoTexto.BackColor = System.Drawing.Color.White;
            this.tbNovoTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNovoTexto.CausesValidation = false;
            this.tbNovoTexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNovoTexto.ForeColor = System.Drawing.Color.Black;
            this.tbNovoTexto.Location = new System.Drawing.Point(12, 71);
            this.tbNovoTexto.Name = "tbNovoTexto";
            this.tbNovoTexto.Size = new System.Drawing.Size(333, 26);
            this.tbNovoTexto.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(283, 103);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(62, 26);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlteraTexto
            // 
            this.btnAlteraTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlteraTexto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraTexto.Location = new System.Drawing.Point(194, 103);
            this.btnAlteraTexto.Name = "btnAlteraTexto";
            this.btnAlteraTexto.Size = new System.Drawing.Size(82, 26);
            this.btnAlteraTexto.TabIndex = 2;
            this.btnAlteraTexto.Text = "Alterar";
            this.btnAlteraTexto.UseVisualStyleBackColor = true;
            this.btnAlteraTexto.Click += new System.EventHandler(this.btnAlteraTexto_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(295, 243);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(46, 26);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmHello2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 281);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlteraTexto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tbNovoTexto);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmHello2";
            this.Text = "FrmHello2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbNovoTexto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlteraTexto;
        private System.Windows.Forms.Button btnSair;
    }
}