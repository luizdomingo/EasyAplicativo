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
            lblTitulo = new Label();
            tblFormsMenus = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnProdutos = new FontAwesome.Sharp.IconButton();
            btnTipoProduto = new FontAwesome.Sharp.IconButton();
            btnCategoriaProduto = new FontAwesome.Sharp.IconButton();
            btnPrecoProduto = new FontAwesome.Sharp.IconButton();
            btnMedida = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnCadastrarUsuarios = new FontAwesome.Sharp.IconButton();
            btnFuncoes = new FontAwesome.Sharp.IconButton();
            timer = new System.Windows.Forms.Timer(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tblFormsMenus.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tblFormsMenus, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(764, 398);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(128, 128, 255);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.Controls.Add(btnExit, 2, 0);
            tableLayoutPanel2.Controls.Add(btnMenu, 0, 0);
            tableLayoutPanel2.Controls.Add(lblTitulo, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(1);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(764, 30);
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
            btnExit.Location = new Point(730, 1);
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
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Television;
            btnMenu.IconColor = Color.White;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 20;
            btnMenu.Location = new Point(1, 1);
            btnMenu.Margin = new Padding(0, 0, 1, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(209, 28);
            btnMenu.TabIndex = 3;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(214, 1);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(513, 28);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Easy Cashier App Desktop";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblFormsMenus
            // 
            tblFormsMenus.ColumnCount = 2;
            tblFormsMenus.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 208F));
            tblFormsMenus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFormsMenus.Controls.Add(flowLayoutPanel1, 0, 0);
            tblFormsMenus.Dock = DockStyle.Fill;
            tblFormsMenus.Location = new Point(3, 33);
            tblFormsMenus.Name = "tblFormsMenus";
            tblFormsMenus.RowCount = 1;
            tblFormsMenus.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblFormsMenus.Size = new Size(758, 328);
            tblFormsMenus.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.Controls.Add(btnProdutos);
            flowLayoutPanel1.Controls.Add(btnTipoProduto);
            flowLayoutPanel1.Controls.Add(btnCategoriaProduto);
            flowLayoutPanel1.Controls.Add(btnPrecoProduto);
            flowLayoutPanel1.Controls.Add(btnMedida);
            flowLayoutPanel1.Controls.Add(btnUsuarios);
            flowLayoutPanel1.Controls.Add(btnCadastrarUsuarios);
            flowLayoutPanel1.Controls.Add(btnFuncoes);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(208, 328);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.FromArgb(128, 128, 255);
            btnProdutos.Cursor = Cursors.Hand;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnProdutos.ForeColor = SystemColors.Window;
            btnProdutos.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            btnProdutos.IconColor = Color.White;
            btnProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProdutos.IconSize = 25;
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(0, 0);
            btnProdutos.Margin = new Padding(0, 0, 2, 0);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(205, 31);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Produtos";
            btnProdutos.TextAlign = ContentAlignment.MiddleLeft;
            btnProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnTipoProduto
            // 
            btnTipoProduto.Cursor = Cursors.Hand;
            btnTipoProduto.FlatAppearance.BorderSize = 0;
            btnTipoProduto.FlatStyle = FlatStyle.Flat;
            btnTipoProduto.ForeColor = Color.FromArgb(128, 128, 255);
            btnTipoProduto.IconChar = FontAwesome.Sharp.IconChar.LandMineOn;
            btnTipoProduto.IconColor = Color.FromArgb(128, 128, 255);
            btnTipoProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTipoProduto.IconSize = 25;
            btnTipoProduto.ImageAlign = ContentAlignment.MiddleRight;
            btnTipoProduto.Location = new Point(0, 31);
            btnTipoProduto.Margin = new Padding(0, 0, 2, 0);
            btnTipoProduto.Name = "btnTipoProduto";
            btnTipoProduto.Size = new Size(205, 33);
            btnTipoProduto.TabIndex = 3;
            btnTipoProduto.Text = "Tipos";
            btnTipoProduto.TextAlign = ContentAlignment.MiddleRight;
            btnTipoProduto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnTipoProduto.UseVisualStyleBackColor = true;
            btnTipoProduto.Visible = false;
            // 
            // btnCategoriaProduto
            // 
            btnCategoriaProduto.Cursor = Cursors.Hand;
            btnCategoriaProduto.FlatAppearance.BorderSize = 0;
            btnCategoriaProduto.FlatStyle = FlatStyle.Flat;
            btnCategoriaProduto.ForeColor = Color.FromArgb(128, 128, 255);
            btnCategoriaProduto.IconChar = FontAwesome.Sharp.IconChar.List12;
            btnCategoriaProduto.IconColor = Color.FromArgb(128, 128, 255);
            btnCategoriaProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategoriaProduto.IconSize = 25;
            btnCategoriaProduto.ImageAlign = ContentAlignment.MiddleRight;
            btnCategoriaProduto.Location = new Point(0, 64);
            btnCategoriaProduto.Margin = new Padding(0, 0, 2, 0);
            btnCategoriaProduto.Name = "btnCategoriaProduto";
            btnCategoriaProduto.Size = new Size(205, 33);
            btnCategoriaProduto.TabIndex = 4;
            btnCategoriaProduto.Text = "Categorias";
            btnCategoriaProduto.TextAlign = ContentAlignment.MiddleRight;
            btnCategoriaProduto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCategoriaProduto.UseVisualStyleBackColor = true;
            btnCategoriaProduto.Visible = false;
            // 
            // btnPrecoProduto
            // 
            btnPrecoProduto.Cursor = Cursors.Hand;
            btnPrecoProduto.FlatAppearance.BorderSize = 0;
            btnPrecoProduto.FlatStyle = FlatStyle.Flat;
            btnPrecoProduto.ForeColor = Color.FromArgb(128, 128, 255);
            btnPrecoProduto.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnPrecoProduto.IconColor = Color.FromArgb(128, 128, 255);
            btnPrecoProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrecoProduto.IconSize = 25;
            btnPrecoProduto.ImageAlign = ContentAlignment.MiddleRight;
            btnPrecoProduto.Location = new Point(0, 97);
            btnPrecoProduto.Margin = new Padding(0, 0, 2, 0);
            btnPrecoProduto.Name = "btnPrecoProduto";
            btnPrecoProduto.Size = new Size(205, 33);
            btnPrecoProduto.TabIndex = 5;
            btnPrecoProduto.Text = "Preços dos Produtos";
            btnPrecoProduto.TextAlign = ContentAlignment.MiddleRight;
            btnPrecoProduto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrecoProduto.UseVisualStyleBackColor = true;
            btnPrecoProduto.Visible = false;
            // 
            // btnMedida
            // 
            btnMedida.Cursor = Cursors.Hand;
            btnMedida.FlatAppearance.BorderSize = 0;
            btnMedida.FlatStyle = FlatStyle.Flat;
            btnMedida.ForeColor = Color.FromArgb(128, 128, 255);
            btnMedida.IconChar = FontAwesome.Sharp.IconChar.RulerHorizontal;
            btnMedida.IconColor = Color.FromArgb(128, 128, 255);
            btnMedida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMedida.IconSize = 25;
            btnMedida.ImageAlign = ContentAlignment.MiddleRight;
            btnMedida.Location = new Point(0, 130);
            btnMedida.Margin = new Padding(0, 0, 2, 0);
            btnMedida.Name = "btnMedida";
            btnMedida.Size = new Size(205, 33);
            btnMedida.TabIndex = 6;
            btnMedida.Text = "Medidas";
            btnMedida.TextAlign = ContentAlignment.MiddleRight;
            btnMedida.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMedida.UseVisualStyleBackColor = true;
            btnMedida.Visible = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(128, 128, 255);
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnUsuarios.ForeColor = SystemColors.Window;
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUsuarios.IconColor = Color.White;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 25;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 163);
            btnUsuarios.Margin = new Padding(0, 0, 2, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(205, 31);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCadastrarUsuarios
            // 
            btnCadastrarUsuarios.Cursor = Cursors.Hand;
            btnCadastrarUsuarios.FlatAppearance.BorderSize = 0;
            btnCadastrarUsuarios.FlatStyle = FlatStyle.Flat;
            btnCadastrarUsuarios.ForeColor = Color.FromArgb(128, 128, 255);
            btnCadastrarUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnCadastrarUsuarios.IconColor = Color.FromArgb(128, 128, 255);
            btnCadastrarUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadastrarUsuarios.IconSize = 25;
            btnCadastrarUsuarios.ImageAlign = ContentAlignment.MiddleRight;
            btnCadastrarUsuarios.Location = new Point(0, 194);
            btnCadastrarUsuarios.Margin = new Padding(0, 0, 2, 0);
            btnCadastrarUsuarios.Name = "btnCadastrarUsuarios";
            btnCadastrarUsuarios.Size = new Size(205, 33);
            btnCadastrarUsuarios.TabIndex = 7;
            btnCadastrarUsuarios.Text = "Cadastrar";
            btnCadastrarUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrarUsuarios.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCadastrarUsuarios.UseVisualStyleBackColor = true;
            btnCadastrarUsuarios.Visible = false;
            // 
            // btnFuncoes
            // 
            btnFuncoes.Cursor = Cursors.Hand;
            btnFuncoes.FlatAppearance.BorderSize = 0;
            btnFuncoes.FlatStyle = FlatStyle.Flat;
            btnFuncoes.ForeColor = Color.FromArgb(128, 128, 255);
            btnFuncoes.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            btnFuncoes.IconColor = Color.FromArgb(128, 128, 255);
            btnFuncoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFuncoes.IconSize = 25;
            btnFuncoes.ImageAlign = ContentAlignment.MiddleRight;
            btnFuncoes.Location = new Point(0, 227);
            btnFuncoes.Margin = new Padding(0, 0, 2, 0);
            btnFuncoes.Name = "btnFuncoes";
            btnFuncoes.Size = new Size(205, 33);
            btnFuncoes.TabIndex = 8;
            btnFuncoes.Text = "Funções";
            btnFuncoes.TextAlign = ContentAlignment.MiddleRight;
            btnFuncoes.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFuncoes.UseVisualStyleBackColor = true;
            btnFuncoes.Visible = false;
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
            ClientSize = new Size(764, 398);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHome";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tblFormsMenus.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Label lblTitulo;
        private TableLayoutPanel tblFormsMenus;
        private FontAwesome.Sharp.IconButton btnExit;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnProdutos;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Timer timer;
        private FontAwesome.Sharp.IconButton btnTipoProduto;
        private FontAwesome.Sharp.IconButton btnCategoriaProduto;
        private FontAwesome.Sharp.IconButton btnPrecoProduto;
        private FontAwesome.Sharp.IconButton btnMedida;
        private FontAwesome.Sharp.IconButton btnCadastrarUsuarios;
        private FontAwesome.Sharp.IconButton btnFuncoes;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}