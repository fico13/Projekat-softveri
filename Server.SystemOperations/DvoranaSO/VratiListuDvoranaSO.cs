using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.DvoranaSO
{
    public class VratiListuDvoranaSO : SystemOperationBase
    {
        public List<Dvorana> Result { get; set; }
        protected override void Execute()
        {
            Result = repository.VratiSve(new Dvorana()).OfType<Dvorana>().ToList();
        }
    }
}
