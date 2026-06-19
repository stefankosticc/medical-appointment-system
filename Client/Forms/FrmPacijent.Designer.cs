namespace Client.Forms
{
    partial class FrmPacijent
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
            lblIme = new Label();
            txtIme = new TextBox();
            lblPrezime = new Label();
            txtPrezime = new TextBox();
            lblDatumRodjenja = new Label();
            dtpDatumRodjenja = new DateTimePicker();
            lblPol = new Label();
            cmbPol = new ComboBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblBrojTelefona = new Label();
            txtBrojTelefona = new TextBox();
            lblKategorija = new Label();
            cmbKategorijaPacijenta = new ComboBox();
            btnSacuvaj = new Button();
            btnOdustani = new Button();
            SuspendLayout();

            // lblIme
            lblIme.Text = "Ime:";
            lblIme.Location = new Point(20, 25);
            lblIme.Size = new Size(130, 23);

            // txtIme
            txtIme.Location = new Point(160, 22);
            txtIme.Size = new Size(280, 27);
            txtIme.Name = "txtIme";

            // lblPrezime
            lblPrezime.Text = "Prezime:";
            lblPrezime.Location = new Point(20, 68);
            lblPrezime.Size = new Size(130, 23);

            // txtPrezime
            txtPrezime.Location = new Point(160, 65);
            txtPrezime.Size = new Size(280, 27);
            txtPrezime.Name = "txtPrezime";

            // lblDatumRodjenja
            lblDatumRodjenja.Text = "Datum rođenja:";
            lblDatumRodjenja.Location = new Point(20, 111);
            lblDatumRodjenja.Size = new Size(130, 23);

            // dtpDatumRodjenja
            dtpDatumRodjenja.Location = new Point(160, 108);
            dtpDatumRodjenja.Size = new Size(280, 27);
            dtpDatumRodjenja.CustomFormat = "dd.MM.yyyy";
            dtpDatumRodjenja.Format = DateTimePickerFormat.Custom;
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";

            // lblPol
            lblPol.Text = "Pol:";
            lblPol.Location = new Point(20, 154);
            lblPol.Size = new Size(130, 23);

            // cmbPol
            cmbPol.Location = new Point(160, 151);
            cmbPol.Size = new Size(280, 27);
            cmbPol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPol.Name = "cmbPol";

            // lblEmail
            lblEmail.Text = "Email:";
            lblEmail.Location = new Point(20, 197);
            lblEmail.Size = new Size(130, 23);

            // txtEmail
            txtEmail.Location = new Point(160, 194);
            txtEmail.Size = new Size(280, 27);
            txtEmail.Name = "txtEmail";

            // lblBrojTelefona
            lblBrojTelefona.Text = "Broj telefona:";
            lblBrojTelefona.Location = new Point(20, 240);
            lblBrojTelefona.Size = new Size(130, 23);

            // txtBrojTelefona
            txtBrojTelefona.Location = new Point(160, 237);
            txtBrojTelefona.Size = new Size(280, 27);
            txtBrojTelefona.Name = "txtBrojTelefona";

            // lblKategorija
            lblKategorija.Text = "Kategorija:";
            lblKategorija.Location = new Point(20, 283);
            lblKategorija.Size = new Size(130, 23);

            // cmbKategorijaPacijenta
            cmbKategorijaPacijenta.Location = new Point(160, 280);
            cmbKategorijaPacijenta.Size = new Size(280, 27);
            cmbKategorijaPacijenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategorijaPacijenta.Name = "cmbKategorijaPacijenta";

            // btnSacuvaj
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.Location = new Point(160, 335);
            btnSacuvaj.Size = new Size(120, 35);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Click += new EventHandler(btnSacuvaj_Click);

            // btnOdustani
            btnOdustani.Text = "Odustani";
            btnOdustani.Location = new Point(290, 335);
            btnOdustani.Size = new Size(120, 35);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Click += new EventHandler(btnOdustani_Click);

            // FrmPacijent
            ClientSize = new Size(490, 400);
            Text = "Pacijent";
            Name = "FrmPacijent";
            StartPosition = FormStartPosition.CenterParent;
            Controls.Add(lblIme);
            Controls.Add(txtIme);
            Controls.Add(lblPrezime);
            Controls.Add(txtPrezime);
            Controls.Add(lblDatumRodjenja);
            Controls.Add(dtpDatumRodjenja);
            Controls.Add(lblPol);
            Controls.Add(cmbPol);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblBrojTelefona);
            Controls.Add(txtBrojTelefona);
            Controls.Add(lblKategorija);
            Controls.Add(cmbKategorijaPacijenta);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnOdustani);
            FormClosing += FrmPacijent_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIme;
        public TextBox txtIme;
        private Label lblPrezime;
        public TextBox txtPrezime;
        private Label lblDatumRodjenja;
        public DateTimePicker dtpDatumRodjenja;
        private Label lblPol;
        public ComboBox cmbPol;
        private Label lblEmail;
        public TextBox txtEmail;
        private Label lblBrojTelefona;
        public TextBox txtBrojTelefona;
        private Label lblKategorija;
        public ComboBox cmbKategorijaPacijenta;
        public Button btnSacuvaj;
        public Button btnOdustani;
    }
}
