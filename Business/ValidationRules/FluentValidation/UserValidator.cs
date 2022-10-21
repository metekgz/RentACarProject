using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Models.Concrete;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserFirstName).NotEmpty();
            RuleFor(u => u.UserLastName).NotEmpty();
        }
    }
}
