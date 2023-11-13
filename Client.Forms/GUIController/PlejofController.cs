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
        private Tim a1;
        private Tim a2;
        private Tim b1;
        private Tim b2;
        private Tim c1;
        private Tim c2;
        private Tim d1;
        private Tim d2;

        public PlejofController(UCPlejof uCPlejof)
        {
            this.uCPlejof = uCPlejof;
            try
            {
                Tim tim = new Tim
                {
                    FindCondition = "order by t.Bodovi desc, t.KosRazlika desc"
                };
                BindingList<Tim> timovi = new BindingList<Tim>(Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.NadjiTimove, tim));
                a1 = timovi[0];
                a2 = timovi[7];
                b1 = timovi[1];
                b2 = timovi[6];
                c1 = timovi[2];
                c2 = timovi[5];
                d1 = timovi[3];
                d2 = timovi[4];
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

        internal void DodajUtakmicuD()
        {
            FrmUtakmica frmUtakmica = new FrmUtakmica(d1, d2);
            frmUtakmica.ShowDialog();
        }

        internal void DodajUtakmicuC()
        {
            FrmUtakmica frmUtakmica = new FrmUtakmica(c1, c2);
            frmUtakmica.ShowDialog();
        }

        internal void DodajUtakmicuB()
        {
            FrmUtakmica frmUtakmica = new FrmUtakmica(b1, b2);
            frmUtakmica.ShowDialog();
        }

        internal void DodajUtakmicuA()
        {
            FrmUtakmica frmUtakmica = new FrmUtakmica(a1, a2);
            frmUtakmica.ShowDialog();
        }
    }
}
