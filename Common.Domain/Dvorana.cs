using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Dvorana : IDomainObject
    {
        public int DvoranaId { get; set; }
        public string Ime { get; set; }
        public string Drzava { get; set; }
        public int Kapacitet { get; set; }

        public string TableName => "Dvorana";

        public string InsertValues => $"'{Ime}', '{Drzava}', {Kapacitet}";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Dvorana dvorana = new Dvorana
            {
                DvoranaId = (int)reader["DvoranaId"],
                Ime = (string)reader["Ime"],
                Drzava = (string)reader["Drzava"],
                Kapacitet = (int)reader["Kapacitet"]
            };
            return dvorana;
        }
    }
}
