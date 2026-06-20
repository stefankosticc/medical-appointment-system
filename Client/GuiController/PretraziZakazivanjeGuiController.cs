using Client.Session;
using Client.UserControls;
using Common.Communication;
using Common.Domain;

namespace Client.GuiController
{
    internal class PretraziZakazivanjeGuiController
    {
        private readonly ZakazivanjeUC _uc;

        public PretraziZakazivanjeGuiController(ZakazivanjeUC uc)
        {
            _uc = uc;
        }

        internal void VratiListuZakazivanje()
        {
            Zakazivanje kriterijum = new Zakazivanje();
            var uslovi = new List<string>();

            long idZaposleni = _uc.IzabraniZaposleniFilter?.Id ?? Koordinator.Instance.UlogovanZaposleni.Id;
            uslovi.Add($"z.idZaposleni = {idZaposleni}");

            if (_uc.IzabraniPacijentFilter != null)
                uslovi.Add($"z.idPacijent = {_uc.IzabraniPacijentFilter.Id}");

            long idUsluga = _uc.cmbUsluga.SelectedValue is long uid && uid != -1 ? uid : -1;
            if (idUsluga != -1)
                uslovi.Add($"EXISTS (SELECT 1 FROM StavkaZakazivanja sz2 WHERE sz2.idZakazivanje = z.id AND sz2.idUsluga = {idUsluga})");

            kriterijum.WhereClause = string.Join(" AND ", uslovi);

            Response response = Communication.Instance.VratiListuZakazivanje(kriterijum);

            if (response.ExceptionMessage != null || response.Data == null || (response.Data as List<Zakazivanje>)?.Count == 0)
            {
                MessageBox.Show(_uc.ParentForm, "Sistem ne može da nađe zakazivanja po zadatim kriterijumima.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Koordinator.Instance.ListaZakazivanja = response.Data as List<Zakazivanje>;
            AzurirajTabelu(Koordinator.Instance.ListaZakazivanja);
            MessageBox.Show(_uc.ParentForm, "Sistem je našao zakazivanja po zadatim kriterijumima.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal bool NadjiZakazivanje()
        {
            if (Koordinator.Instance.IzabranoZakazivanje == null)
            {
                MessageBox.Show(_uc.ParentForm, "Nije izabrano nijedno zakazivanje.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Zakazivanje kriterijum = new Zakazivanje();
            kriterijum.WhereClause = $"z.id = {Koordinator.Instance.IzabranoZakazivanje.Id}";
            Response response = Communication.Instance.PretraziZakazivanje(kriterijum);

            if (response.ExceptionMessage != null || response.Data == null)
            {
                MessageBox.Show(_uc.ParentForm, "Sistem ne može da nađe zakazivanje.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Koordinator.Instance.IzabranoZakazivanje = response.Data as Zakazivanje;
            MessageBox.Show(_uc.ParentForm, "Sistem je našao zakazivanje.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        internal void PopuniGrid()
        {
            var kriterijum = new Zakazivanje();

            kriterijum.WhereClause = $"z.idZaposleni = {Koordinator.Instance.UlogovanZaposleni.Id}";
            Response response = Communication.Instance.VratiListuZakazivanje(kriterijum);

            if (response.ExceptionMessage == null)
                Koordinator.Instance.ListaZakazivanja = response.Data as List<Zakazivanje>;

            AzurirajTabelu(Koordinator.Instance.ListaZakazivanja);
        }

        internal void AzurirajTabelu(List<Zakazivanje> lista)
        {
            _uc.dgvZakazivanja.DataSource = null;
            _uc.dgvZakazivanja.DataSource = lista;
            _uc.dgvZakazivanja.ClearSelection();
        }
    }
}
