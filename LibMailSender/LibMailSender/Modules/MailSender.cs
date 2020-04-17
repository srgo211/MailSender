using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace LibMailSender.Modules
{
    /// <summary>Класс отправки почты</summary>
     public class MailSender
    {
        readonly string _AdressSMTP;
        readonly int _Port;
        bool _UseSSL;
        string _LoginToEmail;
        string _PasswordToEmail;


        public MailSender(string AdressSMTP, int Port, bool UseSSL, string LoginToEmail, string PasswordToEmail)
        {
            _AdressSMTP = AdressSMTP;
            _Port = Port;
            _UseSSL = UseSSL;
            _LoginToEmail = LoginToEmail;
            _PasswordToEmail = PasswordToEmail;

        }


        /// <summary>
        /// Отправки почты
        /// </summary>
        /// <param name="Subject">Тема сообщения</param>
        /// <param name="Body">Тело(текст) сообщения</param>
        /// <param name="From">Отправитель (От кого отправляем email) </param>
        /// <param name="To">Приниматель (Кому отправляем email)</param>
        public void Send(string Subject, string Body, string From, string To)
        {

            // создаем объект сообщения
            using (MailMessage msg = new MailMessage(From, To))
            {

                msg.Subject = Subject; 
                msg.Body = Body;
                msg.IsBodyHtml = false;

                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = _AdressSMTP;    //адрес сервера
                    smtp.Port = _Port;          //порт
                    smtp.EnableSsl = _UseSSL;   // не используем шифрование
                    smtp.Credentials = new System.Net.NetworkCredential(_LoginToEmail, _PasswordToEmail); //проверка учетной записи логин и пароль от почты

                    smtp.Send(msg);

                    
                }
            }


        }
    
    
    }
}
