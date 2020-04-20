using LibMailSender.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Modules.Interfaces
{
    /// <summary>
    /// Интерфейс хранения данных
    /// </summary>
    public interface IRecipientsStore
    {
        IEnumerable<Recipient> Get();

        void Edit(int id, Recipient recipient);

        void SaveChanges();
    }
}
