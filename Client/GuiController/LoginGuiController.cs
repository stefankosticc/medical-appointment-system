using Client.Forms;
using Client.Session;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Transactions;

namespace Client.GuiController
{
    public class LoginGuiController
    {
        private FrmLogin frmLogin;

        public LoginGuiController(FrmLogin frmLogin) { this.frmLogin = frmLogin; }

        public void Login()
        {
            if (!Validacija()) return;

            try
            {
                Zaposleni zaposleni = new Zaposleni
                {
                    KorisnickoIme = frmLogin.textBoxEmail.Text,
                    Sifra = frmLogin.textBoxLozinka.Text
                };

                Response response = Communication.Instance.PrijaviZaposleni(zaposleni);
                Console.WriteLine(response.ToString());
                if (response.ExceptionMessage == null && response.Data != null)
                {
                    Koordinator.Instance.UlogovanZaposleni = response.Data as Zaposleni;
                    MessageBox.Show(frmLogin, "Korisnicko ime i sifra su ispravni.", "USPEŠNO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmLogin.Close();
                    Koordinator.Instance.OtvoriGlavnuFormu();
                }
                else
                {
                    MessageBox.Show(frmLogin, "Korisnicko ime i sifra nisu ispravni", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(frmLogin, "Ne moze da se otvori glavna forma i meni", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool Validacija()
        {
            if (string.IsNullOrWhiteSpace(frmLogin.textBoxEmail.Text) || string.IsNullOrWhiteSpace(frmLogin.textBoxLozinka.Text))
            {
                MessageBox.Show(frmLogin, "Popunite sva polja!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        internal void OtvoriFormu()
        {
            frmLogin.ShowDialog();
        }
    }
}
