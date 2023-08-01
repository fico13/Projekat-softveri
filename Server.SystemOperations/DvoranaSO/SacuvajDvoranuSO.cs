using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.DvoranaSO
{
    public class SacuvajDvoranuSO : SystemOperationBase
    {
        private Dvorana dvorana;

        public SacuvajDvoranuSO(Dvorana dvorana)
        {
            this.dvorana = dvorana;
        }

        protected override void Execute()
        {
            repository.Sacuvaj(dvorana);
        }
    }
}
