using LibMailSender.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Entities
{
    /// <summary> Класс отправителя</summary>
     public class Sender : PersonEntity
    {
        public override string ToString() => $"{Name} : {AddressToEmail}";
    }
}
