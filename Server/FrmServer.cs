using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        Server server;

        public FrmServer()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Server();
            server.Start();
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            lblServerStatus.Text = "Server je pokrenut!";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            lblServerStatus.Text = "Server je zaustavljen!";
        }
    }
}
