using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.Statistika
{
    public class NadjiStatistikeSO : SystemOperationBase
    {
        private Common.Domain.Statistika statistika;
        public List<Common.Domain.Statistika> Result { get; set; }

        public NadjiStatistikeSO(Common.Domain.Statistika statistika)
        {
            this.statistika = statistika;
        }

        
        protected override void Execute()
        {
            Result = repository.NadjiOdredjeni(statistika).Cast<Common.Domain.Statistika>().ToList();   
        }
    }
}
