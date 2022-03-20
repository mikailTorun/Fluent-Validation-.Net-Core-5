using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluent_Validation_.Net_Core_5.Model.Validators
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Name is must be filled");
            RuleFor(x => x.Address).MaximumLength(50).WithMessage("Address area length can be at most 50 character");
            RuleFor(x => x.EmployeeCount).GreaterThanOrEqualTo(0).WithMessage("EmployeeCount cannot be less than 0");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Not a correct email");
        }
    }
}
