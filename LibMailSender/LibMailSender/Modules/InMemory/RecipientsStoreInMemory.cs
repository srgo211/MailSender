using LibMailSender.Data;
using LibMailSender.Entities;
using LibMailSender.Modules.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LibMailSender.Modules.InMemory;

namespace LibMailSender.Modules
{
    public class RecipientsStoreInMemory : DataStoreInMemory<Recipient>, IRecipientsStore
    {

        public RecipientsStoreInMemory() : base(TestData.ListRecipients) { }

        /// <summary>
        /// Правка Получателей
        /// </summary>
        /// <param name="id">Идентификатор получателя</param>
        /// <param name="recipient">информацию которую нужно править</param>
        public override void Edit(int id, Recipient recipient)
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

     

  

    }
}
