using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain
{
    internal class StavkaRezervacije : IDomainObject
    {
        public Rezervacija Rezervacija { get; set; } = new Rezervacija();
        public long Rb {  get; set; }
        public decimal Cena { get; set; }
        public string? Napomena { get; set; }
        public Usluga Usluga { get; set; } = new Usluga();

        public string TableName => "StavkaRezervacije";

        public string InsertColumns => "idRezervacija, rb, cena, napomena, idUsluga";

        public string InsertValues => $"'{Rezervacija.Id}', '{Rb}', '{Cena}', '{Napomena}', '{Usluga.Id}'";

        public string SelectColumns => throw new NotImplementedException();

        public string JoinClause => throw new NotImplementedException();

        public string SetClause => throw new NotImplementedException();

        public string PrimaryKeyClause => $"idRezervacija={Rezervacija.Id} and rb={Rb}";

        public string WhereClause { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IDomainObject> All(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
