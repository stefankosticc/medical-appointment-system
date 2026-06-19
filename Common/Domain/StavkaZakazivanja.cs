using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain
{
    public class StavkaZakazivanja : IDomainObject
    {
        public Zakazivanje Zakazivanje { get; set; } = new Zakazivanje();
        public int Rb { get; set; }
        public decimal Cena { get; set; }
        public string? Napomena { get; set; }
        public Usluga Usluga { get; set; } = new Usluga();

        public string TableName => "StavkaZakazivanja";

        public string InsertColumns => "idZakazivanje, rb, cena, napomena, idUsluga";

        public string InsertValues => $"{Zakazivanje.Id}, {Rb}, {Cena}, '{Napomena}', {Usluga.Id}";

        public string SelectColumns => "sz.idZakazivanje, sz.rb, sz.cena as cenaSZ, sz.napomena, u.id as idUsluga, u.naziv, u.cena as cenaUsluge";

        public string JoinClause => "sz JOIN Usluga u ON sz.idUsluga = u.id";

        public string SetClause => $"cena={Cena}, napomena='{Napomena}', idUsluga={Usluga.Id}";

        public string PrimaryKeyClause => $"idZakazivanje={Zakazivanje.Id} AND rb={Rb}";

        public string WhereClause { get => $"sz.idZakazivanje = {Zakazivanje.Id}"; set; } 

        public List<IDomainObject> All(SqlDataReader reader)
        {
            List<IDomainObject> lista = new List<IDomainObject>();

            while (reader.Read())
            {
                StavkaZakazivanja sz = new StavkaZakazivanja
                {
                    Rb = (int)reader["rb"],
                    Cena = (decimal)reader["cenaSZ"],
                    Napomena = reader["napomena"] as string ?? "",
                    Usluga = new Usluga
                    {
                        Id = (long)reader["idUsluga"],
                        Naziv = reader["naziv"].ToString().Trim(),
                        Cena = (decimal)reader["cenaUsluge"]
                    },
                    Zakazivanje = new Zakazivanje { Id = (long)reader["idZakazivanje"] }
                };

                lista.Add(sz);
            }

            return lista;
        }
    }
}
