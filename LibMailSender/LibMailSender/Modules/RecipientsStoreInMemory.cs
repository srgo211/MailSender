using LibMailSender.Data;
using LibMailSender.Entities;
using LibMailSender.Modules.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Modules
{
    public class RecipientsStoreInMemory : IRecipientsStore
    {
        /// <summary>
        /// Интерфейс для хранения инфо в памяти
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Recipient> GetAll() => TestData.ListRecipients;

        /// <summary>
        /// Правка Получателей
        /// </summary>
        /// <param name="id">Идентификатор получателя</param>
        /// <param name="recipient">информацию которую нужно править</param>
        public void Edit(int id, Recipient recipient)
        {
            /*т.к. у нас хранится в памяти то ничего не делаем
             * если хранили в БД
             * то взяли бы контент БД 
             * и внесли изменения в запись с указанным ID
             * а инфо взять из recipient
             * */
        }

        /// <summary>
        /// Сохранение информации
        /// </summary>
        public void SaveChanges()
        {
            /*т.к. у нас хранится в памяти то ничего не делаем
             * если хранили в БД
             * то внести измения в БД
             * */
        }
    }
}
