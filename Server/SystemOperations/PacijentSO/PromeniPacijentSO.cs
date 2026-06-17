using Common.Domain;

namespace Server.SystemOperations.PacijentSO
{
    internal class PromeniPacijentSO : SystemOperationBase
    {
        private readonly Pacijent _pacijent;
        public Pacijent Result { get; set; }

        public PromeniPacijentSO(Pacijent pacijent)
        {
            _pacijent = pacijent;
        }

        protected override void IzvrsenjeSO()
        {
            repository.Update(_pacijent);
            Result = _pacijent;
        }
    }
}
