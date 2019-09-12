using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class EmailHelper
    {
        public  Task SendEmail(MailMessage mail, string host, int port, NetworkCredential credential,
                            SendCompletedEventHandler handler = null)
        {
            using (SmtpClient client = new SmtpClient(host, port))
            {
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                if (client.UseDefaultCredentials)
                {
                    client.Credentials = CredentialCache.DefaultNetworkCredentials;
                }
                else
                {
                    client.UseDefaultCredentials = true;//顺序在前
                    client.Credentials = credential;
                }

                //注册异步发送邮件完成时的事件: object sender, AsyncCompletedEventArgs e
                if (handler != null)
                {
                    client.SendCompleted += handler;
                }
                return client.SendMailAsync(mail);
            }
        }

    }
}
