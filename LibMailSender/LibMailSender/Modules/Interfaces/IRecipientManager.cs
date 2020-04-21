using LibMailSender.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Modules.Interfaces
{
    public interface IRecipientManager
    {
        IEnumerable<Recipient> GetAll();

        void Add(Recipient NewRecipient);

        void Edit(Recipient Recipient);

        void SaveChanges();
    }
}
