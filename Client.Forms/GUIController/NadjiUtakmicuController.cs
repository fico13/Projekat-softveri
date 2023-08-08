using Client.Forms.Exceptions;
using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Utakmica;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class NadjiUtakmicuController
    {
        private UCPretragaUtakmica uCPretragaUtakmica;
        public Utakmica Utakmica { get; set; }

        public NadjiUtakmicuController(UCPretragaUtakmica uCPretragaUtakmica)
        {
            this.uCPretragaUtakmica = uCPretragaUtakmica;
        }

        internal void Init()
        {
            uCPretragaUtakmica.CbTimovi.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
            uCPretragaUtakmica.BtnUcitajUtakmicu.Enabled = false;
            uCPretragaUtakmica.BtnPrikaziStatistiku.Enabled = false;
            uCPretragaUtakmica.DgvDomaci.Visible = false;
            uCPretragaUtakmica.DgvGosti.Visible = false;
        }

        internal void NadjiUtakmice()
        {
            if(UserControlsHelper.ComboBoxValidation(uCPretragaUtakmica.CbTimovi))
            {
                MessageBox.Show("Sistem ne može da nađe utakmice po zadatoj vrednosti! Niste lepo odabrali tim iz combobox-a! Pokušajte ponovo!");
            }
            Utakmica utakmica = new Utakmica
            {
                FindCondition = $"lower(d.ImeTima) like '{uCPretragaUtakmica.CbTimovi.Text.ToLower()}' or lower(g.ImeTima) like '{uCPretragaUtakmica.CbTimovi.Text.ToLower()}'"
            };
            try
            {
                BindingList<Utakmica> utakmice = new BindingList<Utakmica>(Communication.Instance.SendRequestGetResult<List<Utakmica>>(Operation.NadjiUtakmice, utakmica));
                if (utakmice.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe utakmice po zadatoj vrednosti!");
                    uCPretragaUtakmica.DgvUtakmice.DataSource = null;
                    return;
                }
                uCPretragaUtakmica.DgvUtakmice.DataSource = utakmice;
                uCPretragaUtakmica.BtnUcitajUtakmicu.Enabled = true;
                OcistiPodatke();

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe utakmice po zadatoj vrednosti!");
                throw;
            }
        }

        internal void PrikaziStatistiku()
        {
            List<Statistika> statistikaDomacin = new List<Statistika>();
            List<Statistika> statistikaGost = new List<Statistika>();
            foreach (var statistika in Utakmica.Statistka)
            {
                statistika.Utakmica = Utakmica;
                if (statistika.Igrac.Tim.TimId == Utakmica.Domacin.TimId)
                {
                    statistikaDomacin.Add(statistika);
                }

                if (statistika.Igrac.Tim.TimId == Utakmica.Gost.TimId)
                {
                    statistikaGost.Add(statistika);
                }
            }
            uCPretragaUtakmica.DgvDomaci.Visible = true;
            uCPretragaUtakmica.DgvGosti.Visible = true;
            uCPretragaUtakmica.LblDomacin.Text = Utakmica.Domacin.ToString();
            uCPretragaUtakmica.LblGost.Text = Utakmica.Gost.ToString();
            uCPretragaUtakmica.DgvDomaci.DataSource = statistikaDomacin;
            uCPretragaUtakmica.DgvGosti.DataSource = statistikaGost;
            statistikaDomacin = new List<Statistika>();
            statistikaGost = new List<Statistika>();

        }

        private void OcistiPodatke()
        {
            uCPretragaUtakmica.TxtDomacin.Text = "";
            uCPretragaUtakmica.TxtPoeniDomacin.Text = "";
            uCPretragaUtakmica.TxtGost.Text = "";
            uCPretragaUtakmica.TxtPoeniGost.Text = "";
            uCPretragaUtakmica.TxtDatum.Text = "";
        }

        internal void UcitajUtakmicu()
        {
            if(uCPretragaUtakmica.DgvUtakmice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne može da učita utakmicu! Niste odabrali nijednu utakmicu! Pokušajte ponovo!");
                return;
            }
            Utakmica = (Utakmica)uCPretragaUtakmica.DgvUtakmice.SelectedRows[0].DataBoundItem;
            uCPretragaUtakmica.TxtDomacin.Text = Utakmica.Domacin.ToString();
            uCPretragaUtakmica.TxtPoeniDomacin.Text = Utakmica.BrojPoenaDomacin.ToString();
            uCPretragaUtakmica.TxtGost.Text = Utakmica.Gost.ToString();
            uCPretragaUtakmica.TxtPoeniGost.Text = Utakmica.BrojPoenaGost.ToString();
            uCPretragaUtakmica.TxtDatum.Text = Utakmica.DatumOdigravanja.ToString();
            uCPretragaUtakmica.BtnPrikaziStatistiku.Enabled = true;
        }
    }
}
