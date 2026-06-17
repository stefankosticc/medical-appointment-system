using Client.Forms;
using Client.Session;
using Common.Communication;
using Common.Domain;
using Common.Domain.Enums;
using System.Diagnostics;

namespace Client.GuiController
{
    public class KreirajPacijentGuiController
    {
        private FrmPacijent _frm;

        public KreirajPacijentGuiController(FrmPacijent frm)
        {
            _frm = frm;
        }

        internal void KreirajPacijenta()
        {
            _frm.ShowDialog();
        }

        internal void SacuvajPacijenta()
        {
            if (!Validacija()) return;

            try
            {
                Pacijent pacijent = new Pacijent
                {
                    Ime = _frm.txtIme.Text.Trim(),
                    Prezime = _frm.txtPrezime.Text.Trim(),
                    DatumRodjenja = DateOnly.FromDateTime(_frm.dtpDatumRodjenja.Value),
                    Pol = Enum.Parse<Pol>(_frm.cmbPol.SelectedItem.ToString()),
                    Email = _frm.txtEmail.Text.Trim(),
                    BrojTelefona = _frm.txtBrojTelefona.Text.Trim(),
                    KategorijaPacijenta = (KategorijaPacijenta)_frm.cmbKategorijaPacijenta.SelectedItem
                };

                Response response = Communication.Instance.KreirajPacijent(pacijent);

                if (response.ExceptionMessage != null || response.Data == null)
                {
                    MessageBox.Show(_frm, "Sistem ne može da kreira pacijenta.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(_frm, "Sistem je kreirao pacijenta.", "USPEŠNO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Koordinator.Instance.IzabraniPacijent = response.Data as Pacijent;
                _frm.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        internal void OdustaniKreiraj()
        {
            _frm.Close();
        }

        private bool Validacija()
        {
            if (string.IsNullOrEmpty(_frm.txtIme.Text) ||
                string.IsNullOrEmpty(_frm.txtPrezime.Text) ||
                string.IsNullOrEmpty(_frm.txtEmail.Text) ||
                string.IsNullOrEmpty(_frm.txtBrojTelefona.Text))
            {
                MessageBox.Show(_frm, "Popunite sva polja!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_frm.txtIme.Text.Any(char.IsDigit) || _frm.txtPrezime.Text.Any(char.IsDigit))
            {
                MessageBox.Show(_frm, "Ime i prezime ne smeju sadržati cifre!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
