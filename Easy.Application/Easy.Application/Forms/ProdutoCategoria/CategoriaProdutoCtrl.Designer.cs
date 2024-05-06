namespace Easy.ApplicationDesk.Forms.Produtos
{
    partial class CategoriaProdutoCtrl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnManter = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtCategoriaProduto = new Guna.UI2.WinForms.Guna2TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            dtgvPrincipal = new Guna.UI2.WinForms.Guna2DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Habilitado = new DataGridViewCheckBoxColumn();
            DescricaoCategoria = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPrincipal).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(824, 429);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 168F));
            tableLayoutPanel2.Controls.Add(btnManter, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtCategoriaProduto, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(4);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(818, 49);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnManter
            // 
            btnManter.BackColor = Color.MediumSeaGreen;
            btnManter.Cursor = Cursors.Hand;
            btnManter.Dock = DockStyle.Fill;
            btnManter.FlatAppearance.BorderSize = 0;
            btnManter.FlatStyle = FlatStyle.Flat;
            btnManter.ForeColor = Color.White;
            btnManter.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnManter.IconColor = Color.White;
            btnManter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnManter.IconSize = 20;
            btnManter.ImageAlign = ContentAlignment.MiddleRight;
            btnManter.Location = new Point(650, 8);
            btnManter.Margin = new Padding(4);
            btnManter.Name = "btnManter";
            btnManter.Size = new Size(160, 33);
            btnManter.TabIndex = 11;
            btnManter.Text = "cadastrar";
            btnManter.TextAlign = ContentAlignment.MiddleLeft;
            btnManter.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnManter.UseVisualStyleBackColor = false;
            btnManter.Click += btnManter_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(7, 4);
            label1.Name = "label1";
            label1.Size = new Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCategoriaProduto
            // 
            txtCategoriaProduto.CustomizableEdges = customizableEdges1;
            txtCategoriaProduto.DefaultText = "";
            txtCategoriaProduto.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCategoriaProduto.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCategoriaProduto.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCategoriaProduto.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCategoriaProduto.Dock = DockStyle.Fill;
            txtCategoriaProduto.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoriaProduto.Font = new Font("Segoe UI", 9F);
            txtCategoriaProduto.ForeColor = Color.Teal;
            txtCategoriaProduto.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoriaProduto.Location = new Point(147, 7);
            txtCategoriaProduto.Name = "txtCategoriaProduto";
            txtCategoriaProduto.PasswordChar = '\0';
            txtCategoriaProduto.PlaceholderForeColor = Color.Teal;
            txtCategoriaProduto.PlaceholderText = "informe a categoria do produto";
            txtCategoriaProduto.SelectedText = "";
            txtCategoriaProduto.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtCategoriaProduto.Size = new Size(496, 35);
            txtCategoriaProduto.TabIndex = 1;
            txtCategoriaProduto.TextChanged += txtFormaPagamento_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dtgvPrincipal, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(6, 55);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 96.83544F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 3.164557F));
            tableLayoutPanel3.Size = new Size(812, 368);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // dtgvPrincipal
            // 
            dtgvPrincipal.AllowUserToAddRows = false;
            dtgvPrincipal.AllowUserToDeleteRows = false;
            dtgvPrincipal.AllowUserToResizeColumns = false;
            dtgvPrincipal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dtgvPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvPrincipal.ColumnHeadersHeight = 17;
            dtgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgvPrincipal.Columns.AddRange(new DataGridViewColumn[] { Id, Habilitado, DescricaoCategoria });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtgvPrincipal.DefaultCellStyle = dataGridViewCellStyle4;
            dtgvPrincipal.Dock = DockStyle.Fill;
            dtgvPrincipal.GridColor = Color.FromArgb(231, 229, 255);
            dtgvPrincipal.Location = new Point(3, 3);
            dtgvPrincipal.MultiSelect = false;
            dtgvPrincipal.Name = "dtgvPrincipal";
            dtgvPrincipal.RowHeadersVisible = false;
            dtgvPrincipal.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgvPrincipal.Size = new Size(806, 350);
            dtgvPrincipal.TabIndex = 0;
            dtgvPrincipal.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dtgvPrincipal.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgvPrincipal.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dtgvPrincipal.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dtgvPrincipal.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dtgvPrincipal.ThemeStyle.BackColor = Color.White;
            dtgvPrincipal.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dtgvPrincipal.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dtgvPrincipal.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgvPrincipal.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dtgvPrincipal.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dtgvPrincipal.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgvPrincipal.ThemeStyle.HeaderStyle.Height = 17;
            dtgvPrincipal.ThemeStyle.ReadOnly = false;
            dtgvPrincipal.ThemeStyle.RowsStyle.BackColor = Color.White;
            dtgvPrincipal.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvPrincipal.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dtgvPrincipal.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dtgvPrincipal.ThemeStyle.RowsStyle.Height = 25;
            dtgvPrincipal.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dtgvPrincipal.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dtgvPrincipal.CellEndEdit += dtgvPrincipal_CellEndEdit;
            dtgvPrincipal.CellFormatting += dtgvPrincipal_CellFormatting;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Id.DefaultCellStyle = dataGridViewCellStyle3;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Habilitado
            // 
            Habilitado.DataPropertyName = "Habilitado";
            Habilitado.FillWeight = 101.522842F;
            Habilitado.HeaderText = "Ativo";
            Habilitado.Name = "Habilitado";
            Habilitado.ReadOnly = true;
            // 
            // DescricaoCategoria
            // 
            DescricaoCategoria.DataPropertyName = "DescricaoCategoria";
            DescricaoCategoria.HeaderText = "Categoria";
            DescricaoCategoria.Name = "DescricaoCategoria";
            // 
            // CategoriaProdutoCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CategoriaProdutoCtrl";
            Size = new Size(824, 429);
            Load += CategoriaProdutoCtrl_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btnManter;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoriaProduto;
        private TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvPrincipal;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewCheckBoxColumn Habilitado;
        private DataGridViewTextBoxColumn DescricaoCategoria;
    }
}
