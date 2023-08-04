using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IDomainObject
    {
        string TableName { get; }
        string InsertValues { get; }
        string WhereCondition { get; }
        string Alias { get; }
        string JoinTable { get; }
        string JoinCondition { get; }
        string FindCondition { get; }
        string UpdateCondition { get; }
        string IdColumnName { get; }


        IDomainObject ReadObjectRow(SqlDataReader reader);
    }
}
