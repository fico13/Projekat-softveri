﻿using Common.Domain;
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
        List<T> VratiSve(IDomainObject objekat);
        void Sacuvaj(T objekat);
        List<T> NadjiOdredjeni(IDomainObject objekat);

        List<T> VratiSveJoin(IDomainObject objekat);

        void Update(T objekat);
    }
}
