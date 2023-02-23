namespace Slide_6_Ex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picPull = new System.Windows.Forms.PictureBox();
            this.picPush = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPush)).BeginInit();
            this.SuspendLayout();
            // 
            // picPull
            // 
            this.picPull.Image = ((System.Drawing.Image)(resources.GetObject("picPull.Image")));
            this.picPull.Location = new System.Drawing.Point(71, 69);
            this.picPull.Name = "picPull";
            this.picPull.Size = new System.Drawing.Size(324, 274);
            this.picPull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPull.TabIndex = 0;
            this.picPull.TabStop = false;
            // 
            // picPush
            // 
            this.picPush.Image = ((System.Drawing.Image)(resources.GetObject("picPush.Image")));
            this.picPush.Location = new System.Drawing.Point(71, 67);
            this.picPush.Name = "picPush";
            this.picPush.Size = new System.Drawing.Size(324, 274);
            this.picPush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPush.TabIndex = 1;
            this.picPush.TabStop = false;
            this.picPush.Click += new System.EventHandler(this.picPush_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(68, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkMusic.ForeColor = System.Drawing.Color.Black;
            this.chkMusic.Location = new System.Drawing.Point(337, 12);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(58, 19);
            this.chkMusic.TabIndex = 3;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.chkMusic_CheckedChanged);
            // 
            // btnPush
            // 
            this.btnPush.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPush.ForeColor = System.Drawing.Color.Black;
            this.btnPush.Location = new System.Drawing.Point(68, 380);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(327, 59);
            this.btnPush.TabIndex = 4;
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblAuthor.Location = new System.Drawing.Point(71, 488);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(105, 15);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Designed by: NVA";
            // 
            // lblCounter
            // 
            this.lblCounter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCounter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCounter.Location = new System.Drawing.Point(196, 456);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(96, 52);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(315, 483);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(324, 23);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(469, 530);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picPush);
            this.Controls.Add(this.picPull);
            this.Name = "Form1";
            this.Text = "Tap Luyen The Thao ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPush)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picPull;
        private PictureBox picPush;
        private Label lblName;
        private CheckBox chkMusic;
        private Button btnPush;
        private Label lblAuthor;
        private Label lblCounter;
        private Button btnExit;
        private TextBox txtName;
    }
}