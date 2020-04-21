using System;
using System.Collections.Generic;
using System.Text;

namespace LibMailSender.Entities.Base
{
    /// <summary>
    /// Общий класс для всех сущностей (Получатели, отправители, сервера)
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id {get;set;}
    
    }
}
