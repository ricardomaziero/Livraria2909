
namespace Livraria2909
{
    partial class frmCadEditora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEditora));
            this.btnLimparEditora = new System.Windows.Forms.Button();
            this.btnSalvarEditora = new System.Windows.Forms.Button();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNomeEditora = new System.Windows.Forms.Label();
            this.txtEmailEditora = new System.Windows.Forms.TextBox();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.msktxtTelefoneEd = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnLimparEditora
            // 
            this.btnLimparEditora.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparEditora.BackgroundImage = global::Livraria2909.Properties.Resources.archeology;
            this.btnLimparEditora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimparEditora.FlatAppearance.BorderSize = 0;
            this.btnLimparEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparEditora.Location = new System.Drawing.Point(238, 12);
            this.btnLimparEditora.Name = "btnLimparEditora";
            this.btnLimparEditora.Size = new System.Drawing.Size(51, 45);
            this.btnLimparEditora.TabIndex = 4;
            this.btnLimparEditora.UseVisualStyleBackColor = false;
            this.btnLimparEditora.Click += new System.EventHandler(this.btnLimparEditora_Click);
            // 
            // btnSalvarEditora
            // 
            this.btnSalvarEditora.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarEditora.BackgroundImage = global::Livraria2909.Properties.Resources.salve_;
            this.btnSalvarEditora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvarEditora.FlatAppearance.BorderSize = 0;
            this.btnSalvarEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEditora.Location = new System.Drawing.Point(321, 12);
            this.btnSalvarEditora.Name = "btnSalvarEditora";
            this.btnSalvarEditora.Size = new System.Drawing.Size(51, 45);
            this.btnSalvarEditora.TabIndex = 3;
            this.btnSalvarEditora.UseVisualStyleBackColor = false;
            this.btnSalvarEditora.Click += new System.EventHandler(this.btnSalvarEditora_Click);
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.BackColor = System.Drawing.Color.Transparent;
            this.lblEditora.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.Location = new System.Drawing.Point(212, 169);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(78, 23);
            this.lblEditora.TabIndex = 8;
            this.lblEditora.Text = "Telefone";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(231, 132);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(59, 23);
            this.lblAutor.TabIndex = 7;
            this.lblAutor.Text = "E-mail";
            // 
            // lblNomeEditora
            // 
            this.lblNomeEditora.AutoSize = true;
            this.lblNomeEditora.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeEditora.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEditora.Location = new System.Drawing.Point(223, 95);
            this.lblNomeEditora.Name = "lblNomeEditora";
            this.lblNomeEditora.Size = new System.Drawing.Size(67, 23);
            this.lblNomeEditora.TabIndex = 6;
            this.lblNomeEditora.Text = "Editora";
            this.lblNomeEditora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmailEditora
            // 
            this.txtEmailEditora.Location = new System.Drawing.Point(328, 135);
            this.txtEmailEditora.Name = "txtEmailEditora";
            this.txtEmailEditora.Size = new System.Drawing.Size(215, 20);
            this.txtEmailEditora.TabIndex = 1;
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(328, 98);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(215, 20);
            this.txtNomeEditora.TabIndex = 0;
            // 
            // msktxtTelefoneEd
            // 
            this.msktxtTelefoneEd.Location = new System.Drawing.Point(328, 172);
            this.msktxtTelefoneEd.Mask = "(##)#########";
            this.msktxtTelefoneEd.Name = "msktxtTelefoneEd";
            this.msktxtTelefoneEd.Size = new System.Drawing.Size(86, 20);
            this.msktxtTelefoneEd.TabIndex = 2;
            this.msktxtTelefoneEd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msktxtTelefoneEd.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // frmCadEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Livraria2909.Properties.Resources.livroFundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 289);
            this.Controls.Add(this.msktxtTelefoneEd);
            this.Controls.Add(this.btnLimparEditora);
            this.Controls.Add(this.btnSalvarEditora);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNomeEditora);
            this.Controls.Add(this.txtEmailEditora);
            this.Controls.Add(this.txtNomeEditora);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadEditora";
            this.Text = "Cadastro Editora";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimparEditora;
        private System.Windows.Forms.Button btnSalvarEditora;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblNomeEditora;
        private System.Windows.Forms.TextBox txtEmailEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.MaskedTextBox msktxtTelefoneEd;
    }
}