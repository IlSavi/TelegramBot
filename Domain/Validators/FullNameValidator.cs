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
    public class FullNameValidator : AbstractValidator<FullName> 
    {
        public FullNameValidator() 
        {
            //TODO: Провалидировать все поля 
            RuleFor(x => x.FirstName)
                .NotNull()
                .WithMessage(ValidationMessage.NotNull)
                .NotEmpty()
                .WithMessage(ValidationMessage.NotEmpty)
                .Matches(@"^[\p{L}]+$")
                .WithMessage(ValidationMessage.LettersOnly);

            RuleFor(x => x.LastName)
                .NotNull()
                .WithMessage(ValidationMessage.NotNull)
                .NotEmpty()
                .WithMessage(ValidationMessage.NotEmpty)
                .Matches(@"^[\p{L}]+$")
                .WithMessage(ValidationMessage.LettersOnly);

            RuleFor(x => x.MiddleName)
                .Matches(@"^[\p{L}]+$")
                .WithMessage(ValidationMessage.LettersOnly);
        } 
    }
}
