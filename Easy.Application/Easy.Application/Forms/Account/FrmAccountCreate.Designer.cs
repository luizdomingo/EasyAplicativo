namespace Easy.Application.Forms.Account
{
    partial class FrmAccountCreate
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            flForm = new FlowLayoutPanel();
            label4 = new Label();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            txtConfirmaSenha = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flForm.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(515, 302);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(flForm, 0, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(509, 296);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // flForm
            // 
            flForm.Controls.Add(label4);
            flForm.Controls.Add(txtEmail);
            flForm.Controls.Add(label5);
            flForm.Controls.Add(txtSenha);
            flForm.Controls.Add(label3);
            flForm.Controls.Add(txtConfirmaSenha);
            flForm.Controls.Add(guna2Button1);
            flForm.Controls.Add(btnCadastrar);
            flForm.Dock = DockStyle.Fill;
            flForm.Location = new Point(3, 38);
            flForm.Name = "flForm";
            flForm.Padding = new Padding(120, 30, 0, 0);
            flForm.Size = new Size(503, 255);
            flForm.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(154, 156, 181);
            label4.Location = new Point(123, 30);
            label4.Name = "label4";
            label4.Size = new Size(314, 17);
            label4.TabIndex = 2;
            label4.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.CustomizableEdges = customizableEdges11;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(123, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtEmail.Size = new Size(284, 36);
            txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.FromArgb(154, 156, 181);
            label5.Location = new Point(123, 89);
            label5.Name = "label5";
            label5.Size = new Size(314, 17);
            label5.TabIndex = 4;
            label5.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.CustomizableEdges = customizableEdges13;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(123, 109);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.PlaceholderText = "";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtSenha.Size = new Size(284, 36);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(154, 156, 181);
            label3.Location = new Point(123, 148);
            label3.Name = "label3";
            label3.Size = new Size(314, 17);
            label3.TabIndex = 7;
            label3.Text = "Confirme a Senha";
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.CustomizableEdges = customizableEdges15;
            txtConfirmaSenha.DefaultText = "";
            txtConfirmaSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmaSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmaSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmaSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmaSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmaSenha.Font = new Font("Segoe UI", 9F);
            txtConfirmaSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmaSenha.Location = new Point(123, 168);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PasswordChar = '●';
            txtConfirmaSenha.PlaceholderText = "";
            txtConfirmaSenha.SelectedText = "";
            txtConfirmaSenha.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtConfirmaSenha.Size = new Size(284, 36);
            txtConfirmaSenha.TabIndex = 8;
            txtConfirmaSenha.UseSystemPasswordChar = true;
            // 
            // guna2Button1
            // 
            guna2Button1.AutoRoundedCorners = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.White;
            guna2Button1.BorderRadius = 13;
            guna2Button1.BorderThickness = 1;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges17;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.LightSteelBlue;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(123, 210);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2Button1.Size = new Size(117, 29);
            guna2Button1.TabIndex = 9;
            guna2Button1.Text = "cancelar";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoRoundedCorners = true;
            btnCadastrar.BorderColor = Color.White;
            btnCadastrar.BorderRadius = 13;
            btnCadastrar.BorderThickness = 1;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.CustomizableEdges = customizableEdges19;
            btnCadastrar.DisabledState.BorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCadastrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCadastrar.FillColor = Color.SteelBlue;
            btnCadastrar.Font = new Font("Segoe UI", 9F);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(246, 210);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnCadastrar.Size = new Size(168, 29);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(503, 35);
            label2.TabIndex = 0;
            label2.Text = "Cadastrar Usuário";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmAccountCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(555, 342);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAccountCreate";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAccountCreate";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            flForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flForm;
        private Label label2;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmaSenha;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}