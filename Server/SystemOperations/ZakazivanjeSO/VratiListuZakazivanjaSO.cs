using Common.Domain;
using System.Diagnostics;

namespace Server.SystemOperations.ZakazivanjeSO
{
    internal class VratiListuZakazivanjaSO : SystemOperationBase
    {
        private readonly Zakazivanje _kriterijum;
        public List<Zakazivanje> ResultList { get; set; }
        StavkaZakazivanja stavka = new StavkaZakazivanja();

        public VratiListuZakazivanjaSO(Zakazivanje kriterijum)
        {
            _kriterijum = kriterijum;
        }

        protected override void IzvrsenjeSO()
        {
            List<IDomainObject> list = repository.GetAllByCondition(_kriterijum);
            ResultList = list.Cast<Zakazivanje>().ToList();

            foreach (Zakazivanje zakazivanje in ResultList)
            {
                stavka.Zakazivanje = zakazivanje;
                List<IDomainObject> listaStavki = repository.GetAllByCondition(stavka);
                zakazivanje.StavkeZakazivanja = listaStavki.Cast<StavkaZakazivanja>().ToList();
            }
        }
    }
}
