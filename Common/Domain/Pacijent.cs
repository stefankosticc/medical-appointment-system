using Common.Domain.Enums;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

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
        public KategorijaPacijenta KategorijaPacijenta { get; set; } = new KategorijaPacijenta();

        public string TableName => "Pacijent";

        public string InsertColumns => "ime, prezime, datRodjenja, pol, email, brTelefona, idKategorijaPacijenta";

        public string InsertValues => $"'{Ime}', '{Prezime}', '{DatumRodjenja}', {(int)Pol}, '{Email}', '{BrojTelefona}', '{KategorijaPacijenta.Id}'";

        public string SelectColumns => "p.id, p.ime, p.prezime, p.datRodjenja, p.pol, p.email, p.brTelefona, k.id as idKategorijaPacijenta, k.naziv, k.popust";

        public string JoinClause => "p JOIN KategorijaPacijenta k ON p.idKategorijaPacijenta = k.id";
        
        public string SetClause => $"ime='{Ime}', prezime='{Prezime}', datRodjenja='{DatumRodjenja}', pol={(int)Pol}, email='{Email}', brTelefona='{BrojTelefona}', idKategorijaPacijenta={KategorijaPacijenta.Id}";

        public string PrimaryKeyClause => $"id = {Id}";

        public string WhereClause { get; set; }

        public override string ToString() => $"{Ime} {Prezime}";

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
                    DatumRodjenja = DateOnly.FromDateTime((DateTime)reader["datRodjenja"]),
                    Pol = (Pol)(int)reader["pol"],
                    Email = reader["email"].ToString().Trim(),
                    BrojTelefona = reader["brTelefona"].ToString().Trim(),
                    KategorijaPacijenta = new KategorijaPacijenta
                    {
                        Id = (long)reader["idKategorijaPacijenta"],
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
