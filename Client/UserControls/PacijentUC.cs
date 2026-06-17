using Client.Session;
using Common.Domain;

namespace Client.UserControls
{
    public partial class PacijentUC : UserControl
    {
        public PacijentUC()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            Koordinator.Instance.OtvoriKreirajPacijentFormu();
            Koordinator.Instance.KreirajPacijentGuiController.KreirajPacijenta();
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
           // Koordinator.Instance.PromeniPacijentGuiController.OtvoriFormu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
           // Koordinator.Instance.PromeniPacijentGuiController.ObrisiPacijenta();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            // implementirati kada dodamo PretraziPacijent SO
        }
    }
}
