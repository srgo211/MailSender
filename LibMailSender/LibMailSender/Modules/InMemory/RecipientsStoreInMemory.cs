using LibMailSender.Data;
using LibMailSender.Entities;
using LibMailSender.Modules.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        /// Ворачивает найденный элемент по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Recipient GetById(int id) => TestData.ListRecipients.FirstOrDefault(d => d.Id == id);

        /// <summary>
        ////Создать получателя
        /// </summary>
        /// <param name="Recipient"></param>
        /// <returns></returns>
        public int Create(Recipient Recipient)
        {
            //Если в нашем списке элемент содержится  - то делать ничего не будем
            if (TestData.ListRecipients.Contains(Recipient)) return Recipient.Id;
            
            //если в списке Получателей 0 записей то присваиваем 1 или след. запись
            Recipient.Id = TestData.ListRecipients.Count == 0 ? 1
                            : TestData.ListRecipients.Max(r=> r.Id) + 1;
            //Добавляем получателя в список
            TestData.ListRecipients.Add(Recipient);
            return Recipient.Id;

            /* TODO 
             * Если используем БД - то прописываем код для добавления в БД
             */
        }



        /// <summary>
        /// Правка Получателей
        /// </summary>
        /// <param name="id">Идентификатор получателя</param>
        /// <param name="recipient">информацию которую нужно править</param>
        public void Edit(int id, Recipient recipient)
        {
            /*т.к. у нас хранится в памяти то ничего не делаем,
             * но сейчас пример как можно это реализовать
             * если бы работали с БД
             * */

            var db_recipient = GetById(id);
            if (db_recipient is null) return;

            db_recipient.Name = recipient.Name;
            db_recipient.AddressToEmail = recipient.AddressToEmail;




        }

        /// <summary>
        /// Удалить получателя
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Recipient Remove(int id)
        {
            var db_recipient = GetById(id);
            if (db_recipient != null)
                TestData.ListRecipients.Remove(db_recipient);
            return db_recipient;

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
            System.Diagnostics.Debug.WriteLine("Сохранение изменений в хранилище получателей писем");
        }

    }
}
