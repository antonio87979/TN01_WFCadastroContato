namespace TN01_WFCadastroContato
{
    partial class FormCadastroContato
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
            lblNome = new Label();
            lblSobreNome = new Label();
            lblTelefone = new Label();
            lblTipoTelefone = new Label();
            lblEmail = new Label();
            btnSalvar = new Button();
            txtNome = new TextBox();
            txtSobreNome = new TextBox();
            mkdTelefone = new MaskedTextBox();
            rdbPessoal = new RadioButton();
            rdbComercial = new RadioButton();
            rdbRecado = new RadioButton();
            txtEmail = new TextBox();
            lblLinha = new Label();
            lblLinha2 = new Label();
            gbxTipoTelefone = new GroupBox();
            btnVoltar = new Button();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(35, 33);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblSobreNome
            // 
            lblSobreNome.AutoSize = true;
            lblSobreNome.Location = new Point(233, 33);
            lblSobreNome.Name = "lblSobreNome";
            lblSobreNome.Size = new Size(76, 15);
            lblSobreNome.TabIndex = 1;
            lblSobreNome.Text = "Sobre Nome:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(35, 111);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(83, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "DDD/Telefone:";
            // 
            // lblTipoTelefone
            // 
            lblTipoTelefone.AutoSize = true;
            lblTipoTelefone.Location = new Point(195, 111);
            lblTipoTelefone.Name = "lblTipoTelefone";
            lblTipoTelefone.Size = new Size(80, 15);
            lblTipoTelefone.TabIndex = 3;
            lblTipoTelefone.Text = "Tipo Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(35, 203);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(363, 278);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 23);
            txtNome.TabIndex = 6;
            // 
            // txtSobreNome
            // 
            txtSobreNome.Location = new Point(233, 51);
            txtSobreNome.Name = "txtSobreNome";
            txtSobreNome.Size = new Size(256, 23);
            txtSobreNome.TabIndex = 7;
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(35, 129);
            mkdTelefone.Mask = "(99) 00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(125, 23);
            mkdTelefone.TabIndex = 8;
            mkdTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(0, 4);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 9;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(100, 4);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 10;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(196, 4);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 11;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 221);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(454, 23);
            txtEmail.TabIndex = 13;
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(35, 92);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(450, 1);
            lblLinha.TabIndex = 14;
            // 
            // lblLinha2
            // 
            lblLinha2.BorderStyle = BorderStyle.Fixed3D;
            lblLinha2.Location = new Point(35, 174);
            lblLinha2.Name = "lblLinha2";
            lblLinha2.Size = new Size(450, 1);
            lblLinha2.TabIndex = 15;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Location = new Point(195, 129);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(290, 23);
            gbxTipoTelefone.TabIndex = 16;
            gbxTipoTelefone.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(269, 278);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormCadastroContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 323);
            Controls.Add(btnVoltar);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(lblLinha2);
            Controls.Add(lblLinha);
            Controls.Add(lblTipoTelefone);
            Controls.Add(txtEmail);
            Controls.Add(mkdTelefone);
            Controls.Add(txtSobreNome);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblSobreNome);
            Controls.Add(lblNome);
            Name = "FormCadastroContato";
            Text = "Form1";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblSobreNome;
        private Label lblTelefone;
        private Label lblTipoTelefone;
        private Label lblEmail;
        private Button btnSalvar;
        private TextBox txtNome;
        private TextBox txtSobreNome;
        private MaskedTextBox mkdTelefone;
        private RadioButton rdbPessoal;
        private RadioButton rdbComercial;
        private RadioButton rdbRecado;
        private TextBox txtEmail;
        private Label lblLinha;
        private Label lblLinha2;
        private GroupBox gbxTipoTelefone;
        private Button btnVoltar;
    }
}
