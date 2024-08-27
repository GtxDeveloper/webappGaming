using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebApplication.Common
{
    public static class EmailSender
    {
        public static bool SendEmail(string email , string link)
        {
            var mail = "smtpgameportal@gmail.com";
            var pw = "q1w2e3r4t5!";

            var client = new SmtpClient("smtp.gmail.com", 465)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)
            };

            client.Send(
                new MailMessage(from: mail,
                                to: email,
                                subject: "Authorization",
                                body: link));

            return true;
        }
    }
}
