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
    public class Takmicenje : IDomainObject
    {
        public int TakmicenjeID { get; set; }
        public string Naziv { get; set; }
        public int BrojKola { get; set; }

        [Browsable(false)]
        public List<Tim> Timovi { get; set; }

        [Browsable(false)]
        public string TableName => "Takmicenje";

        [Browsable(false)]
        public string InsertValues => $"'{Naziv}', {BrojKola}";

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
            throw new NotImplementedException();
        }
    }
}
