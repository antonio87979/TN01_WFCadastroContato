namespace WFUsandoListagem
{
    partial class FormCadastro
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
            btnCadastrar = new Button();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            lblLogin = new Label();
            lblSenha = new Label();
            lblConfirmarSenha = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(89, 197);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(88, 27);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(54, 58);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Novo login...";
            txtLogin.Size = new Size(123, 23);
            txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(54, 105);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Nova senha...";
            txtSenha.Size = new Size(123, 23);
            txtSenha.TabIndex = 2;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(54, 155);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.PlaceholderText = "Confirme a nova  senha...";
            txtConfirmarSenha.Size = new Size(123, 23);
            txtConfirmarSenha.TabIndex = 3;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(54, 41);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(54, 88);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(41, 15);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(54, 138);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(98, 15);
            lblConfirmarSenha.TabIndex = 6;
            lblConfirmarSenha.Text = "Confirmar senha";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 262);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(btnCadastrar);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar novo usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblConfirmarSenha;
    }
}