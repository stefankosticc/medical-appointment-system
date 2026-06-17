using Client.Session;

namespace Client.Forms
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
            lblUsername.Text = Koordinator.Instance.UlogovanZaposleni.ToString();
            lblAvatar.Text = lblUsername.Text[0].ToString();
        }

        private void btnPacijenti_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.OtvoriPacijentPanel(panelContent);
        }

        private void btnUsluge_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.OtvoriUslugaPanel(panelContent);
        }
    }
}
