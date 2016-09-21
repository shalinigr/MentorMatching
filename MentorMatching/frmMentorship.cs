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
            //TODO
            /* Send files to Matching.cs
             * getMatchedResults
             * Display on grid
             */
            if (validate()) return;
            Matching objMatching = new Matching(txtMentorPath.Text.Trim(),txtMenteePath.Text.Trim());         
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
