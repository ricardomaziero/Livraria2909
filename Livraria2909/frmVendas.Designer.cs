
namespace Livraria2909
{
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.btnLimparVenda = new System.Windows.Forms.Button();
            this.btnSalvarVenda = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lvlLivroVenda = new System.Windows.Forms.Label();
            this.cbLivroVenda = new System.Windows.Forms.ComboBox();
            this.numQtdVenda = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dtgvVendas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.msktxtData = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblContatoCliente = new System.Windows.Forms.Label();
            this.txtContatoCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimparVenda
            // 
            this.btnLimparVenda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparVenda.BackgroundImage = global::Livraria2909.Properties.Resources.archeology;
            this.btnLimparVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimparVenda.FlatAppearance.BorderSize = 0;
            this.btnLimparVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparVenda.Location = new System.Drawing.Point(238, 12);
            this.btnLimparVenda.Name = "btnLimparVenda";
            this.btnLimparVenda.Size = new System.Drawing.Size(51, 45);
            this.btnLimparVenda.TabIndex = 7;
            this.btnLimparVenda.UseVisualStyleBackColor = false;
            this.btnLimparVenda.Click += new System.EventHandler(this.btnLimparVenda_Click);
            // 
            // btnSalvarVenda
            // 
            this.btnSalvarVenda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarVenda.BackgroundImage = global::Livraria2909.Properties.Resources.salve_;
            this.btnSalvarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvarVenda.FlatAppearance.BorderSize = 0;
            this.btnSalvarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarVenda.Location = new System.Drawing.Point(321, 12);
            this.btnSalvarVenda.Name = "btnSalvarVenda";
            this.btnSalvarVenda.Size = new System.Drawing.Size(51, 45);
            this.btnSalvarVenda.TabIndex = 6;
            this.btnSalvarVenda.UseVisualStyleBackColor = false;
            this.btnSalvarVenda.Click += new System.EventHandler(this.btnSalvarVenda_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(242, 184);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(47, 23);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Data";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lvlLivroVenda
            // 
            this.lvlLivroVenda.AutoSize = true;
            this.lvlLivroVenda.BackColor = System.Drawing.Color.Transparent;
            this.lvlLivroVenda.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlLivroVenda.Location = new System.Drawing.Point(240, 78);
            this.lvlLivroVenda.Name = "lvlLivroVenda";
            this.lvlLivroVenda.Size = new System.Drawing.Size(49, 23);
            this.lvlLivroVenda.TabIndex = 10;
            this.lvlLivroVenda.Text = "Livro";
            this.lvlLivroVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbLivroVenda
            // 
            this.cbLivroVenda.FormattingEnabled = true;
            this.cbLivroVenda.Location = new System.Drawing.Point(327, 80);
            this.cbLivroVenda.Name = "cbLivroVenda";
            this.cbLivroVenda.Size = new System.Drawing.Size(215, 21);
            this.cbLivroVenda.TabIndex = 0;
            // 
            // numQtdVenda
            // 
            this.numQtdVenda.Location = new System.Drawing.Point(327, 158);
            this.numQtdVenda.Name = "numQtdVenda";
            this.numQtdVenda.Size = new System.Drawing.Size(69, 20);
            this.numQtdVenda.TabIndex = 3;
            this.numQtdVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQtdVenda.ValueChanged += new System.EventHandler(this.numQtdVenda_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(241, 209);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 23);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(327, 209);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(69, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgvVendas
            // 
            this.dtgvVendas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVendas.Location = new System.Drawing.Point(402, 171);
            this.dtgvVendas.Name = "dtgvVendas";
            this.dtgvVendas.Size = new System.Drawing.Size(198, 113);
            this.dtgvVendas.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quantidade";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // msktxtData
            // 
            this.msktxtData.Location = new System.Drawing.Point(327, 184);
            this.msktxtData.Mask = "##/##/####";
            this.msktxtData.Name = "msktxtData";
            this.msktxtData.Size = new System.Drawing.Size(69, 20);
            this.msktxtData.TabIndex = 4;
            this.msktxtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Registro de Vendas";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCliente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(170, 103);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(119, 23);
            this.lblNomeCliente.TabIndex = 10;
            this.lblNomeCliente.Text = "Nome Cliente";
            this.lblNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(327, 106);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(215, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // lblContatoCliente
            // 
            this.lblContatoCliente.AutoSize = true;
            this.lblContatoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblContatoCliente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContatoCliente.Location = new System.Drawing.Point(155, 129);
            this.lblContatoCliente.Name = "lblContatoCliente";
            this.lblContatoCliente.Size = new System.Drawing.Size(134, 23);
            this.lblContatoCliente.TabIndex = 10;
            this.lblContatoCliente.Text = "Contato Cliente";
            this.lblContatoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContatoCliente
            // 
            this.txtContatoCliente.Location = new System.Drawing.Point(327, 132);
            this.txtContatoCliente.Name = "txtContatoCliente";
            this.txtContatoCliente.Size = new System.Drawing.Size(215, 20);
            this.txtContatoCliente.TabIndex = 2;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Livraria2909.Properties.Resources.livroFundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msktxtData);
            this.Controls.Add(this.dtgvVendas);
            this.Controls.Add(this.txtContatoCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.numQtdVenda);
            this.Controls.Add(this.cbLivroVenda);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContatoCliente);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lvlLivroVenda);
            this.Controls.Add(this.btnLimparVenda);
            this.Controls.Add(this.btnSalvarVenda);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendas";
            this.Text = "Vendas";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numQtdVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimparVenda;
        private System.Windows.Forms.Button btnSalvarVenda;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lvlLivroVenda;
        private System.Windows.Forms.ComboBox cbLivroVenda;
        private System.Windows.Forms.NumericUpDown numQtdVenda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dtgvVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktxtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblContatoCliente;
        private System.Windows.Forms.TextBox txtContatoCliente;
    }
}