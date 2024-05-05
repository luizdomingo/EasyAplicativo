using Easy.ApplicationDesk.Shared;
using Easy.Services.Dtos.UserIdentity;
using Easy.Services.Interfaces.Account;
using Easy.Services.Shared;

namespace Easy.ApplicationDesk.Forms.Account
{
    public partial class FrmAccountCreate : Form
    {
        private readonly IIdentityService? _service;
        public FrmAccountCreate()
        {
            InitializeComponent();
            _service = AppServicos.IIdentityService;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            ValidarComponentes.FlowLayoutPanel(this.flForm);

            UsuarioCadastroRequest usuarioRequest = new UsuarioCadastroRequest
            {
                Email = txtEmail.Text,
                Nome = txtEmail.Text,
                Senha = txtSenha.Text,
                SenhaConfirmacao = txtConfirmaSenha.Text
            };


            string validacoes = ValidarDataAnnotation.VerificarDataAnnotations(usuarioRequest);
            if (!string.IsNullOrEmpty(validacoes))
            {
                MessageBox.Show(validacoes);
                return;
            }

            Services.Dtos.ResponseDto<List<UsuarioCadastroResponse>> response = await _service.Create(usuarioRequest);
            if (!response.Status)
            {
                MessageBox.Show(response.Mensagem);
                return;
            }

            MessageBox.Show("Usuário Criado com sucesso! Realize o login");
            this.DialogResult = DialogResult.Yes;

        }
    }
}
