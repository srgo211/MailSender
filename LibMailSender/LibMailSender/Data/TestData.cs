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
            new Server {Name = "Рамблер", AddressSMTP="smtp.rambler.ru" , Port=25, UseSSL=false, LoginToEmail="Login", PasswordToEmail = "Pass" },
            new Server {Name = "Яндекс", AddressSMTP="smtp.yandex.ru" , Port=587, UseSSL=true, LoginToEmail="Login", PasswordToEmail = "Pass" },
            new Server {Name = "Gmail", AddressSMTP="smtp.google.com" , Port=587, UseSSL=true, LoginToEmail="Login", PasswordToEmail = "Pass" }
        };

        /// <summary>Список отправителей почты</summary>
        public static List<Sender> ListSenders { get; } = new List<Sender>
        {
            new Sender {AddressToEmail = "ivanov@email.com", Name = "Иванов" },
            new Sender {AddressToEmail = "petrov@email.com", Name = "Петров" },
            new Sender {AddressToEmail = "sidorov@email.com", Name = "Сидоров" }

        };


        /// <summary>Список получателей почты</summary>
        public static List<Recipient> ListRecipients { get; } = new List<Recipient>
        {
            new Recipient {AddressToEmail = "ivanov@email.com", Name = "Иванов П" },
            new Recipient {AddressToEmail = "petrov@email.com", Name = "Петров П" },
            new Recipient {AddressToEmail = "sidorov@email.com", Name = "Сидоров П" }

        };

    }
}
