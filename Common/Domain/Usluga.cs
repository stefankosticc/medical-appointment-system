using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain
{
    public class Usluga : IDomainObject
    {
        public long Id { get; set; }
        public string Naziv {  get; set; }
        public decimal Cena { get; set; }

        public string TableName => "Usluga";

        public string InsertColumns => "naziv, cena";

        public string InsertValues => $"'{Naziv}', '{Cena}'";

        public string SelectColumns => "*";

        public string JoinClause => "";

        public string SetClause => $"naziv='{Naziv}', cena={Cena}";

        public string PrimaryKeyClause => $"id = {Id}";

        public string WhereClause { get; set; }

        public List<IDomainObject> All(SqlDataReader reader)
        {
            List<IDomainObject> usluge = new List<IDomainObject>();

            while (reader.Read())
            {
                Usluga usluga = new Usluga
                {
                    Id = (long)reader["id"],
                    Naziv = reader["naziv"].ToString().Trim(),
                    Cena = (decimal)reader["cena"]
                };

                usluge.Add(usluga);
            }

            return usluge;
        }
    }
}
