using LibMailSender.Entities.Base;
using LibMailSender.Modules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibMailSender.Modules.InMemory
{
    public abstract class DataStoreInMemory<T> : IDataStore<T> where T : BaseEntity
    {
        private readonly List<T> _Items;

        protected DataStoreInMemory(List<T> Items = null) => _Items = Items ?? new List<T>();

        /// <summary>
        ///  Интерфейс для хранения инфо в памяти
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll() => _Items;

        /// <summary>
        /// Ворачивает найденный элемент по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id) => _Items.FirstOrDefault(item => item.Id == id);

        public int Create(T item)
        {
            //Если в нашем списке элемент содержится  - то делать ничего не будем
            if (_Items.Contains(item)) return item.Id;

            //если в списке Получателей 0 записей то присваиваем 1 или след. запись
            item.Id = _Items.Count == 0 ? 1
                            : _Items.Max(r => r.Id) + 1;
            //Добавляем получателя в список
            _Items.Add(item);
            return item.Id;

            /* TODO 
             * Если используем БД - то прописываем код для добавления в БД
             */
        }

        public abstract void Edit(int id, T item);



        public T Remove(int id)
        {
            var item = GetById(id);
            if (item != null)
                _Items.Remove(item);
            return item;
        }

        public void SaveChanges()
        {
            System.Diagnostics.Debug.WriteLine("Сохранение изменений в хранилище {0}.", typeof(T));
        }
    }
}
