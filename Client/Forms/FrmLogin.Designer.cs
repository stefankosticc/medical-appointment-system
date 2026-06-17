namespace Client.Forms
{
    partial class FrmLogin
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
            pnlLeft = new Panel();
            picLogo = new PictureBox();
            lblAppName = new Label();
            lblTagline = new Label();
            pnlRight = new Panel();
            pnlAccentRight = new Panel();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            lblEmail = new Label();
            textBoxEmail = new TextBox();
            lblLozinka = new Label();
            textBoxLozinka = new TextBox();
            btnLogin = new Button();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(214, 34, 70);
            pnlLeft.Controls.Add(picLogo);
            pnlLeft.Controls.Add(lblAppName);
            pnlLeft.Controls.Add(lblTagline);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(271, 440);
            pnlLeft.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.x_rays_red;
            picLogo.Location = new Point(75, 100);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(120, 110);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblAppName.ForeColor = Color.FromArgb(255, 255, 251);
            lblAppName.Location = new Point(9, 228);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(254, 36);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Medicinski Sistem";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTagline
            // 
            lblTagline.Font = new Font("Segoe UI", 9F);
            lblTagline.ForeColor = Color.FromArgb(255, 180, 195);
            lblTagline.Location = new Point(18, 270);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(236, 22);
            lblTagline.TabIndex = 2;
            lblTagline.Text = "Sistem za zakazivanje pregleda";
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(255, 255, 251);
            pnlRight.Controls.Add(pnlAccentRight);
            pnlRight.Controls.Add(lblWelcome);
            pnlRight.Controls.Add(lblSubtitle);
            pnlRight.Controls.Add(lblEmail);
            pnlRight.Controls.Add(textBoxEmail);
            pnlRight.Controls.Add(lblLozinka);
            pnlRight.Controls.Add(textBoxLozinka);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Location = new Point(271, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(411, 440);
            pnlRight.TabIndex = 1;
            // 
            // pnlAccentRight
            // 
            pnlAccentRight.BackColor = Color.FromArgb(214, 34, 70);
            pnlAccentRight.Dock = DockStyle.Top;
            pnlAccentRight.Location = new Point(0, 0);
            pnlAccentRight.Name = "pnlAccentRight";
            pnlAccentRight.Size = new Size(411, 5);
            pnlAccentRight.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(47, 47, 47);
            lblWelcome.Location = new Point(48, 62);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(315, 42);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Dobrodošli!";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(150, 150, 150);
            lblSubtitle.Location = new Point(48, 107);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(315, 20);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Prijavite se na vaš nalog";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(80, 80, 80);
            lblEmail.Location = new Point(48, 158);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(112, 17);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "KORISNIČKO IME";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(245, 245, 245);
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Segoe UI", 10.5F);
            textBoxEmail.Location = new Point(48, 180);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(315, 26);
            textBoxEmail.TabIndex = 2;
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize = true;
            lblLozinka.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLozinka.ForeColor = Color.FromArgb(80, 80, 80);
            lblLozinka.Location = new Point(48, 224);
            lblLozinka.Name = "lblLozinka";
            lblLozinka.Size = new Size(64, 17);
            lblLozinka.TabIndex = 3;
            lblLozinka.Text = "LOZINKA";
            // 
            // textBoxLozinka
            // 
            textBoxLozinka.BackColor = Color.FromArgb(245, 245, 245);
            textBoxLozinka.BorderStyle = BorderStyle.FixedSingle;
            textBoxLozinka.Font = new Font("Segoe UI", 10.5F);
            textBoxLozinka.Location = new Point(48, 246);
            textBoxLozinka.Name = "textBoxLozinka";
            textBoxLozinka.Size = new Size(315, 26);
            textBoxLozinka.TabIndex = 4;
            textBoxLozinka.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(214, 34, 70);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(255, 255, 251);
            btnLogin.Location = new Point(48, 308);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(315, 38);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "PRIJAVI SE";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 440);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prijava";
            Load += FrmLogin_Load;
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private PictureBox picLogo;
        private Label lblAppName;
        private Label lblTagline;
        private Panel pnlRight;
        private Panel pnlAccentRight;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Label lblEmail;
        private Label lblLozinka;
        private Button btnLogin;
        internal TextBox textBoxEmail;
        internal TextBox textBoxLozinka;
    }
}
