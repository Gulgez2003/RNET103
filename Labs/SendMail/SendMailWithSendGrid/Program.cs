using SendGrid;
using SendGrid.Helpers.Mail;

var apiKeyValue = "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";
Environment.SetEnvironmentVariable("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", apiKeyValue);

var apiKey = Environment.GetEnvironmentVariable("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");

if (string.IsNullOrWhiteSpace(apiKey))
{
    Console.WriteLine("SendGrid API key is missing or invalid.");
}
else
{
    var client = new SendGridClient(apiKey);
    var from = new EmailAddress("zoosfera7@gmail.com", "ZooSfera");
    var subject = "Please verify your email for ZooSfera Petshop";
    var to = new EmailAddress("isim@soyisim.com", "Example User");
    var plainTextContent = "Please verify your email for ZooSfera Petshop";
    var htmlContent = "";
    using (StreamReader stream = new StreamReader("HtmlPage.html"))
    {
        htmlContent = stream.ReadToEnd();
    }


    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

    var response = await client.SendEmailAsync(msg);

    if (response.StatusCode == System.Net.HttpStatusCode.OK || response.StatusCode == System.Net.HttpStatusCode.Accepted)
    {
        Console.WriteLine("Email sent successfully.");
    }
    else
    {
        Console.WriteLine($"Error sending email. Status code: {response.StatusCode}");

    }
}


