namespace WindowsFormsApplication1 {
    partial class UILargeof3 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.numVal1 = new System.Windows.Forms.NumericUpDown();
            this.numVal2 = new System.Windows.Forms.NumericUpDown();
            this.numVal3 = new System.Windows.Forms.NumericUpDown();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numVal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVal3)).BeginInit();
            this.SuspendLayout();
            // 
            // numVal1
            // 
            this.numVal1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numVal1.AutoSize = true;
            this.numVal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numVal1.Location = new System.Drawing.Point(35, 12);
            this.numVal1.Name = "numVal1";
            this.numVal1.Size = new System.Drawing.Size(165, 20);
            this.numVal1.TabIndex = 1;
            this.numVal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVal1.ValueChanged += new System.EventHandler(this.numberUpdate);
            // 
            // numVal2
            // 
            this.numVal2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numVal2.AutoSize = true;
            this.numVal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numVal2.Location = new System.Drawing.Point(35, 38);
            this.numVal2.Name = "numVal2";
            this.numVal2.Size = new System.Drawing.Size(165, 20);
            this.numVal2.TabIndex = 3;
            this.numVal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVal2.ValueChanged += new System.EventHandler(this.numberUpdate);
            // 
            // numVal3
            // 
            this.numVal3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numVal3.AutoSize = true;
            this.numVal3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numVal3.Location = new System.Drawing.Point(35, 64);
            this.numVal3.Name = "numVal3";
            this.numVal3.Size = new System.Drawing.Size(165, 20);
            this.numVal3.TabIndex = 5;
            this.numVal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVal3.ValueChanged += new System.EventHandler(this.numberUpdate);
            // 
            // txtOut
            // 
            this.txtOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(12, 155);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(188, 31);
            this.txtOut.TabIndex = 7;
            this.txtOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOut
            // 
            this.lblOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(8, 132);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(67, 20);
            this.lblOut.TabIndex = 6;
            this.lblOut.Text = "Largest:";
            // 
            // lblA
            // 
            this.lblA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 14);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A: ";
            // 
            // lblB
            // 
            this.lblB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 40);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(20, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B: ";
            // 
            // lblC
            // 
            this.lblC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(12, 66);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(20, 13);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "C: ";
            // 
            // UILargeof3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 198);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.numVal3);
            this.Controls.Add(this.numVal2);
            this.Controls.Add(this.numVal1);
            this.Name = "UILargeof3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Largest of 3";
            ((System.ComponentModel.ISupportInitialize)(this.numVal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVal3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numVal1;
        private System.Windows.Forms.NumericUpDown numVal2;
        private System.Windows.Forms.NumericUpDown numVal3;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
    }
}

