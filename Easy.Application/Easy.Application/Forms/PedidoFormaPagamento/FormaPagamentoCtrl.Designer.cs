﻿namespace Easy.ApplicationDesk.Forms.PedidoFormaPagamento
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnManter = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtFormaPagamento = new Guna.UI2.WinForms.Guna2TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            dtgvPrincipal = new Guna.UI2.WinForms.Guna2DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Habilitado = new DataGridViewCheckBoxColumn();
            DescricaoFormaPg = new DataGridViewTextBoxColumn();
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
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(772, 377);
            tableLayoutPanel1.TabIndex = 0;
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
            tableLayoutPanel2.Controls.Add(txtFormaPagamento, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(4);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(766, 49);
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
            btnManter.Location = new Point(598, 8);
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
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(7, 4);
            label1.Name = "label1";
            label1.Size = new Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Forma de Pagamento";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFormaPagamento
            // 
            txtFormaPagamento.CustomizableEdges = customizableEdges3;
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
            txtFormaPagamento.PlaceholderForeColor = Color.Orange;
            txtFormaPagamento.PlaceholderText = "digite forma de pagamento";
            txtFormaPagamento.SelectedText = "";
            txtFormaPagamento.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtFormaPagamento.Size = new Size(444, 35);
            txtFormaPagamento.TabIndex = 1;
            txtFormaPagamento.TextChanged += txtFormaPagamento_TextChanged;
            txtFormaPagamento.PreviewKeyDown += txtFormaPagamento_PreviewKeyDown;
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
            tableLayoutPanel3.Size = new Size(760, 316);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // dtgvPrincipal
            // 
            dtgvPrincipal.AllowUserToAddRows = false;
            dtgvPrincipal.AllowUserToDeleteRows = false;
            dtgvPrincipal.AllowUserToResizeColumns = false;
            dtgvPrincipal.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dtgvPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.DarkOrange;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgvPrincipal.ColumnHeadersHeight = 17;
            dtgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgvPrincipal.Columns.AddRange(new DataGridViewColumn[] { Id, Habilitado, DescricaoFormaPg });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dtgvPrincipal.DefaultCellStyle = dataGridViewCellStyle10;
            dtgvPrincipal.Dock = DockStyle.Fill;
            dtgvPrincipal.GridColor = Color.FromArgb(231, 229, 255);
            dtgvPrincipal.Location = new Point(3, 3);
            dtgvPrincipal.MultiSelect = false;
            dtgvPrincipal.Name = "dtgvPrincipal";
            dtgvPrincipal.RowHeadersVisible = false;
            dtgvPrincipal.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgvPrincipal.Size = new Size(754, 300);
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
            dtgvPrincipal.CellEndEdit += dtFormaPagamento_CellEndEdit;
            dtgvPrincipal.CellFormatting += dtgv_CellFormatting;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Id.DefaultCellStyle = dataGridViewCellStyle8;
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
            // DescricaoFormaPg
            // 
            DescricaoFormaPg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DescricaoFormaPg.DataPropertyName = "DescricaoFormaPg";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.BottomLeft;
            DescricaoFormaPg.DefaultCellStyle = dataGridViewCellStyle9;
            DescricaoFormaPg.FillWeight = 98.4771652F;
            DescricaoFormaPg.HeaderText = "Forma Pagamento";
            DescricaoFormaPg.Name = "DescricaoFormaPg";
            DescricaoFormaPg.Resizable = DataGridViewTriState.True;
            DescricaoFormaPg.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FormaPagamentoCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(tableLayoutPanel1);
            Name = "FormaPagamentoCtrl";
            Padding = new Padding(10);
            Size = new Size(792, 397);
            Load += FormPagamentoCtrl_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFormaPagamento;
        private FontAwesome.Sharp.IconButton btnManter;
        private TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvPrincipal;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewCheckBoxColumn Habilitado;
        private DataGridViewTextBoxColumn DescricaoFormaPg;
    }
}
