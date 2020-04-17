using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Entities
{
    /// <summary>Класс получателя</summary>
    public class Recipient
    {
        /// <summary>
        /// Имя получателя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  Email получателя
        /// </summary>
        public string AddressToEmail { get; set; }


    }
}
