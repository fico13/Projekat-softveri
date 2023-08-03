using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.IgracSO
{
    public class IzmeniIgracaSO : SystemOperationBase
    {
        private Igrac igrac;

        public IzmeniIgracaSO(Igrac igrac)
        {
            this.igrac = igrac;
        }

        protected override void Execute()
        {
            repository.Update(igrac);
        }
    }
}
