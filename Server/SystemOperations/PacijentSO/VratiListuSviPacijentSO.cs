using Common.Domain;

namespace Server.SystemOperations.PacijentSO
{
    internal class VratiListuSviPacijentSO : SystemOperationBase
    {
        private readonly Pacijent _pacijent;
        public List<Pacijent> ResultList { get; set; }

        public VratiListuSviPacijentSO(Pacijent pacijent)
        {
            _pacijent = pacijent;
        }

        protected override void IzvrsenjeSO()
        {
            List<IDomainObject> list = repository.GetAll(_pacijent);
            ResultList = list.Cast<Pacijent>().ToList();
        }
    }
}
