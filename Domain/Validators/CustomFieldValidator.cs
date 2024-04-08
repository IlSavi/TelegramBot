
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Domain.Entities;
using Domain.Primitives;

namespace Domain.Validators
{
    public class CustomFieldValidator : AbstractValidator<CustomField>
    {
        public CustomFieldValidator() 
        {
            RuleFor(x => x.FieldName)
                .NotNull()
                .WithMessage(ValidationMessage.NotNull)
                .NotEmpty()
                .WithMessage(ValidationMessage.NotEmpty);

            RuleFor(x => x.Value)
                 .NotNull()
                .WithMessage(ValidationMessage.NotNull)
                .NotEmpty()
                .WithMessage(ValidationMessage.NotEmpty);
        }
    }
}
