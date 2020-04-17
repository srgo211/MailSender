using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Diagnostics;

namespace LibMailSender.Modules
{
    /// <summary>Класс отправки почты</summary>
    public class MailSenderDebug
    {
        readonly string _AdressSMTP;
        readonly int _Port;
        bool _UseSSL;
        string _LoginToEmail;
        string _PasswordToEmail;

        /// <summary>
        ///Сервер для отправки email
        /// </summary>
        /// <param name="AdressSMTP">адресс SMTP сервера исходящей почты</param>
        /// <param name="Port">Порт сервера исходящей почты</param>
        /// <param name="UseSSL">Использовать защищенное соединеие</param>
        /// <param name="LoginToEmail">Логин от email</param>
        /// <param name="PasswordToEmail">Пароль от email</param>
        public MailSenderDebug(string AdressSMTP, int Port, bool UseSSL, string LoginToEmail, string PasswordToEmail)
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

            Debug.WriteLine("Отправка почты от {0} к {1} через {2}:{3} [{4}]\r\n{5}, {6}",
                                            From,To, _AdressSMTP,_Port, _UseSSL ? "SSL": "NOSSL",
                                            Subject,Body);


        }


    }
}
