namespace Client.UserControls
{
    partial class UslugaUC
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
            dgvUsluge = new DataGridView();
            pnlCardFooterDiv = new Panel();
            pnlCardFooter = new Panel();
            lblStatusDot = new Label();
            lblStatus = new Label();
            pnlCardHeaderDiv = new Panel();
            pnlCardHeader = new Panel();
            lblCardTitle = new Label();
            pnlButtons = new Panel();
            btnUbaci = new Button();
            btnPromeni = new Button();
            btnObrisi = new Button();
            pnlPageHeader.SuspendLayout();
            pnlCardOuter.SuspendLayout();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsluge).BeginInit();
            pnlCardFooter.SuspendLayout();
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
            lblPageTitle.Size = new Size(115, 41);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Usluge";
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.AutoSize = true;
            lblPageSubtitle.Font = new Font("Segoe UI", 9F);
            lblPageSubtitle.ForeColor = Color.FromArgb(140, 140, 140);
            lblPageSubtitle.Location = new Point(32, 50);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new Size(243, 15);
            lblPageSubtitle.TabIndex = 1;
            lblPageSubtitle.Text = "Upravljanje medicinskim uslugama i cenama";
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
            pnlCard.Controls.Add(dgvUsluge);
            pnlCard.Controls.Add(pnlCardFooterDiv);
            pnlCard.Controls.Add(pnlCardFooter);
            pnlCard.Controls.Add(pnlCardHeaderDiv);
            pnlCard.Controls.Add(pnlCardHeader);
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.Location = new Point(24, 0);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(712, 478);
            pnlCard.TabIndex = 0;
            // 
            // dgvUsluge
            // 
            dgvUsluge.AllowUserToAddRows = false;
            dgvUsluge.AllowUserToDeleteRows = false;
            dgvUsluge.AutoGenerateColumns = false;
            dgvUsluge.BackgroundColor = Color.White;
            dgvUsluge.BorderStyle = BorderStyle.None;
            dgvUsluge.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsluge.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsluge.ColumnHeadersHeight = 34;
            dgvUsluge.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsluge.Dock = DockStyle.Fill;
            dgvUsluge.EnableHeadersVisualStyles = false;
            dgvUsluge.GridColor = Color.FromArgb(238, 238, 238);
            dgvUsluge.Location = new Point(0, 55);
            dgvUsluge.MultiSelect = false;
            dgvUsluge.Name = "dgvUsluge";
            dgvUsluge.ReadOnly = true;
            dgvUsluge.RowHeadersVisible = false;
            dgvUsluge.RowTemplate.Height = 42;
            dgvUsluge.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsluge.Size = new Size(712, 386);
            dgvUsluge.TabIndex = 0;
            dgvUsluge.CellFormatting += dgvUsluge_CellFormatting;
            dgvUsluge.SelectionChanged += dgvUsluge_SelectionChanged;
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
            lblStatus.Size = new Size(117, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Nijedna nije izabrana";
            // 
            // pnlCardHeaderDiv
            // 
            pnlCardHeaderDiv.BackColor = Color.FromArgb(235, 235, 235);
            pnlCardHeaderDiv.Dock = DockStyle.Top;
            pnlCardHeaderDiv.Location = new Point(0, 54);
            pnlCardHeaderDiv.Name = "pnlCardHeaderDiv";
            pnlCardHeaderDiv.Size = new Size(712, 1);
            pnlCardHeaderDiv.TabIndex = 3;
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
            lblCardTitle.Text = "Sve usluge";
            lblCardTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(242, 242, 242);
            pnlButtons.Controls.Add(btnUbaci);
            pnlButtons.Controls.Add(btnPromeni);
            pnlButtons.Controls.Add(btnObrisi);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 560);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(760, 60);
            pnlButtons.TabIndex = 2;
            // 
            // btnUbaci
            // 
            btnUbaci.BackColor = Color.FromArgb(214, 34, 70);
            btnUbaci.Cursor = Cursors.Hand;
            btnUbaci.FlatAppearance.BorderSize = 0;
            btnUbaci.FlatStyle = FlatStyle.Flat;
            btnUbaci.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUbaci.ForeColor = Color.White;
            btnUbaci.Location = new Point(24, 14);
            btnUbaci.Name = "btnUbaci";
            btnUbaci.Size = new Size(140, 34);
            btnUbaci.TabIndex = 0;
            btnUbaci.Text = "Nova usluga";
            btnUbaci.UseVisualStyleBackColor = false;
            btnUbaci.Click += btnUbaci_Click;
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
            // UslugaUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            Controls.Add(pnlCardOuter);
            Controls.Add(pnlPageHeader);
            Controls.Add(pnlButtons);
            Name = "UslugaUC";
            Size = new Size(760, 620);
            pnlPageHeader.ResumeLayout(false);
            pnlPageHeader.PerformLayout();
            pnlCardOuter.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsluge).EndInit();
            pnlCardFooter.ResumeLayout(false);
            pnlCardFooter.PerformLayout();
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
        private Panel pnlCardFooterDiv;
        private Panel pnlCardFooter;
        private Label lblStatusDot;
        private Label lblStatus;
        public DataGridView dgvUsluge;
        private DataGridViewTextBoxColumn colRb;
        private DataGridViewTextBoxColumn colNaziv;
        private DataGridViewTextBoxColumn colCena;
        private Panel pnlButtons;
        public Button btnUbaci;
        public Button btnPromeni;
        public Button btnObrisi;
    }
}
