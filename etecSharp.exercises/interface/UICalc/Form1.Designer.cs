namespace WindowsFormsApplication1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.statMain = new System.Windows.Forms.StatusStrip();
            this.statFuncType = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSum = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.statMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(94, 140);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(82, 20);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "lblOutput";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVal2
            // 
            this.txtVal2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVal2.Location = new System.Drawing.Point(56, 40);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(152, 20);
            this.txtVal2.TabIndex = 1;
            this.txtVal2.Text = "0";
            this.txtVal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVal2.TextChanged += new System.EventHandler(this.updateOutput);
            // 
            // txtVal1
            // 
            this.txtVal1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVal1.Location = new System.Drawing.Point(56, 14);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(152, 20);
            this.txtVal1.TabIndex = 0;
            this.txtVal1.Text = "0";
            this.txtVal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVal1.TextChanged += new System.EventHandler(this.updateOutput);
            // 
            // statMain
            // 
            this.statMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statFuncType});
            this.statMain.Location = new System.Drawing.Point(0, 181);
            this.statMain.Name = "statMain";
            this.statMain.Size = new System.Drawing.Size(265, 22);
            this.statMain.SizingGrip = false;
            this.statMain.TabIndex = 7;
            this.statMain.Text = "statusStrip1";
            // 
            // statFuncType
            // 
            this.statFuncType.Name = "statFuncType";
            this.statFuncType.Size = new System.Drawing.Size(78, 17);
            this.statFuncType.Text = "statFuncType";
            // 
            // btnSum
            // 
            this.btnSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(56, 67);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(32, 32);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setSum);
            this.btnSum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.updateOutput);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(96, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setSub);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.updateOutput);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(136, 67);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setMul);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.updateOutput);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(176, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setDiv);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.updateOutput);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 203);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.statMain);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.lblOutput);
            this.Name = "Form1";
            this.Text = "1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setSum);
            this.statMain.ResumeLayout(false);
            this.statMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.StatusStrip statMain;
        private System.Windows.Forms.ToolStripStatusLabel statFuncType;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

