using Common.Domain;

namespace Server.SystemOperations.ZakazivanjeSO
{
    internal class VratiListuZakazivanjaSO : SystemOperationBase
    {
        private readonly Zakazivanje _kriterijum;
        public List<Zakazivanje> ResultList { get; set; }

        public VratiListuZakazivanjaSO(Zakazivanje kriterijum)
        {
            _kriterijum = kriterijum;
        }

        protected override void IzvrsenjeSO()
        {
            List<IDomainObject> list = repository.GetAllByCondition(_kriterijum);
            ResultList = list.Cast<Zakazivanje>().ToList();
        }
    }
}
