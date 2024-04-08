using Domain.Entities;
using Domain.Primitives;
using Domain.ValueObjects;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator() 
        {
            RuleFor(x => x.Birthday)
                .NotNull()
                .WithMessage(ValidationMessage.NotNull)
                .NotEmpty()
                .WithMessage(ValidationMessage.NotEmpty)
                .GreaterThan(new DateTime(1905, 1, 1))
                .WithMessage(ValidationMessage.CorrectDate);

            RuleFor(x => x.FullName).SetValidator(new FullNameValidator());

            RuleFor(x => x.Age)
                .NotNull()
                .WithMessage(ValidationMessage.NotNull)
                .NotEmpty()
                .WithMessage(ValidationMessage.NotEmpty)
                .GreaterThan(120)
                .WithMessage(ValidationMessage.CorrectDate);

            //RuleFor(x => x.CustomFields).SetValidator(new CustomFieldValidator());
        }
    }
}
