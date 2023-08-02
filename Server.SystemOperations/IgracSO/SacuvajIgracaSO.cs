using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.IgracSO
{
    public class SacuvajIgracaSO : SystemOperationBase
    {
        private Igrac igrac;

        public SacuvajIgracaSO(Igrac igrac)
        {
            this.igrac = igrac;
        }

        protected override void Execute()
        {
            repository.Sacuvaj(igrac);
        }
    }
}
