using Common.Domain;

namespace Server.SystemOperations.ZakazivanjeSO
{
    internal class PretraziZakazivanjeSO : SystemOperationBase
    {
        private readonly Zakazivanje _zakazivanje;
        public Zakazivanje Result { get; set; }

        public PretraziZakazivanjeSO(Zakazivanje zakazivanje)
        {
            _zakazivanje = zakazivanje;
        }

        protected override void IzvrsenjeSO()
        {
            List<IDomainObject> lista = repository.GetAllByCondition(_zakazivanje);
            Result = lista.Cast<Zakazivanje>().FirstOrDefault();

            if (Result == null) return;

            var stavka = new StavkaZakazivanja { Zakazivanje = Result };
            List<IDomainObject> listaStavki = repository.GetAllByCondition(stavka);
            Result.StavkeZakazivanja = listaStavki.Cast<StavkaZakazivanja>().ToList();
        }
    }
}
