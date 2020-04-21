using LibMailSender.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Entities
{
    public class Mail : BaseEntity
    {
        /// <summary>
        /// тема письма
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Текс письма
        /// </summary>
        public string Body { get; set; }

        //public ICollection Attachments { get; set; } = new List<MailAttachment>();
    }

    //public class MailAttachment : BaseEntity
    //{
    //    // ...
    //}

  
}
