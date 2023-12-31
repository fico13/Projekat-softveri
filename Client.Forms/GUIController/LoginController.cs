﻿using Client.Forms.Exceptions;
using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class LoginController
    {
        internal void Login(FrmLogin frmLogin)
        {
            if((UserControlsHelper.EmptyText(frmLogin.TxtUsername) && UserControlsHelper.EmptyText(frmLogin.TxtPassword)) || UserControlsHelper.EmptyText(frmLogin.TxtUsername) || UserControlsHelper.EmptyText(frmLogin.TxtPassword))
            {
                MessageBox.Show("Niste uneli sve podatke! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string username = frmLogin.TxtUsername.Text;
            string password = frmLogin.TxtPassword.Text;
            frmLogin.DialogResult = DialogResult.OK;
            try
            {
                Administrator administrator = new Administrator
                {
                    Username = username,
                    Password = password
                };
                Communication.Instance.Connect();
                administrator = Communication.Instance.SendRequestGetResult<Administrator>(Operation.UlogujAdministratora, administrator);
                if(administrator == null)
                {
                    frmLogin.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    MessageBox.Show($"Dobrodošli {administrator.Ime} {administrator.Prezime}", "Dobrodošli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin.DialogResult = DialogResult.OK;
                }
            }
            catch (SocketException)
            {
                throw new ServerCommunicationException();
            }
            catch(SystemOperationException ex)
            {
                throw new SystemOperationException(ex.Message);
            }
           

        }

        internal void HidePassword(FrmLogin frmLogin)
        {
            frmLogin.TxtPassword.PasswordChar = '*';
        }

        internal void ShowPassword(FrmLogin frmLogin)
        {
            frmLogin.TxtPassword.PasswordChar = '\0';
        }
    }
}
