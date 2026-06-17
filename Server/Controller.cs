using Common.Domain;
using Server.SystemOperations.KategorijaPacijentaSO;
using Server.SystemOperations.PacijentSO;
using Server.SystemOperations.ZaposleniSO;

namespace Server
{
    internal class Controller
    {
        private static Controller instance;

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        private Controller() { }

        internal Zaposleni PrijaviZaposleni(Zaposleni zaposleni)
        {
            PrijaviZaposleniSO so = new PrijaviZaposleniSO(zaposleni);
            so.OpsteIzvrsenjeSO();
            return so.Result;
        }

        internal List<Zaposleni> VratiListuSviZaposleni(Zaposleni zaposleni)
        {
            VratiListuSviZaposleniSO so = new VratiListuSviZaposleniSO(zaposleni);
            so.OpsteIzvrsenjeSO();
            return so.ResultList;
        }

        internal List<KategorijaPacijenta> VratiListuSviKategorijaPacijenta(KategorijaPacijenta kategorija)
        {
            VratiListuSviKategorijaPacijentaSO so = new VratiListuSviKategorijaPacijentaSO(kategorija);
            so.OpsteIzvrsenjeSO();
            return so.ResultList;
        }

        internal Pacijent KreirajPacijent(Pacijent pacijent)
        {
            KreirajPacijentSO so = new KreirajPacijentSO(pacijent);
            so.OpsteIzvrsenjeSO();
            return so.Result;
        }

        internal Pacijent PromeniPacijent(Pacijent pacijent)
        {
            PromeniPacijentSO so = new PromeniPacijentSO(pacijent);
            so.OpsteIzvrsenjeSO();
            return so.Result;
        }
    }
}
