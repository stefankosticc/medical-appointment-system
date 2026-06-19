using Client.Session;

namespace Client.Forms
{
    public partial class FrmUsluga : Form
    {
        private ModeForme _mode;

        public FrmUsluga(ModeForme mode)
        {
            InitializeComponent();
            _mode = mode;

            if (mode == ModeForme.Kreiraj)
            {
                lblTitle.Text = "Ubaci uslugu";
                btnSacuvaj.Visible = true;
                btnIzmeni.Visible = false;
            }
            else if (mode == ModeForme.Promeni)
            {
                lblTitle.Text = "Promeni uslugu";
                btnSacuvaj.Visible = false;
                btnIzmeni.Visible = true;

                var usluga = Koordinator.Instance.IzabranaUsluga;
                if (usluga != null)
                {
                    txtNaziv.Text = usluga.Naziv;
                    nudCena.Value = usluga.Cena;
                }
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.UslugaGuiController.SacuvajUslugu();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.UslugaGuiController.IzmeniUslugu();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.UslugaGuiController.Odustani();
        }
    }
}
