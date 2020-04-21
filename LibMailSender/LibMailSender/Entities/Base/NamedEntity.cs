using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Entities.Base
{   
    /// <summary>
    /// Общий класс для всех сущностей (Получатели, отправители, сервера)
    /// </summary>
    public abstract class NamedEntity : BaseEntity
    {
        /// <summary>
        /// Имя элемента
        /// </summary>
        public string Name { get; set; }
    }
}
