using Client.Forms;
using Client.Session;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Client.GuiController
{
    internal class OdeljenjeGuiController
    {
        private FrmOdeljenje _frm;

        public OdeljenjeGuiController(FrmOdeljenje frm)
        {
            _frm = frm;
        }

        internal void PopuniGrid()
        {
            Response response = Communication.Instance.VratiListuSviOdeljenje(new Odeljenje());
            if (response.ExceptionMessage == null)
                Koordinator.Instance.ListaOdeljenja = response.Data as List<Odeljenje>;
        }

        internal void UbaciOdeljenje()
        {
            _frm.ShowDialog();
        }

        internal void PromeniOdeljenje()
        {
            _frm.ShowDialog();
        }

        internal void Odustani()
        {
            _frm.Close();
        }

        internal void SacuvajOdeljenje()
        {
            if (!Validacija()) return;

            try
            {
                Odeljenje odeljenje = new Odeljenje
                {
                    Naziv = _frm.txtNaziv.Text.Trim()
                };

                Response response = Communication.Instance.UbaciOdeljenje(odeljenje);

                if (response.ExceptionMessage != null || response.Data == null)
                {
                    MessageBox.Show(_frm, "Sistem ne može da zapamti odeljenje.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(_frm, "Sistem je zapamtio odeljenje.", "USPEŠNO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Koordinator.Instance.IzabranoOdeljenje = response.Data as Odeljenje;
                _frm.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        internal void IzmeniOdeljenje()
        {
            if (!Validacija()) return;

            try
            {
                Odeljenje odeljenje = new Odeljenje
                {
                    Id = Koordinator.Instance.IzabranoOdeljenje.Id,
                    Naziv = _frm.txtNaziv.Text.Trim()
                };

                Response response = Communication.Instance.PromeniOdeljenje(odeljenje);

                if (response.ExceptionMessage != null || response.Data == null)
                {
                    MessageBox.Show(_frm, "Sistem ne može da zapamti odeljenje.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(_frm, "Sistem je zapamtio odeljenje.", "USPEŠNO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Koordinator.Instance.IzabranoOdeljenje = response.Data as Odeljenje;
                _frm.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private bool Validacija()
        {
            if (string.IsNullOrWhiteSpace(_frm.txtNaziv.Text))
            {
                MessageBox.Show(_frm, "Unesite naziv odeljenja!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
