using Client.Forms.Exceptions;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Statistika;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class TabelaTimovaController
    {
        private UCTabelaTimova uCTabelaTimova;

        public TabelaTimovaController(UCTabelaTimova uCTabelaTimova)
        {
            this.uCTabelaTimova = uCTabelaTimova;
            try
            {
                Tim tim = new Tim
                {
                    FindCondition = "order by t.Bodovi desc, t.KosRazlika desc"
                };
                List<Tim> timovi = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.NadjiTimove, tim);
                for (int i = 0; i < timovi.Count; i++)
                {
                    timovi[i].Rank = i + 1;
                }
                uCTabelaTimova.DgvTabelaTimova.DataSource = timovi;
                
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
    }
}
