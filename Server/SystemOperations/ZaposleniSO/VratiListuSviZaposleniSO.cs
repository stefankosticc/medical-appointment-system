using Common.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.SystemOperations.ZaposleniSO
{
    internal class VratiListuSviZaposleniSO : SystemOperationBase
    {
        private readonly Zaposleni _zaposleni;
        public List<Zaposleni> ResultList { get; set; }

        public VratiListuSviZaposleniSO(Zaposleni zaposleni)
        {
            _zaposleni = zaposleni;
        }

        protected override void IzvrsenjeSO()
        {
            List<IDomainObject> list = repository.GetAll(_zaposleni);
            ResultList = list.Cast<Zaposleni>().ToList();
        }
    }
}
