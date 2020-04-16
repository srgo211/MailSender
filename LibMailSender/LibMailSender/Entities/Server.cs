using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Entities
{
    public class Server
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Порт
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// Использовать защищенное соединение
        /// </summary>
        public bool UseSSL { get; set; }



    }
}
