
namespace Livraria2909
{
    partial class frmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.dtgvEstoque = new System.Windows.Forms.DataGridView();
            this.txtPesquisarVendas = new System.Windows.Forms.TextBox();
            this.btnPesquisarVendas = new System.Windows.Forms.Button();
            this.lblLivroEstoque = new System.Windows.Forms.Label();
            this.cbLivroEstoque = new System.Windows.Forms.ComboBox();
            this.numQtdEstoque = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimparEstoque = new System.Windows.Forms.Button();
            this.btnSalvarEstoque = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvEstoque
            // 
            this.dtgvEstoque.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEstoque.Location = new System.Drawing.Point(12, 174);
            this.dtgvEstoque.Name = "dtgvEstoque";
            this.dtgvEstoque.Size = new System.Drawing.Size(588, 112);
            this.dtgvEstoque.TabIndex = 6;
            // 
            // txtPesquisarVendas
            // 
            this.txtPesquisarVendas.Location = new System.Drawing.Point(60, 156);
            this.txtPesquisarVendas.Name = "txtPesquisarVendas";
            this.txtPesquisarVendas.Size = new System.Drawing.Size(233, 20);
            this.txtPesquisarVendas.TabIndex = 19;
            // 
            // btnPesquisarVendas
            // 
            this.btnPesquisarVendas.BackgroundImage = global::Livraria2909.Properties.Resources.lupa;
            this.btnPesquisarVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarVendas.Location = new System.Drawing.Point(12, 156);
            this.btnPesquisarVendas.Name = "btnPesquisarVendas";
            this.btnPesquisarVendas.Size = new System.Drawing.Size(52, 21);
            this.btnPesquisarVendas.TabIndex = 18;
            this.btnPesquisarVendas.UseVisualStyleBackColor = true;
            // 
            // lblLivroEstoque
            // 
            this.lblLivroEstoque.AutoSize = true;
            this.lblLivroEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivroEstoque.Location = new System.Drawing.Point(236, 93);
            this.lblLivroEstoque.Name = "lblLivroEstoque";
            this.lblLivroEstoque.Size = new System.Drawing.Size(55, 24);
            this.lblLivroEstoque.TabIndex = 20;
            this.lblLivroEstoque.Text = "Livro";
            // 
            // cbLivroEstoque
            // 
            this.cbLivroEstoque.FormattingEnabled = true;
            this.cbLivroEstoque.Location = new System.Drawing.Point(325, 96);
            this.cbLivroEstoque.Name = "cbLivroEstoque";
            this.cbLivroEstoque.Size = new System.Drawing.Size(220, 21);
            this.cbLivroEstoque.TabIndex = 0;
            // 
            // numQtdEstoque
            // 
            this.numQtdEstoque.Location = new System.Drawing.Point(325, 120);
            this.numQtdEstoque.Name = "numQtdEstoque";
            this.numQtdEstoque.Size = new System.Drawing.Size(64, 20);
            this.numQtdEstoque.TabIndex = 1;
            this.numQtdEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quantidade";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLimparEstoque
            // 
            this.btnLimparEstoque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparEstoque.BackgroundImage = global::Livraria2909.Properties.Resources.archeology;
            this.btnLimparEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimparEstoque.FlatAppearance.BorderSize = 0;
            this.btnLimparEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparEstoque.Location = new System.Drawing.Point(239, 14);
            this.btnLimparEstoque.Name = "btnLimparEstoque";
            this.btnLimparEstoque.Size = new System.Drawing.Size(51, 45);
            this.btnLimparEstoque.TabIndex = 25;
            this.btnLimparEstoque.UseVisualStyleBackColor = false;
            this.btnLimparEstoque.Click += new System.EventHandler(this.btnLimparEstoque_Click);
            // 
            // btnSalvarEstoque
            // 
            this.btnSalvarEstoque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarEstoque.BackgroundImage = global::Livraria2909.Properties.Resources.salve_;
            this.btnSalvarEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvarEstoque.FlatAppearance.BorderSize = 0;
            this.btnSalvarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEstoque.Location = new System.Drawing.Point(322, 14);
            this.btnSalvarEstoque.Name = "btnSalvarEstoque";
            this.btnSalvarEstoque.Size = new System.Drawing.Size(51, 45);
            this.btnSalvarEstoque.TabIndex = 2;
            this.btnSalvarEstoque.UseVisualStyleBackColor = false;
            this.btnSalvarEstoque.Click += new System.EventHandler(this.btnSalvarEstoque_Click);
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Livraria2909.Properties.Resources.livroFundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 289);
            this.Controls.Add(this.btnLimparEstoque);
            this.Controls.Add(this.btnSalvarEstoque);
            this.Controls.Add(this.numQtdEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLivroEstoque);
            this.Controls.Add(this.lblLivroEstoque);
            this.Controls.Add(this.txtPesquisarVendas);
            this.Controls.Add(this.btnPesquisarVendas);
            this.Controls.Add(this.dtgvEstoque);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoque";
            this.Text = "Controle de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEstoque;
        private System.Windows.Forms.TextBox txtPesquisarVendas;
        private System.Windows.Forms.Button btnPesquisarVendas;
        private System.Windows.Forms.Label lblLivroEstoque;
        private System.Windows.Forms.ComboBox cbLivroEstoque;
        private System.Windows.Forms.NumericUpDown numQtdEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimparEstoque;
        private System.Windows.Forms.Button btnSalvarEstoque;
    }
}