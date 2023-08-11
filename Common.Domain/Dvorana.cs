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
    public class Dvorana : IDomainObject
    {
        public int DvoranaId { get; set; }
        public string Ime { get; set; }
        public string Drzava { get; set; }
        public int Kapacitet { get; set; }
        
        
        
        [Browsable(false)]
        public string TableName => "Dvorana";
        [Browsable(false)]
        public string InsertValues => $"'{Ime}', '{Drzava}', {Kapacitet}";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string FindCondition => "";
        [Browsable(false)]
        public string Alias => "d";
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
            Dvorana dvorana = new Dvorana
            {
                DvoranaId = (int)reader["DvoranaId"],
                Ime = (string)reader["ImeDvorane"],
                Drzava = (string)reader["DrzavaDvorane"],
                Kapacitet = (int)reader["Kapacitet"]
            };
            return dvorana;
        }

        public override string ToString()
        {
            return Ime; 
        }
    }
}
