using LibMailSender.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Entities
{
    public class MailingList : NamedEntity
    {
        public ICollection<Recipient> Recipients { get; set; } = new List<Recipient>();

    }
}
