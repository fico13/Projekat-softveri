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

        public string WhereCondition => throw new NotImplementedException();
        [Browsable(false)]

        public string Alias => "u";
        [Browsable(false)]

        public string JoinTable => throw new NotImplementedException();
        [Browsable(false)]

        public string JoinCondition => throw new NotImplementedException();
        [Browsable(false)]

        public string FindCondition => throw new NotImplementedException();
        [Browsable(false)]

        public string UpdateCondition => throw new NotImplementedException();
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
                    TimId = (int)reader["d.TimId"],
                    Ime = (string)reader["d.ImeTima"],
                    Drzava = (string)reader["d.DrzavaTima"],
                    BrojPobeda = (int)reader["d.BrojPobeda"],
                    BrojPoraza = (int)reader["d.BrojPoraza"],
                    Bodovi = (int)reader["d.Bodovi"],
                    Dvorana = new Dvorana
                    {
                        DvoranaId = (int)reader["dv.DvoranaId"],
                        Ime = (string)reader["dv.ImeDvorane"],
                        Drzava = (string)reader["dv.DrzavaDvorane"],
                        Kapacitet = (int)reader["dv.Kapacitet"]
                    }
                },
                Gost = new Tim
                {
                    TimId = (int)reader["g.TimId"],
                    Ime = (string)reader["g.ImeTima"],
                    Drzava = (string)reader["g.DrzavaTima"],
                    BrojPobeda = (int)reader["g.BrojPobeda"],
                    BrojPoraza = (int)reader["g.BrojPoraza"],
                    Bodovi = (int)reader["g.Bodovi"],
                    Dvorana = new Dvorana
                    {
                        DvoranaId = (int)reader["dvo.DvoranaId"],
                        Ime = (string)reader["dvo.ImeDvorane"],
                        Drzava = (string)reader["dvo.DrzavaDvorane"],
                        Kapacitet = (int)reader["dvo.Kapacitet"]
                    }
                }
            };
            return utakmica;
        }
    }
}
