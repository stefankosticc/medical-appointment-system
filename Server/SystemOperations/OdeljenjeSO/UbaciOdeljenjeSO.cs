using Common.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.SystemOperations.OdeljenjeSO
{
    internal class UbaciOdeljenjeSO : SystemOperationBase
    {
        private readonly Odeljenje _odeljenje;
        public Odeljenje Result { get; set; }
        public UbaciOdeljenjeSO(Odeljenje odeljenje)
        {
            _odeljenje = odeljenje;
        }

        protected override void IzvrsenjeSO()
        {
            _odeljenje.Id = repository.InsertIntoOutput(_odeljenje);
            Result = _odeljenje;
        }
    }
}
