using System;
using System.Net;
using System.Net.Mail;

namespace TestConsoleWpf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Старт тестового проекта на Core!");

            //мой email
            string myMail = "dmitriyzhukov1995351j6vz@rambler.ua";
            //мой пароль от почты
            string password = "X2i9Tz24V";
            
            //получатель
            string receiver = "evgeniyzhuravlyov2000018dwh@rambler.ua";

            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress(myMail, "Tom");
            // кому отправляем
            MailAddress to = new MailAddress(receiver);



            // создаем объект сообщения
            MailMessage msg = new MailMessage(from, to);
            msg.Subject = "Тема сообщения";
            msg.Body = "Тело сообщения";
            msg.IsBodyHtml = false;
            msg.Attachments.Add(new Attachment("D:\\1.jpg")); //отправка файлов



            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "mail.rambler.ru";
            smtp.Port = 25;
            smtp.EnableSsl = true; //используем шифрование
            smtp.Credentials = new NetworkCredential(myMail,password); //проверка учетной записи

            smtp.Send(msg);
        }
    }//class Program
}//namespace TestConsoleWpf
