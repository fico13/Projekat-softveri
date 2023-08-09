using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.UtakmicaSO
{
    public class UcitajUtakmicuSO : SystemOperationBase
    {
        private Utakmica utakmica;

        public UcitajUtakmicuSO(Utakmica utakmica)
        {
            this.utakmica = utakmica;
        }

        public Utakmica Result { get; set; }
        protected override void Execute()
        {
            Result = repository.NadjiOdredjeni(utakmica).Cast<Utakmica>().First();
        }
    }
}
