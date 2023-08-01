using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.TimSO
{
    public class SacuvajTimSO : SystemOperationBase
    {
        private Tim tim;

        public SacuvajTimSO(Tim tim)
        {
            this.tim = tim;
        }

        protected override void Execute()
        {
            repository.Sacuvaj(tim);
        }
    }
}
