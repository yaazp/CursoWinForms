namespace CursoWinForms.Frms
{
    partial class FrmMenu2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formuláriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstracaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascara2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(3);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formuláriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3);
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formuláriosToolStripMenuItem
            // 
            this.formuláriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloWordToolStripMenuItem,
            this.validaSenhaToolStripMenuItem,
            this.demonstracaoToolStripMenuItem,
            this.mascaraToolStripMenuItem,
            this.mascara2ToolStripMenuItem});
            this.formuláriosToolStripMenuItem.Name = "formuláriosToolStripMenuItem";
            this.formuláriosToolStripMenuItem.ShortcutKeyDisplayString = "F";
            this.formuláriosToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
            this.formuláriosToolStripMenuItem.Text = "Formulários";
            // 
            // helloWordToolStripMenuItem
            // 
            this.helloWordToolStripMenuItem.Name = "helloWordToolStripMenuItem";
            this.helloWordToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.helloWordToolStripMenuItem.Text = "Hello&Word";
            this.helloWordToolStripMenuItem.Click += new System.EventHandler(this.helloWordToolStripMenuItem_Click);
            // 
            // validaSenhaToolStripMenuItem
            // 
            this.validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
            this.validaSenhaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.validaSenhaToolStripMenuItem.Text = "Valida Senha";
            this.validaSenhaToolStripMenuItem.Click += new System.EventHandler(this.validaSenhaToolStripMenuItem_Click);
            // 
            // demonstracaoToolStripMenuItem
            // 
            this.demonstracaoToolStripMenuItem.Name = "demonstracaoToolStripMenuItem";
            this.demonstracaoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.demonstracaoToolStripMenuItem.Text = "Demonstração";
            this.demonstracaoToolStripMenuItem.Click += new System.EventHandler(this.demonstraçãoToolStripMenuItem_Click);
            // 
            // mascaraToolStripMenuItem
            // 
            this.mascaraToolStripMenuItem.Name = "mascaraToolStripMenuItem";
            this.mascaraToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.mascaraToolStripMenuItem.Text = "Máscara";
            this.mascaraToolStripMenuItem.Click += new System.EventHandler(this.mascaraToolStripMenuItem_Click);
            // 
            // mascara2ToolStripMenuItem
            // 
            this.mascara2ToolStripMenuItem.Name = "mascara2ToolStripMenuItem";
            this.mascara2ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.mascara2ToolStripMenuItem.Text = "Mascara 2";
            this.mascara2ToolStripMenuItem.Click += new System.EventHandler(this.mascara2ToolStripMenuItem_Click);
            // 
            // FrmMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmMenu2";
            this.Text = "FrmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formuláriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstracaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascara2ToolStripMenuItem;
    }
}