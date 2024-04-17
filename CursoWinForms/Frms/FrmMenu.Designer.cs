namespace CursoWinForms.Frms
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formuláriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstracaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControle = new System.Windows.Forms.Panel();
            this.mascaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascara2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelControle);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.helloWordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helloWordToolStripMenuItem.Image")));
            this.helloWordToolStripMenuItem.Name = "helloWordToolStripMenuItem";
            this.helloWordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helloWordToolStripMenuItem.Text = "Hello&Word";
            this.helloWordToolStripMenuItem.Click += new System.EventHandler(this.helloWordToolStripMenuItem_Click);
            // 
            // validaSenhaToolStripMenuItem
            // 
            this.validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
            this.validaSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.validaSenhaToolStripMenuItem.Text = "Valida Senha";
            this.validaSenhaToolStripMenuItem.Click += new System.EventHandler(this.validaSenhaToolStripMenuItem_Click);
            // 
            // demonstracaoToolStripMenuItem
            // 
            this.demonstracaoToolStripMenuItem.Name = "demonstracaoToolStripMenuItem";
            this.demonstracaoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.demonstracaoToolStripMenuItem.Text = "Demonstração";
            this.demonstracaoToolStripMenuItem.Click += new System.EventHandler(this.demonstraçãoToolStripMenuItem_Click);
            // 
            // panelControle
            // 
            this.panelControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControle.Location = new System.Drawing.Point(0, 0);
            this.panelControle.Name = "panelControle";
            this.panelControle.Size = new System.Drawing.Size(800, 421);
            this.panelControle.TabIndex = 0;
            // 
            // mascaraToolStripMenuItem
            // 
            this.mascaraToolStripMenuItem.Name = "mascaraToolStripMenuItem";
            this.mascaraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mascaraToolStripMenuItem.Text = "Máscara";
            this.mascaraToolStripMenuItem.Click += new System.EventHandler(this.mascaraToolStripMenuItem_Click);
            // 
            // mascara2ToolStripMenuItem
            // 
            this.mascara2ToolStripMenuItem.Name = "mascara2ToolStripMenuItem";
            this.mascara2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mascara2ToolStripMenuItem.Text = "Mascara 2";
            this.mascara2ToolStripMenuItem.Click += new System.EventHandler(this.mascara2ToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formuláriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstracaoToolStripMenuItem;
        private System.Windows.Forms.Panel panelControle;
        private System.Windows.Forms.ToolStripMenuItem mascaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascara2ToolStripMenuItem;
    }
}