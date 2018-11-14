namespace basicIO
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
			this.lblUsuario = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblSenha = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.cmbUsr = new System.Windows.Forms.ComboBox();
			this.cmbDepto = new System.Windows.Forms.ComboBox();
			this.lblDepto = new System.Windows.Forms.Label();
			this.btnCad = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(28, 81);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(89, 22);
			this.lblUsuario.TabIndex = 0;
			this.lblUsuario.Text = "Usuário:";
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(32, 172);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(104, 39);
			this.btnLogin.TabIndex = 1;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.login);
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.Location = new System.Drawing.Point(28, 117);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(76, 22);
			this.lblSenha.TabIndex = 2;
			this.lblSenha.Text = "Senha:";
			// 
			// txtPass
			// 
			this.txtPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPass.Location = new System.Drawing.Point(129, 114);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(112, 29);
			this.txtPass.TabIndex = 4;
			// 
			// cmbUsr
			// 
			this.cmbUsr.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbUsr.FormattingEnabled = true;
			this.cmbUsr.Location = new System.Drawing.Point(129, 78);
			this.cmbUsr.Name = "cmbUsr";
			this.cmbUsr.Size = new System.Drawing.Size(112, 30);
			this.cmbUsr.TabIndex = 5;
			// 
			// cmbDepto
			// 
			this.cmbDepto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbDepto.FormattingEnabled = true;
			this.cmbDepto.Location = new System.Drawing.Point(129, 42);
			this.cmbDepto.Name = "cmbDepto";
			this.cmbDepto.Size = new System.Drawing.Size(112, 30);
			this.cmbDepto.TabIndex = 7;
			this.cmbDepto.SelectedIndexChanged += new System.EventHandler(this.depto);
			// 
			// lblDepto
			// 
			this.lblDepto.AutoSize = true;
			this.lblDepto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDepto.Location = new System.Drawing.Point(28, 45);
			this.lblDepto.Name = "lblDepto";
			this.lblDepto.Size = new System.Drawing.Size(77, 22);
			this.lblDepto.TabIndex = 6;
			this.lblDepto.Text = "Depto.:";
			// 
			// btnCad
			// 
			this.btnCad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCad.Location = new System.Drawing.Point(142, 172);
			this.btnCad.Name = "btnCad";
			this.btnCad.Size = new System.Drawing.Size(111, 39);
			this.btnCad.TabIndex = 8;
			this.btnCad.Text = "Cadastrar";
			this.btnCad.UseVisualStyleBackColor = true;
			this.btnCad.Click += new System.EventHandler(this.cadastrar);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnCad);
			this.Controls.Add(this.cmbDepto);
			this.Controls.Add(this.lblDepto);
			this.Controls.Add(this.cmbUsr);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.lblUsuario);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.ComboBox cmbUsr;
		private System.Windows.Forms.ComboBox cmbDepto;
		private System.Windows.Forms.Label lblDepto;
		private System.Windows.Forms.Button btnCad;
	}
}

