using Common.Domain;

namespace Server.SystemOperations.PacijentSO
{
    internal class ObrisiPacijentSO : SystemOperationBase
    {
        private readonly Pacijent _pacijent;

        public ObrisiPacijentSO(Pacijent pacijent)
        {
            _pacijent = pacijent;
        }

        protected override void IzvrsenjeSO()
        {
            repository.Delete(_pacijent);
        }
    }
}
