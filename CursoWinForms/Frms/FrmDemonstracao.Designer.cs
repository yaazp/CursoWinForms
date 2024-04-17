namespace CursoWinForms.Frms
{
    partial class FrmDemonstracao
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblMaius = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(8, 8);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            // 
            // tbMsg
            // 
            this.tbMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMsg.Location = new System.Drawing.Point(8, 40);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.ReadOnly = true;
            this.tbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMsg.Size = new System.Drawing.Size(304, 232);
            this.tbMsg.TabIndex = 1;
            this.tbMsg.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Location = new System.Drawing.Point(328, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 28);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Limpar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMinus
            // 
            this.lblMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinus.Location = new System.Drawing.Point(320, 104);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(44, 13);
            this.lblMinus.TabIndex = 3;
            this.lblMinus.Text = "Minus.";
            this.lblMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMaius
            // 
            this.lblMaius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaius.Location = new System.Drawing.Point(320, 56);
            this.lblMaius.Name = "lblMaius";
            this.lblMaius.Size = new System.Drawing.Size(40, 16);
            this.lblMaius.TabIndex = 4;
            this.lblMaius.Text = "Maius.";
            this.lblMaius.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUpper
            // 
            this.lblUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUpper.Location = new System.Drawing.Point(368, 56);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(32, 23);
            this.lblUpper.TabIndex = 5;
            this.lblUpper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLower
            // 
            this.lblLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLower.Location = new System.Drawing.Point(368, 104);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(32, 23);
            this.lblLower.TabIndex = 6;
            this.lblLower.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmDemonstracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.lblMaius);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.tbInput);
            this.Name = "FrmDemonstracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblMaius;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblLower;
    }
}