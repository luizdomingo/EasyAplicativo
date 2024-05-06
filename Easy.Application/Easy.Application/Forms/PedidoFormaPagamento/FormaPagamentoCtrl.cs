using Easy.ApplicationDesk.Shared;
using Easy.Services.Dtos.PedidoFormaPagamento;
using Easy.Services.Interfaces.PagamentoPedido;
using Easy.Services.Shared;
using System.Windows.Forms;

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
            tela = AcaoTela.cadastrar;
            dtFormaPagamento.AutoGenerateColumns = false;

            MenuDt(dtFormaPagamento);
        }
        private async void FormPagamentoCtrl_Load(object sender, EventArgs e)
        {
            await AtualizadDt();
        }

        private async Task AtualizadDt()
        {

            _fpgts = (await _service.GetAll()).Dados;
            dtFormaPagamento.DataSource = _fpgts;

        }
        private void MenuDt(DataGridView dt)
        {
            ContextMenuStrip cmsDgvGrd = new ContextMenuStrip();
            dt.ContextMenuStrip = cmsDgvGrd;

            cmsDgvGrd.Items.Add(new ToolStripMenuItem
            {
                Font = new System.Drawing.Font("Segoe UI", 8F),
                BackColor = Color.DarkGray,
                ForeColor = Color.Snow,
                Text = "    Opções",
                Alignment = ToolStripItemAlignment.Right,
                Height = 2 * Height,
            });
            cmsDgvGrd.Items.Add(new ToolStripSeparator
            {
                BackColor = Color.Bisque,
                Height = 3
            });
            cmsDgvGrd.Items.Add(new ToolStripMenuItem
            {
                Font = new System.Drawing.Font("Segoe UI", 8F),
                ForeColor = Color.Red,
                Text = "Desabilitar"
                // Image = Properties.Resources.page
            });

            cmsDgvGrd.Items.Add(new ToolStripMenuItem
            {
                Font = new System.Drawing.Font("Segoe UI", 8F),
                ForeColor = Color.SeaGreen,
                Text = "Habilitar"
                // Image = Properties.Resources.page
            });
            cmsDgvGrd.ItemClicked += CmsDgvGrd_Click;
        }
        private async void CmsDgvGrd_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Text)
                {
                    case "Desabilitar":
                        if (dtFormaPagamento.SelectedRows.Count == 0)
                            return;

                        FormaPagamentoDto? dto = dtFormaPagamento.SelectedRows[0].DataBoundItem as FormaPagamentoDto;

                        if (dto == null)
                            return;

                        FormaPagamentoDtoUpdate updateDto = new FormaPagamentoDtoUpdate
                        {
                            DescricaoFormaPg = dto.DescricaoFormaPg,
                            Habilitado = false,
                            Id = dto.Id
                        };


                        try
                        {
                            var result = await _service.Update(updateDto);
                            if (!result.Status)
                            {
                                MessageBox.Show(result.Mensagem);
                                return;
                            }

                            //MessageBox.Show("Desabilitado");

                            _fpgts = (await _service.GetAll()).Dados;
                            dtFormaPagamento.DataSource = null;
                            dtFormaPagamento.DataSource = _fpgts;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }

                        break;
                    case "Habilitar":
                        if (dtFormaPagamento.SelectedRows.Count == 0)
                            return;

                        FormaPagamentoDto? dtoD = dtFormaPagamento.SelectedRows[0].DataBoundItem as FormaPagamentoDto;

                        if (dtoD == null)
                            return;

                        FormaPagamentoDtoUpdate updateDtoD = new FormaPagamentoDtoUpdate
                        {
                            DescricaoFormaPg = dtoD.DescricaoFormaPg,
                            Habilitado = true,
                            Id = dtoD.Id
                        };


                        try
                        {
                            var result = await _service.Update(updateDtoD);
                            if (!result.Status)
                            {
                                MessageBox.Show(result.Mensagem);
                                return;
                            }

                            //MessageBox.Show("Habilitado");

                            _fpgts = (await _service.GetAll()).Dados;
                            dtFormaPagamento.DataSource = null;
                            dtFormaPagamento.DataSource = _fpgts;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        break;
                    default:

                        break;
                }
            }
            catch
            {

            }
        }

        private void txtFormaPagamento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _fpgts.Where(f => f.DescricaoFormaPg.ToLower().Contains(txtFormaPagamento.Text.ToLower()));

                dtFormaPagamento.DataSource = result.ToList();

                if (!result.Any())
                {
                    btnManter.BackColor = Color.SeaGreen;
                    btnManter.Text = "cadastrar";
                    this.tela = AcaoTela.cadastrar;
                }
                else
                {
                    btnManter.BackColor = Color.Goldenrod;
                    btnManter.Text = "alterar";
                    this.tela = AcaoTela.alterar;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

        private async void btnManter_Click(object sender, EventArgs e)
        {

            switch (tela)
            {
                case AcaoTela.cadastrar:

                    if (txtFormaPagamento.Text == string.Empty)
                        return;
                    FormaPagamentoDtoCreate dtoCreate = new FormaPagamentoDtoCreate
                    {
                        DescricaoFormaPg = txtFormaPagamento.Text
                    };

                    string validacoes = ValidarDataAnnotation.VerificarDataAnnotations(dtoCreate);
                    if (!string.IsNullOrEmpty(validacoes))
                    {
                        MessageBox.Show(validacoes);
                        return;
                    }


                    var result = await _service.Create(dtoCreate);
                    if (result.Status)
                    {
                        await AtualizadDt();
                    }
                    else
                    {
                        MessageBox.Show(result.Mensagem);
                        return;
                    }



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

        private async void dtFormaPagamento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


            if (dtFormaPagamento.SelectedRows.Count == 0)
                return;

            FormaPagamentoDto? dto = dtFormaPagamento.SelectedRows[0].DataBoundItem as FormaPagamentoDto;

            if (dto == null)
                return;

            FormaPagamentoDtoUpdate updateDto = new FormaPagamentoDtoUpdate
            {
                DescricaoFormaPg = dto.DescricaoFormaPg,
                Habilitado = dto.Habilitado,
                Id = dto.Id
            };


            try
            {
                var result = await _service.Update(updateDto);
                if (!result.Status)
                {
                    MessageBox.Show(result.Mensagem);
                    return;
                }

                // await AtualizadDt();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private async void txtFormaPagamento_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtFormaPagamento.Text == string.Empty)
                        return;
                    FormaPagamentoDtoCreate dtoCreate = new FormaPagamentoDtoCreate
                    {
                        DescricaoFormaPg = txtFormaPagamento.Text
                    };

                    string validacoes = ValidarDataAnnotation.VerificarDataAnnotations(dtoCreate);
                    if (!string.IsNullOrEmpty(validacoes))
                    {
                        MessageBox.Show(validacoes);
                        return;
                    }


                    var result = await _service.Create(dtoCreate);
                    if (result.Status)
                    {
                        await AtualizadDt();
                    }
                    else
                    {
                        MessageBox.Show(result.Mensagem);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
