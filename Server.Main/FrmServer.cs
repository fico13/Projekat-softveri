using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Main
{
    public partial class FrmServer : Form
    {
        private Server server;
        public FrmServer()
        {
            InitializeComponent();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                server = new Server();
                server.Start();
                Thread nit = new Thread(server.ObradiKlijente);
                nit.Start();
                MessageBox.Show("Server je pokrenut");
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                txtStatus.Text = "Pokrenut";
                txtStatus.BackColor = Color.Green;
                txtStatus.ForeColor = Color.White;
            }
            catch (SocketException)
            {
                MessageBox.Show("Prekinuta je veza sa serverom!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            server?.Close();
            server = null;
            MessageBox.Show("Server je zaustavljen");
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            txtStatus.Text = "Stopiran";
            txtStatus.BackColor = Color.Red;
            txtStatus.ForeColor = Color.White;
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
