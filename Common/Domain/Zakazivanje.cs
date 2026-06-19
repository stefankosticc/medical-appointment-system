using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain
{
    public class Zakazivanje : IDomainObject
    {
        public long Id { get; set; }
        public DateTime DatumIVremeZakazivanja { get; set; }
        public decimal Popust
        {
            get
            {
                if (Pacijent == null) return 0;
                return Pacijent.KategorijaPacijenta.Popust;
            }
            set;
        }
        public decimal UkupanIznos { get { return StavkeZakazivanja.Sum(sz => sz.Cena); } set; }
        public decimal IznosSaPopustom
        {
            get
            {
                return Math.Round(UkupanIznos - (UkupanIznos * (Popust / 100)), 2);
            }
            set;
        }
        public Zaposleni Zaposleni { get; set; } = new Zaposleni();
        public Pacijent Pacijent { get; set; } = new Pacijent();
        public List<StavkaZakazivanja> StavkeZakazivanja { get; set; } = new List<StavkaZakazivanja>();

        public string TableName => "Zakazivanje";

        public string InsertColumns => "datIVremeZak, popust, ukupanIznos, iznosSaPopustom, idZaposleni, idPacijent";

        public string InsertValues => $"'{DatumIVremeZakazivanja:yyyy-MM-dd HH:mm:ss}', {Popust}, {UkupanIznos}, {IznosSaPopustom}, {Zaposleni.Id}, {Pacijent.Id}";

        public string SelectColumns => "z.id, z.datIVremeZak, zap.id as idZaposleni, zap.ime as imeZap, zap.prezime as prezimeZap, p.id as idPacijent, p.ime as imePac, p.prezime as prezimePac, k.id as idKat, k.naziv as nazivKat, k.popust as popustKat";

        public string JoinClause => "z JOIN Zaposleni zap ON z.idZaposleni = zap.id JOIN Pacijent p ON z.idPacijent = p.id JOIN KategorijaPacijenta k ON p.idKategorijaPacijenta = k.id";

        public string SetClause => $"datIVremeZak='{DatumIVremeZakazivanja:yyyy-MM-dd HH:mm:ss}', popust={Popust}, ukupanIznos={UkupanIznos}, iznosSaPopustom={IznosSaPopustom}, idZaposleni={Zaposleni.Id}, idPacijent={Pacijent.Id}";

        public string PrimaryKeyClause => $"id = {Id}";

        public string WhereClause { get; set; }

        public List<IDomainObject> All(SqlDataReader reader)
        {
            List<IDomainObject> lista = new List<IDomainObject>();

            while (reader.Read())
            {
                Zakazivanje z = new Zakazivanje
                {
                    Id = (long)reader["id"],
                    DatumIVremeZakazivanja = (DateTime)reader["datIVremeZak"],
                    Zaposleni = new Zaposleni
                    {
                        Id = (long)reader["idZaposleni"],
                        Ime = reader["imeZap"].ToString().Trim(),
                        Prezime = reader["prezimeZap"].ToString().Trim()
                    },
                    Pacijent = new Pacijent
                    {
                        Id = (long)reader["idPacijent"],
                        Ime = reader["imePac"].ToString().Trim(),
                        Prezime = reader["prezimePac"].ToString().Trim(),
                        KategorijaPacijenta = new KategorijaPacijenta
                        {
                            Id = (long)reader["idKat"],
                            Naziv = reader["nazivKat"].ToString().Trim(),
                            Popust = (decimal)reader["popustKat"]
                        }
                    }
                };

                lista.Add(z);
            }

            return lista;
        }

        public override string ToString() => $"#{Id} – {Pacijent?.Ime} {Pacijent?.Prezime}";
    }
}
