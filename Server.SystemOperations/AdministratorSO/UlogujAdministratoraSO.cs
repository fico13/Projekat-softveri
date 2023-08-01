using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.AdministratorSO
{
    public class UlogujAdministratoraSO : SystemOperationBase
    {
        private Administrator administrator;

        public UlogujAdministratoraSO(Administrator administrator)
        {
            this.administrator = administrator;
        }

        public Administrator Result { get; private set; }
        protected override void Execute()
        {
            foreach (Administrator admin in repository.VratiSve(new Administrator()).OfType<Administrator>().ToList())
            {
                if(admin.Username == administrator.Username && admin.Password == administrator.Password)
                {
                    administrator.AdministratorId = admin.AdministratorId;
                    administrator.Ime = admin.Ime;
                    administrator.Prezime = admin.Prezime;
                    Result = administrator;
                }
            }
        }
    }
}
