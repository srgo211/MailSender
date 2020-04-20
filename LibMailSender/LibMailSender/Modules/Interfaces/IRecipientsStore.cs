using LibMailSender.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Modules.Interfaces
{
    /// <summary>
    /// Интерфейс объекта храненилища данных  - получателей писем
    /// </summary>
    public interface IRecipientsStore
    {
        /// <summary>
        /// Получить Все данные из хранилища
        /// </summary>
        /// <returns></returns>
        IEnumerable<Recipient> GetAll();

        /// <summary>
        /// Получить элемент по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Recipient GetById(int id);

        /// <summary>
        /// Создать нового получателя
        /// </summary>
        /// <param name="Recipient">Данные к-рые необходимо создать</param>
        /// <returns></returns>
        int Create(Recipient Recipient);


        /// <summary>
        /// Отредактировать данные
        /// </summary>
        /// <param name="id">номер получателя по ID</param>
        /// <param name="recipient">Данные к-рые необходимо редактировать</param>
        void Edit(int id, Recipient recipient);

        /// <summary>
        ////Удалить получателя
        /// </summary>
        /// <param name="id">Id получателя</param>
        /// <returns></returns>
        Recipient Remove(int id);

        /// <summary>
        /// Сохранить данные
        /// </summary>
        void SaveChanges();
    }
}
