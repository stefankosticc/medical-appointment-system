namespace Client.UserControls
{
    partial class ZakazivanjeUC
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
            dgvZakazivanja = new DataGridView();
            pnlCardFooterDiv = new Panel();
            pnlCardFooter = new Panel();
            lblStatusDot = new Label();
            lblStatus = new Label();
            pnlCardHeaderDiv = new Panel();
            pnlCardFilter = new Panel();
            btnIzaberiZaposleni = new Button();
            lblIzabraniZaposleni = new Label();
            btnIzaberiPacijent = new Button();
            lblIzabraniPacijent = new Label();
            cmbUsluga = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvZakazivanja).BeginInit();
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
            lblPageTitle.Size = new Size(183, 41);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Zakazivanja";
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.AutoSize = true;
            lblPageSubtitle.Font = new Font("Segoe UI", 9F);
            lblPageSubtitle.ForeColor = Color.FromArgb(140, 140, 140);
            lblPageSubtitle.Location = new Point(30, 50);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new Size(187, 15);
            lblPageSubtitle.TabIndex = 1;
            lblPageSubtitle.Text = "Upravljanje zakazanim pregledima";
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
            pnlCard.Controls.Add(dgvZakazivanja);
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
            // dgvZakazivanja
            // 
            dgvZakazivanja.AllowUserToAddRows = false;
            dgvZakazivanja.AllowUserToDeleteRows = false;
            dgvZakazivanja.BackgroundColor = Color.White;
            dgvZakazivanja.BorderStyle = BorderStyle.None;
            dgvZakazivanja.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvZakazivanja.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvZakazivanja.ColumnHeadersHeight = 34;
            dgvZakazivanja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvZakazivanja.Dock = DockStyle.Fill;
            dgvZakazivanja.EnableHeadersVisualStyles = false;
            dgvZakazivanja.GridColor = Color.FromArgb(238, 238, 238);
            dgvZakazivanja.Location = new Point(0, 107);
            dgvZakazivanja.MultiSelect = false;
            dgvZakazivanja.Name = "dgvZakazivanja";
            dgvZakazivanja.ReadOnly = true;
            dgvZakazivanja.RowHeadersVisible = false;
            dgvZakazivanja.RowTemplate.Height = 42;
            dgvZakazivanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZakazivanja.Size = new Size(712, 334);
            dgvZakazivanja.TabIndex = 0;
            dgvZakazivanja.CellDoubleClick += dgvZakazivanja_CellDoubleClick;
            dgvZakazivanja.CellFormatting += dgvZakazivanja_CellFormatting;
            dgvZakazivanja.SelectionChanged += dgvZakazivanja_SelectionChanged;
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
            lblStatus.Size = new Size(119, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Nijedno nije izabrano";
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
            pnlCardFilter.BackColor = Color.FromArgb(250, 250, 250);
            pnlCardFilter.Controls.Add(btnIzaberiZaposleni);
            pnlCardFilter.Controls.Add(lblIzabraniZaposleni);
            pnlCardFilter.Controls.Add(btnIzaberiPacijent);
            pnlCardFilter.Controls.Add(lblIzabraniPacijent);
            pnlCardFilter.Controls.Add(cmbUsluga);
            pnlCardFilter.Controls.Add(btnPretrazi);
            pnlCardFilter.Dock = DockStyle.Top;
            pnlCardFilter.Location = new Point(0, 54);
            pnlCardFilter.Name = "pnlCardFilter";
            pnlCardFilter.Size = new Size(712, 52);
            pnlCardFilter.TabIndex = 5;
            // 
            // btnIzaberiZaposleni
            // 
            btnIzaberiZaposleni.BackColor = Color.FromArgb(245, 245, 245);
            btnIzaberiZaposleni.Cursor = Cursors.Hand;
            btnIzaberiZaposleni.FlatAppearance.BorderColor = Color.FromArgb(210, 210, 210);
            btnIzaberiZaposleni.FlatStyle = FlatStyle.Flat;
            btnIzaberiZaposleni.Font = new Font("Segoe UI", 8.5F);
            btnIzaberiZaposleni.ForeColor = Color.FromArgb(80, 80, 80);
            btnIzaberiZaposleni.Location = new Point(16, 11);
            btnIzaberiZaposleni.Name = "btnIzaberiZaposleni";
            btnIzaberiZaposleni.Size = new Size(60, 28);
            btnIzaberiZaposleni.TabIndex = 0;
            btnIzaberiZaposleni.Text = "Izaberi";
            btnIzaberiZaposleni.UseVisualStyleBackColor = false;
            btnIzaberiZaposleni.Click += btnIzaberiZaposleni_Click;
            // 
            // lblIzabraniZaposleni
            // 
            lblIzabraniZaposleni.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblIzabraniZaposleni.ForeColor = Color.FromArgb(130, 130, 130);
            lblIzabraniZaposleni.Location = new Point(81, 11);
            lblIzabraniZaposleni.Name = "lblIzabraniZaposleni";
            lblIzabraniZaposleni.Size = new Size(115, 28);
            lblIzabraniZaposleni.TabIndex = 1;
            lblIzabraniZaposleni.Text = "Nije izabran";
            lblIzabraniZaposleni.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnIzaberiPacijent
            // 
            btnIzaberiPacijent.BackColor = Color.FromArgb(245, 245, 245);
            btnIzaberiPacijent.Cursor = Cursors.Hand;
            btnIzaberiPacijent.FlatAppearance.BorderColor = Color.FromArgb(210, 210, 210);
            btnIzaberiPacijent.FlatStyle = FlatStyle.Flat;
            btnIzaberiPacijent.Font = new Font("Segoe UI", 8.5F);
            btnIzaberiPacijent.ForeColor = Color.FromArgb(80, 80, 80);
            btnIzaberiPacijent.Location = new Point(206, 11);
            btnIzaberiPacijent.Name = "btnIzaberiPacijent";
            btnIzaberiPacijent.Size = new Size(60, 28);
            btnIzaberiPacijent.TabIndex = 2;
            btnIzaberiPacijent.Text = "Izaberi";
            btnIzaberiPacijent.UseVisualStyleBackColor = false;
            btnIzaberiPacijent.Click += btnIzaberiPacijent_Click;
            // 
            // lblIzabraniPacijent
            // 
            lblIzabraniPacijent.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblIzabraniPacijent.ForeColor = Color.FromArgb(130, 130, 130);
            lblIzabraniPacijent.Location = new Point(271, 11);
            lblIzabraniPacijent.Name = "lblIzabraniPacijent";
            lblIzabraniPacijent.Size = new Size(115, 28);
            lblIzabraniPacijent.TabIndex = 3;
            lblIzabraniPacijent.Text = "Nije izabran";
            lblIzabraniPacijent.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbUsluga
            // 
            cmbUsluga.BackColor = Color.FromArgb(245, 245, 245);
            cmbUsluga.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsluga.FlatStyle = FlatStyle.Flat;
            cmbUsluga.Font = new Font("Segoe UI", 9F);
            cmbUsluga.Location = new Point(396, 13);
            cmbUsluga.Name = "cmbUsluga";
            cmbUsluga.Size = new Size(160, 23);
            cmbUsluga.TabIndex = 4;
            // 
            // btnPretrazi
            // 
            btnPretrazi.BackColor = Color.FromArgb(36, 36, 36);
            btnPretrazi.Cursor = Cursors.Hand;
            btnPretrazi.FlatAppearance.BorderSize = 0;
            btnPretrazi.FlatStyle = FlatStyle.Flat;
            btnPretrazi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPretrazi.ForeColor = Color.White;
            btnPretrazi.Location = new Point(566, 11);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(115, 28);
            btnPretrazi.TabIndex = 5;
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
            pnlCardHeader.TabIndex = 4;
            // 
            // lblCardTitle
            // 
            lblCardTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCardTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblCardTitle.Location = new Point(16, 0);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(300, 54);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Sva zakazivanja";
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
            btnKreiraj.Size = new Size(160, 34);
            btnKreiraj.TabIndex = 0;
            btnKreiraj.Text = "Novo zakazivanje";
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
            btnPromeni.Location = new Point(192, 14);
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
            btnObrisi.Location = new Point(320, 14);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(120, 34);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // ZakazivanjeUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            Controls.Add(pnlCardOuter);
            Controls.Add(pnlPageHeader);
            Controls.Add(pnlButtons);
            Name = "ZakazivanjeUC";
            Size = new Size(760, 620);
            pnlPageHeader.ResumeLayout(false);
            pnlPageHeader.PerformLayout();
            pnlCardOuter.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvZakazivanja).EndInit();
            pnlCardFooter.ResumeLayout(false);
            pnlCardFooter.PerformLayout();
            pnlCardFilter.ResumeLayout(false);
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
        private Panel pnlCardHeaderDiv;
        private Panel pnlCardFilter;
        private Button btnIzaberiZaposleni;
        private Label lblIzabraniZaposleni;
        private Button btnIzaberiPacijent;
        private Label lblIzabraniPacijent;
        public ComboBox cmbUsluga;
        private Button btnPretrazi;
        private Panel pnlCardFooterDiv;
        private Panel pnlCardFooter;
        private Label lblStatusDot;
        private Label lblStatus;
        public DataGridView dgvZakazivanja;
        private Panel pnlButtons;
        public Button btnKreiraj;
        private Button btnPromeni;
        private Button btnObrisi;
    }
}
