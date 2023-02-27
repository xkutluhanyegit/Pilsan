using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object enttity)
        {
            //FluentValid Basicly
            var validContext = new ValidationContext<object>(enttity);
            var validResult = validator.Validate(validContext);


            if (!validResult.IsValid)
            {
                throw new ValidationException(validResult.Errors);
            }

        }
    }
}