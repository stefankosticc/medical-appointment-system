using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain
{
    internal class Usluga : IDomainObject
    {
        public long Id { get; set; }
        public string Naziv {  get; set; }
        public decimal Cena { get; set; }

        public string TableName => "Usluga";

        public string InsertColumns => "naziv, cena";

        public string InsertValues => $"'{Naziv}', '{Cena}'";

        public string SelectColumns => throw new NotImplementedException();

        public string JoinClause => throw new NotImplementedException();

        public string SetClause => throw new NotImplementedException();

        public string PrimaryKeyClause => throw new NotImplementedException();

        public string WhereClause { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IDomainObject> All(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
