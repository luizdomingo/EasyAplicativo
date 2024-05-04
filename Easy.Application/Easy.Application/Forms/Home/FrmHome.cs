using Easy.Services.Shared;

namespace Easy.Application.Forms.Home
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            label1.Text = Globais.GetToken();
        }
    }
}
