namespace Easy.ApplicationDesk.Forms.Home.Temp
{
    partial class BtnMnHome
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tblPrincipal = new TableLayoutPanel();
            pnlLed = new Panel();
            icon = new FontAwesome.Sharp.IconPictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblDescricao = new Label();
            lblTitulo = new Label();
            tblPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tblPrincipal
            // 
            tblPrincipal.ColumnCount = 3;
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPrincipal.Controls.Add(pnlLed, 0, 0);
            tblPrincipal.Controls.Add(icon, 1, 0);
            tblPrincipal.Controls.Add(tableLayoutPanel2, 2, 0);
            tblPrincipal.Dock = DockStyle.Fill;
            tblPrincipal.Location = new Point(0, 0);
            tblPrincipal.Name = "tblPrincipal";
            tblPrincipal.RowCount = 1;
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPrincipal.Size = new Size(340, 57);
            tblPrincipal.TabIndex = 0;
            // 
            // pnlLed
            // 
            pnlLed.BackColor = Color.SeaGreen;
            pnlLed.Cursor = Cursors.Hand;
            pnlLed.Dock = DockStyle.Fill;
            pnlLed.Location = new Point(0, 0);
            pnlLed.Margin = new Padding(0);
            pnlLed.Name = "pnlLed";
            pnlLed.Size = new Size(5, 57);
            pnlLed.TabIndex = 0;
            // 
            // icon
            // 
            icon.BackColor = Color.White;
            icon.Cursor = Cursors.Hand;
            icon.Dock = DockStyle.Fill;
            icon.ForeColor = Color.SeaGreen;
            icon.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            icon.IconColor = Color.SeaGreen;
            icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon.IconSize = 43;
            icon.Location = new Point(8, 3);
            icon.Name = "icon";
            icon.Size = new Size(43, 51);
            icon.SizeMode = PictureBoxSizeMode.CenterImage;
            icon.TabIndex = 1;
            icon.TabStop = false;
            icon.Click += lblTitulo_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(lblDescricao, 0, 1);
            tableLayoutPanel2.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(57, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(280, 51);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Cursor = Cursors.Hand;
            lblDescricao.Dock = DockStyle.Fill;
            lblDescricao.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = SystemColors.ControlDark;
            lblDescricao.Location = new Point(3, 25);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(274, 26);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Cadastrar produtos, tipos, preços, estoque entre outros.";
            lblDescricao.Click += lblDescricao_Click;
            lblDescricao.MouseEnter += btn_enter;
            lblDescricao.MouseLeave += btn_leave;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Cursor = Cursors.Hand;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(274, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Produtos";
            lblTitulo.TextAlign = ContentAlignment.BottomLeft;
            lblTitulo.Click += lblTitulo_Click;
            lblTitulo.MouseEnter += btn_enter;
            lblTitulo.MouseLeave += btn_leave;
            // 
            // BtnMnHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tblPrincipal);
            Name = "BtnMnHome";
            Size = new Size(340, 57);
            tblPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblPrincipal;
        private Panel pnlLed;
        private FontAwesome.Sharp.IconPictureBox icon;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblDescricao;
        private Label lblTitulo;
    }
}
