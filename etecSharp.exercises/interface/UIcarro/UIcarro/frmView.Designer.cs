namespace carro
{
	partial class frmView
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
			this.dgv = new System.Windows.Forms.DataGridView();
			this.lblID = new System.Windows.Forms.Label();
			this.lblVal = new System.Windows.Forms.Label();
			this.mtxtano = new System.Windows.Forms.MaskedTextBox();
			this.cmbmarca = new System.Windows.Forms.ComboBox();
			this.txtmodelo = new System.Windows.Forms.TextBox();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv
			// 
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToDeleteRows = false;
			this.dgv.AllowUserToResizeRows = false;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgv.Location = new System.Drawing.Point(337, 12);
			this.dgv.MultiSelect = false;
			this.dgv.Name = "dgv";
			this.dgv.ReadOnly = true;
			this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv.Size = new System.Drawing.Size(453, 359);
			this.dgv.TabIndex = 0;
			this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.click);
			this.dgv.SelectionChanged += new System.EventHandler(this.click);
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(75, 24);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(21, 13);
			this.lblID.TabIndex = 7;
			this.lblID.Text = "ID:";
			// 
			// lblVal
			// 
			this.lblVal.AutoSize = true;
			this.lblVal.Location = new System.Drawing.Point(262, 24);
			this.lblVal.Name = "lblVal";
			this.lblVal.Size = new System.Drawing.Size(19, 13);
			this.lblVal.TabIndex = 6;
			this.lblVal.Text = "----";
			this.lblVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mtxtano
			// 
			this.mtxtano.Location = new System.Drawing.Point(252, 44);
			this.mtxtano.Mask = "0000";
			this.mtxtano.Name = "mtxtano";
			this.mtxtano.Size = new System.Drawing.Size(29, 20);
			this.mtxtano.TabIndex = 5;
			this.mtxtano.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// cmbmarca
			// 
			this.cmbmarca.FormattingEnabled = true;
			this.cmbmarca.Location = new System.Drawing.Point(75, 71);
			this.cmbmarca.Name = "cmbmarca";
			this.cmbmarca.Size = new System.Drawing.Size(206, 21);
			this.cmbmarca.TabIndex = 4;
			// 
			// txtmodelo
			// 
			this.txtmodelo.Location = new System.Drawing.Point(75, 44);
			this.txtmodelo.Name = "txtmodelo";
			this.txtmodelo.Size = new System.Drawing.Size(171, 20);
			this.txtmodelo.TabIndex = 3;
			// 
			// btnDeletar
			// 
			this.btnDeletar.Location = new System.Drawing.Point(110, 98);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(29, 23);
			this.btnDeletar.TabIndex = 2;
			this.btnDeletar.Text = "-";
			this.btnDeletar.UseVisualStyleBackColor = true;
			this.btnDeletar.Click += new System.EventHandler(this.deletar);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Location = new System.Drawing.Point(75, 98);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(29, 23);
			this.btnAdicionar.TabIndex = 1;
			this.btnAdicionar.Text = "+";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.adicionar);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(252, 98);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(29, 23);
			this.btnPesquisar.TabIndex = 0;
			this.btnPesquisar.Text = "?";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisar);
			// 
			// frmView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(802, 383);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.lblVal);
			this.Controls.Add(this.mtxtano);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.cmbmarca);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.txtmodelo);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.btnDeletar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmView";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.ComboBox cmbmarca;
		private System.Windows.Forms.TextBox txtmodelo;
		private System.Windows.Forms.Button btnDeletar;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.MaskedTextBox mtxtano;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label lblVal;
	}
}

