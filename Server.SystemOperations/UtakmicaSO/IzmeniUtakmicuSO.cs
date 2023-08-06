using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.UtakmicaSO
{
    public class IzmeniUtakmicuSO : SystemOperationBase
    {
        private Utakmica utakmica;

        public IzmeniUtakmicuSO(Utakmica utakmica)
        {
            this.utakmica = utakmica;
        }

        protected override void Execute()
        {
            repository.Update(utakmica);
            foreach (var statistika in utakmica.Statistka)
            {
                repository.Update(statistika);
            }
        }
    }
}
