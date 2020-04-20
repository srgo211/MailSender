using LibMailSender.Data;
using LibMailSender.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Modules
{
    public class RecipientsStoreInMemory
    {
        /// <summary>
        /// Интерфейс для хранения инфо в памяти
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Recipient> Get() => TestData.ListRecipients;
    }
}
