using Common;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using Xunit;

namespace CommonXUnitTest
{
    public class EmailHelperTest
    {
        [Fact]
        public  void SendEmail()
        {
            EmailHelper emailHelper = new EmailHelper();

            MailMessage mailMessage = new MailMessage(new MailAddress("443929389@qq.com"), new MailAddress("443929389@qq.com"))
            {
                Subject = "Test Email",
                Body = "<p>Hello Email!</p></br>hahahaha",
                IsBodyHtml = true,
                BodyEncoding = Encoding.UTF8,
                SubjectEncoding = Encoding.UTF8
            };

            NetworkCredential networkCredential = new NetworkCredential("443929389@qq.com", "88668719");
            
            emailHelper.SendEmail(mailMessage, "smtp.qq.com", 465, networkCredential, null);
            Assert.True(false);
        }
    }
}
