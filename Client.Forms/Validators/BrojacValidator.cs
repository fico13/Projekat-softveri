using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.Validators
{
    public class BrojacValidator : AbstractValidator<NumericUpDown>
    {
        public BrojacValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;
            RuleFor(nud => nud.Value)
                .LessThan(100).WithMessage("Broj kola ne sme biti trocifren!")
                .GreaterThan(0).WithMessage("Broj kola mora biti veći od 0!");
        }
    }
}
