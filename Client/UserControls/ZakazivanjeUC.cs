using Client.Forms;
using Client.Session;
using Common.Communication;
using Common.Domain;

namespace Client.UserControls
{
    public partial class ZakazivanjeUC : UserControl
    {
        private Zaposleni _izabraniZaposleniFilter;
        private Pacijent _izabraniPacijentFilter;

        public Zaposleni IzabraniZaposleniFilter => _izabraniZaposleniFilter;
        public Pacijent IzabraniPacijentFilter => _izabraniPacijentFilter;

        public ZakazivanjeUC()
        {
            InitializeComponent();
            FormatirajGrid();
            PopuniCmbUsluga();
            lblIzabraniZaposleni.Text = Koordinator.Instance.UlogovanZaposleni?.ToString() ?? "Nije izabran";
            Koordinator.Instance.InicijalizujPretraziZakazivanjeKontroler(this);
            PopuniGrid();
            pnlCard.PerformLayout();
        }

        private void PopuniCmbUsluga()
        {
            var uslugeAll = new List<Usluga> { new Usluga { Id = -1, Naziv = "Sve usluge" } };
            uslugeAll.AddRange(Koordinator.Instance.ListaUsluga ?? new List<Usluga>());
            cmbUsluga.DataSource = uslugeAll;
            cmbUsluga.DisplayMember = "Naziv";
            cmbUsluga.ValueMember = "Id";
        }

        private void AzurirajLabele()
        {
            if (_izabraniZaposleniFilter != null)
            {
                lblIzabraniZaposleni.Text = _izabraniZaposleniFilter.ToString();
                lblIzabraniZaposleni.ForeColor = Color.FromArgb(20, 20, 20);
                lblIzabraniZaposleni.Font = new Font("Segoe UI", 9F);
            }
            else
            {
                lblIzabraniZaposleni.Text = Koordinator.Instance.UlogovanZaposleni?.ToString() ?? "Nije izabran";
                lblIzabraniZaposleni.ForeColor = Color.FromArgb(130, 130, 130);
                lblIzabraniZaposleni.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            }

            if (_izabraniPacijentFilter != null)
            {
                lblIzabraniPacijent.Text = _izabraniPacijentFilter.ToString();
                lblIzabraniPacijent.ForeColor = Color.FromArgb(20, 20, 20);
                lblIzabraniPacijent.Font = new Font("Segoe UI", 9F);
            }
            else
            {
                lblIzabraniPacijent.Text = "Nije izabran";
                lblIzabraniPacijent.ForeColor = Color.FromArgb(130, 130, 130);
                lblIzabraniPacijent.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            }
        }

        private void FormatirajGrid()
        {
            dgvZakazivanja.AutoGenerateColumns = false;
            dgvZakazivanja.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(150, 150, 150),
                Font = new Font("Segoe UI", 8.5F),
                SelectionBackColor = Color.White,
                SelectionForeColor = Color.FromArgb(150, 150, 150),
                Padding = new Padding(8, 0, 0, 0)
            };
            dgvZakazivanja.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(20, 20, 20),
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(253, 237, 241),
                SelectionForeColor = Color.FromArgb(20, 20, 20),
                Padding = new Padding(8, 0, 0, 0)
            };

            var colRb = new DataGridViewTextBoxColumn
            {
                Name = "colRb", HeaderText = "#", Width = 40,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    ForeColor = Color.FromArgb(170, 170, 170),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Padding = new Padding(0)
                },
                HeaderCell = { Style = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            };

