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
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            lblCena = new Label();
            nudCena = new NumericUpDown();
            btnSacuvaj = new Button();
            btnIzmeni = new Button();
            btnOdustani = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCena).BeginInit();
            SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.Location = new Point(20, 58);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(130, 23);
            lblNaziv.TabIndex = 1;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(160, 55);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(280, 23);
            txtNaziv.TabIndex = 2;
            // 
            // lblCena
            // 
            lblCena.Location = new Point(20, 101);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(130, 23);
            lblCena.TabIndex = 3;
            lblCena.Text = "Cena (RSD):";
            // 
            // nudCena
            // 
            nudCena.DecimalPlaces = 2;
            nudCena.Location = new Point(160, 98);
            nudCena.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCena.Name = "nudCena";
            nudCena.Size = new Size(280, 23);
            nudCena.TabIndex = 4;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(160, 148);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(120, 35);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(160, 148);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(130, 35);
            btnIzmeni.TabIndex = 6;
            btnIzmeni.Text = "Sačuvaj izmene";
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(300, 148);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(120, 35);
            btnOdustani.TabIndex = 7;
            btnOdustani.Text = "Odustani";
            btnOdustani.Click += btnOdustani_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ubaci uslugu";
            // 
            // FrmUsluga
            // 
            ClientSize = new Size(490, 210);
            Controls.Add(lblTitle);
            Controls.Add(lblNaziv);
            Controls.Add(txtNaziv);
            Controls.Add(lblCena);
            Controls.Add(nudCena);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnOdustani);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsluga";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Usluga";
            ((System.ComponentModel.ISupportInitialize)nudCena).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNaziv;
        internal TextBox txtNaziv;
        private Label lblCena;
        internal NumericUpDown nudCena;
        internal Button btnSacuvaj;
        internal Button btnIzmeni;
        internal Button btnOdustani;
    }
}
