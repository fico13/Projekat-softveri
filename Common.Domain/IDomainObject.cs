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

        IDomainObject ReadObjectRow(SqlDataReader reader);
    }
}
