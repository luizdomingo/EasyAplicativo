using Easy.ApplicationDesk.Forms.Alerta;
using Easy.ApplicationDesk.Forms.PedidoFormaPagamento;
using FontAwesome.Sharp;
using System.Windows.Interop;

namespace Easy.ApplicationDesk.Forms.Home
{
    public partial class FrmHome : Form
    {
        #region Menu Variaveis
        private bool colunaExpandida = true;
        private const int larguraInicial = 60;
        private const int larguraMaxima = 275;
        private const int incremento = 12;
        #endregion
        public FrmHome()
        {
            InitializeComponent();
            CriarListaBotoesProdutos();
            CriarListaBotoesUsuarios();
            CriarListaBotoesPontoVenda();
        }
        private void FrmHome_Load(object sender, EventArgs e)
        {
            btnMnProdutos.ClickCustomEvent += btn_produto_click;
            btnMnPontoVenda.ClickCustomEvent += btn_pdv_click;
            btnMnUsuarios.ClickCustomEvent += btn_usuarios_click;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void Alert(string msg, FrmAlerta.enmType type)
        {
            FrmAlerta frm = new FrmAlerta();
            frm.ShowAlert(this, msg, type);
        }

        #region ExibirEsconderBotoes

        private List<IconButton> _btnsProdutos = new List<IconButton>();
        private List<IconButton> _btnsUsuarios = new List<IconButton>();
        private List<IconButton> _btnsPontoVenda = new List<IconButton>();

        private static void AddGrupoBotoes(List<IconButton> lista, IconButton grupo)
        {
            lista.Add(grupo);
        }
        private void EsconderTodosBotoes()
        {
            ExibirEsconderBotoes(_btnsProdutos, true);
            ExibirEsconderBotoes(_btnsUsuarios, true);
            ExibirEsconderBotoes(_btnsPontoVenda, true);
        }
        private void ExibirEsconderBotoes(List<IconButton> lista, bool esconder = false)
        {
            if (esconder)
            {
                foreach (var btn in lista)
                {
                    btn.Visible = false;
                }
            }
            else
            {
                foreach (var btn in lista)
                {
                    if (btn.Visible)
                        btn.Visible = false;
                    else
                        btn.Visible = true;
                }
            }
        }
        private void CriarListaBotoesProdutos()
        {
            AddGrupoBotoes(_btnsProdutos, btnTipoProduto);
            AddGrupoBotoes(_btnsProdutos, btnCategoriaProduto);
            AddGrupoBotoes(_btnsProdutos, btnPrecoProduto);
            AddGrupoBotoes(_btnsProdutos, btnMedida);
        }

        private void CriarListaBotoesUsuarios()
        {
            AddGrupoBotoes(_btnsUsuarios, btnCadastrarUsuarios);
            AddGrupoBotoes(_btnsUsuarios, btnFuncoes);
        }

        private void CriarListaBotoesPontoVenda()
        {
            AddGrupoBotoes(_btnsPontoVenda, btnFormaPagamento);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (colunaExpandida)
            {
                if (tblFormsMenus.ColumnStyles[0].Width > larguraMaxima)
                {
                    tblFormsMenus.ColumnStyles[0].Width = larguraMaxima;
                    timer.Stop();
                }
                else
                {
                    tblFormsMenus.ColumnStyles[0].Width += incremento;
                }
            }
            else
            {
                if (tblFormsMenus.ColumnStyles[0].Width < larguraInicial)
                {
                    tblFormsMenus.ColumnStyles[0].Width = larguraInicial;
                    EsconderTodosBotoes();
                    timer.Stop();
                }
                else
                {
                    tblFormsMenus.ColumnStyles[0].Width -= incremento;
                }
            }
        }
        #endregion
        #region Manipulando Fonts

        private void mouserEnterFonts(IconButton btn)
        {
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.BackColor = Color.White;
            btn.IconSize = 25;
        }
        private void mouserLeaveFonts(IconButton btn)
        {
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            btn.BackColor = Color.White;
            btn.IconSize = 20;
        }
        private void btn_mouse_enter(object sender, EventArgs e)
        {
            var btn = sender as IconButton;
            mouserEnterFonts(btn!);
        }

        private void btn_mouse_leave(object sender, EventArgs e)
        {
            var btn = sender as IconButton;
            mouserLeaveFonts(btn!);
        }

        #endregion
        #region Manipulando Click
        private void btn_Click(object sender, EventArgs e)
        {
            var btn = sender as IconButton;


            this.Alert("Tipo de Produtos", FrmAlerta.enmType.Success);
        }
        #endregion
        #region ControlesComponentes

        private void ChamarControle(Control ctr)
        {
            pnlControles.Controls.Clear();
            if (ctr == null)
                return;
            ctr.Dock = DockStyle.Fill;
            pnlControles.Controls.Add(ctr);

        }

        #endregion


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Start();
                colunaExpandida = !colunaExpandida;
            }
        }


        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            EsconderTodosBotoes();

            if (colunaExpandida)
            {
                ExibirEsconderBotoes(_btnsUsuarios);
            }
            else
            {
                timer.Start();
                colunaExpandida = !colunaExpandida;
            }
        }





        #region Clicks Menu       
        private void btn_produto_click(object sender, EventArgs e)
        {
            EsconderTodosBotoes();

            if (colunaExpandida)
            {
                ExibirEsconderBotoes(_btnsProdutos);
            }
            else
            {
                timer.Start();
                colunaExpandida = !colunaExpandida;
            }
        }
        private void btn_pdv_click(object sender, EventArgs e)
        {
            EsconderTodosBotoes();

            if (colunaExpandida)
            {
                ExibirEsconderBotoes(_btnsPontoVenda);
            }
            else
            {
                timer.Start();
                colunaExpandida = !colunaExpandida;
            }
        }

        private void btn_usuarios_click(object sender, EventArgs e)
        {
            EsconderTodosBotoes();

            if (colunaExpandida)
            {
                ExibirEsconderBotoes(_btnsUsuarios);
            }
            else
            {
                timer.Start();
                colunaExpandida = !colunaExpandida;
            }
        }
        #endregion



        #region Clicks SubMenu
        private void btnFormaPagamento_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Formas de Pagamento";
            //tblForms.BackColor = Color.Orange;
            FormaPagamentoCtrl ctr = new FormaPagamentoCtrl();
            ChamarControle(ctr);
            // this.Alert("Formas de Pagamento", FrmAlerta.enmType.Info);
        }
        #endregion
    }
}
