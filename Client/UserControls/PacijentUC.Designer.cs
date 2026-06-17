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
            pnlHeader = new Panel();
            lblPageTitle = new Label();
            pnlHeaderDiv = new Panel();
            pnlFilter = new Panel();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            lblKategorija = new Label();
            cmbKategorija = new ComboBox();
            btnPretrazi = new Button();
            dgvPacijenti = new DataGridView();
            pnlButtons = new Panel();
            btnKreiraj = new Button();
            btnPromeni = new Button();
            btnObrisi = new Button();
            pnlHeader.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(255, 255, 255);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Controls.Add(pnlHeaderDiv);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(835, 56);
            pnlHeader.TabIndex = 3;
            //
            // lblPageTitle
            //
            lblPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(28, 28, 28);
            lblPageTitle.Location = new Point(20, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(300, 55);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Pacijenti";
            lblPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            //
            // pnlHeaderDiv
            //
            pnlHeaderDiv.BackColor = Color.FromArgb(230, 230, 230);
            pnlHeaderDiv.Dock = DockStyle.Bottom;
            pnlHeaderDiv.Name = "pnlHeaderDiv";
            pnlHeaderDiv.Size = new Size(835, 1);
            pnlHeaderDiv.TabIndex = 1;
            //
            // pnlFilter
            //
            pnlFilter.BackColor = Color.FromArgb(248, 248, 248);
            pnlFilter.Controls.Add(txtIme);
            pnlFilter.Controls.Add(txtPrezime);
            pnlFilter.Controls.Add(lblKategorija);
            pnlFilter.Controls.Add(cmbKategorija);
            pnlFilter.Controls.Add(btnPretrazi);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(835, 56);
            pnlFilter.TabIndex = 1;
            //
            // txtIme
            //
            txtIme.BackColor = Color.FromArgb(255, 255, 255);
            txtIme.BorderStyle = BorderStyle.FixedSingle;
            txtIme.Font = new Font("Segoe UI", 9.5F);
            txtIme.Location = new Point(16, 15);
            txtIme.Name = "txtIme";
            txtIme.PlaceholderText = "Ime";
            txtIme.Size = new Size(140, 26);
            txtIme.TabIndex = 0;
            //
            // txtPrezime
            //
            txtPrezime.BackColor = Color.FromArgb(255, 255, 255);
            txtPrezime.BorderStyle = BorderStyle.FixedSingle;
            txtPrezime.Font = new Font("Segoe UI", 9.5F);
            txtPrezime.Location = new Point(164, 15);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.PlaceholderText = "Prezime";
            txtPrezime.Size = new Size(140, 26);
            txtPrezime.TabIndex = 1;
            //
            // lblKategorija
            //
            lblKategorija.Font = new Font("Segoe UI", 9F);
            lblKategorija.ForeColor = Color.FromArgb(110, 110, 110);
            lblKategorija.Location = new Point(316, 17);
            lblKategorija.Name = "lblKategorija";
            lblKategorija.Size = new Size(66, 22);
            lblKategorija.TabIndex = 2;
            lblKategorija.Text = "Kategorija:";
            lblKategorija.TextAlign = ContentAlignment.MiddleLeft;
            //
            // cmbKategorija
            //
            cmbKategorija.BackColor = Color.FromArgb(255, 255, 255);
            cmbKategorija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategorija.FlatStyle = FlatStyle.Flat;
            cmbKategorija.Font = new Font("Segoe UI", 9.5F);
            cmbKategorija.Location = new Point(385, 15);
            cmbKategorija.Name = "cmbKategorija";
            cmbKategorija.Size = new Size(160, 26);
            cmbKategorija.TabIndex = 3;
            //
            // btnPretrazi
            //
            btnPretrazi.BackColor = Color.FromArgb(93, 169, 233);
            btnPretrazi.Cursor = Cursors.Hand;
            btnPretrazi.FlatAppearance.BorderSize = 0;
            btnPretrazi.FlatStyle = FlatStyle.Flat;
            btnPretrazi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnPretrazi.ForeColor = Color.FromArgb(255, 255, 255);
            btnPretrazi.Location = new Point(560, 14);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(100, 28);
            btnPretrazi.TabIndex = 4;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = false;
            btnPretrazi.Click += btnPretrazi_Click;
            //
            // dgvPacijenti
            //
            dgvPacijenti.AllowUserToAddRows = false;
            dgvPacijenti.AllowUserToDeleteRows = false;
            dgvPacijenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacijenti.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvPacijenti.BorderStyle = BorderStyle.None;
            dgvPacijenti.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(28, 28, 28),
                ForeColor = Color.FromArgb(255, 255, 255),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                SelectionBackColor = Color.FromArgb(28, 28, 28),
                SelectionForeColor = Color.FromArgb(255, 255, 255),
                Padding = new Padding(8, 0, 0, 0)
            };
            dgvPacijenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPacijenti.ColumnHeadersHeight = 36;
            dgvPacijenti.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(255, 255, 255),
                ForeColor = Color.FromArgb(47, 47, 47),
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(218, 218, 218),
                SelectionForeColor = Color.FromArgb(28, 28, 28),
                Padding = new Padding(8, 0, 0, 0)
            };
            dgvPacijenti.Dock = DockStyle.Fill;
            dgvPacijenti.EnableHeadersVisualStyles = false;
            dgvPacijenti.GridColor = Color.FromArgb(232, 232, 232);
            dgvPacijenti.MultiSelect = false;
            dgvPacijenti.Name = "dgvPacijenti";
            dgvPacijenti.ReadOnly = true;
            dgvPacijenti.RowHeadersVisible = false;
            dgvPacijenti.RowTemplate.Height = 32;
            dgvPacijenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacijenti.TabIndex = 0;
            //
            // pnlButtons
            //
            pnlButtons.BackColor = Color.FromArgb(255, 255, 255);
            pnlButtons.Controls.Add(btnKreiraj);
            pnlButtons.Controls.Add(btnPromeni);
            pnlButtons.Controls.Add(btnObrisi);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(835, 58);
            pnlButtons.TabIndex = 2;
            //
            // btnKreiraj
            //
            btnKreiraj.BackColor = Color.FromArgb(93, 169, 233);
            btnKreiraj.Cursor = Cursors.Hand;
            btnKreiraj.FlatAppearance.BorderSize = 0;
            btnKreiraj.FlatStyle = FlatStyle.Flat;
            btnKreiraj.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnKreiraj.ForeColor = Color.FromArgb(255, 255, 255);
            btnKreiraj.Location = new Point(16, 12);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(148, 34);
            btnKreiraj.TabIndex = 0;
            btnKreiraj.Text = "Novi pacijent";
            btnKreiraj.UseVisualStyleBackColor = false;
            btnKreiraj.Click += btnKreiraj_Click;
            //
            // btnPromeni
            //
            btnPromeni.BackColor = Color.FromArgb(255, 255, 255);
            btnPromeni.Cursor = Cursors.Hand;
            btnPromeni.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnPromeni.FlatAppearance.BorderSize = 1;
            btnPromeni.FlatStyle = FlatStyle.Flat;
            btnPromeni.Font = new Font("Segoe UI", 9.5F);
            btnPromeni.ForeColor = Color.FromArgb(60, 60, 60);
            btnPromeni.Location = new Point(172, 12);
            btnPromeni.Name = "btnPromeni";
            btnPromeni.Size = new Size(148, 34);
            btnPromeni.TabIndex = 1;
            btnPromeni.Text = "Izmeni";
            btnPromeni.UseVisualStyleBackColor = false;
            btnPromeni.Click += btnPromeni_Click;
            //
            // btnObrisi
            //
            btnObrisi.BackColor = Color.FromArgb(255, 255, 255);
            btnObrisi.Cursor = Cursors.Hand;
            btnObrisi.FlatAppearance.BorderColor = Color.FromArgb(214, 34, 70);
            btnObrisi.FlatAppearance.BorderSize = 1;
            btnObrisi.FlatStyle = FlatStyle.Flat;
            btnObrisi.Font = new Font("Segoe UI", 9.5F);
            btnObrisi.ForeColor = Color.FromArgb(214, 34, 70);
            btnObrisi.Location = new Point(328, 12);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(148, 34);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            //
            // PacijentUC
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            Controls.Add(dgvPacijenti);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Controls.Add(pnlButtons);
            Name = "PacijentUC";
            Size = new Size(835, 620);
            pnlHeader.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblPageTitle;
        private Panel pnlHeaderDiv;
        private Panel pnlFilter;
        public TextBox txtIme;
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
