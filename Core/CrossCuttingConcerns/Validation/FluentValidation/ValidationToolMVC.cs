using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public static class ValidationToolMVC
    {
        public static bool Validate(IValidator validator, object enttity)
        {
            List<string> errorList = new List<string>();
            var validContext = new ValidationContext<object>(enttity);
            var validResult = validator.Validate(validContext);
            return validResult.IsValid;
        }
    }
}