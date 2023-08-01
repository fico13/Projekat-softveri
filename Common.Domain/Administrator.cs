using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Browsable(false)]
        public string TableName => "Administrator";
        [Browsable(false)]
        public string InsertValues => throw new NotImplementedException();
        [Browsable(false)]
        public string WhereCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string FindCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string Alias => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinTable => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => throw new NotImplementedException();
        [Browsable(false)]
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
