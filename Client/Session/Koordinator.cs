using Client.Forms;
using Client.GuiController;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Session
{
    internal class Koordinator
    {
        private static Koordinator instance;

        private Koordinator() { }

        public static Koordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Koordinator();
                }
                return instance;
            }
        }

        public Zaposleni? UlogovanZaposleni { get; internal set; }

        public LoginGuiController LoginGuiController { get; set; }
        public FrmLogin frmLogin { get; set; }

        internal void OtvoriGlavnuFormu()
        {
            throw new NotImplementedException();
        }

        internal void OtvoriLoginFormu()
        {
            frmLogin = new FrmLogin();
            LoginGuiController = new LoginGuiController(frmLogin);
            LoginGuiController.OtvoriFormu();
        }
    }
}
