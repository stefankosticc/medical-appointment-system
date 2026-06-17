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

        // Selektovani objekti
        public Pacijent IzabraniPacijent { get; set; }

        // Forme i controlleri
        public FrmLogin FrmLogin { get; set; }
        public FrmGlavna FrmGlavna { get; set; }
        public FrmPacijent FrmPacijent { get; set; }

        public LoginGuiController LoginGuiController { get; set; }
        public KreirajPacijentGuiController KreirajPacijentGuiController { get; set; }

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

        internal void OtvoriKreirajPacijentFormu()
        {
            FrmPacijent = new FrmPacijent(ModeForme.Kreiraj);
            KreirajPacijentGuiController = new KreirajPacijentGuiController(FrmPacijent);
        }

        internal void OtvoriPromeniPacijentFormu()
        {
            FrmPacijent = new FrmPacijent(ModeForme.Promeni);
            // PromeniPacijentGuiController = new PromeniPacijentGuiController(FrmPacijent);
        }
    }
}
