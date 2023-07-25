namespace Linq
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
            this.cbbData = new System.Windows.Forms.ComboBox();
            this.txtFillter = new System.Windows.Forms.TextBox();
            this.btnFiltter = new System.Windows.Forms.Button();
            this.cbbResult = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbbData
            // 
            this.cbbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbbData.FormattingEnabled = true;
            this.cbbData.Location = new System.Drawing.Point(21, 41);
            this.cbbData.Name = "cbbData";
            this.cbbData.Size = new System.Drawing.Size(143, 165);
            this.cbbData.TabIndex = 0;
            // 
            // txtFillter
            // 
            this.txtFillter.Location = new System.Drawing.Point(21, 12);
            this.txtFillter.Name = "txtFillter";
            this.txtFillter.Size = new System.Drawing.Size(120, 23);
            this.txtFillter.TabIndex = 2;
            // 
            // btnFiltter
            // 
            this.btnFiltter.Location = new System.Drawing.Point(193, 12);
            this.btnFiltter.Name = "btnFiltter";
            this.btnFiltter.Size = new System.Drawing.Size(75, 23);
            this.btnFiltter.TabIndex = 3;
            this.btnFiltter.Text = "Filter";
            this.btnFiltter.UseVisualStyleBackColor = true;
            this.btnFiltter.Click += new System.EventHandler(this.btnFiltter_Click);
            // 
            // cbbResult
            // 
            this.cbbResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbbResult.FormattingEnabled = true;
            this.cbbResult.Location = new System.Drawing.Point(178, 41);
            this.cbbResult.Name = "cbbResult";
            this.cbbResult.Size = new System.Drawing.Size(147, 172);
            this.cbbResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 228);
            this.Controls.Add(this.cbbResult);
            this.Controls.Add(this.btnFiltter);
            this.Controls.Add(this.txtFillter);
            this.Controls.Add(this.cbbData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbbData;
        private TextBox txtFillter;
        private Button btnFiltter;
        private ComboBox cbbResult;
    }
}