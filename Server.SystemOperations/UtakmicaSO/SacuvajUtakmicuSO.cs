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
            utakmica.Takmicenje = new Common.Domain.Takmicenje
            {
                TakmicenjeID = repository.VratiMaxID(new Common.Domain.Takmicenje())
            };
            utakmica.UtakmicaId = repository.DajNoviID(utakmica);
            repository.Sacuvaj(utakmica);
            foreach (var statistika in utakmica.Statistka)
            {
                statistika.Utakmica = new Utakmica
                {
                    UtakmicaId = utakmica.UtakmicaId
                };
                statistika.Takmicenje = new Common.Domain.Takmicenje
                {
                    TakmicenjeID = utakmica.Takmicenje.TakmicenjeID
                };
                repository.Sacuvaj(statistika);
            }
            repository.Update(utakmica.Domacin);
            repository.Update(utakmica.Gost);
        }
    }
}
