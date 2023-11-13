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
        public Takmicenje Takmicenje { get; set; }
        public Utakmica Utakmica { get; set; }
        public Igrac Igrac { get; set; }
        public int Poeni { get; set; }
        public int Skokovi { get; set; }
        public int Asistencije { get; set; }
        
        
        [Browsable(false)]
        public string TableName => "Statistika";
        [Browsable(false)]
        public string InsertValues => $"{Takmicenje.TakmicenjeID}, {Utakmica.UtakmicaId}, {Igrac.IgracId}, {Poeni}, {Skokovi}, {Asistencije}";
        [Browsable(false)]
        public string WhereCondition => $"UtakmicaId = {Utakmica.UtakmicaId} and IgracId = {Igrac.IgracId}";
        [Browsable(false)]
        public string Alias => "s";
        [Browsable(false)]
        public string JoinTable => "Utakmica u";
        [Browsable(false)]
        public string JoinCondition => "(s.UtakmicaId = u.UtakmicaId) and (s.TakmicenjeId = u.TakmicenjeId) join Igrac i on (s.IgracId = i.IgracId) join Tim t on (i.TimId = t.TimId) join Tim d on (u.DomacinId = d.TimId) join Tim g on (u.GostId = g.TimId)";
        [Browsable(false)]
        public string FindCondition { get; set; }
        [Browsable(false)]
        public string UpdateCondition => $"Poeni = {Poeni}, Skokovi = {Skokovi}, Asistencije = {Asistencije}";
        [Browsable(false)]
        public string IdColumnName => "";
        [Browsable(false)]
        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Statistika statistika = new Statistika
            {
                Takmicenje = new Takmicenje
                {
                    TakmicenjeID = reader.GetInt32(0)
                },
                Poeni = reader.GetInt32(3),
                Skokovi = reader.GetInt32(4),
                Asistencije = reader.GetInt32(5),
                Igrac = new Igrac
                {
                    IgracId = reader.GetInt32(16),
                    ImeIgraca = reader.GetString(17),
                    PrezimeIgraca = reader.GetString(18),
                    DrzavaIgraca = reader.GetString(19),
                    DatumRodjenja = reader.GetDateTime(20),
                    Pozicija = (Pozicija)reader.GetInt32(21),
                    BrojNaDresu = reader.GetInt32(22),
                    Visina = reader.GetInt32(23),
                    Tezina = reader.GetDouble(24),
                    Tim = new Tim
                    {
                        TimId = reader.GetInt32(26),
                        Ime = reader.GetString(27)
                    }
                },
                Utakmica = new Utakmica
                {
                    Takmicenje = new Takmicenje
                    {
                        TakmicenjeID = reader.GetInt32(6)
                    },
                    UtakmicaId = reader.GetInt32(7),
                    BrojPoenaDomacin = reader.GetInt32(8),
                    BrojPoenaGost = reader.GetInt32(9),
                    DatumOdigravanja = reader.GetDateTime(10),
                    BrojGledalaca = reader.GetInt32(11),
                    Runda = reader.GetInt32(12),
                    FazaTakmicenja = reader.GetString(13),
                    Domacin = new Tim
                    {
                        Ime = reader.GetString(35)
                    },
                    Gost = new Tim
                    {
                        Ime = reader.GetString(43)
                    }
                }
            };
            return statistika;
        }
        public override string ToString()
        {
            return $"{Igrac}  {Poeni}  {Skokovi}  {Asistencije}";
        }
    }
}
