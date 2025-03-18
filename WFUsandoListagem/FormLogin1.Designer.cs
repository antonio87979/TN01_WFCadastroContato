namespace WFUsandoListagem
{
    partial class FAutenticação
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
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(101, 61);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Informe o Login...";
            txtUsuario.Size = new Size(112, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(101, 117);
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
            lblUsuario.Location = new Point(101, 43);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(52, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Location = new Point(101, 99);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(44, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(126, 162);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(87, 28);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FAutenticação
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 232);
            Controls.Add(btnEntrar);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FAutenticação";
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
        private Button btnEntrar;
    }
}
