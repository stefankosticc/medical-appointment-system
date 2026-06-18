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
                btnSacuvaj.Visible = true;
                btnIzmeni.Visible = false;
                btnOdustani.Text = "Odustani";
            }
            else if (mode == ModeForme.Promeni)
            {
                btnSacuvaj.Visible = false;
                btnIzmeni.Visible = true;
                btnOdustani.Text = "Odustani";
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            _btnKliknuto = true;
            Koordinator.Instance.KreirajPacijentGuiController.SacuvajPacijenta();
            _btnKliknuto = false;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            _btnKliknuto = true;
            Koordinator.Instance.KreirajPacijentGuiController.SacuvajPacijenta();
            _btnKliknuto = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            _btnKliknuto = true;
            if (_mode == ModeForme.Kreiraj)
                Koordinator.Instance.KreirajPacijentGuiController.OdustaniKreiraj();
            else
                Koordinator.Instance.KreirajPacijentGuiController.OdustaniPromeni();
        }

        private void FrmPacijent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_btnKliknuto || e.CloseReason != CloseReason.UserClosing) return;

            _btnKliknuto = true;
            if (_mode == ModeForme.Kreiraj)
                Koordinator.Instance.KreirajPacijentGuiController.OdustaniKreiraj();
            else
                Koordinator.Instance.KreirajPacijentGuiController.OdustaniPromeni();
        }
    }
}
