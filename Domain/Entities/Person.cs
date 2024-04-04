using Domain.ValueObjects;
using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Класс определяющий сущность Пользователя и его характеристики
    /// </summary>
    public class Person : BaseEntity
    {
        public Person(FullName fullName, DateTime birthday, int age, List<CustomField> customFields) 
        {
            FullName = fullName;
            Birthday = birthday;
            Age = age;
            CustomFields = customFields;
        }
        
        public FullName FullName { get; set; }

        public DateTime Birthday { get; private set; }

        public int Age
        {
            get
            {
                int month = Birthday.Month; int day = Birthday.Day;
                if (Birthday.Month == 2 && Birthday.Day == 29)
                {
                    month = 3; day = 1;
                }
                int age = DateTime.Now.Year - Birthday.Year;
                if (DateTime.Now.Month < month || (DateTime.Now.Month == month && DateTime.Now.Day < day))
                {
                    age--;
                }

                return age;
            }
            set
            {
                // TODO: Реализовать setter 
                //OK? (переделать)
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException(nameof(value), "Возраст должен быть в диапазоне от 0 до 120.");
                }
                else
                {
                    int month = Birthday.Month; int day = Birthday.Day;
                    if (Birthday.Month == 2 && Birthday.Day == 29)
                    {
                        month = 3; day = 1;
                    }
                    int age = DateTime.Now.Year - Birthday.Year;
                    if (DateTime.Now.Month < month || (DateTime.Now.Month == month && DateTime.Now.Day < day))
                    {
                        age--;
                    }
                    value = age - value;
                    Birthday = DateTime.Today.AddYears(value);
                }
            }
        }


        public Gender Gender { get; set; }

        // Лист сущностей (имя филда и значения)  
        public List<CustomField>? CustomFields { get; set; }

    }
}
