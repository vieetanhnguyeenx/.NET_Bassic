namespace Slide_8
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
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnSelectedIndi = new System.Windows.Forms.Button();
            this.btnGan = new System.Windows.Forms.Button();
            this.btnSelectedIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 15;
            this.lstDanhSach.Items.AddRange(new object[] {
            "Nguyen Van A",
            "Nguyen Van B"});
            this.lstDanhSach.Location = new System.Drawing.Point(79, 132);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDanhSach.Size = new System.Drawing.Size(171, 124);
            this.lstDanhSach.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(466, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(466, 105);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(466, 162);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(75, 23);
            this.btnIndex.TabIndex = 3;
            this.btnIndex.Text = "Index";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(466, 221);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAt.TabIndex = 4;
            this.btnRemoveAt.Text = "Remove";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnSelectedIndi
            // 
            this.btnSelectedIndi.Location = new System.Drawing.Point(575, 46);
            this.btnSelectedIndi.Name = "btnSelectedIndi";
            this.btnSelectedIndi.Size = new System.Drawing.Size(75, 23);
            this.btnSelectedIndi.TabIndex = 5;
            this.btnSelectedIndi.Text = "Selected Indi";
            this.btnSelectedIndi.UseVisualStyleBackColor = true;
            this.btnSelectedIndi.Click += new System.EventHandler(this.btnSelectedIndi_Click);
            // 
            // btnGan
            // 
            this.btnGan.Location = new System.Drawing.Point(575, 105);
            this.btnGan.Name = "btnGan";
            this.btnGan.Size = new System.Drawing.Size(75, 23);
            this.btnGan.TabIndex = 6;
            this.btnGan.Text = "Gan";
            this.btnGan.UseVisualStyleBackColor = true;
            this.btnGan.Click += new System.EventHandler(this.btnGan_Click);
            // 
            // btnSelectedIndex
            // 
            this.btnSelectedIndex.Location = new System.Drawing.Point(575, 162);
            this.btnSelectedIndex.Name = "btnSelectedIndex";
            this.btnSelectedIndex.Size = new System.Drawing.Size(91, 23);
            this.btnSelectedIndex.TabIndex = 7;
            this.btnSelectedIndex.Text = "SelectedIndex";
            this.btnSelectedIndex.UseVisualStyleBackColor = true;
            this.btnSelectedIndex.Click += new System.EventHandler(this.btnSelectedIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectedIndex);
            this.Controls.Add(this.btnGan);
            this.Controls.Add(this.btnSelectedIndi);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstDanhSach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstDanhSach;
        private Button btnAdd;
        private Button btnCount;
        private Button btnIndex;
        private Button btnRemoveAt;
        private Button btnSelectedIndi;
        private Button btnGan;
        private Button btnSelectedIndex;
    }
}