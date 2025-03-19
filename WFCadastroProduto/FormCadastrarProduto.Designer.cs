namespace WFCadastroProduto
{
    partial class FormCadastrarProduto
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
            lblCodigo = new Label();
            lblCategoria = new Label();
            lblNomeProduto = new Label();
            lblPreco = new Label();
            lbldataVencimento = new Label();
            lblObservacao = new Label();
            btnSalvar = new Button();
            cbxCategoria = new ComboBox();
            nudPreco = new NumericUpDown();
            txtObservacao = new TextBox();
            txtCodigo = new TextBox();
            txtNomeProduto = new TextBox();
            dtpDataV = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(33, 49);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(182, 49);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Categoria:";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(33, 103);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(106, 15);
            lblNomeProduto.TabIndex = 2;
            lblNomeProduto.Text = "Nome do Produto:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(33, 154);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 3;
            lblPreco.Text = "Preço:";
            // 
            // lbldataVencimento
            // 
            lbldataVencimento.AutoSize = true;
            lbldataVencimento.Location = new Point(182, 154);
            lbldataVencimento.Name = "lbldataVencimento";
            lbldataVencimento.Size = new Size(116, 15);
            lbldataVencimento.TabIndex = 4;
            lbldataVencimento.Text = "Data de Vencimento:";
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(33, 207);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(72, 15);
            lblObservacao.TabIndex = 5;
            lblObservacao.Text = "Observação:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(208, 361);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 30);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Frios e laticínios;", "Adega e bebidas;", "Higiene e limpeza;", "Hortifruti e mercearia;", "Padaria;", "Enlatados;", "Cereais;", "Açougue;" });
            cbxCategoria.Location = new Point(182, 67);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(133, 23);
            cbxCategoria.TabIndex = 7;
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Location = new Point(33, 172);
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(120, 23);
            nudPreco.TabIndex = 8;
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(33, 225);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(282, 109);
            txtObservacao.TabIndex = 10;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(33, 67);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(120, 23);
            txtCodigo.TabIndex = 11;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(33, 121);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(282, 23);
            txtNomeProduto.TabIndex = 12;
            // 
            // dtpDataV
            // 
            dtpDataV.Format = DateTimePickerFormat.Short;
            dtpDataV.Location = new Point(182, 172);
            dtpDataV.Name = "dtpDataV";
            dtpDataV.Size = new Size(133, 23);
            dtpDataV.TabIndex = 13;
            // 
            // FormCadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 450);
            Controls.Add(dtpDataV);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtCodigo);
            Controls.Add(txtObservacao);
            Controls.Add(nudPreco);
            Controls.Add(cbxCategoria);
            Controls.Add(btnSalvar);
            Controls.Add(lblObservacao);
            Controls.Add(lbldataVencimento);
            Controls.Add(lblPreco);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblCategoria);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastrarProduto";
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblCategoria;
        private Label lblNomeProduto;
        private Label lblPreco;
        private Label lbldataVencimento;
        private Label lblObservacao;
        private Button btnSalvar;
        private ComboBox cbxCategoria;
        private NumericUpDown nudPreco;
        private TextBox txtObservacao;
        private TextBox txtCodigo;
        private TextBox txtNomeProduto;
        private DateTimePicker dtpDataV;
    }
}