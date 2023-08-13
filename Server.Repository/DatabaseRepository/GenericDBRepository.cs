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

        public int DajNoviID(IDomainObject objekat)
        {
            SqlCommand command = broker.CreateSqlCommand();
            command.CommandText = $"select max({objekat.IdColumnName}) from {objekat.TableName}";
            object maxId = command.ExecuteScalar();
            return (int)maxId;
        }

        public List<IDomainObject> NadjiOdredjeni(IDomainObject objekat)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateSqlCommand();
            command.CommandText = $"select * from {objekat.TableName} {objekat.Alias} join {objekat.JoinTable} on {objekat.JoinCondition} where {objekat.FindCondition}";
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


        public void Sacuvaj(IDomainObject objekat)
        {
            SqlCommand command = broker.CreateSqlCommand();
            command.CommandText = $"insert into {objekat.TableName} values ({objekat.InsertValues})";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Greska u bazi!");
            }
        }

        public void Update(IDomainObject objekat)
        {
            SqlCommand command = broker.CreateSqlCommand();
            command.CommandText = $"update {objekat.TableName} set {objekat.UpdateCondition} where {objekat.WhereCondition}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception();
            }
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

        public List<IDomainObject> VratiSveJoin(IDomainObject objekat)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateSqlCommand();
            command.CommandText = $"select * from {objekat.TableName} {objekat.Alias} join {objekat.JoinTable} on {objekat.JoinCondition}";
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
