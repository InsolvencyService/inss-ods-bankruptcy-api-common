using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public abstract class CompositeValidator<T> : AbstractValidator<T>
    {
        private List<IValidator> otherValidators = new List<IValidator>();

        protected void RegisterBaseValidator<TBase>(IValidator<TBase> validator)
        {
            // Ensure that we've registered a compatible validator. 
            if (validator.CanValidateInstancesOfType(typeof(T)))
            {
                otherValidators.Add(validator);
            }
            else
            {
                throw new NotSupportedException(string.Format("Type {0} is not a base-class or interface implemented by {1}.", typeof(TBase).Name, typeof(T).Name));
            }

        }


        public override ValidationResult Validate(ValidationContext<T> context)
        {
            var mainErrors = base.Validate(context).Errors;
            var errorsFromOtherValidators = otherValidators.SelectMany(x => x.Validate(context).Errors);
            var combinedErrors = mainErrors.Concat(errorsFromOtherValidators);

            return new ValidationResult(combinedErrors);
        }
    }
}
