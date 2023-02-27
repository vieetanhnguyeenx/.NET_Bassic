namespace Slide_9
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
            this.cboDanhSach = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelected = new System.Windows.Forms.Button();
            this.btnSelectedItem = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnAddRange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboDanhSach
            // 
            this.cboDanhSach.FormattingEnabled = true;
            this.cboDanhSach.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3"});
            this.cboDanhSach.Location = new System.Drawing.Point(159, 79);
            this.cboDanhSach.Name = "cboDanhSach";
            this.cboDanhSach.Size = new System.Drawing.Size(121, 23);
            this.cboDanhSach.TabIndex = 0;
            this.cboDanhSach.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(348, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(348, 85);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSelected
            // 
            this.btnSelected.Location = new System.Drawing.Point(348, 189);
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(75, 23);
            this.btnSelected.TabIndex = 3;
            this.btnSelected.Text = "Selected";
            this.btnSelected.UseVisualStyleBackColor = true;
            this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
            // 
            // btnSelectedItem
            // 
            this.btnSelectedItem.Location = new System.Drawing.Point(464, 85);
            this.btnSelectedItem.Name = "btnSelectedItem";
            this.btnSelectedItem.Size = new System.Drawing.Size(110, 23);
            this.btnSelectedItem.TabIndex = 4;
            this.btnSelectedItem.Text = "Selected Item";
            this.btnSelectedItem.UseVisualStyleBackColor = true;
            this.btnSelectedItem.Click += new System.EventHandler(this.btnSelectedItem_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(464, 134);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnAddRange
            // 
            this.btnAddRange.Location = new System.Drawing.Point(464, 189);
            this.btnAddRange.Name = "btnAddRange";
            this.btnAddRange.Size = new System.Drawing.Size(110, 23);
            this.btnAddRange.TabIndex = 6;
            this.btnAddRange.Text = "Add Range";
            this.btnAddRange.UseVisualStyleBackColor = true;
            this.btnAddRange.Click += new System.EventHandler(this.btnAddRange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(625, 85);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(625, 134);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAt.TabIndex = 8;
            this.btnRemoveAt.Text = "Remove At";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(625, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddRange);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnSelectedItem);
            this.Controls.Add(this.btnSelected);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboDanhSach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cboDanhSach;
        private Button btnAdd;
        private Button btnInsert;
        private Button btnSelected;
        private Button btnSelectedItem;
        private Button btnCount;
        private Button btnAddRange;
        private Button btnRemove;
        private Button btnRemoveAt;
        private Button btnClear;
    }
}