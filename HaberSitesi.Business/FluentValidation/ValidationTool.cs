using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Business.FluentValidation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object nesne)
        {
            var result = validator.Validate(nesne);
            if(result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
