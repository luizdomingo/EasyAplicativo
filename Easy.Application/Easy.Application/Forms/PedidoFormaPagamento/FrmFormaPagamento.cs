using Easy.Services.Dtos.PedidoFormaPagamento;
using Easy.Services.Interfaces.PagamentoPedido;
using Easy.Services.Services;

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
            var result = await _service.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.Dados;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            FormaPagamentoDtoCreate createFk = new FormaPagamentoDtoCreate
            {
                DescricaoFormaPg = textBox1.Text,

            };

            var result = await _service.Create(createFk);

            if (!result.Status)
            {
                MessageBox.Show(result.Mensagem);
            }

            await GetPagamentos();
        }
    }
}
