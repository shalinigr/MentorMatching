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
            this.pnlFill = new System.Windows.Forms.Panel();
            this.lblMentor = new System.Windows.Forms.Label();
            this.lblMentee = new System.Windows.Forms.Label();
            this.txtMentorPath = new System.Windows.Forms.TextBox();
            this.txtMenteePath = new System.Windows.Forms.TextBox();
            this.btnBrosweMentor = new System.Windows.Forms.Button();
            this.btnMenteeBrowse = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBottom.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Controls.Add(this.btnMatch);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 74);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(394, 34);
            this.pnlBottom.TabIndex = 0;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.btnMenteeBrowse);
            this.pnlFill.Controls.Add(this.btnBrosweMentor);
            this.pnlFill.Controls.Add(this.txtMenteePath);
            this.pnlFill.Controls.Add(this.txtMentorPath);
            this.pnlFill.Controls.Add(this.lblMentee);
            this.pnlFill.Controls.Add(this.lblMentor);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(394, 108);
            this.pnlFill.TabIndex = 1;
            // 
            // lblMentor
            // 
            this.lblMentor.AutoSize = true;
            this.lblMentor.Location = new System.Drawing.Point(13, 13);
            this.lblMentor.Name = "lblMentor";
            this.lblMentor.Size = new System.Drawing.Size(84, 13);
            this.lblMentor.TabIndex = 0;
            this.lblMentor.Text = "Mentor File Path";
            // 
            // lblMentee
            // 
            this.lblMentee.AutoSize = true;
            this.lblMentee.Location = new System.Drawing.Point(13, 48);
            this.lblMentee.Name = "lblMentee";
            this.lblMentee.Size = new System.Drawing.Size(87, 13);
            this.lblMentee.TabIndex = 1;
            this.lblMentee.Text = "Mentee File Path";
            // 
            // txtMentorPath
            // 
            this.txtMentorPath.Location = new System.Drawing.Point(103, 10);
            this.txtMentorPath.Name = "txtMentorPath";
            this.txtMentorPath.Size = new System.Drawing.Size(271, 20);
            this.txtMentorPath.TabIndex = 2;
            // 
            // txtMenteePath
            // 
            this.txtMenteePath.Location = new System.Drawing.Point(103, 45);
            this.txtMenteePath.Name = "txtMenteePath";
            this.txtMenteePath.Size = new System.Drawing.Size(271, 20);
            this.txtMenteePath.TabIndex = 3;
            // 
            // btnBrosweMentor
            // 
            this.btnBrosweMentor.Location = new System.Drawing.Point(342, 8);
            this.btnBrosweMentor.Name = "btnBrosweMentor";
            this.btnBrosweMentor.Size = new System.Drawing.Size(32, 23);
            this.btnBrosweMentor.TabIndex = 4;
            this.btnBrosweMentor.Text = "...";
            this.btnBrosweMentor.UseVisualStyleBackColor = true;
            this.btnBrosweMentor.Click += new System.EventHandler(this.btnBrosweMentor_Click);
            // 
            // btnMenteeBrowse
            // 
            this.btnMenteeBrowse.Location = new System.Drawing.Point(342, 43);
            this.btnMenteeBrowse.Name = "btnMenteeBrowse";
            this.btnMenteeBrowse.Size = new System.Drawing.Size(32, 23);
            this.btnMenteeBrowse.TabIndex = 5;
            this.btnMenteeBrowse.Text = "...";
            this.btnMenteeBrowse.UseVisualStyleBackColor = true;
            this.btnMenteeBrowse.Click += new System.EventHandler(this.btnMenteeBrowse_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMatch.Location = new System.Drawing.Point(218, 5);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 23);
            this.btnMatch.TabIndex = 5;
            this.btnMatch.Text = "&Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(299, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // frmMentorship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 108);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlFill);
            this.Name = "frmMentorship";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mentorship";
            this.pnlBottom.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Button btnMenteeBrowse;
        private System.Windows.Forms.Button btnBrosweMentor;
        private System.Windows.Forms.TextBox txtMenteePath;
        private System.Windows.Forms.TextBox txtMentorPath;
        private System.Windows.Forms.Label lblMentee;
        private System.Windows.Forms.Label lblMentor;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}