using Easy.ApplicationDesk.Shared;
using Easy.Services.Dtos.ProdutoCategoria;
using Easy.Services.Interfaces.ProdutoCategoria;
using Easy.Services.Shared;

namespace Easy.ApplicationDesk.Forms.Produtos
{
    public partial class CategoriaProdutoCtrl : UserControl
    {
        private readonly ICategoriaProdutoService _service;
        private List<CategoriaProdutoDto> _categorias;
        private AcaoTela tela;
        public CategoriaProdutoCtrl()
        {
            InitializeComponent();
            _service = AppServicos.ICategoriaProdutoService!;
            dtgvPrincipal.AutoGenerateColumns = false;
            _categorias = new List<CategoriaProdutoDto>();
            MenuDt(dtgvPrincipal);
        }
        private async void CategoriaProdutoCtrl_Load(object sender, EventArgs e)
        {

            await PreencherDtgv(dtgvPrincipal);
        }
        private void dtgvPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dt = sender as DataGridView;
            if (dt.Rows[e.RowIndex].DataBoundItem != null &&
                dt.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
            {
                e.Value = BindPropertyClass.BindProperty(dt.Rows[e.RowIndex].DataBoundItem,
                    dt.Columns[e.ColumnIndex].DataPropertyName);
            }
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
                        if (dtgvPrincipal.SelectedRows.Count == 0)
                            return;

                        CategoriaProdutoDto? dto = dtgvPrincipal.SelectedRows[0].DataBoundItem as CategoriaProdutoDto;

                        if (dto == null)
                            return;

                        CategoriaProdutoDtoUpdate updateDto = new CategoriaProdutoDtoUpdate
                        {
                            DescricaoCategoria = dto.DescricaoCategoria,
                            Habilitado = false,
                            Id = dto.Id
                        };


                        try
                        {
                            Services.Dtos.ResponseDto<List<CategoriaProdutoDto>> result = await _service.Update(updateDto);
                            if (!result.Status)
                            {
                                MessageBox.Show(result.Mensagem);
                                return;
                            }

                            //MessageBox.Show("Desabilitado");

                            _categorias = (await _service.Get()).Dados!;
                            dtgvPrincipal.DataSource = null;
                            dtgvPrincipal.DataSource = _categorias;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }

                        break;
                    case "Habilitar":
                        if (dtgvPrincipal.SelectedRows.Count == 0)
                            return;

                        CategoriaProdutoDto? dtoD = dtgvPrincipal.SelectedRows[0].DataBoundItem as CategoriaProdutoDto;

                        if (dtoD == null)
                            return;

                        CategoriaProdutoDtoUpdate updateDtoD = new CategoriaProdutoDtoUpdate
                        {
                            DescricaoCategoria = dtoD.DescricaoCategoria,
                            Habilitado = true,
                            Id = dtoD.Id
                        };


                        try
                        {
                            Services.Dtos.ResponseDto<List<CategoriaProdutoDto>> result = await _service.Update(updateDtoD);
                            if (!result.Status)
                            {
                                MessageBox.Show(result.Mensagem);
                                return;
                            }

                            //MessageBox.Show("Habilitado");

                            _categorias = (await _service.Get()).Dados!;
                            dtgvPrincipal.DataSource = null;
                            dtgvPrincipal.DataSource = _categorias;

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

        #region Metodos
        private async Task PreencherDtgv(DataGridView dt)
        {
            try
            {
                _categorias = (await _service.Get()).Dados!;
                dt.DataSource = _categorias;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        private void txtFormaPagamento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<CategoriaProdutoDto> result = _categorias.Where(c => c.DescricaoCategoria.ToLower().Contains(txtCategoriaProduto.Text)).ToList();

                dtgvPrincipal.DataSource = result.ToList();

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

        private async void btnManter_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tela)
                {
                    case AcaoTela.cadastrar:

                        await Cadastrar();

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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async Task Cadastrar()
        {
            if (txtCategoriaProduto.Text == string.Empty)
                return;
           
            CategoriaProdutoDtoCreate dtoCreate = new CategoriaProdutoDtoCreate
            {
                DescricaoCategoria = txtCategoriaProduto.Text
            };

            string validacoes = ValidarDataAnnotation.VerificarDataAnnotations(dtoCreate);
            if (!string.IsNullOrEmpty(validacoes))
            {
                MessageBox.Show(validacoes);
                return;
            }

            Services.Dtos.ResponseDto<List<CategoriaProdutoDto>> result = await _service.Create(dtoCreate);
            if (result.Status)
            {
                await PreencherDtgv(dtgvPrincipal);
            }
            else
            {
                MessageBox.Show(result.Mensagem);
                return;
            }
        }

        private async void dtgvPrincipal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvPrincipal.SelectedRows.Count == 0)
                return;

            CategoriaProdutoDto? dto = dtgvPrincipal.SelectedRows[0].DataBoundItem as CategoriaProdutoDto;

            if (dto == null)
                return;

            CategoriaProdutoDtoUpdate updateDto = new CategoriaProdutoDtoUpdate
            {
                DescricaoCategoria = dto.DescricaoCategoria,
                Habilitado = dto.Habilitado,
                Id = dto.Id
            };


            try
            {
                Services.Dtos.ResponseDto<List<CategoriaProdutoDto>> result = await _service.Update(updateDto);
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
    }
}
