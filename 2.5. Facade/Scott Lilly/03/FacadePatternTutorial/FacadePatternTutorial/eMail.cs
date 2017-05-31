using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace FacadePatternTutorial
{
    class Email
    {
        public void DoSomethingSimple()
        {
            // Pretend there is a business logic here

            // Send an e-mail - simple version, with one "to" address
            MailMessage simpleEmail =
                new MailMessage(
                    "from@test.com",
                    "to@test.com",
                    "Email subject here",
                    "Email body here");

            // Set up the mail server
            SmtpClient smtpClient = new SmtpClient("mailservername");
            smtpClient.Credentials = CredentialCache.DefaultNetworkCredentials;
            smtpClient.Timeout = 100;

            //Send the email
            smtpClient.Send(simpleEmail);
        }

        public void DoSomethingComplex()
        {
            // Pretend there is a business logic here

            // Send an e-mail - complex version, with multiple "to", "cc", and "bcc" addresses
            MailMessage email = new MailMessage();

            MailAddress fromAddress = new MailAddress("from@test.com");
            email.From = fromAddress;

            MailAddress toAddress1 = new MailAddress("to1@test.com");
            email.To.Add(toAddress1);
            MailAddress toAddress2 = new MailAddress("to2@test.com");
            email.To.Add(toAddress2);
            MailAddress toAddress3 = new MailAddress("to3@test.com");
            email.To.Add(toAddress3);

            MailAddress ccAddress1 = new MailAddress("cc1@test.com");
            email.CC.Add(ccAddress1);
            MailAddress ccAddress2 = new MailAddress("cc2@test.com");
            email.CC.Add(ccAddress2);

            MailAddress bccAddress1 = new MailAddress("bcc1@test.com");
            email.Bcc.Add(bccAddress1);
            MailAddress bccAddress2 = new MailAddress("bcc2@test.com");
            email.Bcc.Add(bccAddress2);
            MailAddress bccAddress3 = new MailAddress("bcc3@test.com");
            email.Bcc.Add(bccAddress3);
            MailAddress bccAddress4 = new MailAddress("bcc4@test.com");
            email.Bcc.Add(bccAddress4);

            email.Subject = "Email subject here";
            email.Body = "Email body here";

            // Set up the mail server
            SmtpClient smtpClient = new SmtpClient("mailservername");
            smtpClient.Credentials = CredentialCache.DefaultNetworkCredentials;
            smtpClient.Timeout = 100;

            //Send the email
            smtpClient.Send(email);

            // Doing this way, we have 30+ lines of code,
            // and we are creating multiple objects
        }

        // Inlining the mail address creation
        public void DoSomethingComplex_SlightlySimpler()
        {
            // Pretend there is a business logic here

            // Send an e-mail - complex version, with multiple "to", "cc", and "bcc" addresses
            MailMessage email = new MailMessage();

            email.From = new MailAddress("from@test.com");

            email.To.Add(new MailAddress("to1@test.com"));
            email.To.Add(new MailAddress("to2@test.com"));
            email.To.Add(new MailAddress("to3@test.com"));

            email.CC.Add(new MailAddress("cc1@test.com"));
            email.CC.Add(new MailAddress("cc2@test.com"));

            email.Bcc.Add(new MailAddress("bcc1@test.com"));
            email.Bcc.Add(new MailAddress("bcc2@test.com"));
            email.Bcc.Add(new MailAddress("bcc3@test.com"));
            email.Bcc.Add(new MailAddress("bcc4@test.com"));

            email.Subject = "Email subject here";
            email.Body = "Email body here";

            // Set up the mail server
            SmtpClient smtpClient = new SmtpClient("mailservername");
            smtpClient.Credentials = CredentialCache.DefaultNetworkCredentials;
            smtpClient.Timeout = 100;

            //Send the email
            smtpClient.Send(email);

            // This is still 20+ lines of code,
            // and we are creating multiple objects
        }

        // Create a wrapper class: EmailCreator : IEmailFluentInterface
        public void DoSomethingComplexWithWrapper()
        {
            // Pretend there is a business logic here

            // Send an e-mail - wrapper/facade version, with multiple "to", "cc", and "bcc" addresses
            EmailCreator.CreateEmailFrom("from@test.com")
                .To("to1@test.com", "to2@test.com", "to3@test.com")
                .CC("cc1@test.com", "cc2@test.com")
                .Bcc("Bcc1@test.com", "Bcc2@test.com", "Bcc3@test.com", "Bcc4@test.com")
                .WithSubject("Email subject here")
                .WithBody("Email body here")
                .Send();
        }
    }
}
