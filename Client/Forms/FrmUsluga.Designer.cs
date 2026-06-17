namespace Client.Forms
{
    partial class FrmUsluga
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
            pnlAccent = new Panel();
            lblTitle = new Label();
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            lblCena = new Label();
            nudCena = new NumericUpDown();
            pnlButtons = new Panel();
            btnSacuvaj = new Button();
            btnIzmeni = new Button();
            btnOdustani = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCena).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            //
            // pnlAccent
            //
            pnlAccent.BackColor = Color.FromArgb(214, 34, 70);
            pnlAccent.Dock = DockStyle.Top;
            pnlAccent.Location = new Point(0, 0);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(420, 5);
            pnlAccent.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(47, 47, 47);
            lblTitle.Location = new Point(32, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 34);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Ubaci uslugu";
            //
            // lblNaziv
            //
            lblNaziv.Font = new Font("Segoe UI", 9F);
            lblNaziv.ForeColor = Color.FromArgb(120, 120, 120);
            lblNaziv.Location = new Point(32, 75);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(360, 18);
            lblNaziv.TabIndex = 2;
            lblNaziv.Text = "Naziv";
            //
            // txtNaziv
            //
            txtNaziv.BackColor = Color.FromArgb(245, 245, 245);
            txtNaziv.BorderStyle = BorderStyle.FixedSingle;
            txtNaziv.Font = new Font("Segoe UI", 10.5F);
            txtNaziv.Location = new Point(32, 96);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(356, 28);
            txtNaziv.TabIndex = 3;
            //
            // lblCena
            //
            lblCena.Font = new Font("Segoe UI", 9F);
            lblCena.ForeColor = Color.FromArgb(120, 120, 120);
            lblCena.Location = new Point(32, 140);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(360, 18);
            lblCena.TabIndex = 4;
            lblCena.Text = "Cena (RSD)";
            //
            // nudCena
            //
            nudCena.BackColor = Color.FromArgb(245, 245, 245);
            nudCena.BorderStyle = BorderStyle.FixedSingle;
            nudCena.DecimalPlaces = 2;
            nudCena.Font = new Font("Segoe UI", 10.5F);
            nudCena.Location = new Point(32, 161);
            nudCena.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCena.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudCena.Name = "nudCena";
            nudCena.Size = new Size(356, 28);
            nudCena.TabIndex = 5;
            //
            // pnlButtons
            //
            pnlButtons.BackColor = Color.FromArgb(240, 240, 240);
            pnlButtons.Controls.Add(btnSacuvaj);
            pnlButtons.Controls.Add(btnIzmeni);
            pnlButtons.Controls.Add(btnOdustani);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 222);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(32, 10, 32, 10);
            pnlButtons.Size = new Size(420, 56);
            pnlButtons.TabIndex = 6;
            //
            // btnSacuvaj
            //
            btnSacuvaj.BackColor = Color.FromArgb(93, 169, 233);
            btnSacuvaj.Cursor = Cursors.Hand;
            btnSacuvaj.FlatAppearance.BorderSize = 0;
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSacuvaj.ForeColor = Color.FromArgb(255, 255, 251);
            btnSacuvaj.Location = new Point(32, 10);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(160, 34);
            btnSacuvaj.TabIndex = 0;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;
            //
            // btnIzmeni
            //
            btnIzmeni.BackColor = Color.FromArgb(93, 169, 233);
            btnIzmeni.Cursor = Cursors.Hand;
            btnIzmeni.FlatAppearance.BorderSize = 0;
            btnIzmeni.FlatStyle = FlatStyle.Flat;
            btnIzmeni.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnIzmeni.ForeColor = Color.FromArgb(255, 255, 251);
            btnIzmeni.Location = new Point(32, 10);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(160, 34);
            btnIzmeni.TabIndex = 1;
            btnIzmeni.Text = "Sačuvaj izmene";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            //
            // btnOdustani
            //
            btnOdustani.BackColor = Color.FromArgb(255, 255, 251);
            btnOdustani.Cursor = Cursors.Hand;
            btnOdustani.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnOdustani.FlatAppearance.BorderSize = 1;
            btnOdustani.FlatStyle = FlatStyle.Flat;
            btnOdustani.Font = new Font("Segoe UI", 9.5F);
            btnOdustani.ForeColor = Color.FromArgb(80, 80, 80);
            btnOdustani.Location = new Point(202, 10);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(160, 34);
            btnOdustani.TabIndex = 2;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;
            //
            // FrmUsluga
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 251);
            ClientSize = new Size(420, 278);
            Controls.Add(pnlAccent);
            Controls.Add(lblTitle);
            Controls.Add(lblNaziv);
            Controls.Add(txtNaziv);
            Controls.Add(lblCena);
            Controls.Add(nudCena);
            Controls.Add(pnlButtons);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsluga";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Usluga";
            ((System.ComponentModel.ISupportInitialize)nudCena).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlAccent;
        private Label lblTitle;
        private Label lblNaziv;
        internal TextBox txtNaziv;
        private Label lblCena;
        internal NumericUpDown nudCena;
        private Panel pnlButtons;
        internal Button btnSacuvaj;
        internal Button btnIzmeni;
        internal Button btnOdustani;
    }
}
