namespace Client.Forms
{
    partial class FrmIzaberiZaposleni
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
            txtPretraga = new TextBox();
            dgvZaposleni = new DataGridView();
            btnPonitiIzbor = new Button();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).BeginInit();
            SuspendLayout();
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(12, 12);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.PlaceholderText = "Pretraži po imenu ili prezimenu";
            txtPretraga.Size = new Size(456, 23);
            txtPretraga.TabIndex = 0;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // dgvZaposleni
            // 
            dgvZaposleni.AllowUserToAddRows = false;
            dgvZaposleni.AllowUserToDeleteRows = false;
            dgvZaposleni.BackgroundColor = Color.White;
            dgvZaposleni.BorderStyle = BorderStyle.None;
            dgvZaposleni.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvZaposleni.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvZaposleni.ColumnHeadersHeight = 30;
            dgvZaposleni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvZaposleni.EnableHeadersVisualStyles = false;
            dgvZaposleni.GridColor = Color.FromArgb(238, 238, 238);
            dgvZaposleni.Location = new Point(12, 42);
            dgvZaposleni.MultiSelect = false;
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.ReadOnly = true;
            dgvZaposleni.RowHeadersVisible = false;
            dgvZaposleni.RowTemplate.Height = 34;
            dgvZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZaposleni.Size = new Size(456, 270);
            dgvZaposleni.TabIndex = 1;
            dgvZaposleni.CellDoubleClick += dgvZaposleni_CellDoubleClick;
            // 
            // btnPonitiIzbor
            //
            btnPonitiIzbor.Location = new Point(148, 325);
            btnPonitiIzbor.Name = "btnPonitiIzbor";
            btnPonitiIzbor.Size = new Size(115, 32);
            btnPonitiIzbor.TabIndex = 4;
            btnPonitiIzbor.Text = "Poništi izbor";
            btnPonitiIzbor.Click += btnPonitiIzbor_Click;
            //
            // btnPotvrdi
            //
            btnPotvrdi.Location = new Point(270, 325);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(90, 32);
            btnPotvrdi.TabIndex = 2;
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(368, 325);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(100, 32);
            btnOdustani.TabIndex = 3;
            btnOdustani.Text = "Odustani";
            btnOdustani.Click += btnOdustani_Click;
            // 
            // FrmIzaberiZaposleni
            // 
            ClientSize = new Size(480, 375);
            Controls.Add(txtPretraga);
            Controls.Add(dgvZaposleni);
            Controls.Add(btnPonitiIzbor);
            Controls.Add(btnPotvrdi);
            Controls.Add(btnOdustani);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmIzaberiZaposleni";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izaberi zaposlenog";
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPretraga;
        public DataGridView dgvZaposleni;
        private Button btnPonitiIzbor;
        private Button btnPotvrdi;
        private Button btnOdustani;
    }
}
