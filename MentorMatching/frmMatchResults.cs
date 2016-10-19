using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MentorshipModel;

namespace MentorMatching
{
    public partial class frmMatchResults : Form
    {
        #region constructor
        public frmMatchResults(List<Matched> lstFinal)
        {
            InitializeComponent();
            populateUI(lstFinal);
        }
        #endregion

        #region private methods
        private void populateUI(List<Matched> lstFinal)
        {
            if (lstFinal != null)
                grvResults.DataSource = lstFinal;
          
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
           // TODO:
            /*Email everyone*/
            //var fromAddress = new MailAddress("from@gmail.com", "From Name");
            //var toAddress = new MailAddress("to@example.com", "To Name");
            //const string fromPassword = "fromPassword";
            //const string subject = "Subject";
            //const string body = "Body";

            //var smtp = new SmtpClient
            //{
            //    Host = "smtp.gmail.com",
            //    Port = 587,
            //    EnableSsl = true,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            //};
            //using (var message = new MailMessage(fromAddress, toAddress)
            //{
            //    Subject = subject,
            //    Body = body
            //})
            //{
            //    smtp.Send(message);
            //}
        }
        #endregion
    }
}
