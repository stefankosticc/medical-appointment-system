using Client.Session;

namespace Client.Forms
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void btnPacijenti_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.OtvoriPacijentPanel(panelContent);
        }
    }
}
