using Common.Domain;
using Server.SystemOperations;
using Server.SystemOperations.AdministratorSO;
using Server.SystemOperations.DvoranaSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ApplicationLogic
{
    public class Controller
    {
        private static Controller instance;

        private Controller()
        {

        }

        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }

        public object UlogujAdministratora(Administrator administrator)
        {
            SystemOperationBase so = new UlogujAdministratoraSO(administrator);
            so.ExecuteTemplate();
            return ((UlogujAdministratoraSO)so).Result;
        }

        public void SacuvajDvoranu(Dvorana dvorana)
        {
            SystemOperationBase so = new SacuvajDvoranuSO(dvorana);
            so.ExecuteTemplate();
        }
    }
}
