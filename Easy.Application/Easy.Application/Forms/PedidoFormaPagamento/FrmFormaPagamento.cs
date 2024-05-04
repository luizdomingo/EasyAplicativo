using Easy.Services.Dtos.PedidoFormaPagamento;
using Easy.Services.Interfaces.PagamentoPedido;
using Easy.Services.Services.API;
using Easy.Services.Shared;

namespace Easy.Application.Forms.PedidoFormaPagamento
{
    public partial class FrmFormaPagamento : Form
    {
        private readonly IFormaPagamentoService _service;
        public FrmFormaPagamento()
        {
            InitializeComponent();
            _service = AppServicos.IFormaPagamentoService;
        }

        private async void FrmFormaPagamento_Load(object sender, EventArgs e)
        {
            await GetPagamentos();

        }

        private async Task GetPagamentos()
        {
            Services.Dtos.ResponseDto<List<FormaPagamentoDto>> result = await _service.GetAll();
            if (!result.Status)
            {
                MessageBox.Show($"Erro.Detalhes: {result.Mensagem}");
                return;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.Dados;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormaPagamentoDtoCreate createFk = new FormaPagamentoDtoCreate
                {
                    DescricaoFormaPg = textBox1.Text,

                };

                Services.Dtos.ResponseDto<List<FormaPagamentoDto>> result = await _service.Create(createFk);

                if (!result.Status)
                {
                    MessageBox.Show($"Erro.Detalhes: {result.Mensagem}");
                    return;
                }

                await GetPagamentos();
            }
            catch (HttpStatusCodeResponseErrors ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
