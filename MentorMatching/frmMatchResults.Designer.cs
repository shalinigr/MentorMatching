namespace MentorMatching
{
    partial class frmMatchResults
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grvResults = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMentorDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMentorEmailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMentorContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMentee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenteeDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenteeEmailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenteeContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnEmail);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 196);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(842, 35);
            this.pnlBottom.TabIndex = 0;
            // 
            // btnEmail
            // 
            this.btnEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmail.Location = new System.Drawing.Point(680, 6);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEmail.TabIndex = 1;
            this.btnEmail.Text = "&Email All";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(761, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grvResults
            // 
            this.grvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colMentorDept,
            this.colMentorEmailID,
            this.colMentorContact,
            this.colMentee,
            this.colMenteeDept,
            this.colMenteeEmailId,
            this.colMenteeContact});
            this.grvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvResults.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grvResults.Location = new System.Drawing.Point(0, 0);
            this.grvResults.Name = "grvResults";
            this.grvResults.RowHeadersVisible = false;
            this.grvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvResults.Size = new System.Drawing.Size(842, 196);
            this.grvResults.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "MentorName";
            this.colName.HeaderText = "Mentor Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colMentorDept
            // 
            this.colMentorDept.DataPropertyName = "MentorDept";
            this.colMentorDept.HeaderText = "Mentor Department";
            this.colMentorDept.Name = "colMentorDept";
            this.colMentorDept.ReadOnly = true;
            // 
            // colMentorEmailID
            // 
            this.colMentorEmailID.DataPropertyName = "MentorUscId";
            this.colMentorEmailID.HeaderText = "Mentor Email ID";
            this.colMentorEmailID.Name = "colMentorEmailID";
            this.colMentorEmailID.ReadOnly = true;
            // 
            // colMentorContact
            // 
            this.colMentorContact.DataPropertyName = "MentorContact";
            this.colMentorContact.HeaderText = "Mentor Contact No";
            this.colMentorContact.Name = "colMentorContact";
            this.colMentorContact.ReadOnly = true;
            // 
            // colMentee
            // 
            this.colMentee.DataPropertyName = "MenteeName";
            this.colMentee.HeaderText = "Mentee Name";
            this.colMentee.Name = "colMentee";
            this.colMentee.ReadOnly = true;
            // 
            // colMenteeDept
            // 
            this.colMenteeDept.DataPropertyName = "MenteeDept";
            this.colMenteeDept.HeaderText = "Mentee Department";
            this.colMenteeDept.Name = "colMenteeDept";
            this.colMenteeDept.ReadOnly = true;
            // 
            // colMenteeEmailId
            // 
            this.colMenteeEmailId.DataPropertyName = "MenteeUscId";
            this.colMenteeEmailId.HeaderText = "Mentee Email ID";
            this.colMenteeEmailId.Name = "colMenteeEmailId";
            this.colMenteeEmailId.ReadOnly = true;
            // 
            // colMenteeContact
            // 
            this.colMenteeContact.DataPropertyName = "MenteeContact";
            this.colMenteeContact.HeaderText = "Mentee Contact No";
            this.colMenteeContact.Name = "colMenteeContact";
            this.colMenteeContact.ReadOnly = true;
            // 
            // frmMatchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 231);
            this.Controls.Add(this.grvResults);
            this.Controls.Add(this.pnlBottom);
            this.Name = "frmMatchResults";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matched Results";
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView grvResults;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMentorDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMentorEmailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMentorContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMentee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenteeDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenteeEmailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenteeContact;
    }
}
