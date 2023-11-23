using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.Validators
{
    public class BrojValidator : AbstractValidator<TextBox>
    {
        public BrojValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;
            RuleFor(tb => tb.Text)
                .NotEmpty().WithMessage("Niste uneli vrednost!")
                .Must(ValidanBroj).WithMessage("Broj mora biti prirodan!");
        }

        public bool ValidanBroj(string broj)
        {
            return broj.All(Char.IsDigit);
        }

    }
}
