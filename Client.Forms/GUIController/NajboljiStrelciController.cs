using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Statistika;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Forms.GUIController
{
    public class NajboljiStrelciController
    {
        private UCNajboljiStrelci uCNajboljiStrelci;
        private List<Igrac> igraci = new List<Igrac>();
        private List<Statistika> statistike = new List<Statistika>();
        private int zbir = 0;
        

        public NajboljiStrelciController(UCNajboljiStrelci uCNajboljiStrelci)
        {
            this.uCNajboljiStrelci = uCNajboljiStrelci;
        }

        internal void Init()
        {
            Igrac igrac = new Igrac();
            igraci = Communication.Instance.SendRequestGetResult<List<Igrac>>(
                Operation.NadjiIgrace, igrac);
            foreach (var i in igraci)
            {
                Statistika statistika = new Statistika
                {
                    FindCondition = $"where s.IgracId = {i.IgracId}"
                };
                statistike = Communication.Instance.SendRequestGetResult<List<Statistika>>(Operation.NadjiStatistiku, statistika);
                foreach (var s in statistike)
                {
                    zbir += s.Poeni;
                }
                i.ProsekPoeni = (double)zbir / statistike.Count;
                statistike = new List<Statistika>();
                zbir = 0;
            }
            igraci.Sort((x, y) => x.ProsekPoeni.CompareTo(y.ProsekPoeni));
            igraci.Reverse();
            uCNajboljiStrelci.DgvIgraci.DataSource = igraci;
        }
    }
}
