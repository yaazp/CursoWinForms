namespace CursoWinForms.Frms
{
    partial class FrmMascara2
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
            this.mtbInput = new System.Windows.Forms.MaskedTextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.lblMascaraAtiva = new System.Windows.Forms.Label();
            this.btnHora = new System.Windows.Forms.Button();
            this.btnCep = new System.Windows.Forms.Button();
            this.btnMoeda = new System.Windows.Forms.Button();
            this.btnTelefone = new System.Windows.Forms.Button();
            this.btnSenha = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnCPF = new System.Windows.Forms.Button();
            this.btnValidaCPF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtbInput
            // 
            this.mtbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbInput.HideSelection = false;
            this.mtbInput.Location = new System.Drawing.Point(23, 31);
            this.mtbInput.Name = "mtbInput";
            this.mtbInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbInput.Size = new System.Drawing.Size(347, 26);
            this.mtbInput.TabIndex = 1;
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudo.Location = new System.Drawing.Point(23, 246);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(0, 19);
            this.lblConteudo.TabIndex = 2;
            // 
            // lblMascaraAtiva
            // 
            this.lblMascaraAtiva.AutoSize = true;
            this.lblMascaraAtiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascaraAtiva.Location = new System.Drawing.Point(23, 75);
            this.lblMascaraAtiva.Name = "lblMascaraAtiva";
            this.lblMascaraAtiva.Size = new System.Drawing.Size(0, 19);
            this.lblMascaraAtiva.TabIndex = 3;
            // 
            // btnHora
            // 
            this.btnHora.Location = new System.Drawing.Point(23, 110);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(82, 37);
            this.btnHora.TabIndex = 4;
            this.btnHora.Text = "Hora";
            this.btnHora.UseVisualStyleBackColor = true;
            this.btnHora.Click += new System.EventHandler(this.btnHora_Click);
            // 
            // btnCep
            // 
            this.btnCep.Location = new System.Drawing.Point(111, 110);
            this.btnCep.Name = "btnCep";
            this.btnCep.Size = new System.Drawing.Size(82, 37);
            this.btnCep.TabIndex = 5;
            this.btnCep.Text = "CEP";
            this.btnCep.UseVisualStyleBackColor = true;
            this.btnCep.Click += new System.EventHandler(this.btnCep_Click);
            // 
            // btnMoeda
            // 
            this.btnMoeda.Location = new System.Drawing.Point(200, 110);
            this.btnMoeda.Name = "btnMoeda";
            this.btnMoeda.Size = new System.Drawing.Size(82, 37);
            this.btnMoeda.TabIndex = 6;
            this.btnMoeda.Text = "Moeda";
            this.btnMoeda.UseVisualStyleBackColor = true;
            this.btnMoeda.Click += new System.EventHandler(this.btnMoeda_Click);
            // 
            // btnTelefone
            // 
            this.btnTelefone.Location = new System.Drawing.Point(200, 153);
            this.btnTelefone.Name = "btnTelefone";
            this.btnTelefone.Size = new System.Drawing.Size(82, 37);
            this.btnTelefone.TabIndex = 9;
            this.btnTelefone.Text = "Telefone";
            this.btnTelefone.UseVisualStyleBackColor = true;
            this.btnTelefone.Click += new System.EventHandler(this.btnTelefone_Click);
            // 
            // btnSenha
            // 
            this.btnSenha.Location = new System.Drawing.Point(111, 153);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Size = new System.Drawing.Size(82, 37);
            this.btnSenha.TabIndex = 8;
            this.btnSenha.Text = "Senha";
            this.btnSenha.UseVisualStyleBackColor = true;
            this.btnSenha.Click += new System.EventHandler(this.btnSenha_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(23, 153);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(82, 37);
            this.btnData.TabIndex = 7;
            this.btnData.Text = "Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(23, 196);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(347, 37);
            this.btnResultado.TabIndex = 10;
            this.btnResultado.Text = "Ver Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnCPF
            // 
            this.btnCPF.Location = new System.Drawing.Point(288, 110);
            this.btnCPF.Name = "btnCPF";
            this.btnCPF.Size = new System.Drawing.Size(82, 37);
            this.btnCPF.TabIndex = 12;
            this.btnCPF.Text = "CPF";
            this.btnCPF.UseVisualStyleBackColor = true;
            this.btnCPF.Click += new System.EventHandler(this.btnCPF_Click);
            // 
            // btnValidaCPF
            // 
            this.btnValidaCPF.Location = new System.Drawing.Point(288, 153);
            this.btnValidaCPF.Name = "btnValidaCPF";
            this.btnValidaCPF.Size = new System.Drawing.Size(82, 37);
            this.btnValidaCPF.TabIndex = 13;
            this.btnValidaCPF.Text = "Validar CPF";
            this.btnValidaCPF.UseVisualStyleBackColor = true;
            this.btnValidaCPF.Click += new System.EventHandler(this.btnValidaCPF_Click);
            // 
            // FrmMascara2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 284);
            this.Controls.Add(this.btnValidaCPF);
            this.Controls.Add(this.btnCPF);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnTelefone);
            this.Controls.Add(this.btnSenha);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnMoeda);
            this.Controls.Add(this.btnCep);
            this.Controls.Add(this.btnHora);
            this.Controls.Add(this.lblMascaraAtiva);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.mtbInput);
            this.Name = "FrmMascara2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMascara2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbInput;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.Label lblMascaraAtiva;
        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.Button btnCep;
        private System.Windows.Forms.Button btnMoeda;
        private System.Windows.Forms.Button btnTelefone;
        private System.Windows.Forms.Button btnSenha;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnCPF;
        private System.Windows.Forms.Button btnValidaCPF;
    }
}