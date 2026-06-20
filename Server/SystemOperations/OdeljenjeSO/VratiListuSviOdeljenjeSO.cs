using Common.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.SystemOperations.OdeljenjeSO
{
    internal class VratiListuSviOdeljenjeSO : SystemOperationBase
    {
        private readonly Odeljenje _odeljenje;
        public List<Odeljenje> ResultList { get; set; }
        public VratiListuSviOdeljenjeSO(Odeljenje odeljenje)
        {
            _odeljenje = odeljenje;
        }
        protected override void IzvrsenjeSO()
        {
            List<IDomainObject> list = repository.GetAll(_odeljenje);
            ResultList = list.Cast<Odeljenje>().ToList();
        }
    }
}
