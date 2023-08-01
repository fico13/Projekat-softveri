using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Administrator : IDomainObject
    {
        public int AdministratorId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string TableName => "Administrator";

        public string InsertValues => throw new NotImplementedException();

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Administrator administrator = new Administrator
            {
                AdministratorId = (int)reader["AdministratorId"],
                Ime = (string)reader["Ime"],
                Prezime = (string)reader["Prezime"],
                Username = (string)reader["Username"],
                Password = (string)reader["Password"]
            };
            return administrator;
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
