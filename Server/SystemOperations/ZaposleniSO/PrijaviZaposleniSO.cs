using Common.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.SystemOperations.ZaposleniSO
{
    internal class PrijaviZaposleniSO : SystemOperationBase
    {
        private readonly Zaposleni _zaposleni;
        public Zaposleni Result {  get; set; }

        public PrijaviZaposleniSO(Zaposleni zaposleni)
        {
            _zaposleni = zaposleni;
        }

        protected override void IzvrsenjeSO()
        {
            List<IDomainObject> list = repository.GetAllByCondition(_zaposleni);
            Result = list.Cast<Zaposleni>().FirstOrDefault();
        }
    }
}
