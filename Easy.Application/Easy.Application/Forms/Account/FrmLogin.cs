using Easy.ApplicationDesk.Forms.Account;
using Easy.ApplicationDesk.Forms.Home;
using Easy.ApplicationDesk.Shared;
using Easy.Services.Dtos.UserIdentity;
using Easy.Services.Interfaces.Account;
using Easy.Services.Shared;

namespace Easy.ApplicationDesk.Forms.Login
{
    public partial class FrmLogin : Form
    {
        private readonly IIdentityService _service;
        public FrmLogin()
        {
            InitializeComponent();
            _service = AppServicos.IIdentityService;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            using (FrmAccountCreate frm = new FrmAccountCreate())
            {
                this.Visible = false;
                frm.ShowDialog();
                this.Visible = true;
            }
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            ValidarComponentes.FlowLayoutPanel(this.flFormLogin);

            UsuarioLoginRequest userLogin = new UsuarioLoginRequest
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text
            };

            string validacoes = ValidarDataAnnotation.VerificarDataAnnotations(userLogin);
            if (!string.IsNullOrEmpty(validacoes))
            {
                MessageBox.Show(validacoes);
                return;
            }

            Services.Dtos.ResponseDto<List<UsuarioLoginResponse>> response = await _service.Login(userLogin);
            if (!response.Status)
            {

                lblResult.ForeColor = Color.Red;
                lblResult.Text = response.Mensagem;

                LimparComponentes.LimparFlowLayoutPanel(this.flFormLogin);
                return;
            }

            Globais.SetToken(response.Dados.FirstOrDefault());

            this.Visible = false;
            using (FrmHome frm = new FrmHome())
            {
                frm.ShowDialog();
            }
            this.Visible = false;
            this.Close();
        }
    }
}
