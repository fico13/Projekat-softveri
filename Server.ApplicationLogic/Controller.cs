using Common.Domain;
using Server.SystemOperations;
using Server.SystemOperations.AdministratorSO;
using Server.SystemOperations.DvoranaSO;
using Server.SystemOperations.IgracSO;
using Server.SystemOperations.Statistika;
using Server.SystemOperations.TimSO;
using Server.SystemOperations.UtakmicaSO;
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

        public Administrator UlogujAdministratora(Administrator administrator)
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

        public List<Dvorana> VratiSveDvorane()
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

        public List<Tim> NadjiTimove(Tim tim)
        {
            SystemOperationBase so = new NadjiTimoveSO(tim);
            so.ExecuteTemplate();
            return ((NadjiTimoveSO)so).Result;
        }

        public List<Tim> VratiSveTimove()
        {
            SystemOperationBase so = new VratiListuTimovaSO();
            so.ExecuteTemplate();
            return ((VratiListuTimovaSO)so).Result;
        }

        public void SacuvajIgraca(Igrac igrac)
        {
            SystemOperationBase so = new SacuvajIgracaSO(igrac);
            so.ExecuteTemplate();
        }

        public List<Igrac> NadjiIgrace(Igrac igrac)
        {
            SystemOperationBase so = new NadjiIgraceSO(igrac);
            so.ExecuteTemplate();
            return ((NadjiIgraceSO)so).Result;
        }

        public void IzmeniIgraca(Igrac igrac)
        {
            SystemOperationBase so = new IzmeniIgracaSO(igrac);
            so.ExecuteTemplate();
        }

        public void SacuvajUtakmicu(Utakmica utakmica)
        {
            SystemOperationBase so = new SacuvajUtakmicuSO(utakmica);
            so.ExecuteTemplate();
        }

        public List<Utakmica> NadjiUtakmice(Utakmica utakmica)
        {
            SystemOperationBase so = new NadjiUtakmiceSO(utakmica);
            so.ExecuteTemplate();
            return ((NadjiUtakmiceSO)so).Result;
        }

        public void IzmeniUtakmicu(Utakmica utakmica)
        {
            SystemOperationBase so = new IzmeniUtakmicuSO(utakmica);
            so.ExecuteTemplate();
        }

        public Utakmica UcitajUtakmicu(Utakmica utakmica)
        {
            SystemOperationBase so = new UcitajUtakmicuSO(utakmica);
            so.ExecuteTemplate();
            return ((UcitajUtakmicuSO)so).Result;
        }

        public Tim UcitajTim(Tim tim)
        {
            SystemOperationBase so = new UcitajTimSO(tim);
            so.ExecuteTemplate();
            return ((UcitajTimSO)so).Result;
        }

        public Igrac UcitajIgraca(Igrac igrac)
        {
            SystemOperationBase so = new UcitajIgracaSO(igrac);
            so.ExecuteTemplate();
            return ((UcitajIgracaSO)so).Result;
        }

        public List<Statistika> NadjiStatistike(Statistika statistika)
        {
            SystemOperationBase so = new NadjiStatistikeSO(statistika);
            so.ExecuteTemplate();
            return ((NadjiStatistikeSO)so).Result;
        }
    }
}
