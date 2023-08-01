using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIHelper
{
    public class UserControlsHelper
    {
        internal static bool EmptyText(TextBox tekst)
        {
            if(string.IsNullOrWhiteSpace(tekst.Text))
            {
                tekst.BackColor = Color.LightCoral;
                return true;
            }
            else
            {
                tekst.BackColor = Color.White;
                return false;
            }
        }
    }
}
