using Common.Domain;

namespace Server.SystemOperations.PacijentSO
{
    internal class PretraziPacijentSO : SystemOperationBase
    {
        private readonly Pacijent _kriterijum;
        public List<Pacijent> ResultList { get; set; }

        public PretraziPacijentSO(Pacijent kriterijum)
        {
            _kriterijum = kriterijum;
        }

        protected override void IzvrsenjeSO()
        {
            List<IDomainObject> list = repository.GetAllByCondition(_kriterijum);
            ResultList = list.Cast<Pacijent>().ToList();
        }
    }
}
