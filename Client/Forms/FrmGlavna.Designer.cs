namespace Client.Forms
{
    partial class FrmGlavna
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
            pnlSidebar = new Panel();
            pnlSidebarHeader = new Panel();
            pnlLogoBox = new Panel();
            picSidebarLogo = new PictureBox();
            lblSidebarTitle = new Label();
            pnlSidebarDivider = new Panel();
            lblEvidencija = new Label();
            btnPacijenti = new Button();
            btnZakazivanja = new Button();
            lblAdministracija = new Label();
            btnZaposleni = new Button();
            btnUsluge = new Button();
            btnOdeljenja = new Button();
            pnlUserFooter = new Panel();
            pnlAvatar = new Panel();
            lblAvatar = new Label();
            lblUsername = new Label();
            panelContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlSidebarHeader.SuspendLayout();
            pnlLogoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSidebarLogo).BeginInit();
            pnlUserFooter.SuspendLayout();
            pnlAvatar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(22, 22, 22);
            pnlSidebar.Controls.Add(pnlSidebarHeader);
            pnlSidebar.Controls.Add(pnlSidebarDivider);
            pnlSidebar.Controls.Add(lblEvidencija);
            pnlSidebar.Controls.Add(btnPacijenti);
            pnlSidebar.Controls.Add(btnZakazivanja);
            pnlSidebar.Controls.Add(lblAdministracija);
            pnlSidebar.Controls.Add(btnZaposleni);
            pnlSidebar.Controls.Add(btnUsluge);
            pnlSidebar.Controls.Add(btnOdeljenja);
            pnlSidebar.Controls.Add(pnlUserFooter);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(260, 620);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlSidebarHeader
            // 
            pnlSidebarHeader.BackColor = Color.FromArgb(22, 22, 22);
            pnlSidebarHeader.Controls.Add(pnlLogoBox);
            pnlSidebarHeader.Controls.Add(lblSidebarTitle);
            pnlSidebarHeader.Location = new Point(0, 0);
            pnlSidebarHeader.Name = "pnlSidebarHeader";
            pnlSidebarHeader.Size = new Size(260, 80);
            pnlSidebarHeader.TabIndex = 0;
            // 
            // pnlLogoBox
            // 
            pnlLogoBox.BackColor = Color.FromArgb(22, 22, 22);
            pnlLogoBox.Controls.Add(picSidebarLogo);
            pnlLogoBox.Location = new Point(16, 16);
            pnlLogoBox.Name = "pnlLogoBox";
            pnlLogoBox.Size = new Size(48, 48);
            pnlLogoBox.TabIndex = 0;
            // 
            // picSidebarLogo
            // 
            picSidebarLogo.Image = Properties.Resources.x_rays_red;
            picSidebarLogo.Location = new Point(0, 0);
            picSidebarLogo.Name = "picSidebarLogo";
            picSidebarLogo.Size = new Size(48, 48);
            picSidebarLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picSidebarLogo.TabIndex = 0;
            picSidebarLogo.TabStop = false;
            // 
            // lblSidebarTitle
            // 
            lblSidebarTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSidebarTitle.ForeColor = Color.FromArgb(255, 255, 255);
            lblSidebarTitle.Location = new Point(74, 29);
            lblSidebarTitle.Name = "lblSidebarTitle";
            lblSidebarTitle.Size = new Size(170, 22);
            lblSidebarTitle.TabIndex = 1;
            lblSidebarTitle.Text = "MAS";
            // 
            // pnlSidebarDivider
            // 
            pnlSidebarDivider.BackColor = Color.FromArgb(40, 40, 40);
            pnlSidebarDivider.Location = new Point(0, 80);
            pnlSidebarDivider.Name = "pnlSidebarDivider";
            pnlSidebarDivider.Size = new Size(260, 1);
            pnlSidebarDivider.TabIndex = 1;
            // 
            // lblEvidencija
            // 
            lblEvidencija.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblEvidencija.ForeColor = Color.FromArgb(100, 100, 100);
            lblEvidencija.Location = new Point(16, 100);
            lblEvidencija.Name = "lblEvidencija";
            lblEvidencija.Size = new Size(228, 16);
            lblEvidencija.TabIndex = 2;
            lblEvidencija.Text = "EVIDENCIJA";
            // 
            // btnPacijenti
            // 
            btnPacijenti.BackColor = Color.FromArgb(22, 22, 22);
            btnPacijenti.Cursor = Cursors.Hand;
            btnPacijenti.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnPacijenti.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 46, 46);
            btnPacijenti.FlatStyle = FlatStyle.Flat;
            btnPacijenti.Font = new Font("Segoe UI", 9.5F);
            btnPacijenti.ForeColor = Color.FromArgb(220, 220, 220);
            btnPacijenti.Location = new Point(12, 122);
            btnPacijenti.Name = "btnPacijenti";
            btnPacijenti.Padding = new Padding(14, 0, 0, 0);
            btnPacijenti.Size = new Size(236, 42);
            btnPacijenti.TabIndex = 3;
            btnPacijenti.Text = "Pacijenti";
            btnPacijenti.TextAlign = ContentAlignment.MiddleLeft;
            btnPacijenti.UseVisualStyleBackColor = false;
            btnPacijenti.Click += btnPacijenti_Click;
            // 
            // btnZakazivanja
            // 
            btnZakazivanja.BackColor = Color.FromArgb(22, 22, 22);
            btnZakazivanja.Cursor = Cursors.Hand;
            btnZakazivanja.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnZakazivanja.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 46, 46);
            btnZakazivanja.FlatStyle = FlatStyle.Flat;
            btnZakazivanja.Font = new Font("Segoe UI", 9.5F);
            btnZakazivanja.ForeColor = Color.FromArgb(220, 220, 220);
            btnZakazivanja.Location = new Point(12, 170);
            btnZakazivanja.Name = "btnZakazivanja";
            btnZakazivanja.Padding = new Padding(14, 0, 0, 0);
            btnZakazivanja.Size = new Size(236, 42);
            btnZakazivanja.TabIndex = 4;
            btnZakazivanja.Text = "Zakazivanja";
            btnZakazivanja.TextAlign = ContentAlignment.MiddleLeft;
            btnZakazivanja.UseVisualStyleBackColor = false;
            // 
            // lblAdministracija
            // 
            lblAdministracija.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblAdministracija.ForeColor = Color.FromArgb(100, 100, 100);
            lblAdministracija.Location = new Point(16, 228);
            lblAdministracija.Name = "lblAdministracija";
            lblAdministracija.Size = new Size(228, 16);
            lblAdministracija.TabIndex = 5;
            lblAdministracija.Text = "ADMINISTRACIJA";
            // 
            // btnZaposleni
            // 
            btnZaposleni.BackColor = Color.FromArgb(22, 22, 22);
            btnZaposleni.Cursor = Cursors.Hand;
            btnZaposleni.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnZaposleni.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 46, 46);
            btnZaposleni.FlatStyle = FlatStyle.Flat;
            btnZaposleni.Font = new Font("Segoe UI", 9.5F);
            btnZaposleni.ForeColor = Color.FromArgb(220, 220, 220);
            btnZaposleni.Location = new Point(12, 250);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Padding = new Padding(14, 0, 0, 0);
            btnZaposleni.Size = new Size(236, 42);
            btnZaposleni.TabIndex = 6;
            btnZaposleni.Text = "Zaposleni";
            btnZaposleni.TextAlign = ContentAlignment.MiddleLeft;
            btnZaposleni.UseVisualStyleBackColor = false;
            // 
            // btnUsluge
            // 
            btnUsluge.BackColor = Color.FromArgb(22, 22, 22);
            btnUsluge.Cursor = Cursors.Hand;
            btnUsluge.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnUsluge.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 46, 46);
            btnUsluge.FlatStyle = FlatStyle.Flat;
            btnUsluge.Font = new Font("Segoe UI", 9.5F);
            btnUsluge.ForeColor = Color.FromArgb(220, 220, 220);
            btnUsluge.Location = new Point(12, 298);
            btnUsluge.Name = "btnUsluge";
            btnUsluge.Padding = new Padding(14, 0, 0, 0);
            btnUsluge.Size = new Size(236, 42);
            btnUsluge.TabIndex = 7;
            btnUsluge.Text = "Usluge";
            btnUsluge.TextAlign = ContentAlignment.MiddleLeft;
            btnUsluge.UseVisualStyleBackColor = false;
            btnUsluge.Click += btnUsluge_Click;
            // 
            // btnOdeljenja
            // 
            btnOdeljenja.BackColor = Color.FromArgb(22, 22, 22);
            btnOdeljenja.Cursor = Cursors.Hand;
            btnOdeljenja.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnOdeljenja.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 46, 46);
            btnOdeljenja.FlatStyle = FlatStyle.Flat;
            btnOdeljenja.Font = new Font("Segoe UI", 9.5F);
            btnOdeljenja.ForeColor = Color.FromArgb(220, 220, 220);
            btnOdeljenja.Location = new Point(12, 346);
            btnOdeljenja.Name = "btnOdeljenja";
            btnOdeljenja.Padding = new Padding(14, 0, 0, 0);
            btnOdeljenja.Size = new Size(236, 42);
            btnOdeljenja.TabIndex = 8;
            btnOdeljenja.Text = "Odeljenja";
            btnOdeljenja.TextAlign = ContentAlignment.MiddleLeft;
            btnOdeljenja.UseVisualStyleBackColor = false;
            // 
            // pnlUserFooter
            // 
            pnlUserFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlUserFooter.BackColor = Color.FromArgb(16, 16, 16);
            pnlUserFooter.Controls.Add(pnlAvatar);
            pnlUserFooter.Controls.Add(lblUsername);
            pnlUserFooter.Location = new Point(0, 560);
            pnlUserFooter.Name = "pnlUserFooter";
            pnlUserFooter.Size = new Size(260, 60);
            pnlUserFooter.TabIndex = 9;
            // 
            // pnlAvatar
            // 
            pnlAvatar.BackColor = Color.FromArgb(214, 34, 70);
            pnlAvatar.Controls.Add(lblAvatar);
            pnlAvatar.Location = new Point(16, 14);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.Size = new Size(32, 32);
            pnlAvatar.TabIndex = 0;
            // 
            // lblAvatar
            // 
            lblAvatar.Dock = DockStyle.Fill;
            lblAvatar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAvatar.ForeColor = Color.White;
            lblAvatar.Location = new Point(0, 0);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(32, 32);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "AD";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 9.5F);
            lblUsername.ForeColor = Color.FromArgb(200, 200, 200);
            lblUsername.Location = new Point(56, 14);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(190, 32);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Administrator";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(242, 242, 242);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(260, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(760, 620);
            panelContent.TabIndex = 1;
            // 
            // FrmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1020, 620);
            Controls.Add(panelContent);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(800, 500);
            Name = "FrmGlavna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicinski sistem";
            pnlSidebar.ResumeLayout(false);
            pnlSidebarHeader.ResumeLayout(false);
            pnlLogoBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSidebarLogo).EndInit();
            pnlUserFooter.ResumeLayout(false);
            pnlAvatar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlSidebarHeader;
        private Panel pnlLogoBox;
        private PictureBox picSidebarLogo;
        private Label lblSidebarTitle;
        private Panel pnlSidebarDivider;
        private Label lblEvidencija;
        private Button btnPacijenti;
        private Button btnZakazivanja;
        private Label lblAdministracija;
        private Button btnZaposleni;
        private Button btnUsluge;
        private Button btnOdeljenja;
        private Panel pnlUserFooter;
        private Panel pnlAvatar;
        private Label lblAvatar;
        private Label lblUsername;
        private Panel panelContent;
    }
}
