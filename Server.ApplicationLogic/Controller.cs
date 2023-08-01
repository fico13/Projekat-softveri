using Common.Domain;
using Server.SystemOperations;
using Server.SystemOperations.AdministratorSO;
using Server.SystemOperations.DvoranaSO;
using Server.SystemOperations.TimSO;
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

        public object VratiSveDvorane()
        {
            SystemOperationBase so = new VratiListuDvoranaSO();
            so.ExecuteTemplate();
            return ((VratiListuDvoranaSO)so).Result;
        }

        public void SacuvajTim(Tim tim)
        {
            SystemOperationBase so = new SacuvajTimSO(tim);
            so.ExecuteTemplate();
        }

        public object NadjiTimove(Tim tim)
        {
            SystemOperationBase so = new NadjiTimoveSO(tim);
            so.ExecuteTemplate();
            return ((NadjiTimoveSO)so).Result;
        }
    }
}
