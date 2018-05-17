namespace WindowsFormsApplication1
{
    partial class windowMain
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
            this.components = new System.ComponentModel.Container();
            this.btnLose = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnLose
            // 
            this.btnLose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLose.Location = new System.Drawing.Point(12, 12);
            this.btnLose.Name = "btnLose";
            this.btnLose.Size = new System.Drawing.Size(30, 22);
            this.btnLose.TabIndex = 1;
            this.btnLose.UseVisualStyleBackColor = true;
            // 
            // btnPoint
            // 
            this.btnPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPoint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.Location = new System.Drawing.Point(12, 12);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(30, 22);
            this.btnPoint.TabIndex = 2;
            this.btnPoint.TabStop = false;
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.keyAddPoints);
            this.btnPoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyAddPoints);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.keyMinusPoints);
            // 
            // windowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(54, 46);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnLose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "windowMain";
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.SystemColors.Info;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLose;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Timer timer1;
    }
}

