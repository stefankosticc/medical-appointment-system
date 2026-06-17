using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain
{
    public class KategorijaPacijenta : IDomainObject
    {
        public long Id { get; set; }
        public string Naziv {  get; set; }
        public decimal Popust { get; set; }

        public string TableName => "KategorijaPacijenta";

        public string InsertColumns => "naziv, popust";

        public string InsertValues => $"'{Naziv}', '{Popust}'";

        public string SelectColumns => "id, naziv, popust";

        public string JoinClause => "";

        public string SetClause => "";

        public string PrimaryKeyClause => "";

        public string WhereClause { get; set; }

        public List<IDomainObject> All(SqlDataReader reader)
        {
            List<IDomainObject> kategorije = new List<IDomainObject>();

            while (reader.Read())
            {
                KategorijaPacijenta k = new KategorijaPacijenta
                {
                    Id = (long)reader["id"],
                    Naziv = reader["naziv"].ToString().Trim(),
                    Popust = (decimal)reader["popust"]
                };

                kategorije.Add(k);
            }

            return kategorije;
        }
    }
}
