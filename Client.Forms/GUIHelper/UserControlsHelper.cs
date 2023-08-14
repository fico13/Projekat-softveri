using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        internal static bool WordValidation(TextBox tekst)
        {
            if (tekst.Text.Any(Char.IsDigit))
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

        internal static bool DoubleValidation(TextBox tekst)
        {
            Regex proveriDouble = new Regex(@"^[0-9]{2,3}(.|,)?[0-9]*$");

            if (!proveriDouble.IsMatch(tekst.Text))
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

        internal static bool ZeroValidation(TextBox tekst)
        {
            int broj = Convert.ToInt32(tekst.Text);
            if(broj == 0)
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

        internal static bool ThreeDigitsNumberValidation(TextBox tekst)
        {
            int broj = Convert.ToInt32(tekst.Text);
            if (broj > 99)
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
