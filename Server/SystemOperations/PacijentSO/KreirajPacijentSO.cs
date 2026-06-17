using Common.Domain;

namespace Server.SystemOperations.PacijentSO
{
    internal class KreirajPacijentSO : SystemOperationBase
    {
        private readonly Pacijent _pacijent;
        public Pacijent Result { get; set; }

        public KreirajPacijentSO(Pacijent pacijent)
        {
            _pacijent = pacijent;
        }

        protected override void IzvrsenjeSO()
        {
            repository.InsertInto(_pacijent);
            Result = _pacijent;
        }
    }
}
