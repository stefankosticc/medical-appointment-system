using Common.Domain;

namespace Server.SystemOperations.OdeljenjeSO
{
    internal class PromeniOdeljenjeSO : SystemOperationBase
    {
        private readonly Odeljenje _odeljenje;
        public Odeljenje Result { get; set; }

        public PromeniOdeljenjeSO(Odeljenje odeljenje)
        {
            _odeljenje = odeljenje;
        }

        protected override void IzvrsenjeSO()
        {
            repository.Update(_odeljenje);
            Result = _odeljenje;
        }
    }
}
