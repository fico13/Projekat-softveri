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
    public class Statistika : IDomainObject
    {

        public Utakmica Utakmica { get; set; }
        public Igrac Igrac { get; set; }
        public int Poeni { get; set; }
        public int Skokovi { get; set; }
        public int Asistencije { get; set; }
        [Browsable(false)]

        public string TableName => "Statistika";
        [Browsable(false)]

        public string InsertValues => $"{Utakmica.UtakmicaId}, {Igrac.IgracId}, {Poeni}, {Skokovi}, {Asistencije}";
        [Browsable(false)]

        public string WhereCondition => throw new NotImplementedException();
        [Browsable(false)]

        public string Alias => throw new NotImplementedException();
        [Browsable(false)]

        public string JoinTable => throw new NotImplementedException();
        [Browsable(false)]

        public string JoinCondition => throw new NotImplementedException();
        [Browsable(false)]

        public string FindCondition => throw new NotImplementedException();
        [Browsable(false)]

        public string UpdateCondition => throw new NotImplementedException();
        [Browsable(false)]

        public string IdColumnName => throw new NotImplementedException();

        [Browsable(false)]

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Statistika statistika = new Statistika
            {
                Utakmica = new Utakmica
                {
                    UtakmicaId = (int)reader["UtakmicaID"],
                    BrojPoenaDomacin = (int)reader["BrojPoenaDomacin"],
                    BrojPoenaGost = (int)reader["BrojPoenaGost"],
                    DatumOdigravanja = (DateTime)reader["DatumOdigravanja"],
                    Domacin = new Tim
                    {
                        TimId = (int)reader["DomacinId"],
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
                            Kapacitet = (int)reader["dv.Kapacitet"],
                        }
                    },
                    Gost = new Tim
                    {
                        TimId = (int)reader["GostId"],
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
                            Kapacitet = (int)reader["dvo.Kapacitet"],
                        }
                    },

                }
            };
            return statistika;
        }
    }
}
