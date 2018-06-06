namespace UIMixedExercises {
    partial class UIExercise7 {
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
            this.components = new System.ComponentModel.Container();
            this.lblTArlindo = new System.Windows.Forms.Label();
            this.lblArlindo = new System.Windows.Forms.Label();
            this.lblManoel = new System.Windows.Forms.Label();
            this.lblTManoel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTAno = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTArlindo
            // 
            this.lblTArlindo.AutoSize = true;
            this.lblTArlindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTArlindo.Location = new System.Drawing.Point(12, 9);
            this.lblTArlindo.Name = "lblTArlindo";
            this.lblTArlindo.Size = new System.Drawing.Size(79, 25);
            this.lblTArlindo.TabIndex = 0;
            this.lblTArlindo.Text = "Arlindo";
            // 
            // lblArlindo
            // 
            this.lblArlindo.AutoSize = true;
            this.lblArlindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArlindo.Location = new System.Drawing.Point(190, 9);
            this.lblArlindo.Name = "lblArlindo";
            this.lblArlindo.Size = new System.Drawing.Size(76, 25);
            this.lblArlindo.TabIndex = 1;
            this.lblArlindo.Text = "150cm";
            this.lblArlindo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblManoel
            // 
            this.lblManoel.AutoSize = true;
            this.lblManoel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManoel.Location = new System.Drawing.Point(190, 34);
            this.lblManoel.Name = "lblManoel";
            this.lblManoel.Size = new System.Drawing.Size(76, 25);
            this.lblManoel.TabIndex = 3;
            this.lblManoel.Text = "110cm";
            this.lblManoel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTManoel
            // 
            this.lblTManoel.AutoSize = true;
            this.lblTManoel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTManoel.Location = new System.Drawing.Point(12, 34);
            this.lblTManoel.Name = "lblTManoel";
            this.lblTManoel.Size = new System.Drawing.Size(83, 25);
            this.lblTManoel.TabIndex = 2;
            this.lblTManoel.Text = "Manoel";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 125;
            this.timer.Tick += new System.EventHandler(this.tick);
            // 
            // lblTAno
            // 
            this.lblTAno.AutoSize = true;
            this.lblTAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTAno.Location = new System.Drawing.Point(12, 62);
            this.lblTAno.Name = "lblTAno";
            this.lblTAno.Size = new System.Drawing.Size(38, 20);
            this.lblTAno.TabIndex = 4;
            this.lblTAno.Text = "Ano";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(204, 62);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(18, 20);
            this.lblAno.TabIndex = 5;
            this.lblAno.Text = "0";
            this.lblAno.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UIExercise7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 94);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblTAno);
            this.Controls.Add(this.lblManoel);
            this.Controls.Add(this.lblTManoel);
            this.Controls.Add(this.lblArlindo);
            this.Controls.Add(this.lblTArlindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UIExercise7";
            this.Text = "UIExercise7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeWindow);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTArlindo;
        private System.Windows.Forms.Label lblArlindo;
        private System.Windows.Forms.Label lblManoel;
        private System.Windows.Forms.Label lblTManoel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTAno;
        private System.Windows.Forms.Label lblAno;
    }
}