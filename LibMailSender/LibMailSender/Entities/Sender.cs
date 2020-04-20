using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Entities
{
    /// <summary> Класс отправителя</summary>
     public class Sender
    {
        public int Id { get; set; }
        /// <summary>
        /// Имя отправителя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  Email отправителя
        /// </summary>
        public string AddressToEmail { get; set; }
    }
}
