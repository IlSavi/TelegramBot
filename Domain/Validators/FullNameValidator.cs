using Domain.Primitives;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class FullNameValidator : AbstractValidator<FullName> //FluentValidator
    {
        public FullNameValidator() 
        {
            //TODO: Провалидировать все поля 
            RuleFor(x => x.FirstName)
                .NotNull()
                .WithMessage(ValidationMessage.NotNull)
                .NotEmpty()
                .WithMessage("");
        }
        
    }
}
