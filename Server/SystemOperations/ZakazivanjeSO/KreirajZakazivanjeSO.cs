using Common.Domain;

namespace Server.SystemOperations.ZakazivanjeSO
{
    internal class KreirajZakazivanjeSO : SystemOperationBase
    {
        private readonly Zakazivanje _zakazivanje;
        public Zakazivanje Result { get; set; }

        public KreirajZakazivanjeSO(Zakazivanje zakazivanje)
        {
            _zakazivanje = zakazivanje;
        }

        protected override void IzvrsenjeSO()
        {
            _zakazivanje.Id = repository.InsertIntoOutput(_zakazivanje);
            Result = _zakazivanje;
        }
    }
}
