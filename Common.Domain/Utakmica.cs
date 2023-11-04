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
    public class Utakmica : IDomainObject
    {
        public int UtakmicaId { get; set; }
        public int BrojPoenaDomacin { get; set; }
        public int BrojPoenaGost { get; set; }
        public DateTime DatumOdigravanja { get; set; }
        public int BrojGledalaca { get; set; }
        public Tim Domacin { get; set; }
        public Tim Gost { get; set; }
        
        
        
        [Browsable(false)]
        public string DateString { get; set; }

        [Browsable(false)]
        public List<Statistika> Statistka { get; set; }
        [Browsable(false)]
        public string TableName => "Utakmica";
        [Browsable(false)]

        public string InsertValues => $"{BrojPoenaDomacin}, {BrojPoenaGost}, '{DateString}', {BrojGledalaca}, {Domacin.TimId}, {Gost.TimId}";
        [Browsable(false)]

        public string WhereCondition => $"UtakmicaId = {UtakmicaId}";
        [Browsable(false)]

        public string Alias => "u";
        [Browsable(false)]

        public string JoinTable => "Tim d";
        [Browsable(false)]

        public string JoinCondition => "(u.DomacinId = d.TimId) join Tim g on (u.GostId = g.TimId)";
        [Browsable(false)]

        public string FindCondition { get; set; }
        [Browsable(false)]

        public string UpdateCondition => $"BrojPoenaDomacin = {BrojPoenaDomacin}, BrojPoenaGost = {BrojPoenaGost}, DatumOdigravanja = '{DateString}', BrojGledalaca = {BrojGledalaca}";
        [Browsable(false)]

        public string IdColumnName => "UtakmicaId";

        [Browsable(false)]

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Utakmica utakmica = new Utakmica
            {
                UtakmicaId = (int)reader["UtakmicaId"],
                BrojPoenaDomacin = (int)reader["BrojPoenaDomacin"],
                BrojPoenaGost = (int)reader["BrojPoenaGost"],
                DatumOdigravanja = (DateTime)reader["DatumOdigravanja"],
                BrojGledalaca = (int)reader["BrojGledalaca"],
                Domacin = new Tim
                {
                    TimId = reader.GetInt32(7),
                    Ime = reader.GetString(8),
                    Drzava = reader.GetString(9),
                    BrojPobeda = reader.GetInt32(10),
                    BrojPoraza = reader.GetInt32(11),
                    Bodovi = reader.GetInt32(12)
                },
                Gost = new Tim
                {
                    TimId = reader.GetInt32(14),
                    Ime = reader.GetString(15),
                    Drzava = reader.GetString(16),
                    BrojPobeda = reader.GetInt32(17),
                    BrojPoraza = reader.GetInt32(18),
                    Bodovi = reader.GetInt32(19)
                }
            };
            return utakmica;
        }

        public override string ToString()
        {
            return $"{Domacin.Ime} {BrojPoenaDomacin} : {BrojPoenaGost} {Gost.Ime} {DatumOdigravanja}"; 
        }
    }
}
