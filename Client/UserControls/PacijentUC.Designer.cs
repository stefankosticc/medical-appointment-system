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
            pnlPageHeader = new Panel();
            lblPageTitle = new Label();
            lblPageSubtitle = new Label();
            pnlCardOuter = new Panel();
            pnlCard = new Panel();
            dgvPacijenti = new DataGridView();
            pnlCardFooterDiv = new Panel();
            pnlCardFooter = new Panel();
            lblStatusDot = new Label();
            lblStatus = new Label();
            pnlCardHeaderDiv = new Panel();
            pnlCardFilter = new Panel();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            cmbKategorija = new ComboBox();
            dtpDatumRodjenja = new DateTimePicker();
            btnPretrazi = new Button();
            pnlCardHeader = new Panel();
            lblCardTitle = new Label();
            pnlButtons = new Panel();
            btnKreiraj = new Button();
            btnPromeni = new Button();
            btnObrisi = new Button();
            pnlPageHeader.SuspendLayout();
            pnlCardOuter.SuspendLayout();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).BeginInit();
            pnlCardFooter.SuspendLayout();
            pnlCardFilter.SuspendLayout();
            pnlCardHeader.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPageHeader
            // 
            pnlPageHeader.BackColor = Color.FromArgb(242, 242, 242);
            pnlPageHeader.Controls.Add(lblPageTitle);
            pnlPageHeader.Controls.Add(lblPageSubtitle);
            pnlPageHeader.Dock = DockStyle.Top;
            pnlPageHeader.Location = new Point(0, 0);
            pnlPageHeader.Name = "pnlPageHeader";
            pnlPageHeader.Size = new Size(760, 74);
            pnlPageHeader.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(18, 18, 18);
            lblPageTitle.Location = new Point(24, 10);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(138, 41);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Pacijenti";
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.AutoSize = true;
            lblPageSubtitle.Font = new Font("Segoe UI", 9F);
            lblPageSubtitle.ForeColor = Color.FromArgb(140, 140, 140);
            lblPageSubtitle.Location = new Point(29, 50);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new Size(179, 15);
            lblPageSubtitle.TabIndex = 1;
            lblPageSubtitle.Text = "Pregled i upravljanje pacijentima";
            // 
            // pnlCardOuter
            // 
            pnlCardOuter.BackColor = Color.FromArgb(242, 242, 242);
            pnlCardOuter.Controls.Add(pnlCard);
            pnlCardOuter.Dock = DockStyle.Fill;
            pnlCardOuter.Location = new Point(0, 74);
            pnlCardOuter.Name = "pnlCardOuter";
            pnlCardOuter.Padding = new Padding(24, 0, 24, 8);
            pnlCardOuter.Size = new Size(760, 486);
            pnlCardOuter.TabIndex = 1;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(dgvPacijenti);
            pnlCard.Controls.Add(pnlCardFooterDiv);
            pnlCard.Controls.Add(pnlCardFooter);
            pnlCard.Controls.Add(pnlCardHeaderDiv);
            pnlCard.Controls.Add(pnlCardFilter);
            pnlCard.Controls.Add(pnlCardHeader);
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.Location = new Point(24, 0);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(712, 478);
            pnlCard.TabIndex = 0;
            // 
            // dgvPacijenti
            // 
            dgvPacijenti.AllowUserToAddRows = false;
            dgvPacijenti.AllowUserToDeleteRows = false;
            dgvPacijenti.BackgroundColor = Color.White;
            dgvPacijenti.BorderStyle = BorderStyle.None;
            dgvPacijenti.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPacijenti.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPacijenti.ColumnHeadersHeight = 34;
            dgvPacijenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPacijenti.Dock = DockStyle.Fill;
            dgvPacijenti.EnableHeadersVisualStyles = false;
            dgvPacijenti.GridColor = Color.FromArgb(238, 238, 238);
            dgvPacijenti.Location = new Point(0, 107);
            dgvPacijenti.MultiSelect = false;
            dgvPacijenti.Name = "dgvPacijenti";
            dgvPacijenti.ReadOnly = true;
            dgvPacijenti.RowHeadersVisible = false;
            dgvPacijenti.RowTemplate.Height = 42;
            dgvPacijenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacijenti.Size = new Size(712, 334);
            dgvPacijenti.TabIndex = 0;
            dgvPacijenti.CellFormatting += dgvPacijenti_CellFormatting;
            dgvPacijenti.SelectionChanged += dgvPacijenti_SelectionChanged;
            // 
            // pnlCardFooterDiv
            // 
            pnlCardFooterDiv.BackColor = Color.FromArgb(235, 235, 235);
            pnlCardFooterDiv.Dock = DockStyle.Bottom;
            pnlCardFooterDiv.Location = new Point(0, 441);
            pnlCardFooterDiv.Name = "pnlCardFooterDiv";
            pnlCardFooterDiv.Size = new Size(712, 1);
            pnlCardFooterDiv.TabIndex = 1;
            // 
            // pnlCardFooter
            // 
            pnlCardFooter.BackColor = Color.White;
            pnlCardFooter.Controls.Add(lblStatusDot);
            pnlCardFooter.Controls.Add(lblStatus);
            pnlCardFooter.Dock = DockStyle.Bottom;
            pnlCardFooter.Location = new Point(0, 442);
            pnlCardFooter.Name = "pnlCardFooter";
            pnlCardFooter.Size = new Size(712, 36);
            pnlCardFooter.TabIndex = 2;
            // 
            // lblStatusDot
            // 
            lblStatusDot.AutoSize = true;
            lblStatusDot.Font = new Font("Segoe UI", 9F);
            lblStatusDot.ForeColor = Color.FromArgb(214, 34, 70);
            lblStatusDot.Location = new Point(16, 10);
            lblStatusDot.Name = "lblStatusDot";
            lblStatusDot.Size = new Size(14, 15);
            lblStatusDot.TabIndex = 0;
            lblStatusDot.Text = "●";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.FromArgb(130, 130, 130);
            lblStatus.Location = new Point(32, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(111, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Nijedan nije izabran";
            // 
            // pnlCardHeaderDiv
            // 
            pnlCardHeaderDiv.BackColor = Color.FromArgb(235, 235, 235);
            pnlCardHeaderDiv.Dock = DockStyle.Top;
            pnlCardHeaderDiv.Location = new Point(0, 106);
            pnlCardHeaderDiv.Name = "pnlCardHeaderDiv";
            pnlCardHeaderDiv.Size = new Size(712, 1);
            pnlCardHeaderDiv.TabIndex = 3;
            // 
            // pnlCardFilter
            // 
            pnlCardFilter.BackColor = Color.White;
            pnlCardFilter.Controls.Add(txtIme);
            pnlCardFilter.Controls.Add(txtPrezime);
            pnlCardFilter.Controls.Add(dtpDatumRodjenja);
            pnlCardFilter.Controls.Add(cmbKategorija);
            pnlCardFilter.Controls.Add(btnPretrazi);
            pnlCardFilter.Dock = DockStyle.Top;
            pnlCardFilter.Location = new Point(0, 54);
            pnlCardFilter.Name = "pnlCardFilter";
            pnlCardFilter.Size = new Size(712, 52);
            pnlCardFilter.TabIndex = 4;
            // 
            // txtIme
            // 
            txtIme.BackColor = Color.FromArgb(245, 245, 245);
            txtIme.BorderStyle = BorderStyle.FixedSingle;
            txtIme.Font = new Font("Segoe UI", 9.5F);
            txtIme.Location = new Point(16, 13);
            txtIme.Name = "txtIme";
            txtIme.PlaceholderText = "Ime";
            txtIme.Size = new Size(120, 24);
            txtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            txtPrezime.BackColor = Color.FromArgb(245, 245, 245);
            txtPrezime.BorderStyle = BorderStyle.FixedSingle;
            txtPrezime.Font = new Font("Segoe UI", 9.5F);
            txtPrezime.Location = new Point(144, 13);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.PlaceholderText = "Prezime";
            txtPrezime.Size = new Size(120, 24);
            txtPrezime.TabIndex = 1;
            // 
            // cmbKategorija
            // 
            cmbKategorija.BackColor = Color.FromArgb(245, 245, 245);
            cmbKategorija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategorija.FlatStyle = FlatStyle.Flat;
            cmbKategorija.Font = new Font("Segoe UI", 9.5F);
            cmbKategorija.Location = new Point(430, 13);
            cmbKategorija.Name = "cmbKategorija";
            cmbKategorija.Size = new Size(150, 25);
            cmbKategorija.TabIndex = 3;
            //
            // dtpDatumRodjenja
            //
            dtpDatumRodjenja.CustomFormat = "dd.MM.yyyy";
            dtpDatumRodjenja.Format = DateTimePickerFormat.Custom;
            dtpDatumRodjenja.Font = new Font("Segoe UI", 9.5F);
            dtpDatumRodjenja.Location = new Point(272, 13);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.ShowCheckBox = true;
            dtpDatumRodjenja.Checked = false;
            dtpDatumRodjenja.Size = new Size(150, 24);
            dtpDatumRodjenja.TabIndex = 2;
            //
            // btnPretrazi
            //
            btnPretrazi.BackColor = Color.FromArgb(36, 36, 36);
            btnPretrazi.Cursor = Cursors.Hand;
            btnPretrazi.FlatAppearance.BorderSize = 0;
            btnPretrazi.FlatStyle = FlatStyle.Flat;
            btnPretrazi.Font = new Font("Segoe UI", 9F);
            btnPretrazi.ForeColor = Color.White;
            btnPretrazi.Location = new Point(588, 13);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(90, 26);
            btnPretrazi.TabIndex = 4;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = false;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // pnlCardHeader
            // 
            pnlCardHeader.BackColor = Color.White;
            pnlCardHeader.Controls.Add(lblCardTitle);
            pnlCardHeader.Dock = DockStyle.Top;
            pnlCardHeader.Location = new Point(0, 0);
            pnlCardHeader.Name = "pnlCardHeader";
            pnlCardHeader.Size = new Size(712, 54);
            pnlCardHeader.TabIndex = 5;
            // 
            // lblCardTitle
            // 
            lblCardTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCardTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblCardTitle.Location = new Point(16, 0);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(300, 54);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Svi pacijenti";
            lblCardTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(242, 242, 242);
            pnlButtons.Controls.Add(btnKreiraj);
            pnlButtons.Controls.Add(btnPromeni);
            pnlButtons.Controls.Add(btnObrisi);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 560);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(760, 60);
            pnlButtons.TabIndex = 2;
            // 
            // btnKreiraj
            // 
            btnKreiraj.BackColor = Color.FromArgb(93, 169, 233);
            btnKreiraj.Cursor = Cursors.Hand;
            btnKreiraj.FlatAppearance.BorderSize = 0;
            btnKreiraj.FlatStyle = FlatStyle.Flat;
            btnKreiraj.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnKreiraj.ForeColor = Color.White;
            btnKreiraj.Location = new Point(24, 14);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(140, 34);
            btnKreiraj.TabIndex = 0;
            btnKreiraj.Text = "Novi pacijent";
            btnKreiraj.UseVisualStyleBackColor = false;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // btnPromeni
            // 
            btnPromeni.BackColor = Color.FromArgb(242, 242, 242);
            btnPromeni.Cursor = Cursors.Hand;
            btnPromeni.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnPromeni.FlatStyle = FlatStyle.Flat;
            btnPromeni.Font = new Font("Segoe UI", 9.5F);
            btnPromeni.ForeColor = Color.FromArgb(30, 30, 30);
            btnPromeni.Location = new Point(172, 14);
            btnPromeni.Name = "btnPromeni";
            btnPromeni.Size = new Size(120, 34);
            btnPromeni.TabIndex = 1;
            btnPromeni.Text = "Izmeni";
            btnPromeni.UseVisualStyleBackColor = false;
            btnPromeni.Click += btnPromeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.FromArgb(242, 242, 242);
            btnObrisi.Cursor = Cursors.Hand;
            btnObrisi.FlatAppearance.BorderColor = Color.FromArgb(214, 34, 70);
            btnObrisi.FlatStyle = FlatStyle.Flat;
            btnObrisi.Font = new Font("Segoe UI", 9.5F);
            btnObrisi.ForeColor = Color.FromArgb(214, 34, 70);
            btnObrisi.Location = new Point(300, 14);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(120, 34);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // PacijentUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            Controls.Add(pnlCardOuter);
            Controls.Add(pnlPageHeader);
            Controls.Add(pnlButtons);
            Name = "PacijentUC";
            Size = new Size(760, 620);
            pnlPageHeader.ResumeLayout(false);
            pnlPageHeader.PerformLayout();
            pnlCardOuter.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).EndInit();
            pnlCardFooter.ResumeLayout(false);
            pnlCardFooter.PerformLayout();
            pnlCardFilter.ResumeLayout(false);
            pnlCardFilter.PerformLayout();
            pnlCardHeader.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPageHeader;
        private Label lblPageTitle;
        private Label lblPageSubtitle;
        private Panel pnlCardOuter;
        private Panel pnlCard;
        private Panel pnlCardHeader;
        private Label lblCardTitle;
        private Panel pnlCardFilter;
        public TextBox txtIme;
        public TextBox txtPrezime;
        private Label lblKategorija;
        public ComboBox cmbKategorija;
        public DateTimePicker dtpDatumRodjenja;
        public Button btnPretrazi;
        private Panel pnlCardHeaderDiv;
        private Panel pnlCardFooterDiv;
        private Panel pnlCardFooter;
        private Label lblStatusDot;
        private Label lblStatus;
        public DataGridView dgvPacijenti;
        private Panel pnlButtons;
        public Button btnKreiraj;
        public Button btnPromeni;
        public Button btnObrisi;
    }
}
