namespace Slide_10
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
            this.chklbDanhSach = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnAddRange = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheckedIndi = new System.Windows.Forms.Button();
            this.btnCheckedItems = new System.Windows.Forms.Button();
            this.btnGetIndex = new System.Windows.Forms.Button();
            this.btnGetItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklbDanhSach
            // 
            this.chklbDanhSach.FormattingEnabled = true;
            this.chklbDanhSach.Items.AddRange(new object[] {
            "san pham 1",
            "san pham 2",
            "san pham 3",
            "san pham 4"});
            this.chklbDanhSach.Location = new System.Drawing.Point(131, 96);
            this.chklbDanhSach.Name = "chklbDanhSach";
            this.chklbDanhSach.Size = new System.Drawing.Size(120, 94);
            this.chklbDanhSach.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(294, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(294, 123);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnAddRange
            // 
            this.btnAddRange.Location = new System.Drawing.Point(294, 152);
            this.btnAddRange.Name = "btnAddRange";
            this.btnAddRange.Size = new System.Drawing.Size(75, 23);
            this.btnAddRange.TabIndex = 3;
            this.btnAddRange.Text = "Add Range";
            this.btnAddRange.UseVisualStyleBackColor = true;
            this.btnAddRange.Click += new System.EventHandler(this.btnAddRange_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(294, 181);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(399, 95);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(399, 124);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAt.TabIndex = 6;
            this.btnRemoveAt.Text = "Remove At";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(399, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheckedIndi
            // 
            this.btnCheckedIndi.Location = new System.Drawing.Point(399, 182);
            this.btnCheckedIndi.Name = "btnCheckedIndi";
            this.btnCheckedIndi.Size = new System.Drawing.Size(75, 23);
            this.btnCheckedIndi.TabIndex = 8;
            this.btnCheckedIndi.Text = "CheckedIndi";
            this.btnCheckedIndi.UseVisualStyleBackColor = true;
            this.btnCheckedIndi.Click += new System.EventHandler(this.btnCheckedIndi_Click);
            // 
            // btnCheckedItems
            // 
            this.btnCheckedItems.Location = new System.Drawing.Point(508, 97);
            this.btnCheckedItems.Name = "btnCheckedItems";
            this.btnCheckedItems.Size = new System.Drawing.Size(98, 23);
            this.btnCheckedItems.TabIndex = 9;
            this.btnCheckedItems.Text = "Checked Items";
            this.btnCheckedItems.UseVisualStyleBackColor = true;
            this.btnCheckedItems.Click += new System.EventHandler(this.btnCheckedItems_Click);
            // 
            // btnGetIndex
            // 
            this.btnGetIndex.Location = new System.Drawing.Point(510, 126);
            this.btnGetIndex.Name = "btnGetIndex";
            this.btnGetIndex.Size = new System.Drawing.Size(97, 23);
            this.btnGetIndex.TabIndex = 10;
            this.btnGetIndex.Text = "Get Index";
            this.btnGetIndex.UseVisualStyleBackColor = true;
            this.btnGetIndex.Click += new System.EventHandler(this.btnGetIndex_Click);
            // 
            // btnGetItem
            // 
            this.btnGetItem.Location = new System.Drawing.Point(508, 155);
            this.btnGetItem.Name = "btnGetItem";
            this.btnGetItem.Size = new System.Drawing.Size(96, 23);
            this.btnGetItem.TabIndex = 11;
            this.btnGetItem.Text = "Get Item";
            this.btnGetItem.UseVisualStyleBackColor = true;
            this.btnGetItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetItem);
            this.Controls.Add(this.btnGetIndex);
            this.Controls.Add(this.btnCheckedItems);
            this.Controls.Add(this.btnCheckedIndi);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAddRange);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chklbDanhSach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox chklbDanhSach;
        private Button btnAdd;
        private Button btnInsert;
        private Button btnAddRange;
        private Button btnCount;
        private Button btnRemove;
        private Button btnRemoveAt;
        private Button btnClear;
        private Button btnCheckedIndi;
        private Button btnCheckedItems;
        private Button btnGetIndex;
        private Button btnGetItem;
    }
}