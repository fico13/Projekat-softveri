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
        public Takmicenje Takmicenje { get; set; }
        public int UtakmicaId { get; set; }
        public int BrojPoenaDomacin { get; set; }
        public int BrojPoenaGost { get; set; }
        public DateTime DatumOdigravanja { get; set; }
        public int BrojGledalaca { get; set; }
        public int Runda { get; set; }
        public string FazaTakmicenja { get; set; }
        public Tim Domacin { get; set; }
        public Tim Gost { get; set; }
        
        
        
        [Browsable(false)]
        public string DateString { get; set; }

        [Browsable(false)]
        public List<Statistika> Statistka { get; set; }
        [Browsable(false)]
        public string TableName => "Utakmica";
        [Browsable(false)]

        public string InsertValues => $"{Takmicenje.TakmicenjeID}, {UtakmicaId}, {BrojPoenaDomacin}, {BrojPoenaGost}, '{DateString}', {BrojGledalaca}, {Runda}, '{FazaTakmicenja}', {Domacin.TimId}, {Gost.TimId}";
        [Browsable(false)]

        public string WhereCondition => $"UtakmicaId = {UtakmicaId}";
        [Browsable(false)]

        public string Alias => "u";
        [Browsable(false)]

        public string JoinTable => "Tim d";
        [Browsable(false)]

        public string JoinCondition => "(u.DomacinId = d.TimId) join Tim g on (u.GostId = g.TimId) join Takmicenje t on (u.TakmicenjeId = t.TakmicenjeId)";
        [Browsable(false)]

        public string FindCondition { get; set; }
        [Browsable(false)]

        public string UpdateCondition => $"BrojPoenaDomacin = {BrojPoenaDomacin}, BrojPoenaGost = {BrojPoenaGost}, DatumOdigravanja = '{DateString}', Runda = {Runda}, BrojGledalaca = {BrojGledalaca}";
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
                Runda = (int)reader["Runda"],
                FazaTakmicenja = (string)reader["FazaTakmicenja"],
                Takmicenje = new Takmicenje
                {
                    TakmicenjeID = reader.GetInt32(26),
                    Naziv = reader.GetString(27),
                    BrojKola = reader.GetInt32(28)
                },
                Domacin = new Tim
                {
                    TimId = reader.GetInt32(10),
                    Ime = reader.GetString(11),
                    Drzava = reader.GetString(12),
                    BrojPobeda = reader.GetInt32(13),
                    BrojPoraza = reader.GetInt32(14),
                    Bodovi = reader.GetInt32(15),
                    KosRazlika = reader.GetInt32(16)
                },
                Gost = new Tim
                {
                    TimId = reader.GetInt32(18),
                    Ime = reader.GetString(19),
                    Drzava = reader.GetString(20),
                    BrojPobeda = reader.GetInt32(21),
                    BrojPoraza = reader.GetInt32(22),
                    Bodovi = reader.GetInt32(23),
                    KosRazlika = reader.GetInt32(24)
                }
            };
            return utakmica;
        }

        public override string ToString()
        {
            return $"{Domacin.Ime} {BrojPoenaDomacin} : {BrojPoenaGost} {Gost.Ime} {DatumOdigravanja.Day}.{DatumOdigravanja.Month}.{DatumOdigravanja.Year}."; 
        }
    }
}
