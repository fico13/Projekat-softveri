using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.Takmicenje
{
    public class SacuvajTakmicenjeSO : SystemOperationBase
    {
        private Common.Domain.Takmicenje takmicenje;

        public SacuvajTakmicenjeSO(Common.Domain.Takmicenje takmicenje)
        {
            this.takmicenje = takmicenje;
        }

        protected override void Execute()
        {
            repository.Sacuvaj(takmicenje);
        }
    }
}
