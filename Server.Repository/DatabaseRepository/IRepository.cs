using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repository.DatabaseRepository
{
    public interface IRepository<T> where T : class
    {
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
        List<IDomainObject> VratiSve(IDomainObject objekat);
        void Sacuvaj(IDomainObject objekat);
        List<IDomainObject> NadjiOdredjeni(IDomainObject objekat);

        List<IDomainObject> VratiSveJoin(IDomainObject objekat);

        void Update(IDomainObject objekat);
        int VratiMaxID(IDomainObject objekat);
        int DajNoviID(IDomainObject objekat);
    }
}
