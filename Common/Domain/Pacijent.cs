using Common.Domain.Enums;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain
{
    public class Pacijent : IDomainObject
    {
        public long Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateOnly DatumRodjenja { get; set; }
        public Pol Pol { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public KategorijaPacijenta KategorijaPacijenta { get; set; };

        public string TableName => "Pacijent";

        public string InsertColumns => "ime, prezime, datRodjenja, pol, email, brTelefona, idKategorijaPacijenta";

        public string InsertValues => $"'{Ime}', '{Prezime}', '{DatumRodjenja}', '{Pol}', '{Email}', '{BrojTelefona}', '{KategorijaPacijenta.I}'";

        public string SelectColumns => throw new NotImplementedException();

        public string JoinClause => throw new NotImplementedException();

        public string SetClause => throw new NotImplementedException();

        public string PrimaryKeyClause => $"id = {Id}";

        public string WhereClause { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IDomainObject> All(SqlDataReader reader)
        {
            List<IDomainObject> pacijenti = new List<IDomainObject>();

            while (reader.Read())
            {
                Pacijent pacijent = new Pacijent
                {
                    Id = (long)reader["id"],
                    Ime = reader["ime"].ToString().Trim(),
                    Prezime = reader["prezime"].ToString().Trim(),
                    DatumRodjenja = (DateOnly)reader["datRodjenja"],
                    Pol = (Pol)reader["pol"],
                    Email = reader["email"].ToString().Trim(),
                    BrojTelefona = reader["brTelefona"].ToString().Trim(),
                    KategorijaPacijenta = new KategorijaPacijenta
                    {
                        Id = (long)reader["id"],
                        Naziv = reader["naziv"].ToString().Trim(),
                        Popust = (decimal)reader["popust"]
                    }
                };

                pacijenti.Add(pacijent);
            }

            return pacijenti;
        }
    }
}
