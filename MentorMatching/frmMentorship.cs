using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MentorshipModel;

namespace MentorMatching
{
    public partial class frmMentorship : Form
    {
        #region variables
        frmMatchResults _objMatch = null;
        #endregion

        #region constructor
        public frmMentorship()
        {
            InitializeComponent();
        }
        #endregion

        #region methods
        private bool validate()
        {
            errProvider.Clear();
            bool isError = false;
            if (String.IsNullOrEmpty(txtMentorPath.Text.Trim()))
            {
                errProvider.SetError(txtMentorPath, "Path cannot be empty");
                isError = true;
                
            }
            if (String.IsNullOrEmpty(txtMenteePath.Text.Trim()))
            {
                errProvider.SetError(txtMenteePath, "Path cannot be empty");
                isError = true;
            }

            if (String.IsNullOrEmpty(txtMentorName.Text.Trim()))
            {
                errProvider.SetError(txtMentorName, "Please provide the name column");
                isError = true;

            }
            if (String.IsNullOrEmpty(txtMentorDept.Text.Trim()))
            {
                errProvider.SetError(txtMentorDept, "Please provide the department column");
                isError = true;

            }
            if (String.IsNullOrEmpty(txtMentorContact.Text.Trim()))
            {
                errProvider.SetError(txtMentorContact, "Please provide the contact column");
                isError = true;

            }
            if (String.IsNullOrEmpty(txtMentorEmailID.Text.Trim()))
            {
                errProvider.SetError(txtMentorEmailID, "Please provide the email column");
                isError = true;

            }
            if (String.IsNullOrEmpty(txtMenteeName.Text.Trim()))
            {
                errProvider.SetError(txtMenteeName, "Please provide the name column");
                isError = true;

            }
            if (String.IsNullOrEmpty(txtMenteeDept.Text.Trim()))
            {
                errProvider.SetError(txtMenteeDept, "Please provide the department column");
                isError = true;

            }
            if (String.IsNullOrEmpty(txtMenteeContact.Text.Trim()))
            {
                errProvider.SetError(txtMenteeContact, "Please provide the contact column");
                isError = true;

            }
            if (String.IsNullOrEmpty(txtMenteeEmail.Text.Trim()))
            {
                errProvider.SetError(txtMenteeEmail, "Please provide the email column");
                isError = true;

            }

            return isError;
        }
        #endregion

        #region events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrosweMentor_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtMentorPath.Text = ofd.FileName;
            }
        }

        private void btnMenteeBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtMenteePath.Text = ofd.FileName;
            }
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {           
            //if (validate()) return;
            Input objInput = new Input();
            objInput.MentorPath = txtMentorPath.Text.Trim();
            objInput.MenteePath = txtMenteePath.Text.Trim();
            objInput.MentorNameCol = txtMentorName.Text.Trim();
            objInput.MentorDeptCol = txtMentorDept.Text.Trim();
            objInput.MentorContactCol = txtMentorContact.Text.Trim();
            objInput.MentorEmailCol = txtMentorEmailID.Text.Trim();
            objInput.MenteeNameCol = txtMenteeName.Text.Trim();
            objInput.MenteeDeptCol = txtMenteeDept.Text.Trim();
            objInput.MenteeContactCol = txtMenteeContact.Text.Trim();
            objInput.MenteeEmailCol = txtMenteeEmail.Text.Trim();
            Matching objMatching = new Matching(objInput);         
            if (_objMatch == null)
            {
                _objMatch = new frmMatchResults(objMatching.FinalList);
                _objMatch.FormClosing += _objMatch_FormClosing;              
                _objMatch.Show(this);
            }
            else
                _objMatch.BringToFront();
        }

        private void _objMatch_FormClosing(object sender, FormClosingEventArgs e)
        {            
            _objMatch = null;
            
        }
        #endregion
    }
}
