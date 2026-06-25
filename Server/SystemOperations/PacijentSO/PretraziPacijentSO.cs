using Common.Domain;
using System.Diagnostics;

namespace Server.SystemOperations.PacijentSO
{
    internal class PretraziPacijentSO : SystemOperationBase
    {
        private readonly Pacijent _kriterijum;
        public Pacijent Result { get; set; }

        public PretraziPacijentSO(Pacijent kriterijum)
        {
            _kriterijum = kriterijum;
        }

        protected override void IzvrsenjeSO()
        {
            List<IDomainObject> list = repository.GetAllByCondition(_kriterijum);
            Result = list.Cast<Pacijent>().ToList().FirstOrDefault();
        }
    }
}
