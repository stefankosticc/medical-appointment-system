using Common.Domain;

namespace Server.SystemOperations.KategorijaPacijentaSO
{
    internal class VratiListuSviKategorijaPacijentaSO : SystemOperationBase
    {
        private readonly KategorijaPacijenta _kategorija;
        public List<KategorijaPacijenta> ResultList { get; set; }

        public VratiListuSviKategorijaPacijentaSO(KategorijaPacijenta kategorija)
        {
            _kategorija = kategorija;
        }

        protected override void IzvrsenjeSO()
        {
            List<IDomainObject> list = repository.GetAll(_kategorija);
            ResultList = list.Cast<KategorijaPacijenta>().ToList();
        }
    }
}
