namespace Client.UserControls
{
    partial class PacijentUC
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlFilter = new Panel();
            lblIme = new Label();
            txtIme = new TextBox();
            lblPrezime = new Label();
            txtPrezime = new TextBox();
            lblKategorija = new Label();
            cmbKategorija = new ComboBox();
            btnPretrazi = new Button();
            dgvPacijenti = new DataGridView();
            pnlButtons = new Panel();
            btnKreiraj = new Button();
            btnPromeni = new Button();
            btnObrisi = new Button();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(lblIme);
            pnlFilter.Controls.Add(txtIme);
            pnlFilter.Controls.Add(lblPrezime);
            pnlFilter.Controls.Add(txtPrezime);
            pnlFilter.Controls.Add(lblKategorija);
            pnlFilter.Controls.Add(cmbKategorija);
            pnlFilter.Controls.Add(btnPretrazi);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 0);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(5);
            pnlFilter.Size = new Size(700, 55);
            pnlFilter.TabIndex = 1;
            // 
            // lblIme
            // 
            lblIme.Location = new Point(5, 15);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(35, 23);
            lblIme.TabIndex = 0;
            lblIme.Text = "Ime:";
            lblIme.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(43, 12);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(120, 23);
            txtIme.TabIndex = 1;
            // 
            // lblPrezime
            // 
            lblPrezime.Location = new Point(175, 15);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(60, 23);
            lblPrezime.TabIndex = 2;
            lblPrezime.Text = "Prezime:";
            lblPrezime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(238, 12);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(120, 23);
            txtPrezime.TabIndex = 3;
            // 
            // lblKategorija
            // 
            lblKategorija.Location = new Point(370, 15);
            lblKategorija.Name = "lblKategorija";
            lblKategorija.Size = new Size(75, 23);
            lblKategorija.TabIndex = 4;
            lblKategorija.Text = "Kategorija:";
            lblKategorija.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbKategorija
            // 
            cmbKategorija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategorija.Location = new Point(448, 12);
            cmbKategorija.Name = "cmbKategorija";
            cmbKategorija.Size = new Size(160, 23);
            cmbKategorija.TabIndex = 5;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(620, 11);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(90, 30);
            btnPretrazi.TabIndex = 6;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // dgvPacijenti
            // 
            dgvPacijenti.AllowUserToAddRows = false;
            dgvPacijenti.AllowUserToDeleteRows = false;
            dgvPacijenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacijenti.Dock = DockStyle.Fill;
            dgvPacijenti.Location = new Point(0, 55);
            dgvPacijenti.MultiSelect = false;
            dgvPacijenti.Name = "dgvPacijenti";
            dgvPacijenti.ReadOnly = true;
            dgvPacijenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacijenti.Size = new Size(700, 449);
            dgvPacijenti.TabIndex = 0;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnKreiraj);
            pnlButtons.Controls.Add(btnPromeni);
            pnlButtons.Controls.Add(btnObrisi);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 504);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(5);
            pnlButtons.Size = new Size(700, 50);
            pnlButtons.TabIndex = 2;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Location = new Point(5, 8);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(150, 35);
            btnKreiraj.TabIndex = 0;
            btnKreiraj.Text = "Kreiraj pacijenta";
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // btnPromeni
            // 
            btnPromeni.Location = new Point(165, 8);
            btnPromeni.Name = "btnPromeni";
            btnPromeni.Size = new Size(150, 35);
            btnPromeni.TabIndex = 1;
            btnPromeni.Text = "Promeni pacijenta";
            btnPromeni.Click += btnPromeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(325, 8);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(150, 35);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obriši pacijenta";
            btnObrisi.Click += btnObrisi_Click;
            // 
            // PacijentUC
            // 
            Controls.Add(dgvPacijenti);
            Controls.Add(pnlFilter);
            Controls.Add(pnlButtons);
            Name = "PacijentUC";
            Size = new Size(700, 554);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFilter;
        private Label lblIme;
        public TextBox txtIme;
        private Label lblPrezime;
        public TextBox txtPrezime;
        private Label lblKategorija;
        public ComboBox cmbKategorija;
        public Button btnPretrazi;
        public DataGridView dgvPacijenti;
        private Panel pnlButtons;
        public Button btnKreiraj;
        public Button btnPromeni;
        public Button btnObrisi;
    }
}
