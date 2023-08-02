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
    public class Igrac : IDomainObject
    {
        public int IgracId { get; set; }
        public string ImeIgraca { get; set; }
        public string PrezimeIgraca { get; set; }
        public string DrzavaIgraca { get; set; }
        public Pozicija Pozicija { get; set; }
        public int BrojNaDresu { get; set; }
        public int Visina { get; set; }
        public Tim Tim { get; set; }
        public double Tezina { get; set; }

        [Browsable(false)]
        public string TableName => "Igrac";
        [Browsable(false)]
        public string InsertValues => $"'{ImeIgraca}', '{PrezimeIgraca}', '{DrzavaIgraca}', {((int)Pozicija)}, {BrojNaDresu}, {Visina}, {Tezina}, {Tim.TimId}";
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
        
        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Igrac igrac = new Igrac
            {
                IgracId = (int)reader["IgracId"],
                ImeIgraca = (string)reader["ImeIgraca"],
                PrezimeIgraca = (string)reader["PrezimeIgraca"],
                DrzavaIgraca = (string)reader["DrzavaIgraca"],
                Pozicija = (Pozicija)reader["Pozicija"],
                BrojNaDresu = (int)reader["BrojNaDresu"],
                Visina = (int)reader["Visina"],
                Tezina = (double)reader["Tezina"],
                Tim = new Tim
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
                }
            };
            return igrac;
        }

       
    }
}
