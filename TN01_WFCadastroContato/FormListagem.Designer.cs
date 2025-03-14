namespace TN01_WFCadastroContato
{
    partial class FormListagem
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
            dgvListaContatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaContatos).BeginInit();
            SuspendLayout();
            // 
            // dgvListaContatos
            // 
            dgvListaContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaContatos.Location = new Point(37, 12);
            dgvListaContatos.Name = "dgvListaContatos";
            dgvListaContatos.Size = new Size(571, 426);
            dgvListaContatos.TabIndex = 0;
            dgvListaContatos.CellContentClick += dgvListaContatos_CellContentClick;
            // 
            // fmListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListaContatos);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fmListagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem";
            ((System.ComponentModel.ISupportInitialize)dgvListaContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaContatos;
    }
}