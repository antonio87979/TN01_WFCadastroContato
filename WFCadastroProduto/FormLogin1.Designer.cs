namespace WFCadastroProduto
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lblUsuario = new Label();
            lblSenha = new Label();
            btnAcessar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(50, 54);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Informe o Login...";
            txtUsuario.Size = new Size(112, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(50, 110);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Informe a senha...";
            txtSenha.Size = new Size(112, 23);
            txtSenha.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Location = new Point(50, 36);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(52, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Location = new Point(50, 92);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(44, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(75, 155);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(87, 28);
            btnAcessar.TabIndex = 3;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnEntrar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 232);
            Controls.Add(btnAcessar);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autenticação";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lblUsuario;
        private Label lblSenha;
        private Button btnAcessar;
    }
}
