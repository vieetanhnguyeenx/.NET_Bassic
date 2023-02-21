namespace Slide_5_Ex
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblView = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.grbFont = new System.Windows.Forms.GroupBox();
            this.chkGachChan = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBolt = new System.Windows.Forms.CheckBox();
            this.grbColor.SuspendLayout();
            this.grbFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInput.Location = new System.Drawing.Point(41, 19);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(35, 15);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput.Location = new System.Drawing.Point(161, 16);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(537, 35);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Location = new System.Drawing.Point(41, 375);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(51, 15);
            this.lblView.TabIndex = 3;
            this.lblView.Text = "Hien Thi";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResult.Location = new System.Drawing.Point(197, 375);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(390, 40);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "label2";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(644, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbColor
            // 
            this.grbColor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbColor.Controls.Add(this.radBlack);
            this.grbColor.Controls.Add(this.radBlue);
            this.grbColor.Controls.Add(this.radGreen);
            this.grbColor.Controls.Add(this.radRed);
            this.grbColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbColor.Location = new System.Drawing.Point(60, 71);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(200, 217);
            this.grbColor.TabIndex = 6;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "Color";
            this.grbColor.Enter += new System.EventHandler(this.grbColor_Enter);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Location = new System.Drawing.Point(15, 178);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(53, 19);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(15, 124);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(48, 19);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(15, 70);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(56, 19);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(15, 22);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 19);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grbFont
            // 
            this.grbFont.Controls.Add(this.chkGachChan);
            this.grbFont.Controls.Add(this.chkItalic);
            this.grbFont.Controls.Add(this.chkBolt);
            this.grbFont.Location = new System.Drawing.Point(548, 71);
            this.grbFont.Name = "grbFont";
            this.grbFont.Size = new System.Drawing.Size(200, 217);
            this.grbFont.TabIndex = 7;
            this.grbFont.TabStop = false;
            this.grbFont.Text = "Font Chu";
            this.grbFont.Enter += new System.EventHandler(this.grbFont_Enter);
            // 
            // chkGachChan
            // 
            this.chkGachChan.AutoSize = true;
            this.chkGachChan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkGachChan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.chkGachChan.Location = new System.Drawing.Point(20, 179);
            this.chkGachChan.Name = "chkGachChan";
            this.chkGachChan.Size = new System.Drawing.Size(145, 19);
            this.chkGachChan.TabIndex = 2;
            this.chkGachChan.Text = "Gach Chan (underline)";
            this.chkGachChan.UseVisualStyleBackColor = false;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chkItalic.Location = new System.Drawing.Point(20, 101);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(121, 19);
            this.chkItalic.TabIndex = 1;
            this.chkItalic.Text = "In Nghieng (Italic)";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBolt
            // 
            this.chkBolt.AutoSize = true;
            this.chkBolt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkBolt.Location = new System.Drawing.Point(20, 23);
            this.chkBolt.Name = "chkBolt";
            this.chkBolt.Size = new System.Drawing.Size(100, 19);
            this.chkBolt.TabIndex = 0;
            this.chkBolt.Text = "In Dam (Bolt)";
            this.chkBolt.UseVisualStyleBackColor = true;
            this.chkBolt.CheckedChanged += new System.EventHandler(this.chkBolt_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbFont);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.Text = "Dinh Dang";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.grbFont.ResumeLayout(false);
            this.grbFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private Label lblView;
        private Label lblResult;
        private Button btnExit;
        private GroupBox grbColor;
        private GroupBox grbFont;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private CheckBox chkGachChan;
        private CheckBox chkItalic;
        private CheckBox chkBolt;
        public RadioButton radRed;
    }
}