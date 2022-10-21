using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Models.Concrete;

namespace Business.ValidationRules.FluentValidation
{
    class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.ReturnDate).NotEmpty();
        }
    }
}
