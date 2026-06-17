using Common.Domain;

namespace Server.SystemOperations.UslugaSO
{
    internal class PromeniUslugaSO : SystemOperationBase
    {
        private readonly Usluga _usluga;
        public Usluga Result { get; set; }

        public PromeniUslugaSO(Usluga usluga)
        {
            _usluga = usluga;
        }

        protected override void IzvrsenjeSO()
        {
            repository.Update(_usluga);
            Result = _usluga;
        }
    }
}
