using LibMailSender.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LibMailSender.Modules.Interfaces
{
    /// <summary>
    /// Интерфейс Менеджера Получателей
    /// </summary>
    public interface IRecipientManager
    {
        IEnumerable<Recipient> GetAll();


        void Add(Recipient NewRecipient);

        void Edit(Recipient Recipient);

        void SaveChanges();
    }

}
