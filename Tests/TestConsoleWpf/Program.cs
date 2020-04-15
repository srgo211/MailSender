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
            MailAddress from = new MailAddress(myMail);
            // кому отправляем
            MailAddress to = new MailAddress(receiver);



            // создаем объект сообщения
            using (MailMessage msg = new MailMessage(from, to))
            {
                msg.Subject = "Тема сообщения от" + DateTime.Now;
                msg.Body = "Текст сообщения: " + DateTime.Now ;
                msg.IsBodyHtml = false;
                
                msg.Attachments.Add(new Attachment("D:\\1.jpg")); //отправка файлов



                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                using (SmtpClient smtp = new SmtpClient())
                {
                    /*
                     * настройки для рамблер почты
                     * если используем шифрование (рекомендуется) то порт ставим 465
                     * p.s. свежереги сначала не поддерживует шифрование - поэтому порт 25 или 465
                     */
                    smtp.Host = "smtp.rambler.ru";
                    smtp.Port = 25; //порт
                    smtp.EnableSsl = false; // не используем шифрование
                    smtp.Credentials = new NetworkCredential(myMail, password); //проверка учетной записи логин и пароль

                    smtp.Send(msg);
                }
            }
            Console.Write("Отправили сообщение на: " + receiver);
        }
    }//class Program
}//namespace TestConsoleWpf
