namespace CursoWinForms.Frms
{
    partial class FrmValidaSenha
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
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnVerSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(12, 45);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(218, 20);
            this.tbSenha.TabIndex = 0;
            this.tbSenha.UseSystemPasswordChar = true;
            this.tbSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSenha_KeyDown);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(12, 90);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 22);
            this.lbResultado.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(245, 42);
            this.btnReset.Name = "btnReset";
            this.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReset.Size = new System.Drawing.Size(111, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Limpar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnVerSenha
            // 
            this.btnVerSenha.Location = new System.Drawing.Point(245, 71);
            this.btnVerSenha.Name = "btnVerSenha";
            this.btnVerSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVerSenha.Size = new System.Drawing.Size(111, 23);
            this.btnVerSenha.TabIndex = 3;
            this.btnVerSenha.Text = "Ver Senha";
            this.btnVerSenha.UseVisualStyleBackColor = true;
            this.btnVerSenha.Click += new System.EventHandler(this.btnVerSenha_Click);
            // 
            // FrmValidaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.btnVerSenha);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.tbSenha);
            this.Name = "FrmValidaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de Senhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnVerSenha;
    }
}