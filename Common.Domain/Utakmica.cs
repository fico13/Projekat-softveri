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
        public Tim Domacin { get; set; }
        public Tim Gost { get; set; }
        [Browsable(false)]
        public string DateString { get; set; }

        [Browsable(false)]
        public List<Statistika> Statistka { get; set; }
        [Browsable(false)]
        public string TableName => "Utakmica";
        [Browsable(false)]

        public string InsertValues => $"{BrojPoenaDomacin}, {BrojPoenaGost}, '{DateString}', {Domacin.TimId}, {Gost.TimId}";
        [Browsable(false)]

        public string WhereCondition => $"UtakmicaId = {UtakmicaId}";
        [Browsable(false)]

        public string Alias => "u";
        [Browsable(false)]

        public string JoinTable => "Tim d";
        [Browsable(false)]

        public string JoinCondition => "(u.DomacinId = d.TimId) join Tim g on (u.GostId = g.TimId) join Dvorana dv on (d.DvoranaId = dv.DvoranaId) join Dvorana dvo on (g.DvoranaId = dvo.DvoranaId)";
        [Browsable(false)]

        public string FindCondition { get; set; }
        [Browsable(false)]

        public string UpdateCondition => $"BrojPoenaDomacin = {BrojPoenaDomacin}, BrojPoenaGost = {BrojPoenaGost}, DatumOdigravanja = '{DateString}'";
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
                Domacin = new Tim
                {
                    TimId = reader.GetInt32(6),
                    Ime = reader.GetString(7),
                    Drzava = reader.GetString(8),
                    BrojPobeda = reader.GetInt32(9),
                    BrojPoraza = reader.GetInt32(10),
                    Bodovi = reader.GetInt32(11),
                    Dvorana = new Dvorana
                    {
                        DvoranaId = reader.GetInt32(20),
                        Ime = reader.GetString(21),
                        Drzava = reader.GetString(22),
                        Kapacitet = reader.GetInt32(23)
                    }
                },
                Gost = new Tim
                {
                    TimId = reader.GetInt32(13),
                    Ime = reader.GetString(14),
                    Drzava = reader.GetString(15),
                    BrojPobeda = reader.GetInt32(16),
                    BrojPoraza = reader.GetInt32(17),
                    Bodovi = reader.GetInt32(18),
                    Dvorana = new Dvorana
                    {
                        DvoranaId = reader.GetInt32(24),
                        Ime = reader.GetString(25),
                        Drzava = reader.GetString(26),
                        Kapacitet = reader.GetInt32(27)
                    }
                }
            };
            return utakmica;
        }
    }
}
