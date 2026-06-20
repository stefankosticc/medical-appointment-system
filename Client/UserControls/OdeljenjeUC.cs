using Client.Session;
using Common.Domain;

namespace Client.UserControls
{
    public partial class OdeljenjeUC : UserControl
    {
        public OdeljenjeUC()
        {
            InitializeComponent();
            FormatirajGrid();
            PopuniGrid();
        }

        private void FormatirajGrid()
        {
            dgvOdeljenja.AutoGenerateColumns = false;
            dgvOdeljenja.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(150, 150, 150),
                Font = new Font("Segoe UI", 8.5F),
                SelectionBackColor = Color.White,
                SelectionForeColor = Color.FromArgb(150, 150, 150),
                Padding = new Padding(8, 0, 0, 0)
            };
            dgvOdeljenja.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(20, 20, 20),
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(253, 237, 241),
                SelectionForeColor = Color.FromArgb(20, 20, 20),
                Padding = new Padding(8, 0, 0, 0)
            };

            colRb = new DataGridViewTextBoxColumn
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

            colNaziv = new DataGridViewTextBoxColumn
            {
                Name = "colNaziv",
                HeaderText = "NAZIV ODELJENJA",
                DataPropertyName = "Naziv",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Padding = new Padding(8, 0, 0, 0)
                }
            };

            dgvOdeljenja.Columns.AddRange(colRb, colNaziv);
        }

        private void PopuniGrid()
        {
            Koordinator.Instance.OdeljenjeGuiController.PopuniGrid();
            dgvOdeljenja.DataSource = null;
            dgvOdeljenja.DataSource = Koordinator.Instance.ListaOdeljenja;
            dgvOdeljenja.ClearSelection();
            lblStatus.Text = "Nijedno nije izabrano";
        }

        private void dgvOdeljenja_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvOdeljenja.Columns[e.ColumnIndex].Name == "colRb")
            {
                e.Value = (e.RowIndex + 1).ToString();
                e.FormattingApplied = true;
            }
        }

        private void dgvOdeljenja_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOdeljenja.SelectedRows.Count > 0)
            {
                var o = dgvOdeljenja.SelectedRows[0].DataBoundItem as Odeljenje;
                lblStatus.Text = o?.Naziv ?? "";
            }
            else
            {
                lblStatus.Text = "Nijedno nije izabrano";
            }
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.OtvoriUbaciOdeljenjeFormu();
            Koordinator.Instance.OdeljenjeGuiController.UbaciOdeljenje();
            PopuniGrid();
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            if (dgvOdeljenja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite odeljenje!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Koordinator.Instance.IzabranoOdeljenje = dgvOdeljenja.SelectedRows[0].DataBoundItem as Odeljenje;
            Koordinator.Instance.OtvoriPromeniOdeljenjeFormu();
            Koordinator.Instance.OdeljenjeGuiController.PromeniOdeljenje();
            PopuniGrid();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            // implementirati kada dodamo ObrisiOdeljenje SO
        }
    }
}
