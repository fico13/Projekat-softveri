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
            foreach (var utakmica in takmicenje.Utakmice)
            {
                utakmica.Takmicenje = new Common.Domain.Takmicenje
                {
                    TakmicenjeID = repository.VratiMaxID(takmicenje)
                };
                utakmica.UtakmicaId = repository.DajNoviID(utakmica);
                repository.Sacuvaj(utakmica);
                foreach (var statistika in utakmica.Statistka)
                {
                    statistika.Utakmica = new Utakmica
                    {
                        UtakmicaId = repository.VratiMaxID(utakmica)
                    };
                    statistika.Takmicenje = new Common.Domain.Takmicenje
                    {
                        TakmicenjeID = repository.VratiMaxID(takmicenje)
                    };
                    repository.Sacuvaj(statistika);
                }
                repository.Update(utakmica.Domacin);
                repository.Update(utakmica.Gost);
            }
        }
    }
}
