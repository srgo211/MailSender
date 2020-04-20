using LibMailSender.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Modules
{
    /// <summary>
    /// Менеджер Получателей писем
    /// </summary>
    public class RecipientsManager
    {

        private RecipientsStoreInMemory _Store;
        /// <summary>
        /// временный конструктор для хранения данных - потом можно изменить на любые данные (БД, файлы и тд)
        /// </summary>
        /// <param name="recipientStore"></param>
        public RecipientsManager(RecipientsStoreInMemory Store)
        {
            _Store = Store;

        }


        /// <summary>
        /// Получить всех получателей писем
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Recipient> GetAll()
        {
            return _Store.Get();
        }

        /// <summary>
        /// Добавить нового Получателя
        /// </summary>
        /// <param name="NewRecipient"></param>
        public void Add(Recipient NewRecipient)
        {
        }

        //Edit(Recipient)
        //Delete (Recipient)
    }
}
