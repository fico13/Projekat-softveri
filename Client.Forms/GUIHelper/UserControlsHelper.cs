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

        internal static bool IntegerValidation(TextBox tekst)
        {
            if (!tekst.Text.All(Char.IsDigit))
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

        internal static bool ComboBoxValidation(ComboBox cmbox)
        {
            if (cmbox.SelectedIndex == -1)
            {
                cmbox.BackColor = Color.LightCoral;
                return true;
            }
            else
            {
                cmbox.BackColor = Color.White;
                return false;
            }
        }
    }
}
