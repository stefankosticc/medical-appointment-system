using Client.Forms;
using Client.Session;
using Common.Communication;
using Common.Domain;
using System.Diagnostics;

namespace Client.GuiController
{
    public class ZakazivanjeGuiController
    {
        private FrmZakazivanje _frm;

        public ZakazivanjeGuiController(FrmZakazivanje frm)
        {
            _frm = frm;
        }

        internal void KreirajZakazivanje()
        {
            Zakazivanje zakazivanje = new Zakazivanje
            {
                DatumIVremeZakazivanja = DateTime.Now,
                Zaposleni = Koordinator.Instance.UlogovanZaposleni,
                Pacijent = Koordinator.Instance.ListaPacijenata?.FirstOrDefault() ?? new Pacijent { Id = 1 }
            };

            Response response = Communication.Instance.KreirajZakazivanje(zakazivanje);

            if (response.ExceptionMessage != null || response.Data == null)
            {
                MessageBox.Show(_frm, "Sistem ne može da kreira zakazivanje.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Koordinator.Instance.IzabranoZakazivanje = response.Data as Zakazivanje;
            MessageBox.Show(_frm, "Sistem je kreirao zakazivanje.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _frm.ShowDialog();
        }

        private List<StavkaZakazivanja> GetStavke()
        {
            var stavke = new List<StavkaZakazivanja>();
            int rb = 1;
            foreach (DataGridViewRow row in _frm.dgvStavke.Rows)
            {
                if (row.Cells["colUslugaStavka"].Value == null) continue;
                long uslugaId = Convert.ToInt64(row.Cells["colUslugaStavka"].Value);
                Usluga u = Koordinator.Instance.ListaUsluga.FirstOrDefault(x => x.Id == uslugaId);
                if (u == null) continue;
                decimal cena = row.Cells["colCenaStavka"].Value != null
                    ? Convert.ToDecimal(row.Cells["colCenaStavka"].Value) : 0;
                string napomena = row.Cells["colNapomenaStavka"].Value?.ToString() ?? "";
                stavke.Add(new StavkaZakazivanja { Rb = rb++, Usluga = u, Cena = cena, Napomena = napomena });
            }
            return stavke;
        }

        internal void PromeniZakazivanje()
        {
            if (!Validacija()) return;

            try
            {
                Zakazivanje zakazivanje = new Zakazivanje
                {
                    Id = Koordinator.Instance.IzabranoZakazivanje.Id,
                    DatumIVremeZakazivanja = _frm.dtpDatumIVremeZakazivanja.Value,
                    Zaposleni = _frm.IzabraniZaposleni,
                    Pacijent = _frm.IzabraniPacijent,
                    StavkeZakazivanja = GetStavke()
                };

                Response response = Communication.Instance.PromeniZakazivanje(zakazivanje);

                if (response.ExceptionMessage != null || response.Data == null)
                {
                    MessageBox.Show(_frm, "Sistem ne može da zapamti zakazivanje.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(_frm, "Sistem je zapamtio zakazivanje.", "USPEŠNO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Koordinator.Instance.IzabranoZakazivanje = response.Data as Zakazivanje;
                _frm.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        internal void ObrisiZakazivanje()
        {
            if (Koordinator.Instance.IzabranoZakazivanje == null)
            {
                MessageBox.Show(_frm, "Nije izabrano nijedno zakazivanje.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Response response = Communication.Instance.ObrisiZakazivanje(Koordinator.Instance.IzabranoZakazivanje);

            if (response.ExceptionMessage != null)
            {
                MessageBox.Show(_frm, "Sistem ne može da obriše zakazivanje.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(_frm, "Sistem je obrisao zakazivanje.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Koordinator.Instance.IzabranoZakazivanje = null;
        }

        internal void UcitajZakazivanje()
        {
            _frm.ShowDialog();
        }

        internal void OdustaniPromeni()
        {
            _frm.Close();
        }

        internal void OdustaniKreiraj()
        {
            Response response = Communication.Instance.ObrisiZakazivanje(Koordinator.Instance.IzabranoZakazivanje);

            if (response.ExceptionMessage != null)
                MessageBox.Show(_frm, "Sistem ne može da obriše zakazivanje.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Koordinator.Instance.IzabranoZakazivanje = null;
            _frm.Close();
        }

        private bool Validacija()
        {
            if (_frm.IzabraniZaposleni == null || _frm.IzabraniPacijent == null)
            {
                MessageBox.Show(_frm, "Izaberite zaposlenog i pacijenta!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_frm.dtpDatumIVremeZakazivanja.Value <= DateTime.Now)
            {
                MessageBox.Show(_frm, "Datum zakazivanja mora biti u buducnosti!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (GetStavke().Count == 0)
            {
                MessageBox.Show(_frm, "Dodajte bar jednu stavku!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
