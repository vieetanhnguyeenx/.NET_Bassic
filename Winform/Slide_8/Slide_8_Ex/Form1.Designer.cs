namespace Slide_8_Ex
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
            this.components = new System.ComponentModel.Container();
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grbDanhSachSo = new System.Windows.Forms.GroupBox();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnSoChan = new System.Windows.Forms.Button();
            this.btnSoLe = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnTangLen2 = new System.Windows.Forms.Button();
            this.btnXoaPhanTu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDanhSachSo.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNhapSo
            // 
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Location = new System.Drawing.Point(12, 30);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(52, 15);
            this.lblNhapSo.TabIndex = 0;
            this.lblNhapSo.Text = "Nhập Số";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(105, 26);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(423, 23);
            this.txtNhapSo.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(560, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grbDanhSachSo
            // 
            this.grbDanhSachSo.Controls.Add(this.lstSo);
            this.grbDanhSachSo.Location = new System.Drawing.Point(12, 83);
            this.grbDanhSachSo.Name = "grbDanhSachSo";
            this.grbDanhSachSo.Size = new System.Drawing.Size(364, 300);
            this.grbDanhSachSo.TabIndex = 3;
            this.grbDanhSachSo.TabStop = false;
            this.grbDanhSachSo.Text = "Danh sách số";
            // 
            // lstSo
            // 
            this.lstSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 15;
            this.lstSo.Location = new System.Drawing.Point(3, 19);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSo.Size = new System.Drawing.Size(358, 278);
            this.lstSo.TabIndex = 0;
            this.lstSo.SelectedIndexChanged += new System.EventHandler(this.lstSo_SelectedIndexChanged);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnSoChan);
            this.grbChucNang.Controls.Add(this.btnSoLe);
            this.grbChucNang.Controls.Add(this.btnBinhPhuong);
            this.grbChucNang.Controls.Add(this.btnTangLen2);
            this.grbChucNang.Controls.Add(this.btnXoaPhanTu);
            this.grbChucNang.Controls.Add(this.button2);
            this.grbChucNang.Controls.Add(this.btnTong);
            this.grbChucNang.Location = new System.Drawing.Point(420, 83);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(364, 300);
            this.grbChucNang.TabIndex = 4;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chọn chức năng";
            // 
            // btnSoChan
            // 
            this.btnSoChan.Location = new System.Drawing.Point(6, 267);
            this.btnSoChan.Name = "btnSoChan";
            this.btnSoChan.Size = new System.Drawing.Size(352, 23);
            this.btnSoChan.TabIndex = 6;
            this.btnSoChan.Text = "Chọn số chãn";
            this.btnSoChan.UseVisualStyleBackColor = true;
            this.btnSoChan.Click += new System.EventHandler(this.btnSoChan_Click);
            // 
            // btnSoLe
            // 
            this.btnSoLe.Location = new System.Drawing.Point(6, 227);
            this.btnSoLe.Name = "btnSoLe";
            this.btnSoLe.Size = new System.Drawing.Size(352, 23);
            this.btnSoLe.TabIndex = 5;
            this.btnSoLe.Text = "Chọn số lẻ";
            this.btnSoLe.UseVisualStyleBackColor = true;
            this.btnSoLe.Click += new System.EventHandler(this.btnSoLe_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(6, 187);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(352, 23);
            this.btnBinhPhuong.TabIndex = 4;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnTangLen2
            // 
            this.btnTangLen2.Location = new System.Drawing.Point(6, 147);
            this.btnTangLen2.Name = "btnTangLen2";
            this.btnTangLen2.Size = new System.Drawing.Size(352, 23);
            this.btnTangLen2.TabIndex = 3;
            this.btnTangLen2.Text = "Tăng mỗi phàn tử lên 2";
            this.btnTangLen2.UseVisualStyleBackColor = true;
            this.btnTangLen2.Click += new System.EventHandler(this.btnTangLen2_Click);
            // 
            // btnXoaPhanTu
            // 
            this.btnXoaPhanTu.Location = new System.Drawing.Point(6, 107);
            this.btnXoaPhanTu.Name = "btnXoaPhanTu";
            this.btnXoaPhanTu.Size = new System.Drawing.Size(352, 23);
            this.btnXoaPhanTu.TabIndex = 2;
            this.btnXoaPhanTu.Text = "Xóa phần tử đang chọn";
            this.btnXoaPhanTu.UseVisualStyleBackColor = true;
            this.btnXoaPhanTu.Click += new System.EventHandler(this.btnXoaPhanTu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(352, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa phần tử đầu và cuối";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(6, 27);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(352, 23);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng của danh sách";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(15, 389);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(769, 36);
            this.btnKetThuc.TabIndex = 5;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbDanhSachSo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lblNhapSo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbDanhSachSo.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNhapSo;
        private TextBox txtNhapSo;
        private Button btnUpdate;
        private GroupBox grbDanhSachSo;
        private ListBox lstSo;
        private GroupBox grbChucNang;
        private Button btnKetThuc;
        private Button btnSoChan;
        private Button btnSoLe;
        private Button btnBinhPhuong;
        private Button btnTangLen2;
        private Button btnXoaPhanTu;
        private Button button2;
        private Button btnTong;
        private ErrorProvider errorProvider1;
    }
}