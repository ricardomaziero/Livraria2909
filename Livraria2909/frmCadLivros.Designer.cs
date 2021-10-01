
namespace Livraria2909
{
    partial class frmCadLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadLivros));
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.txtTituloLivro = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtValorLivro = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnSalvarLivro = new System.Windows.Forms.Button();
            this.btnLimparLivro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEditora
            // 
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(328, 157);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(215, 21);
            this.cbEditora.TabIndex = 2;
            // 
            // txtTituloLivro
            // 
            this.txtTituloLivro.Location = new System.Drawing.Point(328, 83);
            this.txtTituloLivro.Name = "txtTituloLivro";
            this.txtTituloLivro.Size = new System.Drawing.Size(215, 20);
            this.txtTituloLivro.TabIndex = 0;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(328, 120);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(215, 20);
            this.txtNomeAutor.TabIndex = 1;
            // 
            // txtValorLivro
            // 
            this.txtValorLivro.Location = new System.Drawing.Point(328, 195);
            this.txtValorLivro.Name = "txtValorLivro";
            this.txtValorLivro.Size = new System.Drawing.Size(86, 20);
            this.txtValorLivro.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(167, 80);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 23);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Título do Livro";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(158, 116);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(132, 23);
            this.lblAutor.TabIndex = 8;
            this.lblAutor.Text = "Nome do Autor";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.BackColor = System.Drawing.Color.Transparent;
            this.lblEditora.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.Location = new System.Drawing.Point(223, 153);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(67, 23);
            this.lblEditora.TabIndex = 9;
            this.lblEditora.Text = "Editora";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(239, 191);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(51, 23);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "Valor";
            // 
            // btnSalvarLivro
            // 
            this.btnSalvarLivro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarLivro.BackgroundImage = global::Livraria2909.Properties.Resources.salve_;
            this.btnSalvarLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvarLivro.FlatAppearance.BorderSize = 0;
            this.btnSalvarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarLivro.Location = new System.Drawing.Point(321, 12);
            this.btnSalvarLivro.Name = "btnSalvarLivro";
            this.btnSalvarLivro.Size = new System.Drawing.Size(51, 45);
            this.btnSalvarLivro.TabIndex = 4;
            this.btnSalvarLivro.UseVisualStyleBackColor = false;
            this.btnSalvarLivro.Click += new System.EventHandler(this.btnSalvarLivro_Click);
            // 
            // btnLimparLivro
            // 
            this.btnLimparLivro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparLivro.BackgroundImage = global::Livraria2909.Properties.Resources.archeology;
            this.btnLimparLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimparLivro.FlatAppearance.BorderSize = 0;
            this.btnLimparLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparLivro.Location = new System.Drawing.Point(238, 12);
            this.btnLimparLivro.Name = "btnLimparLivro";
            this.btnLimparLivro.Size = new System.Drawing.Size(51, 45);
            this.btnLimparLivro.TabIndex = 5;
            this.btnLimparLivro.UseVisualStyleBackColor = false;
            this.btnLimparLivro.Click += new System.EventHandler(this.btnLimparLivro_Click);
            // 
            // frmCadLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Livraria2909.Properties.Resources.livroFundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 289);
            this.Controls.Add(this.btnLimparLivro);
            this.Controls.Add(this.btnSalvarLivro);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtValorLivro);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtTituloLivro);
            this.Controls.Add(this.cbEditora);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadLivros";
            this.Text = "Cadastro de Livros";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEditora;
        private System.Windows.Forms.TextBox txtTituloLivro;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtValorLivro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnSalvarLivro;
        private System.Windows.Forms.Button btnLimparLivro;
    }
}