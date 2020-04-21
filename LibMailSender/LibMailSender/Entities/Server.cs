using LibMailSender.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Entities
{
    /// <summary>Почтовый Сервер</summary>
    public class Server : NamedEntity
    {
 
        /// <summary>
        /// Адрес исходящей почты SMTP
        /// </summary>
        public string AddressSMTP { get; set; }
        /// <summary>
        /// Порт исходящей почты SMTP
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// Использовать защищенное соединение
        /// </summary>
        public bool UseSSL { get; set; }
        /// <summary>
        /// Логин от почты
        /// </summary>
        public string LoginToEmail { get; set; }
        /// <summary>
        /// Пароль от почты
        /// </summary>
        public string PasswordToEmail { get; set; }



    }
}
