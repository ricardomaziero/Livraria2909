
namespace Livraria2909
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadLivros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadEditoras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(206, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRINCIPAL";
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.mnEstoque,
            this.mnVendas});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(484, 24);
            this.mnPrincipal.TabIndex = 2;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadLivros,
            this.mnCadEditoras});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // mnCadLivros
            // 
            this.mnCadLivros.Name = "mnCadLivros";
            this.mnCadLivros.Size = new System.Drawing.Size(180, 22);
            this.mnCadLivros.Text = "Livros";
            this.mnCadLivros.Click += new System.EventHandler(this.mnCadLivros_Click);
            // 
            // mnCadEditoras
            // 
            this.mnCadEditoras.Name = "mnCadEditoras";
            this.mnCadEditoras.Size = new System.Drawing.Size(180, 22);
            this.mnCadEditoras.Text = "Editoras";
            this.mnCadEditoras.Click += new System.EventHandler(this.mnCadEditoras_Click);
            // 
            // mnEstoque
            // 
            this.mnEstoque.Name = "mnEstoque";
            this.mnEstoque.Size = new System.Drawing.Size(61, 20);
            this.mnEstoque.Text = "Estoque";
            this.mnEstoque.Click += new System.EventHandler(this.mnEstoque_Click);
            // 
            // mnVendas
            // 
            this.mnVendas.Name = "mnVendas";
            this.mnVendas.Size = new System.Drawing.Size(56, 20);
            this.mnVendas.Text = "Vendas";
            this.mnVendas.Click += new System.EventHandler(this.mnVendas_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Livraria2909.Properties.Resources.imagemLivraria;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnCadLivros;
        private System.Windows.Forms.ToolStripMenuItem mnCadEditoras;
        private System.Windows.Forms.ToolStripMenuItem mnEstoque;
        private System.Windows.Forms.ToolStripMenuItem mnVendas;
    }
}