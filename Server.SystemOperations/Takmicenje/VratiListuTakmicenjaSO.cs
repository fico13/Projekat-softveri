using System;
using Common.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.Takmicenje
{
    public class VratiListuTakmicenjaSO : SystemOperationBase
    {
        public List<Common.Domain.Takmicenje> Result { get; set; }
        protected override void Execute()
        {
            Result = repository.VratiSve(new Common.Domain.Takmicenje()).OfType<Common.Domain.Takmicenje>().ToList();
        }
    }
}