            var colPacijent = new DataGridViewTextBoxColumn
            {
                Name = "colPacijent", HeaderText = "PACIJENT",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), Padding = new Padding(8, 0, 0, 0) }
            };

            var colZaposleni = new DataGridViewTextBoxColumn
            {
                Name = "colZaposleni", HeaderText = "ZAPOSLENI",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { Padding = new Padding(8, 0, 0, 0) }
            };

            var colDatum = new DataGridViewTextBoxColumn
            {
                Name = "colDatum", HeaderText = "DATUM I VREME",
                Width = 160, AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                DefaultCellStyle = new DataGridViewCellStyle { Padding = new Padding(8, 0, 0, 0) }
            };

            dgvZakazivanja.Columns.AddRange(colRb, colPacijent, colZaposleni, colDatum);
        }

        private void PopuniGrid()
        {
            var kriterijum = new Zakazivanje();
            kriterijum.WhereClause = $"z.idZaposleni = {Koordinator.Instance.UlogovanZaposleni.Id}";

            Response response = Communication.Instance.VratiListuZakazivanje(kriterijum);
            if (response.ExceptionMessage == null)
                Koordinator.Instance.ListaZakazivanja = response.Data as List<Zakazivanje>;

            dgvZakazivanja.DataSource = null;
            dgvZakazivanja.DataSource = Koordinator.Instance.ListaZakazivanja;
            dgvZakazivanja.ClearSelection();
            lblStatus.Text = "Nijedno nije izabrano";
        }

        private void dgvZakazivanja_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var z = dgvZakazivanja.Rows[e.RowIndex].DataBoundItem as Zakazivanje;
            if (z == null) return;

            switch (dgvZakazivanja.Columns[e.ColumnIndex].Name)
            {
                case "colRb":
                    e.Value = (e.RowIndex + 1).ToString();
                    e.FormattingApplied = true;
                    break;
                case "colPacijent":
                    e.Value = $"{z.Pacijent?.Ime} {z.Pacijent?.Prezime}";
                    e.FormattingApplied = true;
                    break;
                case "colZaposleni":
                    e.Value = $"{z.Zaposleni?.Ime} {z.Zaposleni?.Prezime}";
                    e.FormattingApplied = true;
                    break;
                case "colDatum":
                    e.Value = z.DatumIVremeZakazivanja.ToString("dd.MM.yyyy HH:mm");
                    e.FormattingApplied = true;
                    break;
            }
        }

        private void dgvZakazivanja_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvZakazivanja.SelectedRows.Count > 0)
            {
                var z = dgvZakazivanja.SelectedRows[0].DataBoundItem as Zakazivanje;
                Koordinator.Instance.IzabranoZakazivanje = z;
                lblStatus.Text = z != null ? $"{z.Pacijent?.Ime} {z.Pacijent?.Prezime}" : "Nijedno nije izabrano";
            }
            else
            {
                Koordinator.Instance.IzabranoZakazivanje = null;
                lblStatus.Text = "Nijedno nije izabrano";
            }
        }

        private void dgvZakazivanja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!Koordinator.Instance.PretraziZakazivanjeGuiController.NadjiZakazivanje()) return;
            Koordinator.Instance.OtvoriPromeniZakazivanjeFormu();
            Koordinator.Instance.ZakazivanjeGuiController.UcitajZakazivanje();
            PopuniGrid();
        }

        private void btnIzaberiZaposleni_Click(object sender, EventArgs e)
        {
            using var frm = new FrmIzaberiZaposleni();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                _izabraniZaposleniFilter = frm.IzabraniZaposleni;
                AzurirajLabele();
            }
        }

        private void btnIzaberiPacijent_Click(object sender, EventArgs e)
        {
            using var frm = new FrmIzaberiPacijent();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                _izabraniPacijentFilter = frm.IzabraniPacijent;
                AzurirajLabele();
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.PretraziZakazivanjeGuiController.VratiListuZakazivanje();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.OtvoriKreirajZakazivanjeFormu();
            Koordinator.Instance.ZakazivanjeGuiController.KreirajZakazivanje();
            PopuniGrid();
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            if (!Koordinator.Instance.PretraziZakazivanjeGuiController.NadjiZakazivanje()) return;
            Koordinator.Instance.OtvoriPromeniZakazivanjeFormu();
            Koordinator.Instance.ZakazivanjeGuiController.UcitajZakazivanje();
            PopuniGrid();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (!Koordinator.Instance.PretraziZakazivanjeGuiController.NadjiZakazivanje()) return;
            Koordinator.Instance.ZakazivanjeGuiController.ObrisiZakazivanje();
            PopuniGrid();
        }
    }
}
