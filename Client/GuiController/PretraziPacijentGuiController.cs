using Client.Session;
using Client.UserControls;
using Common.Communication;
using Common.Domain;

namespace Client.GuiController
{
    internal class PretraziPacijentGuiController
    {
        private readonly PacijentUC _uc;

        public PretraziPacijentGuiController(PacijentUC uc)
        {
            _uc = uc;
        }

        internal void VratiListuPacijent()
        {
            Pacijent kriterijum = new Pacijent();

            string ime = _uc.txtIme.Text.Trim();
            string prezime = _uc.txtPrezime.Text.Trim();
            long idKategorija = _uc.cmbKategorija.SelectedValue is long id ? id : -1;

            var uslovi = new List<string>();
            if (!string.IsNullOrEmpty(ime)) uslovi.Add($"p.ime LIKE '%{ime}%'");
            if (!string.IsNullOrEmpty(prezime)) uslovi.Add($"p.prezime LIKE '%{prezime}%'");
            if (_uc.dtpDatumRodjenja.Checked)
                uslovi.Add($"p.datRodjenja = '{_uc.dtpDatumRodjenja.Value:yyyy-MM-dd}'");
            if (idKategorija != -1) uslovi.Add($"p.idKategorijaPacijenta = {idKategorija}");

            kriterijum.WhereClause = string.Join(" AND ", uslovi);

            if (string.IsNullOrEmpty(kriterijum.WhereClause))
            {
                Response sviResponse = Communication.Instance.VratiListuSviPacijent(new Pacijent());
                if (sviResponse.ExceptionMessage == null)
                    Koordinator.Instance.ListaPacijenata = sviResponse.Data as List<Pacijent>;
                AzurirajTabelu(Koordinator.Instance.ListaPacijenata);
                return;
            }

            Response response = Communication.Instance.VratiListuPacijent(kriterijum);

            if (response.ExceptionMessage != null || response.Data == null || (response.Data as List<Pacijent>)?.Count == 0)
            {
                MessageBox.Show(_uc.ParentForm, "Sistem ne može da nađe pacijente po zadatim kriterijumima.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Koordinator.Instance.ListaPacijenata = response.Data as List<Pacijent>;
            AzurirajTabelu(Koordinator.Instance.ListaPacijenata);
            MessageBox.Show(_uc.ParentForm, "Sistem je našao pacijente po zadatim kriterijumima.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal bool NadjiPacijenta()
        {
            if (Koordinator.Instance.IzabraniPacijent == null)
            {
                MessageBox.Show(_uc.ParentForm, "Nije izabran nijedan pacijent.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Pacijent kriterijum = new Pacijent { WhereClause = $"p.id = {Koordinator.Instance.IzabraniPacijent.Id}" };
            Response response = Communication.Instance.PretraziPacijent(kriterijum);

            if (response.ExceptionMessage != null || response.Data == null || (response.Data as List<Pacijent>)?.Count == 0)
            {
                MessageBox.Show(_uc.ParentForm, "Sistem ne može da nađe pacijenta.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Koordinator.Instance.IzabraniPacijent = (response.Data as List<Pacijent>)[0];
            MessageBox.Show(_uc.ParentForm, "Sistem je našao pacijenta.", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        internal void PopuniGrid()
        {
            Response response = Communication.Instance.VratiListuSviPacijent(new Pacijent());
            if (response.ExceptionMessage == null)
                Koordinator.Instance.ListaPacijenata = response.Data as List<Pacijent>;
            AzurirajTabelu(Koordinator.Instance.ListaPacijenata);
        }

        private void AzurirajTabelu(List<Pacijent> lista)
        {
            _uc.dgvPacijenti.DataSource = null;
            _uc.dgvPacijenti.DataSource = lista;
            _uc.dgvPacijenti.ClearSelection();
        }
    }
}
