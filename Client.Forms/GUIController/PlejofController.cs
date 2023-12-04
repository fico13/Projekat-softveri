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
        private bool a;
        private bool b;
        private bool c;
        private bool d;
        private bool e;
        private bool f;

        public PlejofController(UCPlejof uCPlejof)
        {
            this.uCPlejof = uCPlejof;
        }

        internal void Init()
        {
            uCPlejof.BtnDodajE.Enabled = false;
            uCPlejof.BtnDodajF.Enabled = false;
            uCPlejof.BtnDodajG.Enabled = false;
            a = false;
            b = false;
            c = false;
            d = false;
            e = false;
            f = false;
            try
            {
                Tim tim = new Tim
                {
                    FindCondition = "order by t.Bodovi desc, t.KosRazlika desc"
                };
                timovi = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.NadjiTimove, tim);
                Utakmica utakmica = new Utakmica
                {
                    FindCondition = "where u.FazaTakmicenja = 'regularni deo'"
                };
                List<Utakmica> utakmice = Communication.Instance.SendRequestGetResult<List<Utakmica>>(Operation.NadjiUtakmice, utakmica);
                if(utakmice.Count == 0)
                {
                    MessageBox.Show("Niste dodali nijednu utakmicu u regularnom delu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    uCPlejof.Enabled = false;
                }
                else if (utakmice.Count * 2 < utakmice[0].Takmicenje.BrojKola * timovi.Count)
                {
                    MessageBox.Show("Regularni deo sezone još nije završen!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    uCPlejof.Enabled = false;
                }
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
                MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        internal void DodajUtakmicuG()
        {
            try
            {
                FrmPlejofUtakmica frmUtakmica = new FrmPlejofUtakmica(g1, g2, "finale");
                frmUtakmica.ShowDialog();
                Utakmica utakmica = new Utakmica
                {
                    FindCondition = $"where d.ImeTima like '{g1.Ime}%' and u.FazaTakmicenja = 'finale'"
                };
                List<Utakmica> utakmice = Communication.Instance.SendRequestGetResult<List<Utakmica>>(Operation.NadjiUtakmice, utakmica);
                utakmica = utakmice[0];
                uCPlejof.BtnDodajG.Enabled = false;
                if (utakmica.BrojPoenaDomacin > utakmica.BrojPoenaGost)
                {
                    MessageBox.Show($"Finale je završeno, pobednik je {g1.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.TxtRezultatG1.Text = utakmica.BrojPoenaDomacin.ToString();
                    uCPlejof.TxtRezultatG2.Text = utakmica.BrojPoenaGost.ToString();
                }
                else
                {
                    MessageBox.Show($"Finale je završeno, pobednik je {g2.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.TxtRezultatG1.Text = utakmica.BrojPoenaDomacin.ToString();
                    uCPlejof.TxtRezultatG2.Text = utakmica.BrojPoenaGost.ToString();
                }
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
           
        }

        internal void DodajUtakmicuF()
        {
            try
            {
                FrmPlejofUtakmica frmUtakmica = new FrmPlejofUtakmica(f1, f2, "polufinale");
                frmUtakmica.ShowDialog();
                Utakmica utakmica = new Utakmica
                {
                    FindCondition = $"where d.ImeTima like '{f1.Ime}%' and u.FazaTakmicenja = 'polufinale'"
                };
                List<Utakmica> utakmice = Communication.Instance.SendRequestGetResult<List<Utakmica>>(Operation.NadjiUtakmice, utakmica);
                utakmica = utakmice[0];
                uCPlejof.BtnDodajF.Enabled = false;
                if (utakmica.BrojPoenaDomacin > utakmica.BrojPoenaGost)
                {
                    MessageBox.Show($"Polufinale je završeno, pobednik je {f1.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.TxtG2.Text = f1.Ime;
                    uCPlejof.TxtRezultatF1.Text = utakmica.BrojPoenaDomacin.ToString();
                    uCPlejof.TxtRezultatF2.Text = utakmica.BrojPoenaGost.ToString();
                    g2 = f1;
                    f = true;
                    if (e == true) uCPlejof.BtnDodajG.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"Polufinale je završeno, pobednik je {f2.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.TxtG2.Text = f2.Ime;
                    uCPlejof.TxtRezultatF1.Text = utakmica.BrojPoenaDomacin.ToString();
                    uCPlejof.TxtRezultatF2.Text = utakmica.BrojPoenaGost.ToString();
                    g2 = f2;
                    f = true;
                    if (e == true) uCPlejof.BtnDodajG.Enabled = true;
                }
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
        }

        internal void DodajUtakmicuE()
        {
            try
            {
                FrmPlejofUtakmica frmUtakmica = new FrmPlejofUtakmica(e1, e2, "polufinale");
                frmUtakmica.ShowDialog();
                Utakmica utakmica = new Utakmica
                {
                    FindCondition = $"where d.ImeTima like '{e1.Ime}%' and u.FazaTakmicenja = 'polufinale'"
                };
                List<Utakmica> utakmice = Communication.Instance.SendRequestGetResult<List<Utakmica>>(Operation.NadjiUtakmice, utakmica);
                utakmica = utakmice[0];
                uCPlejof.BtnDodajE.Enabled = false;
                if (utakmica.BrojPoenaDomacin > utakmica.BrojPoenaGost)
                {
                    MessageBox.Show($"Polufinale je završeno, pobednik je {e1.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.TxtG1.Text = e1.Ime;
                    uCPlejof.TxtRezultatE1.Text = utakmica.BrojPoenaDomacin.ToString();
                    uCPlejof.TxtRezultatE2.Text = utakmica.BrojPoenaGost.ToString();
                    g1 = e1;
                    e = true;
                    if (f == true) uCPlejof.BtnDodajG.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"Polufinale je završeno, pobednik je {e2.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.TxtG1.Text = e2.Ime;
                    uCPlejof.TxtRezultatE1.Text = utakmica.BrojPoenaDomacin.ToString();
                    uCPlejof.TxtRezultatE2.Text = utakmica.BrojPoenaGost.ToString();
                    g1 = e2;
                    e = true;
                    if (f == true) uCPlejof.BtnDodajG.Enabled = true;
                }
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
      

        }

        internal void DodajUtakmicuD()
        {
            try
            {
                FrmPlejofUtakmica frmUtakmica = new FrmPlejofUtakmica(d1, d2, "top8");
                frmUtakmica.ShowDialog();
                UpisiRezultat(d1, d2, uCPlejof.TxtRezultatD1, uCPlejof.TxtRezultatD2);
                if (uCPlejof.TxtRezultatD1.Text == "3")
                {
                    MessageBox.Show($"Serija je završena, pobednik je {d1.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.BtnDodajD.Enabled = false;
                    uCPlejof.TxtF2.Text = d1.Ime;
                    f2 = d1;
                    d = true;
                    if (c == true) uCPlejof.BtnDodajF.Enabled = true;
                }
                if (uCPlejof.TxtRezultatD2.Text == "3")
                {
                    MessageBox.Show($"Serija je završena, pobednik je {d2.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.BtnDodajD.Enabled = false;
                    uCPlejof.TxtF2.Text = d2.Ime;
                    f2 = d1;
                    d = true;
                    if (c == true) uCPlejof.BtnDodajF.Enabled = true;
                }
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
        }

        internal void DodajUtakmicuC()
        {
            try
            {
                FrmPlejofUtakmica frmUtakmica = new FrmPlejofUtakmica(c1, c2, "top8");
                frmUtakmica.ShowDialog();
                UpisiRezultat(c1, c2, uCPlejof.TxtRezultatC1, uCPlejof.TxtRezultatC2);
                if (uCPlejof.TxtRezultatC1.Text == "3")
                {
                    MessageBox.Show($"Serija je završena, pobednik je {c1.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.BtnDodajC.Enabled = false;
                    uCPlejof.TxtF1.Text = c1.Ime;
                    f1 = c1;
                    c = true;
                    if (d == true) uCPlejof.BtnDodajF.Enabled = true;
                }
                if (uCPlejof.TxtRezultatC2.Text == "3")
                {
                    MessageBox.Show($"Serija je završena, pobednik je {c2.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.BtnDodajC.Enabled = false;
                    uCPlejof.TxtF1.Text = c2.Ime;
                    f1 = c2;
                    c = true;
                    if (d == true) uCPlejof.BtnDodajF.Enabled = true;
                }
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
        }

        internal void DodajUtakmicuB()
        {
            try
            {
                FrmPlejofUtakmica frmUtakmica = new FrmPlejofUtakmica(b1, b2, "top8");
                frmUtakmica.ShowDialog();
                UpisiRezultat(b1, b2, uCPlejof.TxtRezultatB1, uCPlejof.TxtRezultatB2);
                if (uCPlejof.TxtRezultatB1.Text == "3")
                {
                    MessageBox.Show($"Serija je završena, pobednik je {b1.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.BtnDodajB.Enabled = false;
                    uCPlejof.TxtE2.Text = b1.Ime;
                    e2 = b1;
                    b = true;
                    if (a == true) uCPlejof.BtnDodajE.Enabled = true;
                }
                if (uCPlejof.TxtRezultatB2.Text == "3")
                {
                    MessageBox.Show($"Serija je završena, pobednik je {b2.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.BtnDodajB.Enabled = false;
                    uCPlejof.TxtE2.Text = b2.Ime;
                    e2 = b2;
                    b = true;
                    if (a == true) uCPlejof.BtnDodajE.Enabled = true;
                }
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
        }

        internal void DodajUtakmicuA()
        {
            try
            {
                FrmPlejofUtakmica frmUtakmica = new FrmPlejofUtakmica(a1, a2, "top8");
                frmUtakmica.ShowDialog();
                UpisiRezultat(a1, a2, uCPlejof.TxtRezultatA1, uCPlejof.TxtRezultatiA2);
                if (uCPlejof.TxtRezultatA1.Text == "3")
                {
                    MessageBox.Show($"Serija je završena, pobednik je {a1.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.BtnDodajA.Enabled = false;
                    uCPlejof.TxtE1.Text = a1.Ime;
                    e1 = a1;
                    a = true;
                    if (b == true) uCPlejof.BtnDodajE.Enabled = true;
                }
                if (uCPlejof.TxtRezultatiA2.Text == "3")
                {
                    MessageBox.Show($"Serija je završena, pobednik je {a2.Ime}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCPlejof.BtnDodajA.Enabled = false;
                    uCPlejof.TxtE2.Text = a2.Ime;
                    e1 = a2;
                    a = true;
                    if (b == true) uCPlejof.BtnDodajE.Enabled = true;
                }
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
        }

        private void UpisiRezultat(Tim a1, Tim a2, TextBox domacin, TextBox gost)
        {
            try
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
            catch (ServerCommunicationException)
            {

                throw;
            }
        }
    }
}
