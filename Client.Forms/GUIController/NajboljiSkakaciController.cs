using Client.Forms.Exceptions;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Statistika;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class NajboljiSkakaciController
    {
        private UCNajboljiSkakaci uCNajboljiSkakaci;
        private List<Igrac> igraci = new List<Igrac>();
        private List<Statistika> statistike = new List<Statistika>();
        private int zbir = 0;

        public NajboljiSkakaciController(UCNajboljiSkakaci uCNajboljiSkakaci)
        {
            this.uCNajboljiSkakaci = uCNajboljiSkakaci;
        }

        internal void Init()
        {

            try
            {
                Igrac igrac = new Igrac();
                igraci = Communication.Instance.SendRequestGetResult<List<Igrac>>(
                    Operation.NadjiIgrace, igrac);
                if (igraci.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (var i in igraci)
                {
                    Statistika statistika = new Statistika
                    {
                        FindCondition = $"where s.IgracId = {i.IgracId}"
                    };
                    statistike = Communication.Instance.SendRequestGetResult<List<Statistika>>(Operation.NadjiStatistiku, statistika);
                    foreach (var s in statistike)
                    {
                        zbir += s.Skokovi;
                    }
                    i.ProsekSkokovi = (double)zbir / statistike.Count;
                    statistike = new List<Statistika>();
                    zbir = 0;
                }
                igraci.Sort((x, y) => x.ProsekSkokovi.CompareTo(y.ProsekSkokovi));
                igraci.Reverse();
                for (int i = 0; i < igraci.Count; i++)
                {
                    igraci[i].Rank = i + 1;
                }
                uCNajboljiSkakaci.DgvIgraci.DataSource = igraci;

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
    }
}
