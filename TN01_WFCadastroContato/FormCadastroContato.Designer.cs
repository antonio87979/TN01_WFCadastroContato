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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroContato));
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
            lblNome.BackColor = Color.Transparent;
            lblNome.Location = new Point(35, 33);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(44, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblSobreNome
            // 
            lblSobreNome.AutoSize = true;
            lblSobreNome.BackColor = Color.Transparent;
            lblSobreNome.Location = new Point(233, 33);
            lblSobreNome.Name = "lblSobreNome";
            lblSobreNome.Size = new Size(80, 15);
            lblSobreNome.TabIndex = 1;
            lblSobreNome.Text = "Sobre Nome:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Location = new Point(35, 111);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(91, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "DDD/Telefone:";
            // 
            // lblTipoTelefone
            // 
            lblTipoTelefone.AutoSize = true;
            lblTipoTelefone.BackColor = Color.Transparent;
            lblTipoTelefone.Location = new Point(6, 0);
            lblTipoTelefone.Name = "lblTipoTelefone";
            lblTipoTelefone.Size = new Size(86, 15);
            lblTipoTelefone.TabIndex = 3;
            lblTipoTelefone.Text = "Tipo Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
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
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 23);
            txtNome.TabIndex = 1;
            // 
            // txtSobreNome
            // 
            txtSobreNome.Location = new Point(233, 51);
            txtSobreNome.Name = "txtSobreNome";
            txtSobreNome.Size = new Size(256, 23);
            txtSobreNome.TabIndex = 2;
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(35, 129);
            mkdTelefone.Mask = "(99) 00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(125, 23);
            mkdTelefone.TabIndex = 3;
            mkdTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(6, 16);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(65, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            rdbPessoal.CheckedChanged += rdbPessoal_CheckedChanged;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(89, 16);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(80, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(187, 16);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(66, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 221);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(454, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblLinha
            // 
            lblLinha.BackColor = SystemColors.ControlText;
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(35, 92);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(450, 1);
            lblLinha.TabIndex = 14;
            // 
            // lblLinha2
            // 
            lblLinha2.BackColor = SystemColors.ActiveCaptionText;
            lblLinha2.BorderStyle = BorderStyle.Fixed3D;
            lblLinha2.ForeColor = SystemColors.ActiveCaptionText;
            lblLinha2.Location = new Point(35, 174);
            lblLinha2.Name = "lblLinha2";
            lblLinha2.Size = new Size(450, 1);
            lblLinha2.TabIndex = 15;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.BackColor = Color.Transparent;
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(lblTipoTelefone);
            gbxTipoTelefone.ForeColor = SystemColors.ActiveCaptionText;
            gbxTipoTelefone.Location = new Point(189, 111);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(296, 41);
            gbxTipoTelefone.TabIndex = 4;
            gbxTipoTelefone.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(269, 278);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormCadastroContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(516, 323);
            Controls.Add(btnVoltar);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(lblLinha2);
            Controls.Add(lblLinha);
            Controls.Add(txtEmail);
            Controls.Add(mkdTelefone);
            Controls.Add(txtSobreNome);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblSobreNome);
            Controls.Add(lblNome);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroContato";
            StartPosition = FormStartPosition.CenterScreen;
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
