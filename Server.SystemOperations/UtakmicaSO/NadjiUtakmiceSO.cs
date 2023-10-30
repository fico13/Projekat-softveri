using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.UtakmicaSO
{
    public class NadjiUtakmiceSO : SystemOperationBase
    {
        private Utakmica utakmica;
        public List<Utakmica> Result { get; set; }
        public List<Common.Domain.Statistika> Statistike { get; set; }
        public NadjiUtakmiceSO(Utakmica utakmica)
        {
            this.utakmica = utakmica;
        }

        protected override void Execute()
        {
            Result = repository.NadjiOdredjeni(utakmica).Cast<Utakmica>().ToList();
            foreach (Utakmica u in Result)
            {
                Common.Domain.Statistika statistika = new Common.Domain.Statistika
                {
                    Utakmica = u,
                    FindCondition = $"s.UtakmicaId = {u.UtakmicaId}"
                };
                Statistike = repository.NadjiOdredjeni(statistika).Cast<Common.Domain.Statistika>().ToList();
                u.Statistka = Statistike;
                Statistike = new List<Common.Domain.Statistika>();
            }
        }
    }
}
