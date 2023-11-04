using Client.Forms.Exceptions;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Statistika;
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
                    FindCondition = "order by BrojBodova desc"
                };
                BindingList<Tim> timovi = new BindingList<Tim>(Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove, tim)); 
                uCTabelaTimova.DgvTabelaTimova.DataSource = timovi;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti!");
                throw;
            }
        }
    }
}
