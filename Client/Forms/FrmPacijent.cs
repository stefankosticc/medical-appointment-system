using Client.Session;
using Common.Domain.Enums;

namespace Client.Forms
{
    public partial class FrmPacijent : Form
    {
        private ModeForme _mode;
        private bool _btnKliknuto = false;

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
                btnSacuvaj.Text = "Sačuvaj";
            }
            else if (mode == ModeForme.Promeni)
            {
                btnSacuvaj.Text = "Izmeni";
                dtpDatumRodjenja.Enabled = false;
                cmbPol.Enabled = false;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            _btnKliknuto = true;
            Koordinator.Instance.PacijentGuiController.SacuvajPacijenta();
            _btnKliknuto = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            _btnKliknuto = true;
            if (_mode == ModeForme.Kreiraj)
                Koordinator.Instance.PacijentGuiController.OdustaniKreiraj();
            else
                Koordinator.Instance.PacijentGuiController.OdustaniPromeni();
        }

        private void FrmPacijent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_btnKliknuto || e.CloseReason != CloseReason.UserClosing) return;

            _btnKliknuto = true;
            if (_mode == ModeForme.Kreiraj)
                Koordinator.Instance.PacijentGuiController.OdustaniKreiraj();
            else
                Koordinator.Instance.PacijentGuiController.OdustaniPromeni();
        }
    }
}
