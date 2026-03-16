using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain
{
    public interface IDomainObject
    {
        string TableName { get; }
        string InsertColumns { get; }
        string InsertValues { get; }
        string SelectColumns { get; }
        string JoinClause { get; }
        string SetClause { get; }
        string PrimaryKeyClause { get; }
        string WhereClause { get; set; }
        List<IDomainObject> All(SqlDataReader reader);
    }
}
