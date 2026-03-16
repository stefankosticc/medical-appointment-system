using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain
{
    internal class Rezervacija : IDomainObject
    {
        public long Id { get; set; }
        public DateTime DatumIVremeRezervacije { get; set; }
        public decimal Popust { get; set; }
        public decimal UkupanIznos { get; set; }
        public decimal IznosSaPopustom { get; set; }
        public Zaposleni Zaposleni { get; set; } = new Zaposleni();
        public Pacijent Pacijent { get; set; } = new Pacijent();

        public string TableName => "Rezervacija";

        public string InsertColumns => "datIVremeRez, popust, ukupanIznos, iznosSaPopustom, idZaposleni, idPacijent";

        public string InsertValues => $"'{DatumIVremeRezervacije}', '{Popust}', '{UkupanIznos}', '{IznosSaPopustom}', '{Zaposleni.Id}', '{Pacijent.Id}'";

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
