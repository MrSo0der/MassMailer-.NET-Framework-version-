using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Net.Sockets;
using RazorEngine;
using RazorEngine.Templating;
using System.IO;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace MassMailer
{
    internal class SMTPBrains
    {
        private static SmtpClient client = new SmtpClient();
        private static bool successfullConnection = false;
        private static string loginEmail = "";
        private static List<Dictionary<string, string>> userList = new List<Dictionary<string, string>>();
        public static int usersCount = 0;

        public static string Auth(string login, string password)
        {
            try
            {
                if (!successfullConnection)
                {
                    client.Connect("smtp.yandex.ru", 587, false);
                    successfullConnection = true;
                }
                //"MrSo0der@yandex.ru", "iqzxcnyanqfqobaq"
                client.Authenticate(login, password);
                loginEmail = login;
                return "success";
            }
            catch (MailKit.Security.AuthenticationException)
            {
                return "wrongCredentials";
            }
            catch (SocketException)
            {
                return "badInternetConnection";
            }
        }

        public static void FormData(string path)
        {
            using (var reader = new StreamReader(path))
            {
                string[] headers = reader.ReadLine().Split(',');

                while (!reader.EndOfStream)
                {
                    string[] fields = reader.ReadLine().Split(',');
                    Dictionary<string, string> user = new Dictionary<string, string>();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        user.Add(headers[i], fields[i]);
                    }
                    userList.Add(user);
                }
            }
            usersCount = userList.Count;
        }
        public static string Send(string MessageText, ComboBox.ObjectCollection Recipients, string Subject, ComboBox.ObjectCollection Files, string Mode)
        {
            var builder = new BodyBuilder();
            try
            {
                foreach (var file in Files)
                {
                    builder.Attachments.Add(file.ToString());
                }
            }
            catch (IOException)
            {
                return "filesOpened";
            }
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress(loginEmail, loginEmail));
            message.Subject = Subject;

            switch (Mode)
            {
                case "Plain":
                    builder.TextBody = MessageText;
                    goto case "_StaticPlain";
                case "Static":
                    builder.HtmlBody = MessageText;
                    goto case "_StaticPlain";

                case "_StaticPlain":
                    foreach (var address in Recipients)
                    {
                        string a = address.ToString(); message.To.Add(new MailboxAddress(a, a));
                    }
                    message.Body = builder.ToMessageBody();
                    try
                    {
                        client.Send(message);
                    }
                    catch (SmtpCommandException)
                    {
                        return "wrongAddress";
                    }
                    goto default;

                case "Dynamic":
                    for (int i = 0; i < usersCount; i++)
                    {
                        message.To.Clear();
                        string a = Recipients[i].ToString(); message.To.Add(new MailboxAddress(a, a));
                        builder.HtmlBody = Engine.Razor.RunCompile(MessageText, "emailBodyTemplate", null, userList[i]);
                        message.Body = builder.ToMessageBody();
                        try
                        {
                            client.Send(message);
                        }
                        catch (SmtpCommandException)
                        {
                            return "wrongAddress";
                        }
                    }
                    goto default;

                default: return "success";
            }
        }
    }
}
