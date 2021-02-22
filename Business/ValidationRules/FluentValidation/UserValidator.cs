using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).MinimumLength(2);
            RuleFor(u => u.LastName).MinimumLength(2);
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.Password).MinimumLength(6);
            RuleFor(u => u.Password).Must(HasUpperCase);
            RuleFor(u => u.Password).Must(HasNumber);
        }

        private bool HasNumber(string arg)
        {
            return arg.Any(Char.IsDigit);
        }

        private bool HasUpperCase(string arg)
        {
            return arg.Any(char.IsUpper);
        }
    }
}
