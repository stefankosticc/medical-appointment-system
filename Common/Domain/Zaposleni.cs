using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain
{
    public class Zaposleni : IDomainObject
    {
        public long Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra {  get; set; }

        public string TableName => "Zaposleni";

        public string InsertColumns => "ime, prezime, korisnickoIme, sifra";

        public string InsertValues => $"'{Ime}', '{Prezime}', '{KorisnickoIme}', '{Sifra}'";

        public string SelectColumns => "*";

        public string JoinClause => "";

        public string SetClause => "";

        public string PrimaryKeyClause => "";

        public string WhereClause { get => $"korisnickoIme='{KorisnickoIme}' AND sifra='{Sifra}'"; set { } }

        public List<IDomainObject> All(SqlDataReader reader)
        {
            List<IDomainObject> zaposleni = new List<IDomainObject>();

            while (reader.Read())
            {
                Zaposleni z = new Zaposleni
                {
                    Id = (long)reader["id"],
                    Ime = reader["ime"].ToString().Trim(),
                    Prezime = reader["prezime"].ToString().Trim(),
                    KorisnickoIme = reader["korisnickoIme"].ToString().Trim(),
                    Sifra = reader["sifra"].ToString().Trim(),
                };

                zaposleni.Add(z);
            }

            return zaposleni;
        }
    }
}
