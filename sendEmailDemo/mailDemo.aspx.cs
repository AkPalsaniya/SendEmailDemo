using System;
using System.Net;
using System.Net.Mail;
using System.Text;
namespace sendEmailDemo
{
    public partial class mailDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSent_Click(object sender, EventArgs e)
        {
            try
            {
                // Sender's email credentials for Gmail
                string senderEmail = "xyz@gmail.com";
                //Check for two-factor authentication If you have enabled two-factor authentication for the sender's email account, you may need to generate an application-specific password to use in your code instead of the account's actual password.
                string senderPassword = "ylwx 000 xmgn hmld";

                // Create and configure SMTP client for Gmail
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false, 
                    Credentials = new NetworkCredential(senderEmail, senderPassword)
                };

                // Create the email message
                MailMessage mailMessage = new MailMessage(senderEmail, "ReceverEmail@gmail.com")
                {
                    Subject = txtSubject.Text,
                    Body = txtMsg.Text,
                    IsBodyHtml = true
                };

                // Send the email
                smtpClient.Send(mailMessage);
                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email. Error: " + ex.Message);
            }

            
        }
    }
}