namespace MentorMatching
{
    partial class frmMentorship
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.spltContPanels = new System.Windows.Forms.SplitContainer();
            this.txtMentorEmailID = new System.Windows.Forms.TextBox();
            this.txtMentorContact = new System.Windows.Forms.TextBox();
            this.txtMentorDept = new System.Windows.Forms.TextBox();
            this.txtMentorName = new System.Windows.Forms.TextBox();
            this.lblMentorEmail = new System.Windows.Forms.Label();
            this.lblMentorDept = new System.Windows.Forms.Label();
            this.lblMentorContact = new System.Windows.Forms.Label();
            this.lblMentorName = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.btnBrosweMentor = new System.Windows.Forms.Button();
            this.txtMentorPath = new System.Windows.Forms.TextBox();
            this.lblMentor = new System.Windows.Forms.Label();
            this.txtMenteeEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMenteeContact = new System.Windows.Forms.TextBox();
            this.btnMenteeBrowse = new System.Windows.Forms.Button();
            this.txtMenteeDept = new System.Windows.Forms.TextBox();
            this.txtMenteePath = new System.Windows.Forms.TextBox();
            this.txtMenteeName = new System.Windows.Forms.TextBox();
            this.lblMentee = new System.Windows.Forms.Label();
            this.lblMenteeEmail = new System.Windows.Forms.Label();
            this.lblMenteeDept = new System.Windows.Forms.Label();
            this.lblMenteeName = new System.Windows.Forms.Label();
            this.lblMenteeContact = new System.Windows.Forms.Label();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltContPanels)).BeginInit();
            this.spltContPanels.Panel1.SuspendLayout();
            this.spltContPanels.Panel2.SuspendLayout();
            this.spltContPanels.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Controls.Add(this.btnMatch);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 165);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(820, 34);
            this.pnlBottom.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(736, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMatch.Location = new System.Drawing.Point(655, 5);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 23);
            this.btnMatch.TabIndex = 5;
            this.btnMatch.Text = "&Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // spltContPanels
            // 
            this.spltContPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltContPanels.Location = new System.Drawing.Point(0, 0);
            this.spltContPanels.Name = "spltContPanels";
            // 
            // spltContPanels.Panel1
            // 
            this.spltContPanels.Panel1.Controls.Add(this.txtMentorEmailID);
            this.spltContPanels.Panel1.Controls.Add(this.txtMentorContact);
            this.spltContPanels.Panel1.Controls.Add(this.txtMentorDept);
            this.spltContPanels.Panel1.Controls.Add(this.txtMentorName);
            this.spltContPanels.Panel1.Controls.Add(this.lblMentorEmail);
            this.spltContPanels.Panel1.Controls.Add(this.lblMentorDept);
            this.spltContPanels.Panel1.Controls.Add(this.lblMentorContact);
            this.spltContPanels.Panel1.Controls.Add(this.lblMentorName);
            this.spltContPanels.Panel1.Controls.Add(this.lblLabel);
            this.spltContPanels.Panel1.Controls.Add(this.btnBrosweMentor);
            this.spltContPanels.Panel1.Controls.Add(this.txtMentorPath);
            this.spltContPanels.Panel1.Controls.Add(this.lblMentor);
            // 
            // spltContPanels.Panel2
            // 
            this.spltContPanels.Panel2.Controls.Add(this.txtMenteeEmail);
            this.spltContPanels.Panel2.Controls.Add(this.label1);
            this.spltContPanels.Panel2.Controls.Add(this.txtMenteeContact);
            this.spltContPanels.Panel2.Controls.Add(this.btnMenteeBrowse);
            this.spltContPanels.Panel2.Controls.Add(this.txtMenteeDept);
            this.spltContPanels.Panel2.Controls.Add(this.txtMenteePath);
            this.spltContPanels.Panel2.Controls.Add(this.txtMenteeName);
            this.spltContPanels.Panel2.Controls.Add(this.lblMentee);
            this.spltContPanels.Panel2.Controls.Add(this.lblMenteeEmail);
            this.spltContPanels.Panel2.Controls.Add(this.lblMenteeDept);
            this.spltContPanels.Panel2.Controls.Add(this.lblMenteeName);
            this.spltContPanels.Panel2.Controls.Add(this.lblMenteeContact);
            this.spltContPanels.Size = new System.Drawing.Size(820, 165);
            this.spltContPanels.SplitterDistance = 410;
            this.spltContPanels.TabIndex = 1;
            // 
            // txtMentorEmailID
            // 
            this.txtMentorEmailID.Location = new System.Drawing.Point(263, 130);
            this.txtMentorEmailID.Name = "txtMentorEmailID";
            this.txtMentorEmailID.Size = new System.Drawing.Size(33, 20);
            this.txtMentorEmailID.TabIndex = 54;
            // 
            // txtMentorContact
            // 
            this.txtMentorContact.Location = new System.Drawing.Point(107, 130);
            this.txtMentorContact.Name = "txtMentorContact";
            this.txtMentorContact.Size = new System.Drawing.Size(33, 20);
            this.txtMentorContact.TabIndex = 53;
            // 
            // txtMentorDept
            // 
            this.txtMentorDept.Location = new System.Drawing.Point(263, 96);
            this.txtMentorDept.Name = "txtMentorDept";
            this.txtMentorDept.Size = new System.Drawing.Size(33, 20);
            this.txtMentorDept.TabIndex = 52;
            // 
            // txtMentorName
            // 
            this.txtMentorName.Location = new System.Drawing.Point(108, 96);
            this.txtMentorName.Name = "txtMentorName";
            this.txtMentorName.Size = new System.Drawing.Size(33, 20);
            this.txtMentorName.TabIndex = 51;
            // 
            // lblMentorEmail
            // 
            this.lblMentorEmail.AutoSize = true;
            this.lblMentorEmail.Location = new System.Drawing.Point(195, 133);
            this.lblMentorEmail.Name = "lblMentorEmail";
            this.lblMentorEmail.Size = new System.Drawing.Size(46, 13);
            this.lblMentorEmail.TabIndex = 50;
            this.lblMentorEmail.Text = "Email ID";
            // 
            // lblMentorDept
            // 
            this.lblMentorDept.AutoSize = true;
            this.lblMentorDept.Location = new System.Drawing.Point(195, 99);
            this.lblMentorDept.Name = "lblMentorDept";
            this.lblMentorDept.Size = new System.Drawing.Size(62, 13);
            this.lblMentorDept.TabIndex = 49;
            this.lblMentorDept.Text = "Department";
            // 
            // lblMentorContact
            // 
            this.lblMentorContact.AutoSize = true;
            this.lblMentorContact.Location = new System.Drawing.Point(21, 133);
            this.lblMentorContact.Name = "lblMentorContact";
            this.lblMentorContact.Size = new System.Drawing.Size(80, 13);
            this.lblMentorContact.TabIndex = 48;
            this.lblMentorContact.Text = "Mentor Contact";
            // 
            // lblMentorName
            // 
            this.lblMentorName.AutoSize = true;
            this.lblMentorName.Location = new System.Drawing.Point(21, 99);
            this.lblMentorName.Name = "lblMentorName";
            this.lblMentorName.Size = new System.Drawing.Size(71, 13);
            this.lblMentorName.TabIndex = 47;
            this.lblMentorName.Text = "Mentor Name";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(7, 65);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(352, 13);
            this.lblLabel.TabIndex = 46;
            this.lblLabel.Text = "Please provide the necessary column details for the files to be processed.";
            // 
            // btnBrosweMentor
            // 
            this.btnBrosweMentor.Location = new System.Drawing.Point(341, 20);
            this.btnBrosweMentor.Name = "btnBrosweMentor";
            this.btnBrosweMentor.Size = new System.Drawing.Size(32, 23);
            this.btnBrosweMentor.TabIndex = 44;
            this.btnBrosweMentor.Text = "...";
            this.btnBrosweMentor.UseVisualStyleBackColor = true;
            this.btnBrosweMentor.Click += new System.EventHandler(this.btnBrosweMentor_Click);
            // 
            // txtMentorPath
            // 
            this.txtMentorPath.Location = new System.Drawing.Point(102, 22);
            this.txtMentorPath.Name = "txtMentorPath";
            this.txtMentorPath.Size = new System.Drawing.Size(271, 20);
            this.txtMentorPath.TabIndex = 42;
            // 
            // lblMentor
            // 
            this.lblMentor.AutoSize = true;
            this.lblMentor.Location = new System.Drawing.Point(12, 25);
            this.lblMentor.Name = "lblMentor";
            this.lblMentor.Size = new System.Drawing.Size(84, 13);
            this.lblMentor.TabIndex = 40;
            this.lblMentor.Text = "Mentor File Path";
            // 
            // txtMenteeEmail
            // 
            this.txtMenteeEmail.Location = new System.Drawing.Point(275, 130);
            this.txtMenteeEmail.Name = "txtMenteeEmail";
            this.txtMenteeEmail.Size = new System.Drawing.Size(33, 20);
            this.txtMenteeEmail.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Please provide the necessary column details for the files to be processed.";
            // 
            // txtMenteeContact
            // 
            this.txtMenteeContact.Location = new System.Drawing.Point(119, 130);
            this.txtMenteeContact.Name = "txtMenteeContact";
            this.txtMenteeContact.Size = new System.Drawing.Size(33, 20);
            this.txtMenteeContact.TabIndex = 61;
            // 
            // btnMenteeBrowse
            // 
            this.btnMenteeBrowse.Location = new System.Drawing.Point(342, 20);
            this.btnMenteeBrowse.Name = "btnMenteeBrowse";
            this.btnMenteeBrowse.Size = new System.Drawing.Size(32, 23);
            this.btnMenteeBrowse.TabIndex = 48;
            this.btnMenteeBrowse.Text = "...";
            this.btnMenteeBrowse.UseVisualStyleBackColor = true;
            this.btnMenteeBrowse.Click += new System.EventHandler(this.btnMenteeBrowse_Click);
            // 
            // txtMenteeDept
            // 
            this.txtMenteeDept.Location = new System.Drawing.Point(275, 96);
            this.txtMenteeDept.Name = "txtMenteeDept";
            this.txtMenteeDept.Size = new System.Drawing.Size(33, 20);
            this.txtMenteeDept.TabIndex = 60;
            // 
            // txtMenteePath
            // 
            this.txtMenteePath.Location = new System.Drawing.Point(103, 22);
            this.txtMenteePath.Name = "txtMenteePath";
            this.txtMenteePath.Size = new System.Drawing.Size(271, 20);
            this.txtMenteePath.TabIndex = 47;
            // 
            // txtMenteeName
            // 
            this.txtMenteeName.Location = new System.Drawing.Point(120, 96);
            this.txtMenteeName.Name = "txtMenteeName";
            this.txtMenteeName.Size = new System.Drawing.Size(33, 20);
            this.txtMenteeName.TabIndex = 59;
            // 
            // lblMentee
            // 
            this.lblMentee.AutoSize = true;
            this.lblMentee.Location = new System.Drawing.Point(13, 25);
            this.lblMentee.Name = "lblMentee";
            this.lblMentee.Size = new System.Drawing.Size(87, 13);
            this.lblMentee.TabIndex = 46;
            this.lblMentee.Text = "Mentee File Path";
            // 
            // lblMenteeEmail
            // 
            this.lblMenteeEmail.AutoSize = true;
            this.lblMenteeEmail.Location = new System.Drawing.Point(207, 133);
            this.lblMenteeEmail.Name = "lblMenteeEmail";
            this.lblMenteeEmail.Size = new System.Drawing.Size(46, 13);
            this.lblMenteeEmail.TabIndex = 58;
            this.lblMenteeEmail.Text = "Email ID";
            // 
            // lblMenteeDept
            // 
            this.lblMenteeDept.AutoSize = true;
            this.lblMenteeDept.Location = new System.Drawing.Point(207, 99);
            this.lblMenteeDept.Name = "lblMenteeDept";
            this.lblMenteeDept.Size = new System.Drawing.Size(62, 13);
            this.lblMenteeDept.TabIndex = 57;
            this.lblMenteeDept.Text = "Department";
            // 
            // lblMenteeName
            // 
            this.lblMenteeName.AutoSize = true;
            this.lblMenteeName.Location = new System.Drawing.Point(33, 99);
            this.lblMenteeName.Name = "lblMenteeName";
            this.lblMenteeName.Size = new System.Drawing.Size(74, 13);
            this.lblMenteeName.TabIndex = 55;
            this.lblMenteeName.Text = "Mentee Name";
            // 
            // lblMenteeContact
            // 
            this.lblMenteeContact.AutoSize = true;
            this.lblMenteeContact.Location = new System.Drawing.Point(33, 133);
            this.lblMenteeContact.Name = "lblMenteeContact";
            this.lblMenteeContact.Size = new System.Drawing.Size(83, 13);
            this.lblMenteeContact.TabIndex = 56;
            this.lblMenteeContact.Text = "Mentee Contact";
            // 
            // frmMentorship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 199);
            this.Controls.Add(this.spltContPanels);
            this.Controls.Add(this.pnlBottom);
            this.MaximizeBox = false;
            this.Name = "frmMentorship";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mentorship";
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.spltContPanels.Panel1.ResumeLayout(false);
            this.spltContPanels.Panel1.PerformLayout();
            this.spltContPanels.Panel2.ResumeLayout(false);
            this.spltContPanels.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltContPanels)).EndInit();
            this.spltContPanels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.SplitContainer spltContPanels;
        private System.Windows.Forms.TextBox txtMentorEmailID;
        private System.Windows.Forms.TextBox txtMentorContact;
        private System.Windows.Forms.TextBox txtMentorDept;
        private System.Windows.Forms.TextBox txtMentorName;
        private System.Windows.Forms.Label lblMentorEmail;
        private System.Windows.Forms.Label lblMentorDept;
        private System.Windows.Forms.Label lblMentorContact;
        private System.Windows.Forms.Label lblMentorName;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Button btnBrosweMentor;
        private System.Windows.Forms.TextBox txtMentorPath;
        private System.Windows.Forms.Label lblMentor;
        private System.Windows.Forms.TextBox txtMenteeEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMenteeContact;
        private System.Windows.Forms.Button btnMenteeBrowse;
        private System.Windows.Forms.TextBox txtMenteeDept;
        private System.Windows.Forms.TextBox txtMenteePath;
        private System.Windows.Forms.TextBox txtMenteeName;
        private System.Windows.Forms.Label lblMentee;
        private System.Windows.Forms.Label lblMenteeEmail;
        private System.Windows.Forms.Label lblMenteeDept;
        private System.Windows.Forms.Label lblMenteeName;
        private System.Windows.Forms.Label lblMenteeContact;
    }
}
