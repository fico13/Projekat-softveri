using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.IgracSO
{
    public class NadjiIgraceSO : SystemOperationBase
    {
        private Igrac igrac;

        public NadjiIgraceSO(Igrac igrac)
        {
            this.igrac = igrac;
        }

        public List<Igrac> Result { get; set; }
        protected override void Execute()
        {
            Result = repository.NadjiOdredjeni(igrac).Cast<Igrac>().ToList();
        }
    }
}
