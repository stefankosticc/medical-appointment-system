using Common.Domain;

namespace Server.SystemOperations.UslugaSO
{
    internal class VratiListuSviUslugaSO : SystemOperationBase
    {
        private readonly Usluga _usluga;
        public List<Usluga> ResultList { get; set; }

        public VratiListuSviUslugaSO(Usluga usluga)
        {
            _usluga = usluga;
        }

        protected override void IzvrsenjeSO()
        {
            List<IDomainObject> list = repository.GetAll(_usluga);
            ResultList = list.Cast<Usluga>().ToList();
        }
    }
}
