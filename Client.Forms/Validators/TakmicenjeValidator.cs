using Common.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Forms.Validators
{
    public class TakmicenjeValidator : AbstractValidator<Takmicenje>
    {
        public TakmicenjeValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;
            RuleFor(t => t.Naziv)
                .NotEmpty().WithMessage("{PropertyName} mora da sadrži neka slova!")
                .Must(ValidnoIme).WithMessage("{PropertyName} mora da sadrži samo slova!");
            RuleFor(t => t.Utakmice.First())
                .NotEmpty().WithMessage("Niste dodali nijednu utakmicu!");
        }

        public bool ValidnoIme(string ime)
        {
            ime = ime.Replace(" ", "");
            return ime.All(Char.IsLetter);
        }
    }
}
