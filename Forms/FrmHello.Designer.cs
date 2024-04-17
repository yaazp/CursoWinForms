namespace CursoWinForms
{
    partial class FrmHello
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btn_AlteraTexto = new System.Windows.Forms.Button();
            this.tbNovoTexto = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
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
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(264, 242);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 27);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btn_AlteraTexto
            // 
            this.btn_AlteraTexto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlteraTexto.Location = new System.Drawing.Point(194, 103);
            this.btn_AlteraTexto.Name = "btn_AlteraTexto";
            this.btn_AlteraTexto.Size = new System.Drawing.Size(82, 26);
            this.btn_AlteraTexto.TabIndex = 2;
            this.btn_AlteraTexto.Text = "Alterar";
            this.btn_AlteraTexto.UseVisualStyleBackColor = true;
            this.btn_AlteraTexto.Click += new System.EventHandler(this.btn_AlteraTexto_Click);
            // 
            // tbNovoTexto
            // 
            this.tbNovoTexto.BackColor = System.Drawing.Color.White;
            this.tbNovoTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNovoTexto.CausesValidation = false;
            this.tbNovoTexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNovoTexto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbNovoTexto.Location = new System.Drawing.Point(12, 71);
            this.tbNovoTexto.Name = "tbNovoTexto";
            this.tbNovoTexto.Size = new System.Drawing.Size(333, 26);
            this.tbNovoTexto.TabIndex = 3;
            // 
            // btnLimpar
            // 
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
            // FrmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 281);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tbNovoTexto);
            this.Controls.Add(this.btn_AlteraTexto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmHello";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btn_AlteraTexto;
        private System.Windows.Forms.TextBox tbNovoTexto;
        private System.Windows.Forms.Button btnLimpar;
    }
}

