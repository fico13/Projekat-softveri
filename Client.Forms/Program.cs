using Client.Forms.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            while(true)
            {
                try
                {
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.ShowDialog();
                    DialogResult result = frmLogin.DialogResult;
                    if(result == DialogResult.OK)
                    {
                        Application.Run(new FrmMain());
                        frmLogin.Dispose();
                    }
                    if(result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Pokusajte ponovo prijavu!");
                    }
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Server je isključen! Uključite ga i pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (SystemOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
