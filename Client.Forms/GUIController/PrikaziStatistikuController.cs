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

        public PrikaziStatistikuController(FrmStatistikaIgraca frmStatistikaIgraca)
        {
            this.frmStatistikaIgraca = frmStatistikaIgraca;
            Igrac igrac = SessionData.Instance.IzabraniIgrac;
            frmStatistikaIgraca.LblIgrac.Text = igrac.ToString() + $"\nTim: {igrac.Tim.Ime}";
            try
            {
                Statistika statistika = new Statistika
                {
                    FindCondition = $"where i.IgracId = {igrac.IgracId}"
                };
                List<Statistika> statistikas = Communication.Instance.SendRequestGetResult<List<Statistika>>(
                    Operation.NadjiStatistiku, statistika);
                frmStatistikaIgraca.DgvStatistika.DataSource = statistikas;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe statistike po zadatoj vrednosti");
                throw;
            }
            
        }
    }
}
