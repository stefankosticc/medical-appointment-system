using Client.Session;
using Common.Domain.Enums;

namespace Client.Forms
{
    public partial class FrmPacijent : Form
    {
        private ModeForme _mode;

        public FrmPacijent(ModeForme mode)
        {
            InitializeComponent();
            _mode = mode;

            cmbPol.DataSource = Enum.GetValues(typeof(Pol));

            cmbKategorijaPacijenta.DataSource = Koordinator.Instance.ListaKategorijaPacijenta;
            cmbKategorijaPacijenta.DisplayMember = "Naziv";
            cmbKategorijaPacijenta.ValueMember = "Id";

            if (mode == ModeForme.Kreiraj)
            {
                btnSacuvaj.Visible = true;
                btnIzmeni.Visible = false;
                btnOdustani.Text = "Odustani";
            }
            else if (mode == ModeForme.Promeni)
            {
                btnSacuvaj.Visible = false;
                btnIzmeni.Visible = true;
                btnOdustani.Text = "Obriši";
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.KreirajPacijentGuiController.SacuvajPacijenta();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
           // Koordinator.Instance.PromeniPacijentGuiController.SacuvajPacijenta();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            if (_mode == ModeForme.Kreiraj)
                Koordinator.Instance.KreirajPacijentGuiController.OdustaniKreiraj();
            //else
              //  Koordinator.Instance.PromeniPacijentGuiController.OdustaniPromeni();
        }
    }
}
