using Client.Session;
using Common.Communication;
using Common.Domain;

namespace Client.UserControls
{
    public partial class PacijentUC : UserControl
    {
        public PacijentUC()
        {
            InitializeComponent();
            FormatirajGrid();
            PopuniKomboKategorija();
            PopuniGrid();
            Koordinator.Instance.InicijalizujPretraziPacijentKontroler(this);
        }

        private void PopuniKomboKategorija()
        {
            var lista = new List<KategorijaPacijenta> { new KategorijaPacijenta { Id = -1, Naziv = "Kategorija" } };
            lista.AddRange(Koordinator.Instance.ListaKategorijaPacijenta ?? new List<KategorijaPacijenta>());
            cmbKategorija.DataSource = lista;
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "Id";
            cmbKategorija.SelectedIndex = 0;
        }

        private void PopuniGrid()
        {
            Response response = Communication.Instance.VratiListuSviPacijent(new Pacijent());
            if (response.ExceptionMessage == null)
                Koordinator.Instance.ListaPacijenata = response.Data as List<Pacijent>;

            dgvPacijenti.DataSource = null;
            dgvPacijenti.DataSource = Koordinator.Instance.ListaPacijenata;
            dgvPacijenti.ClearSelection();
            lblStatus.Text = "Nijedan nije izabran";
        }

        private void FormatirajGrid()
        {
            dgvPacijenti.AutoGenerateColumns = false;
            dgvPacijenti.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(150, 150, 150),
                Font = new Font("Segoe UI", 8.5F),
                SelectionBackColor = Color.White,
                SelectionForeColor = Color.FromArgb(150, 150, 150),
                Padding = new Padding(8, 0, 0, 0)
            };
            dgvPacijenti.DefaultCellStyle = new DataGridViewCellStyle
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
                Name = "colRb",
                HeaderText = "#",
                Width = 40,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    ForeColor = Color.FromArgb(170, 170, 170),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Padding = new Padding(0)
                },
                HeaderCell =
                {
                    Style = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    }
                }
            };

            var colIme = new DataGridViewTextBoxColumn
            {
                Name = "colIme",
                HeaderText = "IME",
                DataPropertyName = "Ime",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Padding = new Padding(8, 0, 0, 0)
                }
            };

            var colPrezime = new DataGridViewTextBoxColumn
            {
                Name = "colPrezime",
                HeaderText = "PREZIME",
                DataPropertyName = "Prezime",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Padding = new Padding(8, 0, 0, 0)
                }
            };

            var colDatumRodjenja = new DataGridViewTextBoxColumn
            {
                Name = "colDatumRodjenja",
                HeaderText = "DAT. ROĐENJA",
                DataPropertyName = "DatumRodjenja",
                Width = 130,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Padding = new Padding(8, 0, 0, 0)
                }
            };

            var colKategorija = new DataGridViewTextBoxColumn
            {
                Name = "colKategorija",
                HeaderText = "KATEGORIJA",
                Width = 150,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Padding = new Padding(8, 0, 0, 0)
                }
            };

            dgvPacijenti.Columns.AddRange(colRb, colIme, colPrezime, colDatumRodjenja, colKategorija);
        }

        private void dgvPacijenti_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPacijenti.Columns[e.ColumnIndex].Name == "colRb")
            {
                e.Value = (e.RowIndex + 1).ToString();
                e.FormattingApplied = true;
            }
            else if (dgvPacijenti.Columns[e.ColumnIndex].Name == "colKategorija")
            {
                var p = dgvPacijenti.Rows[e.RowIndex].DataBoundItem as Pacijent;
                e.Value = p?.KategorijaPacijenta?.Naziv ?? "";
                e.FormattingApplied = true;
            }
        }

        private void dgvPacijenti_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPacijenti.SelectedRows.Count > 0)
            {
                var p = dgvPacijenti.SelectedRows[0].DataBoundItem as Pacijent;
                Koordinator.Instance.IzabraniPacijent = p;
                lblStatus.Text = p != null ? $"{p.Ime} {p.Prezime}" : "Nijedan nije izabran";
            }
            else
            {
                Koordinator.Instance.IzabraniPacijent = null;
                lblStatus.Text = "Nijedan nije izabran";
            }
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.OtvoriKreirajPacijentFormu();
            Koordinator.Instance.KreirajPacijentGuiController.KreirajPacijenta();
            PopuniGrid();
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            if (!Koordinator.Instance.PretraziPacijentGuiController.NadjiPacijenta()) return;
            Koordinator.Instance.OtvoriPromeniPacijentFormu();
            Koordinator.Instance.KreirajPacijentGuiController.PromeniPacijenta();
            PopuniGrid();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (!Koordinator.Instance.PretraziPacijentGuiController.NadjiPacijenta()) return;
            Koordinator.Instance.KreirajPacijentGuiController.ObrisiPacijenta();
            PopuniGrid();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.PretraziPacijentGuiController.VratiListuPacijent();
        }

    }
}
