namespace Client.Forms
{
    partial class FrmLogin
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
            panel1 = new Panel();
            btnRegistruj = new LinkLabel();
            lblNemateNalog = new Label();
            btnLogin = new Button();
            textBoxLozinka = new TextBox();
            lblLozinka = new Label();
            textBoxEmail = new TextBox();
            lblEmail = new Label();
            lblLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnRegistruj);
            panel1.Controls.Add(lblNemateNalog);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(textBoxLozinka);
            panel1.Controls.Add(lblLozinka);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblLogin);
            panel1.Location = new Point(159, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 312);
            panel1.TabIndex = 0;
            // 
            // btnRegistruj
            // 
            btnRegistruj.AutoSize = true;
            btnRegistruj.Location = new Point(252, 279);
            btnRegistruj.Name = "btnRegistruj";
            btnRegistruj.Size = new Size(98, 20);
            btnRegistruj.TabIndex = 7;
            btnRegistruj.TabStop = true;
            btnRegistruj.Text = "Registrujte se";
            // 
            // lblNemateNalog
            // 
            lblNemateNalog.AutoSize = true;
            lblNemateNalog.BackColor = Color.White;
            lblNemateNalog.Location = new Point(143, 279);
            lblNemateNalog.Name = "lblNemateNalog";
            lblNemateNalog.Size = new Size(111, 20);
            lblNemateNalog.TabIndex = 6;
            lblNemateNalog.Text = "Nemate nalog?";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(193, 237);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBoxLozinka
            // 
            textBoxLozinka.BorderStyle = BorderStyle.FixedSingle;
            textBoxLozinka.Location = new Point(42, 188);
            textBoxLozinka.Name = "textBoxLozinka";
            textBoxLozinka.Size = new Size(404, 27);
            textBoxLozinka.TabIndex = 4;
            textBoxLozinka.UseSystemPasswordChar = true;
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize = true;
            lblLozinka.Font = new Font("Segoe UI", 10F);
            lblLozinka.ImageAlign = ContentAlignment.MiddleRight;
            lblLozinka.Location = new Point(42, 162);
            lblLozinka.Name = "lblLozinka";
            lblLozinka.Size = new Size(67, 23);
            lblLozinka.TabIndex = 3;
            lblLozinka.Text = "Lozinka";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(42, 120);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(404, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ImageAlign = ContentAlignment.MiddleRight;
            lblEmail.Location = new Point(42, 94);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 16F);
            lblLogin.Location = new Point(196, 20);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(91, 37);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Log in";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 0, 63);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmLogin";
            Text = "Log in";
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblEmail;
        private Label lblLogin;
        private Label lblLozinka;
        private Button btnLogin;
        private LinkLabel btnRegistruj;
        private Label lblNemateNalog;
        internal TextBox textBoxEmail;
        internal TextBox textBoxLozinka;
    }
}