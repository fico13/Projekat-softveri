using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.TimSO
{
    public class UcitajTimSO : SystemOperationBase
    {
        private Tim tim;

        public UcitajTimSO(Tim tim)
        {
            this.tim = tim;
        }
        public Tim Result { get; set; }
        protected override void Execute()
        {
            Result = repository.NadjiOdredjeni(tim).Cast<Tim>().First();
        }
    }
}
