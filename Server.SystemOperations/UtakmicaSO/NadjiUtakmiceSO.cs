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
        public List<Statistika> Statistike { get; set; }
        public NadjiUtakmiceSO(Utakmica utakmica)
        {
            this.utakmica = utakmica;
        }

        protected override void Execute()
        {
            Result = repository.NadjiOdredjeni(utakmica).Cast<Utakmica>().ToList();
            foreach (Utakmica u in Result)
            {
                Statistika statistika = new Statistika
                {
                    Utakmica = u
                };
                Statistike = repository.NadjiOdredjeni(statistika).Cast<Statistika>().ToList();
                u.Statistka = Statistike;
                Statistike = new List<Statistika>();
            }
        }
    }
}
