namespace UIProg
{
    partial class FrmVotes
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabVoter = new System.Windows.Forms.TabPage();
            this.btnVoterClear = new System.Windows.Forms.Button();
            this.lblVoterGuardian = new System.Windows.Forms.Label();
            this.txtVoterGuardian = new System.Windows.Forms.TextBox();
            this.lblVoterPhone = new System.Windows.Forms.Label();
            this.lblVoterAddress = new System.Windows.Forms.Label();
            this.txtVoterPhone = new System.Windows.Forms.TextBox();
            this.txtVoterAddress = new System.Windows.Forms.TextBox();
            this.btnVoter = new System.Windows.Forms.Button();
            this.lblVoterRn = new System.Windows.Forms.Label();
            this.lblVoterName = new System.Windows.Forms.Label();
            this.txtVoterRn = new System.Windows.Forms.TextBox();
            this.txtVoterName = new System.Windows.Forms.TextBox();
            this.tabCandidate = new System.Windows.Forms.TabPage();
            this.btnCandidate = new System.Windows.Forms.Button();
            this.txtCandidateRn = new System.Windows.Forms.TextBox();
            this.lblCandidateRn = new System.Windows.Forms.Label();
            this.tabVote = new System.Windows.Forms.TabPage();
            this.btnVote = new System.Windows.Forms.Button();
            this.lblVoteCandidate = new System.Windows.Forms.Label();
            this.lblVoteRn = new System.Windows.Forms.Label();
            this.txtVoteCandidate = new System.Windows.Forms.TextBox();
            this.txtVoteRn = new System.Windows.Forms.TextBox();
            this.txtVoterSearch = new System.Windows.Forms.TextBox();
            this.dataviewVoters = new System.Windows.Forms.DataGridView();
            this.dataviewCandidates = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabVoter.SuspendLayout();
            this.tabCandidate.SuspendLayout();
            this.tabVote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewVoters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewCandidates)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVoter);
            this.tabControl.Controls.Add(this.tabCandidate);
            this.tabControl.Controls.Add(this.tabVote);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(478, 435);
            this.tabControl.TabIndex = 0;
            // 
            // tabVoter
            // 
            this.tabVoter.BackColor = System.Drawing.SystemColors.Control;
            this.tabVoter.Controls.Add(this.dataviewVoters);
            this.tabVoter.Controls.Add(this.txtVoterSearch);
            this.tabVoter.Controls.Add(this.btnVoterClear);
            this.tabVoter.Controls.Add(this.lblVoterGuardian);
            this.tabVoter.Controls.Add(this.txtVoterGuardian);
            this.tabVoter.Controls.Add(this.lblVoterPhone);
            this.tabVoter.Controls.Add(this.lblVoterAddress);
            this.tabVoter.Controls.Add(this.txtVoterPhone);
            this.tabVoter.Controls.Add(this.txtVoterAddress);
            this.tabVoter.Controls.Add(this.btnVoter);
            this.tabVoter.Controls.Add(this.lblVoterRn);
            this.tabVoter.Controls.Add(this.lblVoterName);
            this.tabVoter.Controls.Add(this.txtVoterRn);
            this.tabVoter.Controls.Add(this.txtVoterName);
            this.tabVoter.Location = new System.Drawing.Point(4, 22);
            this.tabVoter.Name = "tabVoter";
            this.tabVoter.Padding = new System.Windows.Forms.Padding(3);
            this.tabVoter.Size = new System.Drawing.Size(470, 409);
            this.tabVoter.TabIndex = 0;
            this.tabVoter.Text = "Add voter";
            // 
            // btnVoterClear
            // 
            this.btnVoterClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoterClear.Location = new System.Drawing.Point(238, 167);
            this.btnVoterClear.Name = "btnVoterClear";
            this.btnVoterClear.Size = new System.Drawing.Size(75, 23);
            this.btnVoterClear.TabIndex = 11;
            this.btnVoterClear.Text = "Clear";
            this.btnVoterClear.UseVisualStyleBackColor = true;
            // 
            // lblVoterGuardian
            // 
            this.lblVoterGuardian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoterGuardian.AutoSize = true;
            this.lblVoterGuardian.Location = new System.Drawing.Point(78, 144);
            this.lblVoterGuardian.Name = "lblVoterGuardian";
            this.lblVoterGuardian.Size = new System.Drawing.Size(79, 13);
            this.lblVoterGuardian.TabIndex = 8;
            this.lblVoterGuardian.Text = "Guardian name";
            // 
            // txtVoterGuardian
            // 
            this.txtVoterGuardian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVoterGuardian.Location = new System.Drawing.Point(169, 141);
            this.txtVoterGuardian.Name = "txtVoterGuardian";
            this.txtVoterGuardian.Size = new System.Drawing.Size(256, 20);
            this.txtVoterGuardian.TabIndex = 9;
            // 
            // lblVoterPhone
            // 
            this.lblVoterPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoterPhone.AutoSize = true;
            this.lblVoterPhone.Location = new System.Drawing.Point(70, 118);
            this.lblVoterPhone.Name = "lblVoterPhone";
            this.lblVoterPhone.Size = new System.Drawing.Size(38, 13);
            this.lblVoterPhone.TabIndex = 6;
            this.lblVoterPhone.Text = "Phone";
            // 
            // lblVoterAddress
            // 
            this.lblVoterAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoterAddress.AutoSize = true;
            this.lblVoterAddress.Location = new System.Drawing.Point(62, 92);
            this.lblVoterAddress.Name = "lblVoterAddress";
            this.lblVoterAddress.Size = new System.Drawing.Size(45, 13);
            this.lblVoterAddress.TabIndex = 4;
            this.lblVoterAddress.Text = "Address";
            // 
            // txtVoterPhone
            // 
            this.txtVoterPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVoterPhone.Location = new System.Drawing.Point(161, 115);
            this.txtVoterPhone.Name = "txtVoterPhone";
            this.txtVoterPhone.Size = new System.Drawing.Size(256, 20);
            this.txtVoterPhone.TabIndex = 7;
            // 
            // txtVoterAddress
            // 
            this.txtVoterAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVoterAddress.Location = new System.Drawing.Point(153, 89);
            this.txtVoterAddress.Name = "txtVoterAddress";
            this.txtVoterAddress.Size = new System.Drawing.Size(256, 20);
            this.txtVoterAddress.TabIndex = 5;
            // 
            // btnVoter
            // 
            this.btnVoter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoter.Location = new System.Drawing.Point(157, 167);
            this.btnVoter.Name = "btnVoter";
            this.btnVoter.Size = new System.Drawing.Size(75, 23);
            this.btnVoter.TabIndex = 10;
            this.btnVoter.Text = "Insert voter";
            this.btnVoter.UseVisualStyleBackColor = true;
            // 
            // lblVoterRn
            // 
            this.lblVoterRn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoterRn.AutoSize = true;
            this.lblVoterRn.Location = new System.Drawing.Point(54, 65);
            this.lblVoterRn.Name = "lblVoterRn";
            this.lblVoterRn.Size = new System.Drawing.Size(23, 13);
            this.lblVoterRn.TabIndex = 2;
            this.lblVoterRn.Text = "RN";
            // 
            // lblVoterName
            // 
            this.lblVoterName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoterName.AutoSize = true;
            this.lblVoterName.Location = new System.Drawing.Point(46, 39);
            this.lblVoterName.Name = "lblVoterName";
            this.lblVoterName.Size = new System.Drawing.Size(35, 13);
            this.lblVoterName.TabIndex = 0;
            this.lblVoterName.Text = "Name";
            // 
            // txtVoterRn
            // 
            this.txtVoterRn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVoterRn.Location = new System.Drawing.Point(145, 62);
            this.txtVoterRn.Name = "txtVoterRn";
            this.txtVoterRn.Size = new System.Drawing.Size(256, 20);
            this.txtVoterRn.TabIndex = 3;
            // 
            // txtVoterName
            // 
            this.txtVoterName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVoterName.Location = new System.Drawing.Point(137, 36);
            this.txtVoterName.Name = "txtVoterName";
            this.txtVoterName.Size = new System.Drawing.Size(256, 20);
            this.txtVoterName.TabIndex = 1;
            // 
            // tabCandidate
            // 
            this.tabCandidate.BackColor = System.Drawing.SystemColors.Control;
            this.tabCandidate.Controls.Add(this.dataviewCandidates);
            this.tabCandidate.Controls.Add(this.btnCandidate);
            this.tabCandidate.Controls.Add(this.txtCandidateRn);
            this.tabCandidate.Controls.Add(this.lblCandidateRn);
            this.tabCandidate.Location = new System.Drawing.Point(4, 22);
            this.tabCandidate.Name = "tabCandidate";
            this.tabCandidate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCandidate.Size = new System.Drawing.Size(470, 409);
            this.tabCandidate.TabIndex = 1;
            this.tabCandidate.Text = "Add candidate";
            // 
            // btnCandidate
            // 
            this.btnCandidate.Location = new System.Drawing.Point(198, 378);
            this.btnCandidate.Name = "btnCandidate";
            this.btnCandidate.Size = new System.Drawing.Size(75, 23);
            this.btnCandidate.TabIndex = 3;
            this.btnCandidate.Text = "Add candidate";
            this.btnCandidate.UseVisualStyleBackColor = true;
            // 
            // txtCandidateRn
            // 
            this.txtCandidateRn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCandidateRn.Location = new System.Drawing.Point(147, 352);
            this.txtCandidateRn.Name = "txtCandidateRn";
            this.txtCandidateRn.Size = new System.Drawing.Size(256, 20);
            this.txtCandidateRn.TabIndex = 2;
            // 
            // lblCandidateRn
            // 
            this.lblCandidateRn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCandidateRn.AutoSize = true;
            this.lblCandidateRn.Location = new System.Drawing.Point(67, 355);
            this.lblCandidateRn.Name = "lblCandidateRn";
            this.lblCandidateRn.Size = new System.Drawing.Size(74, 13);
            this.lblCandidateRn.TabIndex = 1;
            this.lblCandidateRn.Text = "Candidate RN";
            // 
            // tabVote
            // 
            this.tabVote.Controls.Add(this.btnVote);
            this.tabVote.Controls.Add(this.lblVoteCandidate);
            this.tabVote.Controls.Add(this.lblVoteRn);
            this.tabVote.Controls.Add(this.txtVoteCandidate);
            this.tabVote.Controls.Add(this.txtVoteRn);
            this.tabVote.Location = new System.Drawing.Point(4, 22);
            this.tabVote.Name = "tabVote";
            this.tabVote.Padding = new System.Windows.Forms.Padding(3);
            this.tabVote.Size = new System.Drawing.Size(470, 409);
            this.tabVote.TabIndex = 2;
            this.tabVote.Text = "Vote";
            this.tabVote.UseVisualStyleBackColor = true;
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(198, 219);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(75, 23);
            this.btnVote.TabIndex = 4;
            this.btnVote.Text = "Vote!";
            this.btnVote.UseVisualStyleBackColor = true;
            // 
            // lblVoteCandidate
            // 
            this.lblVoteCandidate.AutoSize = true;
            this.lblVoteCandidate.Location = new System.Drawing.Point(145, 196);
            this.lblVoteCandidate.Name = "lblVoteCandidate";
            this.lblVoteCandidate.Size = new System.Drawing.Size(74, 13);
            this.lblVoteCandidate.TabIndex = 2;
            this.lblVoteCandidate.Text = "Candidate RN";
            // 
            // lblVoteRn
            // 
            this.lblVoteRn.AutoSize = true;
            this.lblVoteRn.Location = new System.Drawing.Point(145, 169);
            this.lblVoteRn.Name = "lblVoteRn";
            this.lblVoteRn.Size = new System.Drawing.Size(51, 13);
            this.lblVoteRn.TabIndex = 0;
            this.lblVoteRn.Text = "Voter RN";
            // 
            // txtVoteCandidate
            // 
            this.txtVoteCandidate.Location = new System.Drawing.Point(225, 193);
            this.txtVoteCandidate.Name = "txtVoteCandidate";
            this.txtVoteCandidate.Size = new System.Drawing.Size(100, 20);
            this.txtVoteCandidate.TabIndex = 3;
            // 
            // txtVoteRn
            // 
            this.txtVoteRn.Location = new System.Drawing.Point(225, 166);
            this.txtVoteRn.Name = "txtVoteRn";
            this.txtVoteRn.Size = new System.Drawing.Size(100, 20);
            this.txtVoteRn.TabIndex = 1;
            // 
            // txtVoterSearch
            // 
            this.txtVoterSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVoterSearch.Location = new System.Drawing.Point(49, 352);
            this.txtVoterSearch.Name = "txtVoterSearch";
            this.txtVoterSearch.Size = new System.Drawing.Size(376, 20);
            this.txtVoterSearch.TabIndex = 13;
            this.txtVoterSearch.Text = "search...";
            // 
            // dataviewVoters
            // 
            this.dataviewVoters.AllowUserToAddRows = false;
            this.dataviewVoters.AllowUserToDeleteRows = false;
            this.dataviewVoters.AllowUserToResizeRows = false;
            this.dataviewVoters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataviewVoters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewVoters.Location = new System.Drawing.Point(49, 196);
            this.dataviewVoters.Name = "dataviewVoters";
            this.dataviewVoters.ReadOnly = true;
            this.dataviewVoters.Size = new System.Drawing.Size(376, 150);
            this.dataviewVoters.TabIndex = 12;
            // 
            // dataviewCandidates
            // 
            this.dataviewCandidates.AllowUserToAddRows = false;
            this.dataviewCandidates.AllowUserToDeleteRows = false;
            this.dataviewCandidates.AllowUserToResizeRows = false;
            this.dataviewCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewCandidates.Location = new System.Drawing.Point(70, 6);
            this.dataviewCandidates.Name = "dataviewCandidates";
            this.dataviewCandidates.ReadOnly = true;
            this.dataviewCandidates.Size = new System.Drawing.Size(333, 340);
            this.dataviewCandidates.TabIndex = 0;
            // 
            // FrmVotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 435);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "FrmVotes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabVoter.ResumeLayout(false);
            this.tabVoter.PerformLayout();
            this.tabCandidate.ResumeLayout(false);
            this.tabCandidate.PerformLayout();
            this.tabVote.ResumeLayout(false);
            this.tabVote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewVoters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewCandidates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabVoter;
        private System.Windows.Forms.TabPage tabCandidate;
        private System.Windows.Forms.Label lblVoterRn;
        private System.Windows.Forms.Label lblVoterName;
        private System.Windows.Forms.TextBox txtVoterRn;
        private System.Windows.Forms.TextBox txtVoterName;
        private System.Windows.Forms.TextBox txtCandidateRn;
        private System.Windows.Forms.Label lblCandidateRn;
        private System.Windows.Forms.TabPage tabVote;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Label lblVoteCandidate;
        private System.Windows.Forms.Label lblVoteRn;
        private System.Windows.Forms.TextBox txtVoteCandidate;
        private System.Windows.Forms.TextBox txtVoteRn;
        private System.Windows.Forms.Button btnVoter;
        private System.Windows.Forms.Button btnCandidate;
        private System.Windows.Forms.Label lblVoterPhone;
        private System.Windows.Forms.Label lblVoterAddress;
        private System.Windows.Forms.TextBox txtVoterPhone;
        private System.Windows.Forms.TextBox txtVoterAddress;
        private System.Windows.Forms.Label lblVoterGuardian;
        private System.Windows.Forms.TextBox txtVoterGuardian;
        private System.Windows.Forms.Button btnVoterClear;
        private System.Windows.Forms.DataGridView dataviewVoters;
        private System.Windows.Forms.TextBox txtVoterSearch;
        private System.Windows.Forms.DataGridView dataviewCandidates;

    }
}

