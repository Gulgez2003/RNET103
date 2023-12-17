using System.Net;
using System.Net.Mail;

MailMessage mail = new MailMessage();
mail.From = new MailAddress("zoosfera7@gmail.com", "ZooSfera");
mail.To.Add(new MailAddress("isim@soyisim.com"));
mail.Subject = "Please verify your email for ZooSfera Petshop";
mail.IsBodyHtml = true;
string body = string.Empty;

using (StreamReader stream = new StreamReader("HtmlPage.html"))
{
    body = stream.ReadToEnd();
}

mail.Body = body.Replace("{{link}}", "Hi, its me");

SmtpClient smtp = new SmtpClient();
smtp.Host = "smtp.gmail.com";
smtp.Port = 587;
smtp.EnableSsl = true;
smtp.Credentials = new NetworkCredential("zoosfera7@gmail.com", "nnae vnre zajn frpi");

smtp.Send(mail);