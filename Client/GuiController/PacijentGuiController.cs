using Client.Forms;
using Client.Session;
using Common.Communication;
using Common.Domain;
using Common.Domain.Enums;
using System.Diagnostics;

namespace Client.GuiController
{
    public class PacijentGuiController
    {
        private FrmPacijent _frm;

        public PacijentGuiController(FrmPacijent frm)
        {
            _frm = frm;
        }

        internal void KreirajPacijenta()
        {
            Pacijent prazanPacijent = new Pacijent
            {
                Ime = "",
                Prezime = "",
                DatumRodjenja = DateOnly.FromDateTime(DateTime.Today),
                Pol = Pol.MUŠKI,
                Email = "",
                BrojTelefona = "",
                KategorijaPacijenta = Koordinator.Instance.ListaKategorijaPacijenta?.FirstOrDefault() ?? new KategorijaPacijenta { Id = 1 }
            };

            Response response = Communication.Instance.KreirajPacijent(prazanPacijent);

            if (response.ExceptionMessage != null || response.Data == null)
            {
                MessageBox.Show(_frm, "Sistem ne može da kreira pacijenta.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Koordinator.Instance.IzabraniPacijent = response.Data as Pacijent;
            MessageBox.Show(_frm, "Sistem je kreirao pacijenta.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _frm.ShowDialog();
        }

        internal void SacuvajPacijenta()
        {
            if (!Validacija()) return;

            try
            {
                Pacijent pacijent = new Pacijent
                {
                    Id = Koordinator.Instance.IzabraniPacijent.Id,
                    Ime = _frm.txtIme.Text.Trim(),
                    Prezime = _frm.txtPrezime.Text.Trim(),
                    DatumRodjenja = DateOnly.FromDateTime(_frm.dtpDatumRodjenja.Value),
                    Pol = Enum.Parse<Pol>(_frm.cmbPol.SelectedItem.ToString()),
                    Email = _frm.txtEmail.Text.Trim(),
                    BrojTelefona = _frm.txtBrojTelefona.Text.Trim(),
                    KategorijaPacijenta = (KategorijaPacijenta)_frm.cmbKategorijaPacijenta.SelectedItem
                };

                Response response = Communication.Instance.PromeniPacijent(pacijent);

                if (response.ExceptionMessage != null || response.Data == null)
                {
                    MessageBox.Show(_frm, "Sistem ne može da zapamti pacijenta.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(_frm, "Sistem je zapamtio pacijenta.", "USPEŠNO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _frm.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        internal void PromeniPacijenta()
        {
            Pacijent p = Koordinator.Instance.IzabraniPacijent;

            _frm.txtIme.Text = p.Ime;
            _frm.txtPrezime.Text = p.Prezime;
            _frm.dtpDatumRodjenja.Value = p.DatumRodjenja.ToDateTime(TimeOnly.MinValue);
            _frm.cmbPol.SelectedItem = p.Pol;
            _frm.txtEmail.Text = p.Email;
            _frm.txtBrojTelefona.Text = p.BrojTelefona;
            _frm.cmbKategorijaPacijenta.SelectedValue = p.KategorijaPacijenta.Id;

            _frm.ShowDialog();
        }

        internal void OdustaniPromeni()
        {
            _frm.Close();
        }

        internal void ObrisiPacijenta()
        {
            Response response = Communication.Instance.ObrisiPacijent(Koordinator.Instance.IzabraniPacijent);

            if (response.ExceptionMessage != null)
            {
                MessageBox.Show("Sistem ne može da obriše pacijenta.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Sistem je obrisao pacijenta.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Koordinator.Instance.IzabraniPacijent = null;
        }

        internal void OdustaniKreiraj()
        {
            ObrisiPacijenta();
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

            if (_frm.dtpDatumRodjenja.Value.Date > DateTime.Today)
            {
                MessageBox.Show(_frm, "Datum rođenja mora biti u prošlosti!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
