using Client.Forms;
using Client.GuiController;
using Client.UserControls;
using Common.Communication;
using Common.Domain;

namespace Client.Session
{
    internal class Koordinator
    {
        private static Koordinator instance;

        private Koordinator() { }

        public static Koordinator Instance
        {
            get
            {
                if (instance == null)
                    instance = new Koordinator();
                return instance;
            }
        }

        // Ulogovani korisnik
        public Zaposleni? UlogovanZaposleni { get; internal set; }

        // Liste
        public List<KategorijaPacijenta> ListaKategorijaPacijenta { get; set; }
        public List<Pacijent> ListaPacijenata { get; set; }
        public List<Usluga> ListaUsluga { get; set; }
        public List<Zaposleni> ListaZaposlenih { get; set; }
        public List<Zakazivanje> ListaZakazivanja { get; set; }

        // Selektovani objekti
        public Pacijent IzabraniPacijent { get; set; }
        public Usluga IzabranaUsluga { get; set; }
        public Zakazivanje IzabranoZakazivanje { get; set; }

        // Forme
        public FrmLogin FrmLogin { get; set; }
        public FrmGlavna FrmGlavna { get; set; }
        public FrmPacijent FrmPacijent { get; set; }
        public FrmUsluga FrmUsluga { get; set; }
        public FrmZakazivanje FrmZakazivanje { get; set; }

        // Kontroleri
        public LoginGuiController LoginGuiController { get; set; }
        public PacijentGuiController PacijentGuiController { get; set; }
        public PretraziPacijentGuiController PretraziPacijentGuiController { get; set; }
        public UslugaGuiController UslugaGuiController { get; set; }
        public ZakazivanjeGuiController ZakazivanjeGuiController { get; set; }
        public PretraziZakazivanjeGuiController PretraziZakazivanjeGuiController { get; set; }

        internal void OtvoriLoginFormu()
        {
            FrmLogin = new FrmLogin();
            LoginGuiController = new LoginGuiController(FrmLogin);
            LoginGuiController.OtvoriFormu();
        }

        internal void OtvoriGlavnuFormu()
        {
            FrmGlavna = new FrmGlavna();
            FrmGlavna.ShowDialog();
        }

        internal void OtvoriPacijentPanel(Panel panelContent)
        {
            Response response = Communication.Instance.VratiListuSviKategorijaPacijenta(new KategorijaPacijenta());
            if (response.ExceptionMessage == null)
                ListaKategorijaPacijenta = response.Data as List<KategorijaPacijenta>;

            PacijentUC uc = new PacijentUC();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(uc);
        }

        internal void OtvoriUslugaPanel(Panel panelContent)
        {
            UslugaGuiController = new UslugaGuiController(null);
            UslugaUC uc = new UslugaUC();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(uc);
        }

        internal void InicijalizujPretraziPacijentKontroler(PacijentUC uc)
        {
            PretraziPacijentGuiController = new PretraziPacijentGuiController(uc);
            PacijentGuiController = new PacijentGuiController(null);
        }

        internal void OtvoriKreirajPacijentFormu()
        {
            FrmPacijent = new FrmPacijent(ModeForme.Kreiraj);
            PacijentGuiController = new PacijentGuiController(FrmPacijent);
        }

        internal void OtvoriPromeniPacijentFormu()
        {
            FrmPacijent = new FrmPacijent(ModeForme.Promeni);
            PacijentGuiController = new PacijentGuiController(FrmPacijent);
        }

        internal void OtvoriUbaciUslugaFormu()
        {
            FrmUsluga = new FrmUsluga(ModeForme.Kreiraj);
            UslugaGuiController = new UslugaGuiController(FrmUsluga);
        }

        internal void OtvoriPromeniUslugaFormu()
        {
            FrmUsluga = new FrmUsluga(ModeForme.Promeni);
            UslugaGuiController = new UslugaGuiController(FrmUsluga);
        }

        internal void OtvoriZakazivanjePanel(Panel panelContent)
        {
            Response responseZap = Communication.Instance.VratiListuSviZaposleni(new Zaposleni());
            if (responseZap.ExceptionMessage == null)
                ListaZaposlenih = responseZap.Data as List<Zaposleni>;

            Response responsePac = Communication.Instance.VratiListuSviPacijent(new Pacijent());
            if (responsePac.ExceptionMessage == null)
                ListaPacijenata = responsePac.Data as List<Pacijent>;

            Response responseUsl = Communication.Instance.VratiListuSviUsluga(new Usluga());
            if (responseUsl.ExceptionMessage == null)
                ListaUsluga = responseUsl.Data as List<Usluga>;

            ZakazivanjeUC uc = new ZakazivanjeUC();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(uc);
        }

        internal void InicijalizujPretraziZakazivanjeKontroler(ZakazivanjeUC uc)
        {
            PretraziZakazivanjeGuiController = new PretraziZakazivanjeGuiController(uc);
            ZakazivanjeGuiController = new ZakazivanjeGuiController(null);
        }

        internal void OtvoriKreirajZakazivanjeFormu()
        {
            FrmZakazivanje = new FrmZakazivanje(ModeForme.Kreiraj);
            ZakazivanjeGuiController = new ZakazivanjeGuiController(FrmZakazivanje);
        }

        internal void OtvoriPromeniZakazivanjeFormu()
        {
            FrmZakazivanje = new FrmZakazivanje(ModeForme.Promeni);
            ZakazivanjeGuiController = new ZakazivanjeGuiController(FrmZakazivanje);
        }
    }
}
