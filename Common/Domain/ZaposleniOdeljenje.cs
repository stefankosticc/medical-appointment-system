using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain
{
    internal class ZaposleniOdeljenje : IDomainObject
    {
        public Zaposleni Zaposleni { get; set; }
        public Odeljenje Odeljenje { get; set; }
        public DateOnly DatumPocetka { get; set; }
        public DateOnly? DatumZavrsetka { get; set; }

        public string TableName => "ZaposleniOdeljenje";

        public string InsertColumns => "idZaposleni, idOdeljenje, datPocetka, datZavrsetka";

        public string InsertValues => $"'{Zaposleni.Id}', '{Odeljenje.Id}', '{DatumPocetka}', '{DatumZavrsetka}'";

        public string SelectColumns => throw new NotImplementedException();

        public string JoinClause => "zo JOIN Zaposleni z ON zo.idZaposleni=z.id JOIN Odeljenje o ON zo.idOdeljenje=o.id";

        public string SetClause => throw new NotImplementedException();

        public string PrimaryKeyClause => throw new NotImplementedException();

        public string WhereClause { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IDomainObject> All(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
