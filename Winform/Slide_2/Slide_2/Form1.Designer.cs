namespace Slide_2
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblIntegerA = new System.Windows.Forms.Label();
            this.lblIntegerB = new System.Windows.Forms.Label();
            this.txtIntegerA = new System.Windows.Forms.TextBox();
            this.txtIntegerB = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnQuotient = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResult.Location = new System.Drawing.Point(0, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(658, 42);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblIntegerA
            // 
            this.lblIntegerA.AutoSize = true;
            this.lblIntegerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIntegerA.Location = new System.Drawing.Point(52, 76);
            this.lblIntegerA.Name = "lblIntegerA";
            this.lblIntegerA.Size = new System.Drawing.Size(58, 15);
            this.lblIntegerA.TabIndex = 1;
            this.lblIntegerA.Text = "Integer A:";
            // 
            // lblIntegerB
            // 
            this.lblIntegerB.AutoSize = true;
            this.lblIntegerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIntegerB.Location = new System.Drawing.Point(52, 132);
            this.lblIntegerB.Name = "lblIntegerB";
            this.lblIntegerB.Size = new System.Drawing.Size(57, 15);
            this.lblIntegerB.TabIndex = 2;
            this.lblIntegerB.Text = "Integer B:";
            // 
            // txtIntegerA
            // 
            this.txtIntegerA.Location = new System.Drawing.Point(166, 68);
            this.txtIntegerA.Name = "txtIntegerA";
            this.txtIntegerA.Size = new System.Drawing.Size(282, 23);
            this.txtIntegerA.TabIndex = 3;
            this.txtIntegerA.TextChanged += new System.EventHandler(this.txtIntegerA_TextChanged);
            // 
            // txtIntegerB
            // 
            this.txtIntegerB.Location = new System.Drawing.Point(166, 124);
            this.txtIntegerB.Name = "txtIntegerB";
            this.txtIntegerB.Size = new System.Drawing.Size(282, 23);
            this.txtIntegerB.TabIndex = 4;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(96, 208);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(103, 39);
            this.btnSum.TabIndex = 5;
            this.btnSum.Text = "&Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnQuotient
            // 
            this.btnQuotient.Location = new System.Drawing.Point(296, 208);
            this.btnQuotient.Name = "btnQuotient";
            this.btnQuotient.Size = new System.Drawing.Size(103, 39);
            this.btnQuotient.TabIndex = 6;
            this.btnQuotient.Text = "&Quotient";
            this.btnQuotient.UseVisualStyleBackColor = true;
            this.btnQuotient.Click += new System.EventHandler(this.btnQuotient_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(497, 208);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 39);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "R&eset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(296, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 39);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(658, 404);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnQuotient);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtIntegerB);
            this.Controls.Add(this.txtIntegerA);
            this.Controls.Add(this.lblIntegerB);
            this.Controls.Add(this.lblIntegerA);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblResult;
        private Label lblIntegerA;
        private Label lblIntegerB;
        private TextBox txtIntegerA;
        private TextBox txtIntegerB;
        private Button btnSum;
        private Button btnQuotient;
        private Button btnReset;
        private Button btnExit;
    }
}