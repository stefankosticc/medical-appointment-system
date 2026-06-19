namespace Client.Forms
{
    partial class FrmIzaberiPacijent
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
            dgvPacijent = new DataGridView();
            btnPonitiIzbor = new Button();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacijent).BeginInit();
            SuspendLayout();
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(12, 12);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.PlaceholderText = "Pretraži po imenu ili prezimenu";
            txtPretraga.Size = new Size(636, 23);
            txtPretraga.TabIndex = 0;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // dgvPacijent
            // 
            dgvPacijent.AllowUserToAddRows = false;
            dgvPacijent.AllowUserToDeleteRows = false;
            dgvPacijent.BackgroundColor = Color.White;
            dgvPacijent.BorderStyle = BorderStyle.None;
            dgvPacijent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPacijent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPacijent.ColumnHeadersHeight = 30;
            dgvPacijent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPacijent.EnableHeadersVisualStyles = false;
            dgvPacijent.GridColor = Color.FromArgb(238, 238, 238);
            dgvPacijent.Location = new Point(12, 42);
            dgvPacijent.MultiSelect = false;
            dgvPacijent.Name = "dgvPacijent";
            dgvPacijent.ReadOnly = true;
            dgvPacijent.RowHeadersVisible = false;
            dgvPacijent.RowTemplate.Height = 34;
            dgvPacijent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacijent.Size = new Size(636, 270);
            dgvPacijent.TabIndex = 1;
            dgvPacijent.CellDoubleClick += dgvPacijent_CellDoubleClick;
            // 
            // btnPonitiIzbor
            //
            btnPonitiIzbor.Location = new Point(328, 325);
            btnPonitiIzbor.Name = "btnPonitiIzbor";
            btnPonitiIzbor.Size = new Size(115, 32);
            btnPonitiIzbor.TabIndex = 4;
            btnPonitiIzbor.Text = "Poništi izbor";
            btnPonitiIzbor.Click += btnPonitiIzbor_Click;
            //
            // btnPotvrdi
            //
            btnPotvrdi.Location = new Point(450, 325);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(90, 32);
            btnPotvrdi.TabIndex = 2;
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(548, 325);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(100, 32);
            btnOdustani.TabIndex = 3;
            btnOdustani.Text = "Odustani";
            btnOdustani.Click += btnOdustani_Click;
            // 
            // FrmIzaberiPacijent
            // 
            ClientSize = new Size(660, 375);
            Controls.Add(txtPretraga);
            Controls.Add(dgvPacijent);
            Controls.Add(btnPonitiIzbor);
            Controls.Add(btnPotvrdi);
            Controls.Add(btnOdustani);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmIzaberiPacijent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izaberi pacijenta";
            ((System.ComponentModel.ISupportInitialize)dgvPacijent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPretraga;
        public DataGridView dgvPacijent;
        private Button btnPonitiIzbor;
        private Button btnPotvrdi;
        private Button btnOdustani;
    }
}
