using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.Utakmica
{
    public class SacuvajUtakmicuSO : SystemOperationBase
    {
        private Common.Domain.Utakmica utakmica;

        public SacuvajUtakmicuSO(Common.Domain.Utakmica utakmica)
        {
            this.utakmica = utakmica;
        }

        protected override void Execute()
        {
            repository.Sacuvaj(utakmica);
            foreach (var statistika in utakmica.Statistka)
            {
                statistika.Utakmica = new Common.Domain.Utakmica
                {
                    UtakmicaId = repository.DajNoviID(utakmica)
                };
                repository.Sacuvaj(statistika);
            }
            repository.Update(utakmica.Domacin);
            repository.Update(utakmica.Gost);
        }
    }
}
