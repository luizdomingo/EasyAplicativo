using FontAwesome.Sharp;

namespace Easy.ApplicationDesk.Forms.Home
{
    public partial class FrmHome : Form
    {
        #region Menu Variaveis
        private bool colunaExpandida = true;
        private const int larguraInicial = 30;
        private const int larguraMaxima = 208;
        private const int incremento = 10;
        #endregion


        public FrmHome()
        {
            InitializeComponent();
            CriarListaBotoesProdutos();
            CriarListaBotoesUsuarios();
        }

        private List<IconButton> _btnsProdutos = new List<IconButton>();
        private List<IconButton> _btnsUsuarios = new List<IconButton>();


        private void EsconderTodosBotoes()
        {
            ExibirEsconderBotoes(_btnsProdutos, true);
            ExibirEsconderBotoes(_btnsUsuarios, true);
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


        private void AddGrupoBotoes(List<IconButton> lista, IconButton grupo)
        {
            lista.Add(grupo);
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

        #region MenuEventos


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Start();
                colunaExpandida = !colunaExpandida;
            }
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

        private void btnProdutos_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
