using Client.Forms.Dialogs.Utakmica;
using Client.Forms.Exceptions;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Takmicenje;
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
    public class PlejofController
    {
        private UCPlejof uCPlejof;
        private List<Tim> timovi;
        private Tim a1;
        private Tim a2;
        private Tim b1;
        private Tim b2;
        private Tim c1;
        private Tim c2;
        private Tim d1;
        private Tim d2;
        private Tim e1;
        private Tim e2;
        private Tim f1;
        private Tim f2;
        private Tim g1;
        private Tim g2;

        public PlejofController(UCPlejof uCPlejof)
        {
            this.uCPlejof = uCPlejof;
            try
            {
                Tim tim = new Tim
                {
                    FindCondition = "order by t.Bodovi desc, t.KosRazlika desc"
                };
                timovi = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.NadjiTimove, tim);
                a1 = timovi[0];
                a2 = timovi[7];
                b1 = timovi[3];
                b2 = timovi[4];
                c1 = timovi[1];
                c2 = timovi[6];
                d1 = timovi[2];
                d2 = timovi[5];
                uCPlejof.TxtA1.Text = a1.ToString();
                uCPlejof.TxtA2.Text = a2.ToString();
                uCPlejof.TxtB1.Text = b1.ToString();
                uCPlejof.TxtB2.Text = b2.ToString();
                uCPlejof.TxtC1.Text = c1.ToString();
                uCPlejof.TxtC2.Text = c2.ToString();
                uCPlejof.TxtD1.Text = d1.ToString();
                uCPlejof.TxtD2.Text = d2.ToString();
                

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti!");
                throw;
            }
        }

        internal void DodajUtakmicuE()
        {
            FrmUtakmica frmUtakmica = new FrmUtakmica(e1, e2, "polufinale");
            frmUtakmica.ShowDialog();
            Utakmica utakmica = new Utakmica
            {
                FindCondition = $"where d.ImeTime like '{e1.Ime}%' and u.FazaTakmicenja = 'polufinale'"
            };
            List<Utakmica> utakmice = Communication.Instance.SendRequestGetResult<List<Utakmica>>(Operation.NadjiUtakmice, utakmica);
            utakmica = utakmice[0];
            if (utakmica.BrojPoenaDomacin > utakmica.BrojPoenaGost)
            {
                MessageBox.Show($"Polufinale je zavrseno, pobednik je {e1.Ime}");
                g1 = e1;
            }
            else
            {
                MessageBox.Show($"Polufinale je zavrseno, pobednik je {e2.Ime}");
                g1 = e2;
            }

        }

        internal void DodajUtakmicuD()
        {
            FrmUtakmica frmUtakmica = new FrmUtakmica(d1, d2, "top8");
            frmUtakmica.ShowDialog();
            UpisiRezultat(d1, d2, uCPlejof.TxtRezultatD1, uCPlejof.TxtRezultatD2);
            if (uCPlejof.TxtRezultatD1.Text == "3")
            {
                MessageBox.Show($"Serija je zavrsena, ponbednik je {d1.Ime}");
                uCPlejof.BtnDodajD.Enabled = false;
                uCPlejof.TxtF2.Text = d1.Ime;
                f2 = d1;
            }
            if (uCPlejof.TxtRezultatD2.Text == "3")
            {
                MessageBox.Show($"Serija je zavrsena, ponbednik je {d2.Ime}");
                uCPlejof.BtnDodajD.Enabled = false;
                uCPlejof.TxtF2.Text = d2.Ime;
                f2 = d1;
            }
        }

        internal void DodajUtakmicuC()
        {
            FrmUtakmica frmUtakmica = new FrmUtakmica(c1, c2, "top8");
            frmUtakmica.ShowDialog();
            UpisiRezultat(c1, c2, uCPlejof.TxtRezultatC1, uCPlejof.TxtRezultatC2);
            if (uCPlejof.TxtRezultatB1.Text == "3")
            {
                MessageBox.Show($"Serija je zavrsena, ponbednik je {c1.Ime}");
                uCPlejof.BtnDodajC.Enabled = false;
                uCPlejof.TxtF1.Text = c1.Ime;
                f1 = c1;
            }
            if (uCPlejof.TxtRezultatB2.Text == "3")
            {
                MessageBox.Show($"Serija je zavrsena, ponbednik je {c2.Ime}");
                uCPlejof.BtnDodajC.Enabled = false;
                uCPlejof.TxtF1.Text = c2.Ime;
                f1 = c2;
            }
        }

        internal void DodajUtakmicuB()
        {
            FrmUtakmica frmUtakmica = new FrmUtakmica(b1, b2, "top8");
            frmUtakmica.ShowDialog();
            UpisiRezultat(b1, b2, uCPlejof.TxtRezultatB1, uCPlejof.TxtRezultatB2);
            if (uCPlejof.TxtRezultatB1.Text == "3")
            {
                MessageBox.Show($"Serija je zavrsena, ponbednik je {b1.Ime}");
                uCPlejof.BtnDodajB.Enabled = false;
                uCPlejof.TxtE2.Text = b1.Ime;
                e2 = b1;
            }
            if (uCPlejof.TxtRezultatB2.Text == "3")
            {
                MessageBox.Show($"Serija je zavrsena, ponbednik je {b2.Ime}");
                uCPlejof.BtnDodajB.Enabled = false;
                uCPlejof.TxtE2.Text = b2.Ime;
                e2 = b2;
            }
        }

        internal void DodajUtakmicuA()
        {
            FrmUtakmica frmUtakmica = new FrmUtakmica(a1, a2, "top8");
            frmUtakmica.ShowDialog();
            UpisiRezultat(a1, a2, uCPlejof.TxtRezultatA1, uCPlejof.TxtRezultatiA2);
            if (uCPlejof.TxtRezultatA1.Text == "3")
            {
                MessageBox.Show($"Serija je zavrsena, ponbednik je {a1.Ime}");
                uCPlejof.BtnDodajA.Enabled = false;
                uCPlejof.TxtE1.Text = a1.Ime;
                e1 = a1;
            }
            if (uCPlejof.TxtRezultatiA2.Text == "3")
            {
                MessageBox.Show($"Serija je zavrsena, ponbednik je {a2.Ime}");
                uCPlejof.BtnDodajA.Enabled = false;
                uCPlejof.TxtE2.Text = a2.Ime;
                e1 = a2;
            }
        }

        private void UpisiRezultat(Tim a1, Tim a2, TextBox domacin, TextBox gost)
        {
            Utakmica utakmica = new Utakmica
            {
                FindCondition = $"where d.ImeTima like '{a1.Ime}' and u.FazaTakmicenja like 'top8'"
            };
            List<Utakmica> utakmice = Communication.Instance.SendRequestGetResult<List<Utakmica>>(Operation.NadjiUtakmice, utakmica);
            int pobedeDomacin = 0;
            int pobedeGost = 0;
            foreach (var u in utakmice)
            {
                if (u.BrojPoenaDomacin > u.BrojPoenaGost) pobedeDomacin++;
                else pobedeGost++;
            }
            domacin.Text = pobedeDomacin.ToString();
            gost.Text = pobedeGost.ToString();
        }
    }
}
