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
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnAddPow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPoints
            // 
            this.lblPoints.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(193, 40);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(105, 30);
            this.lblPoints.TabIndex = 0;
            this.lblPoints.Text = "this.points";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPoints.UseCompatibleTextRendering = true;
            this.lblPoints.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addPoints);
            // 
            // btnAddPow
            // 
            this.btnAddPow.Location = new System.Drawing.Point(12, 82);
            this.btnAddPow.Name = "btnAddPow";
            this.btnAddPow.Size = new System.Drawing.Size(467, 176);
            this.btnAddPow.TabIndex = 1;
            this.btnAddPow.Text = "pow++;";
            this.btnAddPow.UseVisualStyleBackColor = true;
            this.btnAddPow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addPow);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 270);
            this.Controls.Add(this.btnAddPow);
            this.Controls.Add(this.lblPoints);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "WindowName";
            this.TransparencyKey = System.Drawing.SystemColors.Info;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnAddPow;
    }
}

