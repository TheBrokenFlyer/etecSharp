namespace dtbApplication
{
    partial class FrmRegister
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
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.dtbContestants = new System.Windows.Forms.DataGridView();
            this.idPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personResponseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personResponseScoreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._DataSet = new dtbApplication._DataSet();
            this.tabsPanel = new System.Windows.Forms.TabControl();
            this.tabVote = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtVote = new System.Windows.Forms.TextBox();
            this.lblVote = new System.Windows.Forms.Label();
            this.dtbVotes = new System.Windows.Forms.DataGridView();
            this.idPersonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personResponseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personResponseScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPersonTableAdapter = new dtbApplication._DataSetTableAdapters.tbPersonTableAdapter();
            this.tabRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbContestants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DataSet)).BeginInit();
            this.tabsPanel.SuspendLayout();
            this.tabVote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbVotes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRegister
            // 
            this.tabRegister.BackColor = System.Drawing.SystemColors.Control;
            this.tabRegister.Controls.Add(this.splitContainer3);
            this.tabRegister.Location = new System.Drawing.Point(4, 22);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(868, 416);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Register";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer3.Panel1.Controls.Add(this.txtName);
            this.splitContainer3.Panel1.Controls.Add(this.lblResponse);
            this.splitContainer3.Panel1.Controls.Add(this.btnRegister);
            this.splitContainer3.Panel1.Controls.Add(this.lblName);
            this.splitContainer3.Panel1.Controls.Add(this.txtResponse);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dtbContestants);
            this.splitContainer3.Size = new System.Drawing.Size(862, 410);
            this.splitContainer3.SplitterDistance = 449;
            this.splitContainer3.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSearch.Location = new System.Drawing.Point(221, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.AllowDrop = true;
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(140, 162);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 26);
            this.txtName.TabIndex = 2;
            this.txtName.Tag = "name";
            // 
            // lblResponse
            // 
            this.lblResponse.AllowDrop = true;
            this.lblResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse.Location = new System.Drawing.Point(52, 197);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(82, 20);
            this.lblResponse.TabIndex = 1;
            this.lblResponse.Tag = "response";
            this.lblResponse.Text = "Response";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRegister.Location = new System.Drawing.Point(140, 226);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.registerPerson);
            // 
            // lblName
            // 
            this.lblName.AllowDrop = true;
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(52, 165);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Tag = "name";
            this.lblName.Text = "Name";
            // 
            // txtResponse
            // 
            this.txtResponse.AllowDrop = true;
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponse.Location = new System.Drawing.Point(140, 194);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(256, 26);
            this.txtResponse.TabIndex = 3;
            this.txtResponse.Tag = "response";
            // 
            // dtbContestants
            // 
            this.dtbContestants.AllowUserToAddRows = false;
            this.dtbContestants.AllowUserToDeleteRows = false;
            this.dtbContestants.AutoGenerateColumns = false;
            this.dtbContestants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbContestants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonDataGridViewTextBoxColumn,
            this.personNameDataGridViewTextBoxColumn,
            this.personResponseDataGridViewTextBoxColumn,
            this.personResponseScoreDataGridViewTextBoxColumn1});
            this.dtbContestants.DataSource = this.tbPersonBindingSource;
            this.dtbContestants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtbContestants.Location = new System.Drawing.Point(0, 0);
            this.dtbContestants.Name = "dtbContestants";
            this.dtbContestants.ReadOnly = true;
            this.dtbContestants.Size = new System.Drawing.Size(409, 410);
            this.dtbContestants.TabIndex = 0;
            // 
            // idPersonDataGridViewTextBoxColumn
            // 
            this.idPersonDataGridViewTextBoxColumn.DataPropertyName = "idPerson";
            this.idPersonDataGridViewTextBoxColumn.HeaderText = "idPerson";
            this.idPersonDataGridViewTextBoxColumn.Name = "idPersonDataGridViewTextBoxColumn";
            this.idPersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personNameDataGridViewTextBoxColumn
            // 
            this.personNameDataGridViewTextBoxColumn.DataPropertyName = "personName";
            this.personNameDataGridViewTextBoxColumn.HeaderText = "personName";
            this.personNameDataGridViewTextBoxColumn.Name = "personNameDataGridViewTextBoxColumn";
            this.personNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personResponseDataGridViewTextBoxColumn
            // 
            this.personResponseDataGridViewTextBoxColumn.DataPropertyName = "personResponse";
            this.personResponseDataGridViewTextBoxColumn.HeaderText = "personResponse";
            this.personResponseDataGridViewTextBoxColumn.Name = "personResponseDataGridViewTextBoxColumn";
            this.personResponseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personResponseScoreDataGridViewTextBoxColumn1
            // 
            this.personResponseScoreDataGridViewTextBoxColumn1.DataPropertyName = "personResponseScore";
            this.personResponseScoreDataGridViewTextBoxColumn1.HeaderText = "personResponseScore";
            this.personResponseScoreDataGridViewTextBoxColumn1.Name = "personResponseScoreDataGridViewTextBoxColumn1";
            this.personResponseScoreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tbPersonBindingSource
            // 
            this.tbPersonBindingSource.DataMember = "tbPerson";
            this.tbPersonBindingSource.DataSource = this._DataSet;
            // 
            // _DataSet
            // 
            this._DataSet.DataSetName = "_DataSet";
            this._DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabsPanel
            // 
            this.tabsPanel.Controls.Add(this.tabRegister);
            this.tabsPanel.Controls.Add(this.tabVote);
            this.tabsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsPanel.Location = new System.Drawing.Point(0, 0);
            this.tabsPanel.Name = "tabsPanel";
            this.tabsPanel.SelectedIndex = 0;
            this.tabsPanel.Size = new System.Drawing.Size(876, 442);
            this.tabsPanel.TabIndex = 0;
            // 
            // tabVote
            // 
            this.tabVote.BackColor = System.Drawing.SystemColors.Control;
            this.tabVote.Controls.Add(this.splitContainer2);
            this.tabVote.Location = new System.Drawing.Point(4, 22);
            this.tabVote.Name = "tabVote";
            this.tabVote.Size = new System.Drawing.Size(868, 416);
            this.tabVote.TabIndex = 1;
            this.tabVote.Text = "Vote";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblInstructions);
            this.splitContainer2.Panel1.Controls.Add(this.txtVote);
            this.splitContainer2.Panel1.Controls.Add(this.lblVote);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dtbVotes);
            this.splitContainer2.Size = new System.Drawing.Size(868, 416);
            this.splitContainer2.SplitterDistance = 443;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(160, 216);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(122, 13);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "format: X>X>X>X>X>[...]";
            // 
            // txtVote
            // 
            this.txtVote.AllowDrop = true;
            this.txtVote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVote.Location = new System.Drawing.Point(122, 187);
            this.txtVote.Name = "txtVote";
            this.txtVote.Size = new System.Drawing.Size(256, 26);
            this.txtVote.TabIndex = 3;
            this.txtVote.Tag = "name";
            // 
            // lblVote
            // 
            this.lblVote.AllowDrop = true;
            this.lblVote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblVote.AutoSize = true;
            this.lblVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVote.Location = new System.Drawing.Point(65, 190);
            this.lblVote.Name = "lblVote";
            this.lblVote.Size = new System.Drawing.Size(43, 20);
            this.lblVote.TabIndex = 4;
            this.lblVote.Tag = "name";
            this.lblVote.Text = "Vote";
            // 
            // dtbVotes
            // 
            this.dtbVotes.AllowUserToAddRows = false;
            this.dtbVotes.AllowUserToDeleteRows = false;
            this.dtbVotes.AutoGenerateColumns = false;
            this.dtbVotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbVotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonDataGridViewTextBoxColumn1,
            this.personNameDataGridViewTextBoxColumn1,
            this.personResponseDataGridViewTextBoxColumn1,
            this.personResponseScoreDataGridViewTextBoxColumn});
            this.dtbVotes.DataSource = this.tbPersonBindingSource;
            this.dtbVotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtbVotes.Location = new System.Drawing.Point(0, 0);
            this.dtbVotes.Name = "dtbVotes";
            this.dtbVotes.ReadOnly = true;
            this.dtbVotes.Size = new System.Drawing.Size(421, 416);
            this.dtbVotes.TabIndex = 0;
            // 
            // idPersonDataGridViewTextBoxColumn1
            // 
            this.idPersonDataGridViewTextBoxColumn1.DataPropertyName = "idPerson";
            this.idPersonDataGridViewTextBoxColumn1.HeaderText = "idPerson";
            this.idPersonDataGridViewTextBoxColumn1.Name = "idPersonDataGridViewTextBoxColumn1";
            this.idPersonDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // personNameDataGridViewTextBoxColumn1
            // 
            this.personNameDataGridViewTextBoxColumn1.DataPropertyName = "personName";
            this.personNameDataGridViewTextBoxColumn1.HeaderText = "personName";
            this.personNameDataGridViewTextBoxColumn1.Name = "personNameDataGridViewTextBoxColumn1";
            this.personNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // personResponseDataGridViewTextBoxColumn1
            // 
            this.personResponseDataGridViewTextBoxColumn1.DataPropertyName = "personResponse";
            this.personResponseDataGridViewTextBoxColumn1.HeaderText = "personResponse";
            this.personResponseDataGridViewTextBoxColumn1.Name = "personResponseDataGridViewTextBoxColumn1";
            this.personResponseDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // personResponseScoreDataGridViewTextBoxColumn
            // 
            this.personResponseScoreDataGridViewTextBoxColumn.DataPropertyName = "personResponseScore";
            this.personResponseScoreDataGridViewTextBoxColumn.HeaderText = "personResponseScore";
            this.personResponseScoreDataGridViewTextBoxColumn.Name = "personResponseScoreDataGridViewTextBoxColumn";
            this.personResponseScoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbPersonTableAdapter
            // 
            this.tbPersonTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 442);
            this.Controls.Add(this.tabsPanel);
            this.Name = "FrmRegister";
            this.Text = "TWOW prototype thing";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.tabRegister.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtbContestants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DataSet)).EndInit();
            this.tabsPanel.ResumeLayout(false);
            this.tabVote.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtbVotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _DataSet _DataSet;
        private System.Windows.Forms.BindingSource tbPersonBindingSource;
        private _DataSetTableAdapters.tbPersonTableAdapter tbPersonTableAdapter;
        private System.Windows.Forms.TabControl tabsPanel;
        private System.Windows.Forms.TabPage tabRegister;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.TextBox txtResponse;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label lblResponse;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabVote;
        public System.Windows.Forms.Label lblVote;
        public System.Windows.Forms.TextBox txtVote;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dtbContestants;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dtbVotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personResponseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personResponseScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personResponseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personResponseScoreDataGridViewTextBoxColumn1;
    }
}

