namespace Client.Forms
{
    partial class FrmOdeljenje
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
            lblTitle = new Label();
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            btnSacuvaj = new Button();
            btnIzmeni = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ubaci odeljenje";
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
            // btnSacuvaj
            //
            btnSacuvaj.Location = new Point(160, 100);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(120, 35);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.Click += btnSacuvaj_Click;
            //
            // btnIzmeni
            //
            btnIzmeni.Location = new Point(160, 100);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(130, 35);
            btnIzmeni.TabIndex = 4;
            btnIzmeni.Text = "Sačuvaj izmene";
            btnIzmeni.Click += btnIzmeni_Click;
            //
            // btnOdustani
            //
            btnOdustani.Location = new Point(300, 100);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(120, 35);
            btnOdustani.TabIndex = 5;
            btnOdustani.Text = "Odustani";
            btnOdustani.Click += btnOdustani_Click;
            //
            // FrmOdeljenje
            //
            ClientSize = new Size(490, 170);
            Controls.Add(lblTitle);
            Controls.Add(lblNaziv);
            Controls.Add(txtNaziv);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnOdustani);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmOdeljenje";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Odeljenje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNaziv;
        internal TextBox txtNaziv;
        internal Button btnSacuvaj;
        internal Button btnIzmeni;
        internal Button btnOdustani;
    }
}
