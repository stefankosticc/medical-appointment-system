using Client.Session;
using Common.Domain;

namespace Client.UserControls
{
    public partial class UslugaUC : UserControl
    {
        public UslugaUC()
        {
            InitializeComponent();
            FormatirajGrid();
            PopuniGrid();
        }

        private void FormatirajGrid()
        {
            dgvUsluge.AutoGenerateColumns = false;
            dgvUsluge.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(150, 150, 150),
                Font = new Font("Segoe UI", 8.5F),
                SelectionBackColor = Color.White,
                SelectionForeColor = Color.FromArgb(150, 150, 150),
                Padding = new Padding(8, 0, 0, 0)
            };
            dgvUsluge.DefaultCellStyle = new DataGridViewCellStyle
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
                HeaderText = "NAZIV USLUGE",
                DataPropertyName = "Naziv",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Padding = new Padding(8, 0, 0, 0)
                }
            };

            colCena = new DataGridViewTextBoxColumn
            {
                Name = "colCena",
                HeaderText = "CENA (RSD)",
                DataPropertyName = "Cena",
                Width = 160,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    ForeColor = Color.FromArgb(214, 34, 70),
                    SelectionForeColor = Color.FromArgb(214, 34, 70),
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Padding = new Padding(0, 0, 20, 0)
                },
                HeaderCell = { Style = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }}
            };

            dgvUsluge.Columns.AddRange(colRb, colNaziv, colCena);
        }

        private void PopuniGrid()
        {
            Koordinator.Instance.UslugaGuiController.PopuniGrid();
            dgvUsluge.DataSource = null;
            dgvUsluge.DataSource = Koordinator.Instance.ListaUsluga;
            dgvUsluge.ClearSelection();
            lblStatus.Text = "Nijedna nije izabrana";
        }

        private void dgvUsluge_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvUsluge.Columns[e.ColumnIndex].Name == "colRb")
            {
                e.Value = (e.RowIndex + 1).ToString();
                e.FormattingApplied = true;
            }
        }

        private void dgvUsluge_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsluge.SelectedRows.Count > 0)
            {
                var u = dgvUsluge.SelectedRows[0].DataBoundItem as Usluga;
                lblStatus.Text = u?.Naziv ?? "";
            }
            else
            {
                lblStatus.Text = "Nijedna nije izabrana";
            }
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.OtvoriUbaciUslugaFormu();
            Koordinator.Instance.UslugaGuiController.UbaciUslugu();
            PopuniGrid();
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            if (dgvUsluge.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite uslugu!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Koordinator.Instance.IzabranaUsluga = dgvUsluge.SelectedRows[0].DataBoundItem as Usluga;
            Koordinator.Instance.OtvoriPromeniUslugaFormu();
            Koordinator.Instance.UslugaGuiController.PromeniUslugu();
            PopuniGrid();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            // implementirati kada dodamo ObrisiUsluga SO
        }
    }
}
