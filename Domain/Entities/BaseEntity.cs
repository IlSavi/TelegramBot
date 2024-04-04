using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Базовый класс для всех сущностей
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор для сущностей
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// TODO: Сравнение значения идентификатора сущностей
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if(obj is not BaseEntity entity)
            {
                return false;
            }

            if (Id != entity.Id)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            //TODO: Узнать и переопределить (связи с Equals и переопределение)!
            unchecked
            {
                return Id.GetHashCode();
            }
        }

        ///TODO: Переопределить == и !=
    }
}
