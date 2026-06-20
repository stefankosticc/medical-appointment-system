using Microsoft.Data.SqlClient;

namespace Common.Domain
{
    public class Odeljenje : IDomainObject
    {
        public long Id { get; set; }
        public string Naziv { get; set; }

        public string TableName => "Odeljenje";

        public string InsertColumns => "naziv";

        public string InsertValues => $"'{Naziv}'";

        public string SelectColumns => "*";

        public string JoinClause => "";

        public string SetClause => $"naziv='{Naziv}'";

        public string PrimaryKeyClause => $"id = {Id}";

        public string WhereClause { get; set; }

        public List<IDomainObject> All(SqlDataReader reader)
        {
            List<IDomainObject> odeljenja = new List<IDomainObject>();

            while (reader.Read())
            {
                Odeljenje odeljenje = new Odeljenje
                {
                    Id = (long)reader["id"],
                    Naziv = reader["naziv"].ToString().Trim()
                };

                odeljenja.Add(odeljenje);
            }

            return odeljenja;
        }
    }
}
