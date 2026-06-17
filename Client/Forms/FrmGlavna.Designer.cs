namespace Client.Forms
{
    partial class FrmGlavna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnPacijenti = new Button();
            btnZakazivanja = new Button();
            btnZaposleni = new Button();
            btnUsluge = new Button();
            btnOdeljenja = new Button();
            panelContent = new Panel();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(255, 0, 63);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(162, 526);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnPacijenti);
            flowLayoutPanel1.Controls.Add(btnZakazivanja);
            flowLayoutPanel1.Controls.Add(btnZaposleni);
            flowLayoutPanel1.Controls.Add(btnUsluge);
            flowLayoutPanel1.Controls.Add(btnOdeljenja);
            flowLayoutPanel1.Location = new Point(3, 114);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(156, 298);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnPacijenti
            // 
            btnPacijenti.AutoSize = true;
            btnPacijenti.Location = new Point(3, 3);
            btnPacijenti.Margin = new Padding(3, 3, 3, 20);
            btnPacijenti.Name = "btnPacijenti";
            btnPacijenti.Size = new Size(150, 40);
            btnPacijenti.TabIndex = 5;
            btnPacijenti.Text = "Pacijenti";
            btnPacijenti.UseVisualStyleBackColor = true;
            btnPacijenti.Click += new EventHandler(btnPacijenti_Click);
            // 
            // btnZakazivanja
            // 
            btnZakazivanja.AutoSize = true;
            btnZakazivanja.Location = new Point(3, 66);
            btnZakazivanja.Margin = new Padding(3, 3, 3, 20);
            btnZakazivanja.Name = "btnZakazivanja";
            btnZakazivanja.Size = new Size(150, 40);
            btnZakazivanja.TabIndex = 6;
            btnZakazivanja.Text = "Zakazivanja";
            btnZakazivanja.UseVisualStyleBackColor = true;
            // 
            // btnZaposleni
            // 
            btnZaposleni.AutoSize = true;
            btnZaposleni.Location = new Point(3, 129);
            btnZaposleni.Margin = new Padding(3, 3, 3, 20);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(150, 40);
            btnZaposleni.TabIndex = 7;
            btnZaposleni.Text = "Zaposleni";
            btnZaposleni.UseVisualStyleBackColor = true;
            // 
            // btnUsluge
            // 
            btnUsluge.AutoSize = true;
            btnUsluge.Location = new Point(3, 192);
            btnUsluge.Name = "btnUsluge";
            btnUsluge.Size = new Size(150, 40);
            btnUsluge.TabIndex = 8;
            btnUsluge.Text = "Usluge";
            btnUsluge.UseVisualStyleBackColor = true;
            // 
            // btnOdeljenja
            // 
            btnOdeljenja.AutoSize = true;
            btnOdeljenja.Location = new Point(3, 255);
            btnOdeljenja.Margin = new Padding(3, 20, 3, 3);
            btnOdeljenja.Name = "btnOdeljenja";
            btnOdeljenja.Size = new Size(150, 40);
            btnOdeljenja.TabIndex = 9;
            btnOdeljenja.Text = "Odeljenja";
            btnOdeljenja.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(162, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(725, 526);
            panelContent.TabIndex = 1;
            // 
            // FrmGlavna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 526);
            Controls.Add(panelContent);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmGlavna";
            Text = "Glavna forma";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnPacijenti;
        private Button btnZakazivanja;
        private Button btnZaposleni;
        private Button btnUsluge;
        private Button btnOdeljenja;
        private Panel panelContent;
    }
}