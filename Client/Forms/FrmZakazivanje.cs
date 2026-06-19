using Client.Session;
using Common.Domain;

namespace Client.Forms
{
    public partial class FrmZakazivanje : Form
    {
        private ModeForme _mode;
        private bool _btnKliknuto = false;
        private Zaposleni _izabraniZaposleni;
        private Pacijent _izabraniPacijent;

        public Zaposleni IzabraniZaposleni => _izabraniZaposleni;
        public Pacijent IzabraniPacijent => _izabraniPacijent;

        public FrmZakazivanje(ModeForme mode)
        {
            InitializeComponent();
            _mode = mode;

            SetupDgvStavke();
            PopuniIzbor();
            AzurirajIznose();

            if (mode == ModeForme.Kreiraj)
            {
                btnSacuvaj.Text = "Sačuvaj";
            }
            else if (mode == ModeForme.Promeni)
            {
                btnSacuvaj.Text = "Izmeni";
                btnIzaberiPacijent.Enabled = false;
                btnIzaberiPacijent.Visible = false;
            }
        }

        private void SetupDgvStavke()
        {
            dgvStavke.DefaultCellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(253, 237, 241),
                SelectionForeColor = Color.FromArgb(20, 20, 20)
            };

            colRbStavka = new DataGridViewTextBoxColumn
            {
                HeaderText = "Rb",
                Name = "colRbStavka",
                Width = 40,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };

            colUslugaStavka = new DataGridViewComboBoxColumn
            {
                HeaderText = "Usluga",
                Name = "colUslugaStavka",
                DataSource = Koordinator.Instance.ListaUsluga,
                DisplayMember = "Naziv",
                ValueMember = "Id",
                Width = 260,
                FlatStyle = FlatStyle.Flat,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    SelectionBackColor = Color.FromArgb(253, 237, 241),
                    SelectionForeColor = Color.FromArgb(20, 20, 20)
                }
            };

            colCenaStavka = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cena (RSD)",
                Name = "colCenaStavka",
                Width = 120,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };

            colNapomenaStavka = new DataGridViewTextBoxColumn
            {
                HeaderText = "Napomena",
                Name = "colNapomenaStavka",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };

            dgvStavke.Columns.AddRange(colRbStavka, colUslugaStavka, colCenaStavka, colNapomenaStavka);
        }

        private void PopuniIzbor()
        {
            var z = Koordinator.Instance.IzabranoZakazivanje;
            if (z == null) return;
            dtpDatumIVremeZakazivanja.Value = z.DatumIVremeZakazivanja;
            if (_mode == ModeForme.Promeni)
            {
                _izabraniZaposleni = z.Zaposleni;
                _izabraniPacijent = z.Pacijent;
                AzurirajLabele();
                PopuniStavke(z.StavkeZakazivanja);
            }
        }

        private void PopuniStavke(List<StavkaZakazivanja> stavke)
        {
            if (stavke == null) return;
            foreach (var stavka in stavke)
            {
                int rowIdx = dgvStavke.Rows.Add();
                dgvStavke.Rows[rowIdx].Cells[colRbStavka.Name].Value = stavka.Rb;
                dgvStavke.Rows[rowIdx].Cells[colUslugaStavka.Name].Value = stavka.Usluga.Id;
                dgvStavke.Rows[rowIdx].Cells[colCenaStavka.Name].Value = stavka.Cena;
                dgvStavke.Rows[rowIdx].Cells[colNapomenaStavka.Name].Value = stavka.Napomena;
            }
        }

        private void AzurirajLabele()
        {
            if (_izabraniZaposleni != null)
            {
                lblIzabraniZaposleni.Text = _izabraniZaposleni.ToString();
                lblIzabraniZaposleni.ForeColor = Color.FromArgb(20, 20, 20);
                lblIzabraniZaposleni.Font = new Font("Segoe UI", 9F);
            }
            else
            {
                lblIzabraniZaposleni.Text = "Nije izabran";
                lblIzabraniZaposleni.ForeColor = Color.FromArgb(130, 130, 130);
                lblIzabraniZaposleni.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            }

            if (_izabraniPacijent != null)
            {
                lblIzabraniPacijent.Text = _izabraniPacijent.ToString();
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

        private void btnIzaberiZaposleni_Click(object sender, EventArgs e)
        {
            using var frm = new FrmIzaberiZaposleni();
            if (frm.ShowDialog(this) == DialogResult.OK && frm.IzabraniZaposleni != null)
            {
                _izabraniZaposleni = frm.IzabraniZaposleni;
                AzurirajLabele();
            }
        }

        private void btnIzaberiPacijent_Click(object sender, EventArgs e)
        {
            using var frm = new FrmIzaberiPacijent();
            if (frm.ShowDialog(this) == DialogResult.OK && frm.IzabraniPacijent != null)
            {
                _izabraniPacijent = frm.IzabraniPacijent;
                AzurirajLabele();
                AzurirajIznose();
            }
        }

        private void AzurirajIznose()
        {
            decimal ukupanIznos = 0;
            foreach (DataGridViewRow row in dgvStavke.Rows)
            {
                if (row.Cells[colCenaStavka.Index].Value != null)
                    ukupanIznos += Convert.ToDecimal(row.Cells[colCenaStavka.Index].Value);
            }

            decimal popust = _izabraniPacijent?.KategorijaPacijenta.Popust ?? 0;
            decimal iznosSaPopustom = Math.Round(ukupanIznos - ukupanIznos * popust / 100, 2);

            lblPopust.Text = $"Popust: {popust}%";
            lblUkupanIznos.Text = $"Ukupan iznos: {ukupanIznos:F2} RSD";
            lblIznosSaPopustom.Text = $"Sa popustom: {iznosSaPopustom:F2} RSD";
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            dgvStavke.Rows.Add();
        }

        private void btnUkloniStavku_Click(object sender, EventArgs e)
        {
            if (dgvStavke.SelectedRows.Count > 0)
            {
                dgvStavke.Rows.Remove(dgvStavke.SelectedRows[0]);
                AzurirajIznose();
            }
        }

        private void dgvStavke_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvStavke.IsCurrentCellDirty)
                dgvStavke.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvStavke_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colUslugaStavka.Index) return;
            var val = dgvStavke.Rows[e.RowIndex].Cells[colUslugaStavka.Index].Value;
            if (val == null) return;
            long uslugaId = Convert.ToInt64(val);
            Usluga u = Koordinator.Instance.ListaUsluga.FirstOrDefault(x => x.Id == uslugaId);
            if (u != null)
                dgvStavke.Rows[e.RowIndex].Cells[colCenaStavka.Index].Value = u.Cena;
            AzurirajIznose();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            _btnKliknuto = true;
            Koordinator.Instance.ZakazivanjeGuiController.PromeniZakazivanje();
            _btnKliknuto = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            _btnKliknuto = true;
            if (_mode == ModeForme.Kreiraj)
                Koordinator.Instance.ZakazivanjeGuiController.OdustaniKreiraj();
            else
                Koordinator.Instance.ZakazivanjeGuiController.OdustaniPromeni();
        }

        private void FrmZakazivanje_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_btnKliknuto || e.CloseReason != CloseReason.UserClosing) return;
            _btnKliknuto = true;
            if (_mode == ModeForme.Kreiraj)
                Koordinator.Instance.ZakazivanjeGuiController.OdustaniKreiraj();
            else
                Koordinator.Instance.ZakazivanjeGuiController.OdustaniPromeni();
        }
    }
}
