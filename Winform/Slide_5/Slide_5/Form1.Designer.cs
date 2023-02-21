namespace Slide_5
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
            this.grbHabits = new System.Windows.Forms.GroupBox();
            this.chkNgheNhac = new System.Windows.Forms.CheckBox();
            this.chkChoiTheThao = new System.Windows.Forms.CheckBox();
            this.chkDuLich = new System.Windows.Forms.CheckBox();
            this.chkShopping = new System.Windows.Forms.CheckBox();
            this.chkXemPhim = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grbGioiTinh = new System.Windows.Forms.GroupBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.btnCheckGioiTinh = new System.Windows.Forms.Button();
            this.grbHabits.SuspendLayout();
            this.grbGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHabits
            // 
            this.grbHabits.BackColor = System.Drawing.SystemColors.Control;
            this.grbHabits.Controls.Add(this.chkNgheNhac);
            this.grbHabits.Controls.Add(this.chkChoiTheThao);
            this.grbHabits.Controls.Add(this.chkDuLich);
            this.grbHabits.Controls.Add(this.chkShopping);
            this.grbHabits.Controls.Add(this.chkXemPhim);
            this.grbHabits.Location = new System.Drawing.Point(12, 12);
            this.grbHabits.Name = "grbHabits";
            this.grbHabits.Size = new System.Drawing.Size(210, 147);
            this.grbHabits.TabIndex = 0;
            this.grbHabits.TabStop = false;
            this.grbHabits.Text = "So Thich";
            // 
            // chkNgheNhac
            // 
            this.chkNgheNhac.AutoSize = true;
            this.chkNgheNhac.Location = new System.Drawing.Point(22, 121);
            this.chkNgheNhac.Name = "chkNgheNhac";
            this.chkNgheNhac.Size = new System.Drawing.Size(86, 19);
            this.chkNgheNhac.TabIndex = 4;
            this.chkNgheNhac.Text = "Nghe Nhac";
            this.chkNgheNhac.UseVisualStyleBackColor = true;
            // 
            // chkChoiTheThao
            // 
            this.chkChoiTheThao.AutoSize = true;
            this.chkChoiTheThao.Location = new System.Drawing.Point(22, 96);
            this.chkChoiTheThao.Name = "chkChoiTheThao";
            this.chkChoiTheThao.Size = new System.Drawing.Size(102, 19);
            this.chkChoiTheThao.TabIndex = 3;
            this.chkChoiTheThao.Text = "Choi The Thao";
            this.chkChoiTheThao.UseVisualStyleBackColor = true;
            // 
            // chkDuLich
            // 
            this.chkDuLich.AutoSize = true;
            this.chkDuLich.Location = new System.Drawing.Point(22, 71);
            this.chkDuLich.Name = "chkDuLich";
            this.chkDuLich.Size = new System.Drawing.Size(66, 19);
            this.chkDuLich.TabIndex = 2;
            this.chkDuLich.Text = "Du Lich";
            this.chkDuLich.UseVisualStyleBackColor = true;
            // 
            // chkShopping
            // 
            this.chkShopping.AutoSize = true;
            this.chkShopping.Location = new System.Drawing.Point(22, 47);
            this.chkShopping.Name = "chkShopping";
            this.chkShopping.Size = new System.Drawing.Size(77, 19);
            this.chkShopping.TabIndex = 1;
            this.chkShopping.Text = "Shopping";
            this.chkShopping.UseVisualStyleBackColor = true;
            // 
            // chkXemPhim
            // 
            this.chkXemPhim.AutoSize = true;
            this.chkXemPhim.Location = new System.Drawing.Point(22, 22);
            this.chkXemPhim.Name = "chkXemPhim";
            this.chkXemPhim.Size = new System.Drawing.Size(81, 19);
            this.chkXemPhim.TabIndex = 0;
            this.chkXemPhim.Text = "Xem Phim";
            this.chkXemPhim.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(294, 83);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // grbGioiTinh
            // 
            this.grbGioiTinh.Controls.Add(this.radNu);
            this.grbGioiTinh.Controls.Add(this.radNam);
            this.grbGioiTinh.Location = new System.Drawing.Point(12, 211);
            this.grbGioiTinh.Name = "grbGioiTinh";
            this.grbGioiTinh.Size = new System.Drawing.Size(210, 147);
            this.grbGioiTinh.TabIndex = 2;
            this.grbGioiTinh.TabStop = false;
            this.grbGioiTinh.Text = "Gioi Tinh";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(13, 27);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(51, 19);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(13, 57);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(41, 19);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nu";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // btnCheckGioiTinh
            // 
            this.btnCheckGioiTinh.Location = new System.Drawing.Point(294, 264);
            this.btnCheckGioiTinh.Name = "btnCheckGioiTinh";
            this.btnCheckGioiTinh.Size = new System.Drawing.Size(75, 23);
            this.btnCheckGioiTinh.TabIndex = 3;
            this.btnCheckGioiTinh.Text = "Check Gioi Tinh";
            this.btnCheckGioiTinh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckGioiTinh);
            this.Controls.Add(this.grbGioiTinh);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.grbHabits);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grbHabits.ResumeLayout(false);
            this.grbHabits.PerformLayout();
            this.grbGioiTinh.ResumeLayout(false);
            this.grbGioiTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbHabits;
        private CheckBox chkNgheNhac;
        private CheckBox chkChoiTheThao;
        private CheckBox chkDuLich;
        private CheckBox chkShopping;
        private CheckBox chkXemPhim;
        private Button btnCheck;
        private GroupBox grbGioiTinh;
        private RadioButton radNu;
        private RadioButton radNam;
        private Button btnCheckGioiTinh;
    }
}