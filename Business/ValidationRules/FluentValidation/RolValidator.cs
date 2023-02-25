using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RolValidator : AbstractValidator<AppRole>
    {
        public RolValidator()
        {
            RuleFor(p => p.RolName).MinimumLength(2);
            RuleFor(p => p.RolName).NotEmpty();
        }
    }
}