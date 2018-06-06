namespace UIMixedExercises {
    partial class UIExercise4 {
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
            this.listMonth = new System.Windows.Forms.ListBox();
            this.lblT = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listMonth
            // 
            this.listMonth.FormattingEnabled = true;
            this.listMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.listMonth.Location = new System.Drawing.Point(13, 13);
            this.listMonth.Name = "listMonth";
            this.listMonth.Size = new System.Drawing.Size(53, 160);
            this.listMonth.TabIndex = 0;
            this.listMonth.SelectedIndexChanged += new System.EventHandler(this.update);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(72, 13);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(84, 25);
            this.lblT.TabIndex = 1;
            this.lblT.Text = "Month:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(77, 42);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(129, 25);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "not selected";
            // 
            // UIExercise4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 190);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.listMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UIExercise4";
            this.Text = "UIExercise4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeWindow);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMonth;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblMonth;
    }
}