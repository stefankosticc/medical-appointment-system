using Client.Session;
using Common.Domain;

namespace Client.Forms
{
    public partial class FrmIzaberiZaposleni : Form
    {
        public Zaposleni IzabraniZaposleni { get; private set; }

        public FrmIzaberiZaposleni()
        {
            InitializeComponent();
            SetupDgv();
            PopuniGrid();
        }

        private void SetupDgv()
        {
            dgvZaposleni.AutoGenerateColumns = false;
            dgvZaposleni.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(150, 150, 150),
                Font = new Font("Segoe UI", 8.5F),
                SelectionBackColor = Color.White,
                SelectionForeColor = Color.FromArgb(150, 150, 150),
                Padding = new Padding(6, 0, 0, 0)
            };
            dgvZaposleni.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(20, 20, 20),
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(253, 237, 241),
                SelectionForeColor = Color.FromArgb(20, 20, 20),
                Padding = new Padding(6, 0, 0, 0)
            };

            dgvZaposleni.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "colIme", HeaderText = "IME I PREZIME", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { Name = "colKorisnickoIme", HeaderText = "KORISNIČKO IME", DataPropertyName = "KorisnickoIme", Width = 160 }
            );

            dgvZaposleni.CellFormatting += dgvZaposleni_CellFormatting;
        }

        private void dgvZaposleni_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvZaposleni.Columns[e.ColumnIndex].Name != "colIme") return;
            var z = dgvZaposleni.Rows[e.RowIndex].DataBoundItem as Zaposleni;
            if (z == null) return;
            e.Value = $"{z.Ime} {z.Prezime}";
            e.FormattingApplied = true;
        }

        private void PopuniGrid(string filter = "")
        {
            dgvZaposleni.DataSource = Koordinator.Instance.ListaZaposlenih
                .Where(z => z.Ime.ToLower().Contains(filter) || z.Prezime.ToLower().Contains(filter))
                .ToList();
            dgvZaposleni.ClearSelection();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniGrid(txtPretraga.Text.ToLower());
        }

        private void Potvrdi()
        {
            if (dgvZaposleni.SelectedRows.Count == 0) return;
            IzabraniZaposleni = dgvZaposleni.SelectedRows[0].DataBoundItem as Zaposleni;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e) => Potvrdi();

        private void dgvZaposleni_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) Potvrdi();
        }

        private void btnPonitiIzbor_Click(object sender, EventArgs e)
        {
            IzabraniZaposleni = null;
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
