using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Entities.Base
{
    public abstract class PersonEntity : NamedEntity
    {
        /// <summary>
        ///  Email 
        /// </summary>
        public string AddressToEmail { get; set; }
    }
}
