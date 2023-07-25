namespace Slide_12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHori = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArrange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSort});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuOpen
            // 
            this.mnuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenForm1,
            this.mnuOpenForm2,
            this.mnuOpenForm3,
            this.mnuOpenForm4});
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(48, 20);
            this.mnuOpen.Text = "Open";
            // 
            // mnuOpenForm1
            // 
            this.mnuOpenForm1.Name = "mnuOpenForm1";
            this.mnuOpenForm1.Size = new System.Drawing.Size(111, 22);
            this.mnuOpenForm1.Text = "Form 1";
            this.mnuOpenForm1.Click += new System.EventHandler(this.mnuOpenForm1_Click);
            // 
            // mnuOpenForm2
            // 
            this.mnuOpenForm2.Name = "mnuOpenForm2";
            this.mnuOpenForm2.Size = new System.Drawing.Size(111, 22);
            this.mnuOpenForm2.Text = "Form 2";
            this.mnuOpenForm2.Click += new System.EventHandler(this.mnuOpenForm2_Click);
            // 
            // mnuOpenForm3
            // 
            this.mnuOpenForm3.Name = "mnuOpenForm3";
            this.mnuOpenForm3.Size = new System.Drawing.Size(111, 22);
            this.mnuOpenForm3.Text = "Form 3";
            this.mnuOpenForm3.Click += new System.EventHandler(this.mnuOpenForm3_Click);
            // 
            // mnuOpenForm4
            // 
            this.mnuOpenForm4.Name = "mnuOpenForm4";
            this.mnuOpenForm4.Size = new System.Drawing.Size(111, 22);
            this.mnuOpenForm4.Text = "Form 4";
            this.mnuOpenForm4.Click += new System.EventHandler(this.mnuOpenForm4_Click);
            // 
            // mnuSort
            // 
            this.mnuSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVer,
            this.mnuHori,
            this.mnuArrange,
            this.mnuCas});
            this.mnuSort.Name = "mnuSort";
            this.mnuSort.Size = new System.Drawing.Size(40, 20);
            this.mnuSort.Text = "Sort";
            // 
            // mnuVer
            // 
            this.mnuVer.Name = "mnuVer";
            this.mnuVer.Size = new System.Drawing.Size(180, 22);
            this.mnuVer.Text = "Vertical";
            this.mnuVer.Click += new System.EventHandler(this.mnuVer_Click);
            // 
            // mnuHori
            // 
            this.mnuHori.Name = "mnuHori";
            this.mnuHori.Size = new System.Drawing.Size(180, 22);
            this.mnuHori.Text = "Horizontal";
            this.mnuHori.Click += new System.EventHandler(this.mnuHori_Click);
            // 
            // mnuArrange
            // 
            this.mnuArrange.Name = "mnuArrange";
            this.mnuArrange.Size = new System.Drawing.Size(180, 22);
            this.mnuArrange.Text = "Arrange Icon";
            this.mnuArrange.Click += new System.EventHandler(this.arrangeIconToolStripMenuItem_Click);
            // 
            // mnuCas
            // 
            this.mnuCas.Name = "mnuCas";
            this.mnuCas.Size = new System.Drawing.Size(180, 22);
            this.mnuCas.Text = "Cascade";
            this.mnuCas.Click += new System.EventHandler(this.mnuCas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuOpenForm1;
        private ToolStripMenuItem mnuOpenForm2;
        private ToolStripMenuItem mnuOpenForm3;
        private ToolStripMenuItem mnuOpenForm4;
        private ToolStripMenuItem mnuSort;
        private ToolStripMenuItem mnuVer;
        private ToolStripMenuItem mnuHori;
        private ToolStripMenuItem mnuArrange;
        private ToolStripMenuItem mnuCas;
    }
}