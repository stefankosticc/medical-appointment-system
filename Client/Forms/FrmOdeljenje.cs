using Client.Session;

namespace Client.Forms
{
    public partial class FrmOdeljenje : Form
    {
        private ModeForme _mode;

        public FrmOdeljenje(ModeForme mode)
        {
            InitializeComponent();
            _mode = mode;

            if (mode == ModeForme.Kreiraj)
            {
                lblTitle.Text = "Ubaci odeljenje";
                btnSacuvaj.Visible = true;
                btnIzmeni.Visible = false;
            }
            else if (mode == ModeForme.Promeni)
            {
                lblTitle.Text = "Promeni odeljenje";
                btnSacuvaj.Visible = false;
                btnIzmeni.Visible = true;

                var odeljenje = Koordinator.Instance.IzabranoOdeljenje;
                if (odeljenje != null)
                    txtNaziv.Text = odeljenje.Naziv;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.OdeljenjeGuiController.SacuvajOdeljenje();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.OdeljenjeGuiController.IzmeniOdeljenje();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.OdeljenjeGuiController.Odustani();
        }
    }
}
