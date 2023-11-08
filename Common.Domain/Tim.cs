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
    public class Tim : IDomainObject
    {
        public int TimId { get; set; }
        public string Ime { get; set; }
        public string Drzava { get; set; }
        public int BrojPobeda { get; set; } = 0;
        public int BrojPoraza { get; set; } = 0;
        public int Bodovi { get; set; } = 0;
        public Dvorana Dvorana { get; set; }
        



        [Browsable(false)]
        public string TableName => "Tim";
        [Browsable(false)]
        public string InsertValues => $"'{Ime}', '{Drzava}', {BrojPobeda}, {BrojPoraza}, {Bodovi}, {Dvorana.DvoranaId}";
        [Browsable(false)]
        public string WhereCondition => $"TimId = {TimId}";
        [Browsable(false)]
        public string FindCondition { get; set; }
        [Browsable(false)]
        public string Alias => "t";
        [Browsable(false)]
        public string JoinTable => "Dvorana d";
        [Browsable(false)]
        public string JoinCondition => "(t.DvoranaId = d.DvoranaId)";
        [Browsable(false)]
        public string UpdateCondition => $"BrojPobeda = {BrojPobeda}, BrojPoraza = {BrojPoraza}, Bodovi = {Bodovi}";
        [Browsable(false)]

        public string IdColumnName => "";

        [Browsable(false)]
        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Tim tim = new Tim
            {
                TimId = (int)reader["TimId"],
                Ime = (string)reader["ImeTima"],
                Drzava = (string)reader["DrzavaTima"],
                BrojPobeda = (int)reader["BrojPobeda"],
                BrojPoraza = (int)reader["BrojPoraza"],
                Bodovi = (int)reader["Bodovi"],
                Dvorana = new Dvorana
                {
                    DvoranaId = (int)reader["DvoranaId"],
                    Ime = (string)reader["ImeDvorane"],
                    Drzava = (string)reader["DrzavaDvorane"],
                    Kapacitet = (int)reader["Kapacitet"]
                }
            };
            return tim;
        }

        public override string ToString()
        {
            return Ime;
        }

        
    }
}
