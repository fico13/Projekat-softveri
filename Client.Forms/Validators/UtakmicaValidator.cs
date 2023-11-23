using Common.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Forms.Validators
{
    public class UtakmicaValidator : AbstractValidator<Utakmica>
    {
        public UtakmicaValidator(int brojPoenaGost, int kapacitet)
        {
            RuleFor(u => u.BrojPoenaDomacin)
                .NotEqual(brojPoenaGost).WithMessage("Broj poena domaćina i gosta ne sme biti isti!");
            RuleFor(u => u.BrojGledalaca)
                .LessThanOrEqualTo(kapacitet).WithMessage("Broj gledalaca ne može biti veći od kapaciteta dvorane");
        }
    }
}
