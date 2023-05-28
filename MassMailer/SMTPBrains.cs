using System.Collections.Generic;
using MailKit.Net.Smtp;
using MimeKit;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using HandlebarsDotNet;

namespace MassMailer
{
    internal class SMTPBrains
    {
        private static SmtpClient client = new SmtpClient();
        private static bool successfullConnection = false;
        private static string loginEmail = "";
        private static List<Dictionary<string, string>> userList;
        private static int usersCount = 0;

        public static short Auth(string login, string password)
        {
            try
            {
                if (!successfullConnection)
                {
                    client.Connect("smtp.yandex.ru", 465, true);
                    successfullConnection = true;
                }
                //"MrSo0der@yandex.ru", "iqzxcnyanqfqobaq"
                client.Authenticate(login, password);
                loginEmail = login;
                return 0; // success
            }
            catch (MailKit.Security.AuthenticationException)
            {
                return 1; // wrongCredentials
            }
            catch (SocketException)
            {
                return 2; // badInternetConnection
            }
        }

        public static List<Dictionary<string, string>> FormData(string data)
        {
            userList = new List<Dictionary<string, string>>();
            using (var reader = new StringReader(data))
            {
                string[] headers = reader.ReadLine().Split(new string[] { "\t" }, 0);

                int varsCount = headers.Length;

                string[] userRawData = reader.ReadToEnd().Replace("||", "<br>").Split(new string[] { "\n" }, 0);
                usersCount = userRawData.Length;

                for (int i = 0; i < usersCount; i++)
                {
                    string[] varsForCurrentUser = userRawData[i].Split(new string[] { "\t" }, 0); ;
                    Dictionary<string, string> user = new Dictionary<string, string>();
                    for (int j = 0; j < (varsForCurrentUser.Length < varsCount ? varsForCurrentUser.Length : varsCount); j++)
                    {
                        user.Add(headers[j], varsForCurrentUser[j]);
                    }
                    userList.Add(user);
                }
            }
            return userList;
        }
        public static short Send(string MessageText, ComboBox.ObjectCollection Recipients, string Subject, ComboBox.ObjectCollection Files, short Mode)
        {
            var builder = new BodyBuilder();
            try
            {
                foreach (var file in Files)
                {
                    builder.Attachments.Add(file.ToString());
                }
            }
            catch (FileNotFoundException)
            {
                return 5;
            }
            catch (IOException)
            {
                return 3;
            }
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress(loginEmail, loginEmail));
            message.Subject = Subject;

            switch (Mode)
            {
                case 0:
                    builder.TextBody = MessageText;
                    goto case 10;
                case 1:
                    builder.HtmlBody = MessageText;
                    goto case 10;

                case 10:
                    try
                    {
                        foreach (var address in Recipients)
                        {
                            string a = address.ToString(); message.To.Add(new MailboxAddress(a, a));
                        }
                        message.Body = builder.ToMessageBody();

                        client.Send(message);
                    }
                    catch (SmtpCommandException)
                    {
                        return 2;
                    }
                    catch (ParseException)
                    {
                        return 2;
                    }
                    catch (SmtpProtocolException) // Yandex Fix
                    {
                        ReconnectAndSend(message);
                    }
                    goto default;

                case 2:

                    for (int i = 0; i < (usersCount < Recipients.Count ? usersCount : Recipients.Count); i++)
                    {
                        message.To.Clear();
                        string a = Recipients[i].ToString(); try { message.To.Add(new MailboxAddress(a, a)); } catch (ParseException) { return 2; }
                        builder.HtmlBody = Handlebars.Compile(MessageText)(userList[i]);
                        message.Body = builder.ToMessageBody();
                        try
                        {
                            client.Send(message);
                        }
                        catch (SmtpCommandException)
                        {
                            return 2;
                        }
                        catch (SmtpProtocolException) // Yandex Fix
                        {
                            ReconnectAndSend(message);
                        }
                    }
                    goto default;

                default: return 0;
            }
        }
        private static void ReconnectAndSend(MimeMessage message)
        {
            client.Disconnect(true);
            client.Connect("smtp.yandex.ru", 465, true);
            client.Authenticate(Properties.Settings.Default.Login, Encryption.Decrypt(Properties.Settings.Default.PasswordYandexFix, true));
            client.Send(message);
        }
        public static void Disconnect()
        {
            client.Disconnect(true);
        }
    }
}
