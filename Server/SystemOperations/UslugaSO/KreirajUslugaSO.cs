using Common.Domain;

namespace Server.SystemOperations.UslugaSO
{
    internal class KreirajUslugaSO : SystemOperationBase
    {
        private readonly Usluga _usluga;
        public Usluga Result { get; set; }

        public KreirajUslugaSO(Usluga usluga)
        {
            _usluga = usluga;
        }

        protected override void IzvrsenjeSO()
        {
            repository.InsertInto(_usluga);
            Result = _usluga;
        }
    }
}
