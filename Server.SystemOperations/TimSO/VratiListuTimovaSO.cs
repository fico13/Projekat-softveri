using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.TimSO
{
    public class VratiListuTimovaSO : SystemOperationBase
    {
        public List<Tim> Result { get; set; }
        protected override void Execute()
        {
            Result = repository.VratiSveJoin(new Tim()).Cast<Tim>().ToList();
        }
    }
}
