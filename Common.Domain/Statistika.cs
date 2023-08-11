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
        public string WhereCondition => $"UtakmicaId = {Utakmica.UtakmicaId} and IgracId = {Igrac.IgracId}";
        [Browsable(false)]
        public string Alias => "s";
        [Browsable(false)]
        public string JoinTable => "Utakmica u";
        [Browsable(false)]
        public string JoinCondition => "(s.UtakmicaId = u.UtakmicaId) join Igrac i on(s.IgracId = i.IgracId) join Tim t on (i.TimId = t.TimId)";
        [Browsable(false)]
        public string FindCondition => $"s.UtakmicaId = {Utakmica.UtakmicaId}";
        [Browsable(false)]
        public string UpdateCondition => $"Poeni = {Poeni}, Skokovi = {Skokovi}, Asistencije = {Asistencije}";
        [Browsable(false)]
        public string IdColumnName => "";
        [Browsable(false)]
        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Statistika statistika = new Statistika
            {
                Poeni = reader.GetInt32(2),
                Skokovi = reader.GetInt32(3),
                Asistencije = reader.GetInt32(4),
                Igrac = new Igrac
                {
                    IgracId = reader.GetInt32(11),
                    ImeIgraca = reader.GetString(12),
                    PrezimeIgraca = reader.GetString(13),
                    DrzavaIgraca = reader.GetString(14),
                    Pozicija = (Pozicija)reader.GetInt32(15),
                    BrojNaDresu = reader.GetInt32(16),
                    Visina = reader.GetInt32(17),
                    Tezina = reader.GetDouble(18),
                    Tim = new Tim
                    {
                        TimId = reader.GetInt32(20),
                        Ime = reader.GetString(21)
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
