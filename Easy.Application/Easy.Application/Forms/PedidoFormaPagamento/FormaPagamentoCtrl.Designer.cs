namespace Easy.ApplicationDesk.Forms.PedidoFormaPagamento
{
    partial class FormaPagamentoCtrl
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnManter = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtFormaPagamento = new Guna.UI2.WinForms.Guna2TextBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Habilitado = new DataGridViewCheckBoxColumn();
            DescricaoFormaPg = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(guna2DataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(579, 307);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel2.Controls.Add(btnManter, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtFormaPagamento, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(4);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(573, 49);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnManter
            // 
            btnManter.BackColor = Color.SeaGreen;
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
            btnManter.Location = new Point(468, 8);
            btnManter.Margin = new Padding(4);
            btnManter.Name = "btnManter";
            btnManter.Size = new Size(97, 33);
            btnManter.TabIndex = 11;
            btnManter.Text = "cadastrar";
            btnManter.TextAlign = ContentAlignment.MiddleRight;
            btnManter.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnManter.UseVisualStyleBackColor = false;
            btnManter.Click += btnManter_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(7, 4);
            label1.Name = "label1";
            label1.Size = new Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Forma de Pagamento";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFormaPagamento
            // 
            txtFormaPagamento.CustomizableEdges = customizableEdges1;
            txtFormaPagamento.DefaultText = "";
            txtFormaPagamento.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFormaPagamento.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFormaPagamento.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFormaPagamento.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFormaPagamento.Dock = DockStyle.Fill;
            txtFormaPagamento.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFormaPagamento.Font = new Font("Segoe UI", 9F);
            txtFormaPagamento.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFormaPagamento.Location = new Point(147, 7);
            txtFormaPagamento.Name = "txtFormaPagamento";
            txtFormaPagamento.PasswordChar = '\0';
            txtFormaPagamento.PlaceholderForeColor = Color.FromArgb(128, 128, 255);
            txtFormaPagamento.PlaceholderText = "digite forma de pagamento";
            txtFormaPagamento.SelectedText = "";
            txtFormaPagamento.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtFormaPagamento.Size = new Size(314, 35);
            txtFormaPagamento.TabIndex = 1;
            txtFormaPagamento.TextChanged += txtFormaPagamento_TextChanged;
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            guna2DataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 20;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Habilitado, DescricaoFormaPg });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.Dock = DockStyle.Fill;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(6, 55);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.ScrollBars = ScrollBars.Horizontal;
            guna2DataGridView1.Size = new Size(567, 246);
            guna2DataGridView1.TabIndex = 1;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 20;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellFormatting += dtgv_CellFormatting;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 68.43329F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Habilitado
            // 
            Habilitado.DataPropertyName = "Habilitado";
            Habilitado.FillWeight = 104.766441F;
            Habilitado.HeaderText = "Ativo";
            Habilitado.Name = "Habilitado";
            Habilitado.Resizable = DataGridViewTriState.True;
            Habilitado.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // DescricaoFormaPg
            // 
            DescricaoFormaPg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DescricaoFormaPg.DataPropertyName = "DescricaoFormaPg";
            DescricaoFormaPg.FillWeight = 178.556412F;
            DescricaoFormaPg.HeaderText = "Forma";
            DescricaoFormaPg.Name = "DescricaoFormaPg";
            // 
            // FormaPagamentoCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(tableLayoutPanel1);
            Name = "FormaPagamentoCtrl";
            Padding = new Padding(10);
            Size = new Size(599, 327);
            Load += FormPagamentoCtrl_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFormaPagamento;
        private FontAwesome.Sharp.IconButton btnManter;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewCheckBoxColumn Habilitado;
        private DataGridViewTextBoxColumn DescricaoFormaPg;
    }
}
