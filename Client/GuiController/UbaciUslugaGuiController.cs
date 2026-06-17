using Client.Forms;
using Client.Session;
using Common.Communication;
using Common.Domain;
using System.Diagnostics;

namespace Client.GuiController
{
    internal class UbaciUslugaGuiController
    {
        private FrmUsluga _frm;

        public UbaciUslugaGuiController(FrmUsluga frm)
        {
            _frm = frm;
        }

        internal void UbaciUslugu()
        {
            _frm.ShowDialog();
        }

        internal void PromeniUslugu()
        {
            _frm.ShowDialog();
        }

        internal void SacuvajUslugu()
        {
            if (!Validacija()) return;

            try
            {
                Usluga usluga = new Usluga
                {
                    Naziv = _frm.txtNaziv.Text.Trim(),
                    Cena = _frm.nudCena.Value
                };

                Response response = Communication.Instance.UbaciUsluga(usluga);

                if (response.ExceptionMessage != null || response.Data == null)
                {
                    MessageBox.Show(_frm, "Sistem ne može da zapamti uslugu.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(_frm, "Sistem je zapamtio uslugu.", "USPEŠNO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Koordinator.Instance.IzabranaUsluga = response.Data as Usluga;
                _frm.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        internal void IzmeniUslugu()
        {
            if (!Validacija()) return;

            try
            {
                Usluga usluga = new Usluga
                {
                    Id = Koordinator.Instance.IzabranaUsluga.Id,
                    Naziv = _frm.txtNaziv.Text.Trim(),
                    Cena = _frm.nudCena.Value
                };

                Response response = Communication.Instance.PromeniUsluga(usluga);

                if (response.ExceptionMessage != null || response.Data == null)
                {
                    MessageBox.Show(_frm, "Sistem ne može da zapamti uslugu.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(_frm, "Sistem je zapamtio uslugu.", "USPEŠNO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Koordinator.Instance.IzabranaUsluga = response.Data as Usluga;
                _frm.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        internal void Odustani()
        {
            _frm.Close();
        }

        private bool Validacija()
        {
            if (string.IsNullOrWhiteSpace(_frm.txtNaziv.Text))
            {
                MessageBox.Show(_frm, "Unesite naziv usluge!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_frm.nudCena.Value <= 0)
            {
                MessageBox.Show(_frm, "Cena mora biti veća od 0!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
