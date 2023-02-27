namespace Slide_10_Ex
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
            this.chklbLeft = new System.Windows.Forms.CheckedListBox();
            this.chklbRight = new System.Windows.Forms.CheckedListBox();
            this.btnToRight = new System.Windows.Forms.Button();
            this.btnAllToRight = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.btnAllToLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklbLeft
            // 
            this.chklbLeft.FormattingEnabled = true;
            this.chklbLeft.Items.AddRange(new object[] {
            "Wall",
            "Aim bot",
            "BHop",
            "Invisible",
            "Fly"});
            this.chklbLeft.Location = new System.Drawing.Point(62, 79);
            this.chklbLeft.Name = "chklbLeft";
            this.chklbLeft.Size = new System.Drawing.Size(271, 292);
            this.chklbLeft.TabIndex = 0;
            // 
            // chklbRight
            // 
            this.chklbRight.FormattingEnabled = true;
            this.chklbRight.Items.AddRange(new object[] {
            "Crosshair Plus"});
            this.chklbRight.Location = new System.Drawing.Point(467, 79);
            this.chklbRight.Name = "chklbRight";
            this.chklbRight.Size = new System.Drawing.Size(271, 292);
            this.chklbRight.TabIndex = 1;
            // 
            // btnToRight
            // 
            this.btnToRight.Location = new System.Drawing.Point(363, 92);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(75, 23);
            this.btnToRight.TabIndex = 2;
            this.btnToRight.Text = ">";
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // btnAllToRight
            // 
            this.btnAllToRight.Location = new System.Drawing.Point(363, 173);
            this.btnAllToRight.Name = "btnAllToRight";
            this.btnAllToRight.Size = new System.Drawing.Size(75, 23);
            this.btnAllToRight.TabIndex = 3;
            this.btnAllToRight.Text = ">>";
            this.btnAllToRight.UseVisualStyleBackColor = true;
            this.btnAllToRight.Click += new System.EventHandler(this.btnAllToRight_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(363, 254);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnToLeft.TabIndex = 4;
            this.btnToLeft.Text = "<";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // btnAllToLeft
            // 
            this.btnAllToLeft.Location = new System.Drawing.Point(363, 335);
            this.btnAllToLeft.Name = "btnAllToLeft";
            this.btnAllToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnAllToLeft.TabIndex = 5;
            this.btnAllToLeft.Text = "<<";
            this.btnAllToLeft.UseVisualStyleBackColor = true;
            this.btnAllToLeft.Click += new System.EventHandler(this.btnAllToLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAllToLeft);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnAllToRight);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.chklbRight);
            this.Controls.Add(this.chklbLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox chklbLeft;
        private CheckedListBox chklbRight;
        private Button btnToRight;
        private Button btnAllToRight;
        private Button btnToLeft;
        private Button btnAllToLeft;
    }
}