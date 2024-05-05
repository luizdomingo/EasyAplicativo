using FontAwesome.Sharp;

namespace Easy.ApplicationDesk.Forms.Home.Temp
{
    public partial class BtnMnHome : UserControl
    {
        private string _titulo;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; lblTitulo.Text = value; }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; lblDescricao.Text = value; }
        }

        private Color _corIconeLed;

        public Color CorIconeLed
        {
            get { return _corIconeLed; }
            set
            {
                _corIconeLed = value;

                icon.IconColor = value;
                pnlLed.BackColor = value;
                lblTitulo.ForeColor = value;
            }
        }

        private IconChar _iconChar;

        public IconChar IconCharBtn
        {
            get { return _iconChar; }
            set
            {
                _iconChar = value;
                icon.IconChar = value;
            }
        }
        public BtnMnHome()
        {
            InitializeComponent();
        }

        public event EventHandler ClickCustomEvent;
        private void BtnMnHome_MouseClick(object sender, MouseEventArgs e)
        {
            // Verifica se o evento personalizado não é nulo e o dispara
            ClickCustomEvent?.Invoke(this, EventArgs.Empty);
        }
        private void lblTitulo_Click(object sender, EventArgs e)
        {
            ClickCustomEvent?.Invoke(this, EventArgs.Empty);
        }

        private void lblDescricao_Click(object sender, EventArgs e)
        {
            ClickCustomEvent?.Invoke(this, EventArgs.Empty);
        }

        private void mouseEnter(TableLayoutPanel tbl)
        {
            tbl.ColumnStyles[0].Width = 20;
        }

        private void mouseLeave(TableLayoutPanel tbl)
        {
            tbl.ColumnStyles[0].Width = 5;
        }


        private void btn_enter(object bt, EventArgs e)
        {
            mouseEnter(tblPrincipal);
        }

        private void btn_leave(object bt, EventArgs e)
        {
            mouseLeave(tblPrincipal);
        }

       
    }
}
