namespace Easy.ApplicationDesk.Forms.Home
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnMenu = new FontAwesome.Sharp.IconButton();
            lblHome = new Label();
            tblFormsMenus = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnMnPontoVenda = new Temp.BtnMnHome();
            btnFormaPagamento = new FontAwesome.Sharp.IconButton();
            btnMnUsuarios = new Temp.BtnMnHome();
            btnFuncoes = new FontAwesome.Sharp.IconButton();
            btnCadastrarUsuarios = new FontAwesome.Sharp.IconButton();
            btnMnProdutos = new Temp.BtnMnHome();
            btnMedida = new FontAwesome.Sharp.IconButton();
            btnPrecoProduto = new FontAwesome.Sharp.IconButton();
            btnCategoriaProduto = new FontAwesome.Sharp.IconButton();
            btnTipoProduto = new FontAwesome.Sharp.IconButton();
            tblForms = new TableLayoutPanel();
            pnlControles = new Panel();
            lblTitulo = new Label();
            timer = new System.Windows.Forms.Timer(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tblFormsMenus.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tblForms.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tblFormsMenus, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(847, 481);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.SlateBlue;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 277F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.Controls.Add(btnExit, 2, 0);
            tableLayoutPanel2.Controls.Add(btnMenu, 0, 0);
            tableLayoutPanel2.Controls.Add(lblHome, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(1);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(847, 30);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            btnExit.IconColor = Color.White;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 20;
            btnExit.Location = new Point(813, 1);
            btnExit.Margin = new Padding(0, 0, 1, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 28);
            btnExit.TabIndex = 4;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Dock = DockStyle.Fill;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Television;
            btnMenu.IconColor = Color.White;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 20;
            btnMenu.Location = new Point(1, 1);
            btnMenu.Margin = new Padding(0, 0, 1, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(276, 28);
            btnMenu.TabIndex = 3;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // lblHome
            // 
            lblHome.Dock = DockStyle.Fill;
            lblHome.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(281, 1);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(529, 28);
            lblHome.TabIndex = 4;
            lblHome.Text = "Easy Cashier App Desktop";
            lblHome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblFormsMenus
            // 
            tblFormsMenus.ColumnCount = 2;
            tblFormsMenus.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 274F));
            tblFormsMenus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFormsMenus.Controls.Add(flowLayoutPanel1, 0, 0);
            tblFormsMenus.Controls.Add(tblForms, 1, 0);
            tblFormsMenus.Dock = DockStyle.Fill;
            tblFormsMenus.Location = new Point(3, 33);
            tblFormsMenus.Name = "tblFormsMenus";
            tblFormsMenus.RowCount = 1;
            tblFormsMenus.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblFormsMenus.Size = new Size(841, 445);
            tblFormsMenus.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(btnMnPontoVenda);
            flowLayoutPanel1.Controls.Add(btnFormaPagamento);
            flowLayoutPanel1.Controls.Add(btnMnUsuarios);
            flowLayoutPanel1.Controls.Add(btnFuncoes);
            flowLayoutPanel1.Controls.Add(btnCadastrarUsuarios);
            flowLayoutPanel1.Controls.Add(btnMnProdutos);
            flowLayoutPanel1.Controls.Add(btnMedida);
            flowLayoutPanel1.Controls.Add(btnPrecoProduto);
            flowLayoutPanel1.Controls.Add(btnCategoriaProduto);
            flowLayoutPanel1.Controls.Add(btnTipoProduto);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(274, 445);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnMnPontoVenda
            // 
            btnMnPontoVenda.BackColor = Color.White;
            btnMnPontoVenda.CorIconeLed = Color.Orange;
            btnMnPontoVenda.Descricao = "Realize sua vendas de forma simples. Gerencie e imprima seus relatórios";
            btnMnPontoVenda.IconCharBtn = FontAwesome.Sharp.IconChar.LaptopHouse;
            btnMnPontoVenda.Location = new Point(3, 3);
            btnMnPontoVenda.Name = "btnMnPontoVenda";
            btnMnPontoVenda.Size = new Size(272, 61);
            btnMnPontoVenda.TabIndex = 11;
            btnMnPontoVenda.Titulo = "Ponto de Venda";
            // 
            // btnFormaPagamento
            // 
            btnFormaPagamento.Cursor = Cursors.Hand;
            btnFormaPagamento.FlatAppearance.BorderSize = 0;
            btnFormaPagamento.FlatStyle = FlatStyle.Flat;
            btnFormaPagamento.ForeColor = Color.Orange;
            btnFormaPagamento.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnFormaPagamento.IconColor = Color.Orange;
            btnFormaPagamento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFormaPagamento.IconSize = 15;
            btnFormaPagamento.ImageAlign = ContentAlignment.MiddleRight;
            btnFormaPagamento.Location = new Point(0, 67);
            btnFormaPagamento.Margin = new Padding(0, 0, 2, 0);
            btnFormaPagamento.Name = "btnFormaPagamento";
            btnFormaPagamento.Size = new Size(272, 30);
            btnFormaPagamento.TabIndex = 10;
            btnFormaPagamento.Text = "Formas de Pagamento";
            btnFormaPagamento.TextAlign = ContentAlignment.MiddleRight;
            btnFormaPagamento.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFormaPagamento.UseVisualStyleBackColor = true;
            btnFormaPagamento.Visible = false;
            btnFormaPagamento.Click += btnFormaPagamento_Click;
            btnFormaPagamento.MouseEnter += btn_mouse_enter;
            btnFormaPagamento.MouseLeave += btn_mouse_leave;
            // 
            // btnMnUsuarios
            // 
            btnMnUsuarios.BackColor = Color.White;
            btnMnUsuarios.CorIconeLed = Color.RoyalBlue;
            btnMnUsuarios.Descricao = "Cadastre usuarios, crie permissões de acordo com suas necessidades.";
            btnMnUsuarios.IconCharBtn = FontAwesome.Sharp.IconChar.ClipboardUser;
            btnMnUsuarios.Location = new Point(3, 100);
            btnMnUsuarios.Name = "btnMnUsuarios";
            btnMnUsuarios.Size = new Size(272, 61);
            btnMnUsuarios.TabIndex = 13;
            btnMnUsuarios.Titulo = "Usuários";
            // 
            // btnFuncoes
            // 
            btnFuncoes.Cursor = Cursors.Hand;
            btnFuncoes.FlatAppearance.BorderSize = 0;
            btnFuncoes.FlatStyle = FlatStyle.Flat;
            btnFuncoes.ForeColor = Color.RoyalBlue;
            btnFuncoes.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            btnFuncoes.IconColor = Color.RoyalBlue;
            btnFuncoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFuncoes.IconSize = 15;
            btnFuncoes.ImageAlign = ContentAlignment.MiddleRight;
            btnFuncoes.Location = new Point(0, 164);
            btnFuncoes.Margin = new Padding(0, 0, 2, 0);
            btnFuncoes.Name = "btnFuncoes";
            btnFuncoes.Size = new Size(272, 30);
            btnFuncoes.TabIndex = 8;
            btnFuncoes.Text = "Funções";
            btnFuncoes.TextAlign = ContentAlignment.MiddleRight;
            btnFuncoes.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFuncoes.UseVisualStyleBackColor = true;
            btnFuncoes.Visible = false;
            btnFuncoes.Click += btn_Click;
            btnFuncoes.MouseEnter += btn_mouse_enter;
            btnFuncoes.MouseLeave += btn_mouse_leave;
            // 
            // btnCadastrarUsuarios
            // 
            btnCadastrarUsuarios.Cursor = Cursors.Hand;
            btnCadastrarUsuarios.FlatAppearance.BorderSize = 0;
            btnCadastrarUsuarios.FlatStyle = FlatStyle.Flat;
            btnCadastrarUsuarios.ForeColor = Color.RoyalBlue;
            btnCadastrarUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnCadastrarUsuarios.IconColor = Color.RoyalBlue;
            btnCadastrarUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadastrarUsuarios.IconSize = 15;
            btnCadastrarUsuarios.ImageAlign = ContentAlignment.MiddleRight;
            btnCadastrarUsuarios.Location = new Point(0, 194);
            btnCadastrarUsuarios.Margin = new Padding(0, 0, 2, 0);
            btnCadastrarUsuarios.Name = "btnCadastrarUsuarios";
            btnCadastrarUsuarios.Size = new Size(272, 30);
            btnCadastrarUsuarios.TabIndex = 7;
            btnCadastrarUsuarios.Text = "Cadastrar";
            btnCadastrarUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrarUsuarios.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCadastrarUsuarios.UseVisualStyleBackColor = true;
            btnCadastrarUsuarios.Visible = false;
            btnCadastrarUsuarios.Click += btn_Click;
            btnCadastrarUsuarios.MouseEnter += btn_mouse_enter;
            btnCadastrarUsuarios.MouseLeave += btn_mouse_leave;
            // 
            // btnMnProdutos
            // 
            btnMnProdutos.BackColor = Color.White;
            btnMnProdutos.CorIconeLed = Color.Teal;
            btnMnProdutos.Descricao = "Cadastro de produtos, preços, categorias, entre outros";
            btnMnProdutos.IconCharBtn = FontAwesome.Sharp.IconChar.CartPlus;
            btnMnProdutos.Location = new Point(3, 227);
            btnMnProdutos.Name = "btnMnProdutos";
            btnMnProdutos.Size = new Size(272, 61);
            btnMnProdutos.TabIndex = 12;
            btnMnProdutos.Titulo = "Produtos";
            btnMnProdutos.Click += btn_produto_click;
            // 
            // btnMedida
            // 
            btnMedida.Cursor = Cursors.Hand;
            btnMedida.FlatAppearance.BorderSize = 0;
            btnMedida.FlatStyle = FlatStyle.Flat;
            btnMedida.ForeColor = Color.Teal;
            btnMedida.IconChar = FontAwesome.Sharp.IconChar.RulerHorizontal;
            btnMedida.IconColor = Color.Teal;
            btnMedida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMedida.IconSize = 15;
            btnMedida.ImageAlign = ContentAlignment.MiddleRight;
            btnMedida.Location = new Point(0, 291);
            btnMedida.Margin = new Padding(0, 0, 2, 0);
            btnMedida.Name = "btnMedida";
            btnMedida.Size = new Size(272, 30);
            btnMedida.TabIndex = 6;
            btnMedida.Text = "Unidades de Medida";
            btnMedida.TextAlign = ContentAlignment.MiddleRight;
            btnMedida.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMedida.UseVisualStyleBackColor = true;
            btnMedida.Visible = false;
            btnMedida.Click += btn_Click;
            btnMedida.MouseEnter += btn_mouse_enter;
            btnMedida.MouseLeave += btn_mouse_leave;
            // 
            // btnPrecoProduto
            // 
            btnPrecoProduto.Cursor = Cursors.Hand;
            btnPrecoProduto.FlatAppearance.BorderSize = 0;
            btnPrecoProduto.FlatStyle = FlatStyle.Flat;
            btnPrecoProduto.ForeColor = Color.Teal;
            btnPrecoProduto.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnPrecoProduto.IconColor = Color.Teal;
            btnPrecoProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrecoProduto.IconSize = 15;
            btnPrecoProduto.ImageAlign = ContentAlignment.MiddleRight;
            btnPrecoProduto.Location = new Point(0, 321);
            btnPrecoProduto.Margin = new Padding(0, 0, 2, 0);
            btnPrecoProduto.Name = "btnPrecoProduto";
            btnPrecoProduto.Size = new Size(272, 30);
            btnPrecoProduto.TabIndex = 5;
            btnPrecoProduto.Text = "Preços dos Produtos";
            btnPrecoProduto.TextAlign = ContentAlignment.MiddleRight;
            btnPrecoProduto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrecoProduto.UseVisualStyleBackColor = true;
            btnPrecoProduto.Visible = false;
            btnPrecoProduto.Click += btn_Click;
            btnPrecoProduto.MouseEnter += btn_mouse_enter;
            btnPrecoProduto.MouseLeave += btn_mouse_leave;
            // 
            // btnCategoriaProduto
            // 
            btnCategoriaProduto.Cursor = Cursors.Hand;
            btnCategoriaProduto.FlatAppearance.BorderSize = 0;
            btnCategoriaProduto.FlatStyle = FlatStyle.Flat;
            flowLayoutPanel1.SetFlowBreak(btnCategoriaProduto, true);
            btnCategoriaProduto.ForeColor = Color.Teal;
            btnCategoriaProduto.IconChar = FontAwesome.Sharp.IconChar.List12;
            btnCategoriaProduto.IconColor = Color.Teal;
            btnCategoriaProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategoriaProduto.IconSize = 15;
            btnCategoriaProduto.ImageAlign = ContentAlignment.MiddleRight;
            btnCategoriaProduto.Location = new Point(0, 351);
            btnCategoriaProduto.Margin = new Padding(0, 0, 2, 0);
            btnCategoriaProduto.Name = "btnCategoriaProduto";
            btnCategoriaProduto.Size = new Size(272, 30);
            btnCategoriaProduto.TabIndex = 4;
            btnCategoriaProduto.Text = "Categoria dos Produtos";
            btnCategoriaProduto.TextAlign = ContentAlignment.MiddleRight;
            btnCategoriaProduto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCategoriaProduto.UseVisualStyleBackColor = false;
            btnCategoriaProduto.Visible = false;
            btnCategoriaProduto.Click += btn_Click;
            btnCategoriaProduto.MouseEnter += btn_mouse_enter;
            btnCategoriaProduto.MouseLeave += btn_mouse_leave;
            // 
            // btnTipoProduto
            // 
            btnTipoProduto.BackColor = Color.White;
            btnTipoProduto.Cursor = Cursors.Hand;
            btnTipoProduto.FlatAppearance.BorderSize = 0;
            btnTipoProduto.FlatStyle = FlatStyle.Flat;
            btnTipoProduto.Font = new Font("Segoe UI", 9F);
            btnTipoProduto.ForeColor = Color.Teal;
            btnTipoProduto.IconChar = FontAwesome.Sharp.IconChar.LandMineOn;
            btnTipoProduto.IconColor = Color.Teal;
            btnTipoProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTipoProduto.IconSize = 15;
            btnTipoProduto.ImageAlign = ContentAlignment.MiddleRight;
            btnTipoProduto.Location = new Point(0, 381);
            btnTipoProduto.Margin = new Padding(0, 0, 2, 0);
            btnTipoProduto.Name = "btnTipoProduto";
            btnTipoProduto.Size = new Size(272, 30);
            btnTipoProduto.TabIndex = 3;
            btnTipoProduto.Text = "Tipos de Produto";
            btnTipoProduto.TextAlign = ContentAlignment.MiddleRight;
            btnTipoProduto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnTipoProduto.UseVisualStyleBackColor = false;
            btnTipoProduto.Visible = false;
            btnTipoProduto.Click += btn_Click;
            btnTipoProduto.MouseEnter += btn_mouse_enter;
            btnTipoProduto.MouseLeave += btn_mouse_leave;
            // 
            // tblForms
            // 
            tblForms.BackColor = Color.SlateGray;
            tblForms.ColumnCount = 1;
            tblForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblForms.Controls.Add(pnlControles, 0, 1);
            tblForms.Controls.Add(lblTitulo, 0, 0);
            tblForms.Dock = DockStyle.Fill;
            tblForms.Location = new Point(274, 0);
            tblForms.Margin = new Padding(0);
            tblForms.Name = "tblForms";
            tblForms.RowCount = 2;
            tblForms.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblForms.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblForms.Size = new Size(567, 445);
            tblForms.TabIndex = 1;
            // 
            // pnlControles
            // 
            pnlControles.BackColor = Color.Lavender;
            pnlControles.Dock = DockStyle.Fill;
            pnlControles.Location = new Point(3, 30);
            pnlControles.Name = "pnlControles";
            pnlControles.Size = new Size(561, 412);
            pnlControles.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonFace;
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(561, 27);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Seja bem vindo!";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            timer.Interval = 10;
            timer.Tick += timer1_Tick;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.ShadowColor = Color.MidnightBlue;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(110, 117, 122);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(847, 481);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHome";
            WindowState = FormWindowState.Maximized;
            Load += FrmHome_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tblFormsMenus.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tblForms.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Label lblHome;
        private TableLayoutPanel tblFormsMenus;
        private FontAwesome.Sharp.IconButton btnExit;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer;
        private FontAwesome.Sharp.IconButton btnTipoProduto;
        private FontAwesome.Sharp.IconButton btnCategoriaProduto;
        private FontAwesome.Sharp.IconButton btnPrecoProduto;
        private FontAwesome.Sharp.IconButton btnMedida;
        private FontAwesome.Sharp.IconButton btnCadastrarUsuarios;
        private FontAwesome.Sharp.IconButton btnFuncoes;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private TableLayoutPanel tblForms;
        private FontAwesome.Sharp.IconButton btnFormaPagamento;
        private Temp.BtnMnHome btnMnPontoVenda;
        private Temp.BtnMnHome btnMnProdutos;
        private Temp.BtnMnHome btnMnUsuarios;
        private Panel pnlControles;
        private Label lblTitulo;
    }
}