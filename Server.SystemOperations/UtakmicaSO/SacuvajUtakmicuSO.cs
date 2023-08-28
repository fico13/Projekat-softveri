using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.UtakmicaSO
{
    public class SacuvajUtakmicuSO : SystemOperationBase
    {
        private Utakmica utakmica;

        public SacuvajUtakmicuSO(Utakmica utakmica)
        {
            this.utakmica = utakmica;
        }

        protected override void Execute()
        {
            repository.Sacuvaj(utakmica);
            foreach (var statistika in utakmica.Statistka)
            {
                statistika.Utakmica = new Utakmica
                {
                    UtakmicaId = repository.VratiMaxID(utakmica)
                };
                repository.Sacuvaj(statistika);
            }
            repository.Update(utakmica.Domacin);
            repository.Update(utakmica.Gost);
        }
    }
}
