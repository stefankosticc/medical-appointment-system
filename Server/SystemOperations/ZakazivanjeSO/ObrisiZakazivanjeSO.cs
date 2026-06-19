using Common.Domain;

namespace Server.SystemOperations.ZakazivanjeSO
{
    internal class ObrisiZakazivanjeSO : SystemOperationBase
    {
        private readonly Zakazivanje _zakazivanje;

        public ObrisiZakazivanjeSO(Zakazivanje zakazivanje)
        {
            _zakazivanje = zakazivanje;
        }

        protected override void IzvrsenjeSO()
        {
            repository.Delete(_zakazivanje);
        }
    }
}
