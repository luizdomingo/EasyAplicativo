using Easy.Services.Dtos.PedidoSituacao;
using Easy.Services.Interfaces.PedidoSituacao;
using Easy.Services.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Easy.ApplicationDesk.Forms.PedidoSituacao
{
    public partial class FrmSituacaoPedido : Form
    {
        private readonly ISituacaoPedidoService? _service;

        public FrmSituacaoPedido()
        {
            InitializeComponent();
            _service = AppServicos.ISituacaoPedidoService;
        }

        private async void FrmSituacaoPedido_Load(object sender, EventArgs e)
        {
            var situacoesPeddio = await GetAllSituacaoPedido();
        }


        private async Task<List<SituacaoPedidoDto>> GetAllSituacaoPedido()
        {
            try
            {
                var situacoes = await _service.GetAll();
                return situacoes.Dados;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
