using Client.Forms.Dialogs.Igrac;
using Client.Forms.Exceptions;
using Client.Forms.ServerCommunication;
using Client.Forms.Session;
using Client.Forms.UserControls.Igrac;
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
    public class PrikaziStatistikuController
    {
        private FrmStatistikaIgraca frmStatistikaIgraca;
        private Igrac izabraniIgrac;

        public PrikaziStatistikuController(FrmStatistikaIgraca frmStatistikaIgraca, Igrac izabraniIgrac)
        {
            this.frmStatistikaIgraca = frmStatistikaIgraca;
            this.izabraniIgrac = izabraniIgrac;
            frmStatistikaIgraca.LblIgrac.Text = izabraniIgrac.ToString() + $"\nTim: {izabraniIgrac.Tim.Ime}";
            try
            {
                Statistika statistika = new Statistika
                {
                    FindCondition = $"where i.IgracId = {izabraniIgrac.IgracId}"
                };
                List<Statistika> statistike = Communication.Instance.SendRequestGetResult<List<Statistika>>(
                    Operation.NadjiStatistiku, statistika);
                if(statistike.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe statistike po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Sistem je našao statistike po zadatoj vrednosti!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmStatistikaIgraca.DgvStatistika.DataSource = statistike;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe statistike po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
            
        }

        
    }
}
