using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace OesUI.utils
{
    public static class SendEmail
    {
        private static int port = 25;

        //int result = SendingEmail("marioli@augmentum.com.cn", "memory", "marioli@augmentum.com.cn", "test", "this is a test", "mail2.augmentum.com.cn");
        ///<summary>
        /// send email
        ///</summary>
        ///<param name="sendEmailAddress"></param>
        ///<param name="sendEmailPwd"></param>
        ///<param name="msgToEmail"></param>
        ///<param name="title"></param>
        ///<param name="content"></param>
        ///<returns>0：fail 1：success</returns>
        public static bool SendingEmail(string sendEmailAddress, string sendEmailPwd, string receiverAddress, string title, string content, string host)
        {
            string senderAddress = sendEmailAddress;
            string senderPassword = sendEmailPwd;
            string emailTheme = title;
            string emailContent = content;

            SmtpClient client = new SmtpClient(host);
            client.UseDefaultCredentials = false;
            client.Port = port;
            client.EnableSsl = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(sendEmailAddress, senderPassword);

            MailMessage mmsg = new MailMessage();
            mmsg.From = new MailAddress(senderAddress);
            mmsg.To.Add(new MailAddress(receiverAddress));
            mmsg.Subject = emailTheme;
            mmsg.SubjectEncoding = Encoding.UTF8;
            mmsg.Body = emailContent;
            mmsg.BodyEncoding = Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.Priority = MailPriority.High;

            try
            {
                client.Send(mmsg);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
