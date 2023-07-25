namespace CalenderApp
{
    partial class Job
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkDone = new System.Windows.Forms.CheckBox();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudStartHour = new System.Windows.Forms.NumericUpDown();
            this.nudStartMin = new System.Windows.Forms.NumericUpDown();
            this.nudEndHour = new System.Windows.Forms.NumericUpDown();
            this.nudEndMin = new System.Windows.Forms.NumericUpDown();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndMin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.cbbStatus);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtJobName);
            this.panel1.Controls.Add(this.chkDone);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 35);
            this.panel1.TabIndex = 0;
            // 
            // chkDone
            // 
            this.chkDone.AutoSize = true;
            this.chkDone.Location = new System.Drawing.Point(12, 8);
            this.chkDone.Name = "chkDone";
            this.chkDone.Size = new System.Drawing.Size(15, 14);
            this.chkDone.TabIndex = 0;
            this.chkDone.UseVisualStyleBackColor = true;
            // 
            // txtJobName
            // 
            this.txtJobName.Location = new System.Drawing.Point(33, 4);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(341, 23);
            this.txtJobName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTo);
            this.panel2.Controls.Add(this.nudEndMin);
            this.panel2.Controls.Add(this.nudEndHour);
            this.panel2.Controls.Add(this.nudStartMin);
            this.panel2.Controls.Add(this.nudStartHour);
            this.panel2.Location = new System.Drawing.Point(380, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 35);
            this.panel2.TabIndex = 2;
            // 
            // nudStartHour
            // 
            this.nudStartHour.Location = new System.Drawing.Point(3, 5);
            this.nudStartHour.Name = "nudStartHour";
            this.nudStartHour.Size = new System.Drawing.Size(42, 23);
            this.nudStartHour.TabIndex = 0;
            // 
            // nudStartMin
            // 
            this.nudStartMin.Location = new System.Drawing.Point(51, 5);
            this.nudStartMin.Name = "nudStartMin";
            this.nudStartMin.Size = new System.Drawing.Size(42, 23);
            this.nudStartMin.TabIndex = 1;
            // 
            // nudEndHour
            // 
            this.nudEndHour.Location = new System.Drawing.Point(146, 5);
            this.nudEndHour.Name = "nudEndHour";
            this.nudEndHour.Size = new System.Drawing.Size(42, 23);
            this.nudEndHour.TabIndex = 2;
            // 
            // nudEndMin
            // 
            this.nudEndMin.Location = new System.Drawing.Point(194, 5);
            this.nudEndMin.Name = "nudEndMin";
            this.nudEndMin.Size = new System.Drawing.Size(42, 23);
            this.nudEndMin.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(109, 10);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(19, 15);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To";
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(639, 5);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(121, 23);
            this.cbbStatus.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(783, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(864, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Job";
            this.Size = new System.Drawing.Size(946, 35);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtJobName;
        private CheckBox chkDone;
        private ComboBox cbbStatus;
        private Panel panel2;
        private Label lblTo;
        private NumericUpDown nudEndMin;
        private NumericUpDown nudEndHour;
        private NumericUpDown nudStartMin;
        private NumericUpDown nudStartHour;
        private Button btnDelete;
        private Button btnEdit;
    }
}
