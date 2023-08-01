using Common.Domain;
using Server.DatabaseBroker;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repository.DatabaseRepository
{
    public class GenericDBRepository : IRepository<IDomainObject>
    {
        private Broker broker = new Broker();
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public List<IDomainObject> VratiSve(IDomainObject objekat)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateSqlCommand();
            command.CommandText = $"Select * FROM {objekat.TableName}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = objekat.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }
    }
}
