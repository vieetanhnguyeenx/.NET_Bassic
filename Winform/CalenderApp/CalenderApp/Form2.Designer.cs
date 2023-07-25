namespace CalenderApp
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuAddWork = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToday = new System.Windows.Forms.ToolStripMenuItem();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.btnTheNextDay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTheNextDay);
            this.panel1.Controls.Add(this.btnYesterday);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(17, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 484);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 435);
            this.panel2.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(303, 16);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(215, 23);
            this.dtpDate.TabIndex = 1;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddWork,
            this.mnuToday});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(984, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuAddWork
            // 
            this.mnuAddWork.Name = "mnuAddWork";
            this.mnuAddWork.Size = new System.Drawing.Size(73, 20);
            this.mnuAddWork.Text = "Thêm việc";
            // 
            // mnuToday
            // 
            this.mnuToday.Name = "mnuToday";
            this.mnuToday.Size = new System.Drawing.Size(68, 20);
            this.mnuToday.Text = "Hôm nay";
            // 
            // btnYesterday
            // 
            this.btnYesterday.Location = new System.Drawing.Point(3, 14);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(75, 23);
            this.btnYesterday.TabIndex = 2;
            this.btnYesterday.Text = "Hôm qua";
            this.btnYesterday.UseVisualStyleBackColor = true;
            // 
            // btnTheNextDay
            // 
            this.btnTheNextDay.Location = new System.Drawing.Point(872, 14);
            this.btnTheNextDay.Name = "btnTheNextDay";
            this.btnTheNextDay.Size = new System.Drawing.Size(75, 23);
            this.btnTheNextDay.TabIndex = 3;
            this.btnTheNextDay.Text = "Ngày kia";
            this.btnTheNextDay.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnTheNextDay;
        private Button btnYesterday;
        private DateTimePicker dtpDate;
        private Panel panel2;
        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuAddWork;
        private ToolStripMenuItem mnuToday;
    }
}