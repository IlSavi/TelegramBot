using Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Класс для добавления кастомного поля свойств пользователю
    /// </summary>
    public class CustomField : BaseEntity
    {
        public required string FieldName { get; set; }
        public required object Value { get; set; }

        public CustomField(string fieldName, object value)
        {
            //FieldName = fieldName;
            //Value = value;
            var validator = new CustomFieldValidator();

            validator.Validate(this);
        }

    }
}
