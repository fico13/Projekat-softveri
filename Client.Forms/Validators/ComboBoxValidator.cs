using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.Validators
{
    public class ComboBoxValidator : AbstractValidator<ComboBox>
    {
        public ComboBoxValidator(int index)
        {
            ClassLevelCascadeMode = CascadeMode.Stop;
            RuleFor(cb => cb.SelectedIndex)
                .NotEqual(index).WithMessage("Ne mogu isti timovi biti i domaćin i gost!")
                .GreaterThan(-1).WithMessage("Niste lepo odabrali tim u combo box-u!");
        }

        public ComboBoxValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;
            RuleFor(cb => cb.SelectedIndex)
                .GreaterThan(-1).WithMessage("Niste lepo odabrali igrača u combo box-u!");
        }
    }
}
