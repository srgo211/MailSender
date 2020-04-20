using LibMailSender.Entities;
using LibMailSender.Modules.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Modules
{
    /// <summary>
    /// Менеджер Получателей писем
    /// </summary>
    public class RecipientsManager : IRecipientManager
    {

        private IRecipientsStore _Store;
        /// <summary>
        /// временный конструктор для хранения данных - потом можно изменить на любые данные (БД, файлы и тд)
        /// </summary>
        /// <param name="recipientStore"></param>
        public RecipientsManager(IRecipientsStore Store)
        {
            _Store = Store;

        }


        /// <summary>
        /// Получить всех получателей писем
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Recipient> GetAll()
        {
            return _Store.GetAll();
        }

        /// <summary>
        /// Добавить нового Получателя
        /// </summary>
        /// <param name="NewRecipient"></param>
        public void Add(Recipient NewRecipient)
        {
        }

        /// <summary>
        /// Правка информации
        /// </summary>
        /// <param name="Recipient"></param>
        public void Edit(Recipient Recipient)
        {
            //берем место хранения данных
            _Store.Edit(Recipient.Id, Recipient);

        }

        /// <summary>
        /// Сохранение информации
        /// </summary>
        public void SaveChanges()
        {
            //вызываеем метод для сохранения информации
            _Store.SaveChanges();
        }

        //Delete (Recipient)
    }
}
