using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.Validators
{
    public class DatumValidator : AbstractValidator<DateTimePicker>
    {
        public DatumValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;
            RuleFor(dtp => dtp.Value)
                .LessThan(DateTime.Now).WithMessage("Datum ne može biti u budućnosti!");
        }
    }
}
