using Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    //TODO: Определить конструктор
    //OK

    /// <summary>
    /// Класс для определения ФИО пользователя
    /// </summary>
    public class FullName : BaseValueObject
    {
       public FullName()
        {
            var validator = new FullNameValidator();

            validator.Validate(this);
        }
        
        public FullName(string fName, string lName, string? mName = null) 
        {
            FirtsName = fName ?? throw new ArgumentNullException(nameof(fName));
            LastName = lName ?? throw new ArgumentNullException(nameof(lName));
            MiddleName = mName;
        }
        public required string FirtsName {  get; set; }
        public required string LastName { get; set; }
        public string? MiddleName {  get; set; }

        
    }
}
