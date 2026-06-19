using Client.Session;
using Common.Domain;
using Common.Domain.Enums;

namespace Client.Forms
{
    public partial class FrmIzaberiPacijent : Form
    {
        public Pacijent IzabraniPacijent { get; private set; }

        public FrmIzaberiPacijent()
        {
            InitializeComponent();
            SetupDgv();
            PopuniGrid();
        }

        private void SetupDgv()
        {
            dgvPacijent.AutoGenerateColumns = false;
            dgvPacijent.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(150, 150, 150),
                Font = new Font("Segoe UI", 8.5F),
                SelectionBackColor = Color.White,
                SelectionForeColor = Color.FromArgb(150, 150, 150),
                Padding = new Padding(6, 0, 0, 0)
            };
            dgvPacijent.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(20, 20, 20),
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(253, 237, 241),
                SelectionForeColor = Color.FromArgb(20, 20, 20),
                Padding = new Padding(6, 0, 0, 0)
            };

            dgvPacijent.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "colIme", HeaderText = "IME I PREZIME", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { Name = "colDatumRodjenja", HeaderText = "DAT. ROĐENJA", Width = 105 },
                new DataGridViewTextBoxColumn { Name = "colPol", HeaderText = "POL", Width = 70 },
                new DataGridViewTextBoxColumn { Name = "colKategorija", HeaderText = "KATEGORIJA", Width = 120 },
                new DataGridViewTextBoxColumn { Name = "colTelefon", HeaderText = "TELEFON", DataPropertyName = "BrojTelefona", Width = 120 }
            );

            dgvPacijent.CellFormatting += dgvPacijent_CellFormatting;
        }

        private void dgvPacijent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var p = dgvPacijent.Rows[e.RowIndex].DataBoundItem as Pacijent;
            if (p == null) return;

            switch (dgvPacijent.Columns[e.ColumnIndex].Name)
            {
                case "colIme":
                    e.Value = $"{p.Ime} {p.Prezime}";
                    e.FormattingApplied = true;
                    break;
                case "colDatumRodjenja":
                    e.Value = p.DatumRodjenja.ToString("dd.MM.yyyy");
                    e.FormattingApplied = true;
                    break;
                case "colPol":
                    e.Value = p.Pol == Pol.MUŠKI ? "Muški" : "Ženski";
                    e.FormattingApplied = true;
                    break;
                case "colKategorija":
                    e.Value = p.KategorijaPacijenta?.Naziv ?? "";
                    e.FormattingApplied = true;
                    break;
            }
        }

        private void PopuniGrid(string filter = "")
        {
            dgvPacijent.DataSource = Koordinator.Instance.ListaPacijenata
                .Where(p => p.Ime.ToLower().Contains(filter) || p.Prezime.ToLower().Contains(filter))
                .ToList();
            dgvPacijent.ClearSelection();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniGrid(txtPretraga.Text.ToLower());
        }

        private void Potvrdi()
        {
            if (dgvPacijent.SelectedRows.Count == 0) return;
            IzabraniPacijent = dgvPacijent.SelectedRows[0].DataBoundItem as Pacijent;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e) => Potvrdi();

        private void dgvPacijent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) Potvrdi();
        }

        private void btnPonitiIzbor_Click(object sender, EventArgs e)
        {
            IzabraniPacijent = null;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
