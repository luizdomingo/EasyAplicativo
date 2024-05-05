using Easy.ApplicationDesk.Shared;
using Easy.Services.Dtos.PedidoFormaPagamento;
using Easy.Services.Interfaces.PagamentoPedido;
using Easy.Services.Shared;

namespace Easy.ApplicationDesk.Forms.PedidoFormaPagamento
{
    public partial class FormaPagamentoCtrl : UserControl
    {
        private readonly IFormaPagamentoService _service;
        private List<FormaPagamentoDto>? _fpgts = null;
        private AcaoTela tela;

        public FormaPagamentoCtrl()
        {
            InitializeComponent();
            _service = AppServicos.IFormaPagamentoService!;
            _fpgts = new List<FormaPagamentoDto>();
            guna2DataGridView1.AutoGenerateColumns = false;
            tela = AcaoTela.cadastrar;
        }

        private async void FormPagamentoCtrl_Load(object sender, EventArgs e)
        {
            _fpgts = (await _service.GetAll()).Dados;
            guna2DataGridView1.DataSource = _fpgts;
        }

        private void dtgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dt = sender as DataGridView;
            if (dt.Rows[e.RowIndex].DataBoundItem != null &&
                dt.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
            {
                e.Value = BindPropertyClass.BindProperty(dt.Rows[e.RowIndex].DataBoundItem,
                    dt.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private void txtFormaPagamento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _fpgts.Where(f => f.DescricaoFormaPg.ToLower().Contains(txtFormaPagamento.Text.ToLower()));

                guna2DataGridView1.DataSource = result.ToList();

                if (!result.Any())
                {
                    btnManter.BackColor = Color.SeaGreen;
                    btnManter.Text = "cadastrar";
                }
                else
                {
                    btnManter.BackColor = Color.Goldenrod;
                    btnManter.Text = "alterar";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void btnManter_Click(object sender, EventArgs e)
        {
            switch (tela)
            {
                case AcaoTela.cadastrar:


                   

                    break;
                case AcaoTela.alterar:
                    break;
                case AcaoTela.consultar:
                    break;
                case AcaoTela.excluir:
                    break;
                default:
                    break;
            }
        }
    }
}
