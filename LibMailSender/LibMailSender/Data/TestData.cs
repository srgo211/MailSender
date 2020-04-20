using LibMailSender.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Data
{
    public static class TestData
    {
        /// <summary>Список серверов</summary>
        public static List<Server> ListServers { get; } = new List<Server>
        {
            new Server {Id = 0 ,Name = "Рамблер", AddressSMTP="smtp.rambler.ru" , Port=25, UseSSL=false, LoginToEmail="Login", PasswordToEmail = "Pass" },
            new Server {Id = 1 ,Name = "Яндекс", AddressSMTP="smtp.yandex.ru" , Port=587, UseSSL=true, LoginToEmail="Login", PasswordToEmail = "Pass" },
            new Server {Id = 2 ,Name = "Gmail", AddressSMTP="smtp.google.com" , Port=587, UseSSL=true, LoginToEmail="Login", PasswordToEmail = "Pass" }
        };

        /// <summary>Список отправителей почты</summary>
        public static List<Sender> ListSenders { get; } = new List<Sender>
        {
            new Sender { Id = 0,AddressToEmail = "ivanov@email.com", Name = "Иванов" },
            new Sender { Id = 1,AddressToEmail = "petrov@email.com", Name = "Петров" },
            new Sender { Id = 2,AddressToEmail = "sidorov@email.com", Name = "Сидоров" }

        };


        /// <summary>Список получателей почты</summary>
        public static List<Recipient> ListRecipients { get; } = new List<Recipient>
        {
            new Recipient { Id = 0, AddressToEmail = "ivanov@email.com", Name = "Иванов П" },
            new Recipient { Id = 1, AddressToEmail = "petrov@email.com", Name = "Петров П" },
            new Recipient { Id = 2, AddressToEmail = "sidorov@email.com", Name = "Сидоров П" }

        };

    }
}
