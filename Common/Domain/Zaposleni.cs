using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain
{
    internal class Zaposleni : IDomainObject
    {
        public long Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra {  get; set; }

        public string TableName => "Zaposleni";

        public string InsertColumns => "ime, prezime, korisnickoIme, sifra";

        public string InsertValues => $"'{Ime}', '{Prezime}', '{KorisnickoIme}', '{Sifra}'";

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
