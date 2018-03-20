using LogPlay.Helpers.Interface;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LogPlay.Helpers
{
    public static class SendEmailHelper 
    {
       public static async Task Execute()
        {
                var apiKey = System.Configuration.ConfigurationManager.AppSettings["SENDGRID_API_KEY"];
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("test@example.com", "Example User");
                var subject = "Sending with SendGrid is Fun 1";
                var to = new EmailAddress("test.test@googlemail.com", "Example User");
                var plainTextContent = "and easy to do anywhere, even with C#";
                var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);
        }
    }
}