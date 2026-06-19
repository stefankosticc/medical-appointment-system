namespace Client.Forms
{
    partial class FrmZakazivanje
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblZaposleni = new Label();
            lblIzabraniZaposleni = new Label();
            btnIzaberiZaposleni = new Button();
            lblPacijent = new Label();
            lblIzabraniPacijent = new Label();
            btnIzaberiPacijent = new Button();
            lblDatumIVreme = new Label();
            dtpDatumIVremeZakazivanja = new DateTimePicker();
            lblStavke = new Label();
            btnDodajStavku = new Button();
            btnUkloniStavku = new Button();
            dgvStavke = new DataGridView();
            lblPopust = new Label();
            lblUkupanIznos = new Label();
            lblIznosSaPopustom = new Label();
            btnSacuvaj = new Button();
            btnIzmeni = new Button();
            btnOdustani = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // lblZaposleni
            // 
            lblZaposleni.Location = new Point(20, 20);
            lblZaposleni.Name = "lblZaposleni";
            lblZaposleni.Size = new Size(100, 23);
            lblZaposleni.TabIndex = 0;
            lblZaposleni.Text = "Zaposleni:";
            // 
            // lblIzabraniZaposleni
            // 
            lblIzabraniZaposleni.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblIzabraniZaposleni.ForeColor = Color.FromArgb(130, 130, 130);
            lblIzabraniZaposleni.Location = new Point(125, 20);
            lblIzabraniZaposleni.Name = "lblIzabraniZaposleni";
            lblIzabraniZaposleni.Size = new Size(360, 23);
            lblIzabraniZaposleni.TabIndex = 1;
            lblIzabraniZaposleni.Text = "Nije izabran";
            // 
            // btnIzaberiZaposleni
            // 
            btnIzaberiZaposleni.Location = new Point(495, 16);
            btnIzaberiZaposleni.Name = "btnIzaberiZaposleni";
            btnIzaberiZaposleni.Size = new Size(90, 28);
            btnIzaberiZaposleni.TabIndex = 2;
            btnIzaberiZaposleni.Text = "Izaberi";
            btnIzaberiZaposleni.Click += btnIzaberiZaposleni_Click;
            // 
            // lblPacijent
            // 
            lblPacijent.Location = new Point(20, 58);
            lblPacijent.Name = "lblPacijent";
            lblPacijent.Size = new Size(100, 23);
            lblPacijent.TabIndex = 3;
            lblPacijent.Text = "Pacijent:";
            // 
            // lblIzabraniPacijent
            // 
            lblIzabraniPacijent.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblIzabraniPacijent.ForeColor = Color.FromArgb(130, 130, 130);
            lblIzabraniPacijent.Location = new Point(125, 58);
            lblIzabraniPacijent.Name = "lblIzabraniPacijent";
            lblIzabraniPacijent.Size = new Size(360, 23);
            lblIzabraniPacijent.TabIndex = 4;
            lblIzabraniPacijent.Text = "Nije izabran";
            // 
            // btnIzaberiPacijent
            // 
            btnIzaberiPacijent.Location = new Point(495, 54);
            btnIzaberiPacijent.Name = "btnIzaberiPacijent";
            btnIzaberiPacijent.Size = new Size(90, 28);
            btnIzaberiPacijent.TabIndex = 5;
            btnIzaberiPacijent.Text = "Izaberi";
            btnIzaberiPacijent.Click += btnIzaberiPacijent_Click;
            // 
            // lblDatumIVreme
            // 
            lblDatumIVreme.Location = new Point(20, 96);
            lblDatumIVreme.Name = "lblDatumIVreme";
            lblDatumIVreme.Size = new Size(130, 23);
            lblDatumIVreme.TabIndex = 6;
            lblDatumIVreme.Text = "Datum i vreme:";
            // 
            // dtpDatumIVremeZakazivanja
            // 
            dtpDatumIVremeZakazivanja.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpDatumIVremeZakazivanja.Format = DateTimePickerFormat.Custom;
            dtpDatumIVremeZakazivanja.Location = new Point(160, 93);
            dtpDatumIVremeZakazivanja.Name = "dtpDatumIVremeZakazivanja";
            dtpDatumIVremeZakazivanja.Size = new Size(220, 23);
            dtpDatumIVremeZakazivanja.TabIndex = 7;
            // 
            // lblStavke
            // 
            lblStavke.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStavke.Location = new Point(20, 133);
            lblStavke.Name = "lblStavke";
            lblStavke.Size = new Size(130, 20);
            lblStavke.TabIndex = 8;
            lblStavke.Text = "Stavke:";
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.Location = new Point(20, 156);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(130, 30);
            btnDodajStavku.TabIndex = 9;
            btnDodajStavku.Text = "Dodaj stavku";
            btnDodajStavku.Click += btnDodajStavku_Click;
            // 
            // btnUkloniStavku
            // 
            btnUkloniStavku.Location = new Point(158, 156);
            btnUkloniStavku.Name = "btnUkloniStavku";
            btnUkloniStavku.Size = new Size(120, 30);
            btnUkloniStavku.TabIndex = 10;
            btnUkloniStavku.Text = "Ukloni stavku";
            btnUkloniStavku.Click += btnUkloniStavku_Click;
            // 
            // dgvStavke
            // 
            dgvStavke.AllowUserToAddRows = false;
            dgvStavke.AllowUserToDeleteRows = false;
            dgvStavke.BackgroundColor = Color.White;
            dgvStavke.ColumnHeadersHeight = 34;
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStavke.Location = new Point(20, 193);
            dgvStavke.MultiSelect = false;
            dgvStavke.Name = "dgvStavke";
            dgvStavke.RowHeadersVisible = false;
            dgvStavke.RowTemplate.Height = 36;
            dgvStavke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStavke.Size = new Size(565, 200);
            dgvStavke.TabIndex = 11;
            dgvStavke.CellValueChanged += dgvStavke_CellValueChanged;
            dgvStavke.CurrentCellDirtyStateChanged += dgvStavke_CurrentCellDirtyStateChanged;
            // 
            // lblPopust
            // 
            lblPopust.Location = new Point(20, 405);
            lblPopust.Name = "lblPopust";
            lblPopust.Size = new Size(160, 20);
            lblPopust.TabIndex = 12;
            lblPopust.Text = "Popust: 0%";
            // 
            // lblUkupanIznos
            // 
            lblUkupanIznos.Location = new Point(190, 405);
            lblUkupanIznos.Name = "lblUkupanIznos";
            lblUkupanIznos.Size = new Size(210, 20);
            lblUkupanIznos.TabIndex = 13;
            lblUkupanIznos.Text = "Ukupan iznos: 0.00 RSD";
            // 
            // lblIznosSaPopustom
            // 
            lblIznosSaPopustom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIznosSaPopustom.Location = new Point(410, 405);
            lblIznosSaPopustom.Name = "lblIznosSaPopustom";
            lblIznosSaPopustom.Size = new Size(175, 20);
            lblIznosSaPopustom.TabIndex = 14;
            lblIznosSaPopustom.Tag = "";
            lblIznosSaPopustom.Text = "Iznos sa popustom: 0.00 RSD";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(400, 440);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(90, 32);
            btnSacuvaj.TabIndex = 15;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(400, 440);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(90, 32);
            btnIzmeni.TabIndex = 17;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(498, 440);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(90, 32);
            btnOdustani.TabIndex = 16;
            btnOdustani.Text = "Odustani";
            btnOdustani.Click += btnOdustani_Click;
            // 
            // FrmZakazivanje
            // 
            ClientSize = new Size(605, 490);
            Controls.Add(lblZaposleni);
            Controls.Add(lblIzabraniZaposleni);
            Controls.Add(btnIzaberiZaposleni);
            Controls.Add(lblPacijent);
            Controls.Add(lblIzabraniPacijent);
            Controls.Add(btnIzaberiPacijent);
            Controls.Add(lblDatumIVreme);
            Controls.Add(dtpDatumIVremeZakazivanja);
            Controls.Add(lblStavke);
            Controls.Add(btnDodajStavku);
            Controls.Add(btnUkloniStavku);
            Controls.Add(dgvStavke);
            Controls.Add(lblPopust);
            Controls.Add(lblUkupanIznos);
            Controls.Add(lblIznosSaPopustom);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnOdustani);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmZakazivanje";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zakazivanje";
            FormClosing += FrmZakazivanje_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblZaposleni;
        private Label lblIzabraniZaposleni;
        private Button btnIzaberiZaposleni;
        private Label lblPacijent;
        private Label lblIzabraniPacijent;
        private Button btnIzaberiPacijent;
        private Label lblDatumIVreme;
        public DateTimePicker dtpDatumIVremeZakazivanja;
        private Label lblStavke;
        private Button btnDodajStavku;
        private Button btnUkloniStavku;
        public DataGridView dgvStavke;
        private DataGridViewTextBoxColumn colRbStavka;
        private DataGridViewComboBoxColumn colUslugaStavka;
        private DataGridViewTextBoxColumn colCenaStavka;
        private DataGridViewTextBoxColumn colNapomenaStavka;
        private Label lblPopust;
        private Label lblUkupanIznos;
        private Label lblIznosSaPopustom;
        private Button btnSacuvaj;
        private Button btnIzmeni;
        private Button btnOdustani;
    }
}
