using Common.Domain;

namespace Server.SystemOperations.ZakazivanjeSO
{
    internal class PromeniZakazivanjeSO : SystemOperationBase
    {
        private readonly Zakazivanje _zakazivanje;
        public Zakazivanje Result { get; set; }

        public PromeniZakazivanjeSO(Zakazivanje zakazivanje)
        {
            _zakazivanje = zakazivanje;
        }

        protected override void IzvrsenjeSO()
        {
            repository.Update(_zakazivanje);

            var helper = new StavkaZakazivanja { Zakazivanje = new Zakazivanje { Id = _zakazivanje.Id } };
            var existing = repository.GetAllByCondition(helper);
            foreach (StavkaZakazivanja s in existing.Cast<StavkaZakazivanja>())
                repository.Delete(s);

            int rb = 1;
            foreach (StavkaZakazivanja stavka in _zakazivanje.StavkeZakazivanja)
            {
                stavka.Rb = rb++;
                stavka.Zakazivanje = new Zakazivanje { Id = _zakazivanje.Id };
                repository.InsertInto(stavka);
            }

            Result = _zakazivanje;
        }
    }
}
