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
        public string InsertValues => "";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string FindCondition => "";
        [Browsable(false)]
        public string Alias => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string UpdateCondition => "";
        [Browsable(false)]

        public string IdColumnName => "";

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

        public override bool Equals(object obj)
        {
            return ((Administrator)obj).Username == Username && ((Administrator)obj).Password == Password;
        }

        public override int GetHashCode()
        {
            int hashCode = 1499001239;
            hashCode = hashCode * -1521134295 + AdministratorId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Ime);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prezime);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TableName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InsertValues);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WhereCondition);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FindCondition);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Alias);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(JoinTable);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(JoinCondition);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UpdateCondition);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(IdColumnName);
            return hashCode;
        }
    }
}
