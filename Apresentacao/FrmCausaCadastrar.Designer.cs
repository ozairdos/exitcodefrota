namespace Apresentacao
{
    partial class FrmCausaCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCausaCadastrar));
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelCausa = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxCausa = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(7, 9);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código";
            // 
            // labelCausa
            // 
            this.labelCausa.AutoSize = true;
            this.labelCausa.Location = new System.Drawing.Point(7, 48);
            this.labelCausa.Name = "labelCausa";
            this.labelCausa.Size = new System.Drawing.Size(37, 13);
            this.labelCausa.TabIndex = 2;
            this.labelCausa.Text = "Causa";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(10, 25);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(62, 20);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.TabStop = false;
            this.textBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCausa
            // 
            this.textBoxCausa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCausa.Location = new System.Drawing.Point(10, 64);
            this.textBoxCausa.Name = "textBoxCausa";
            this.textBoxCausa.Size = new System.Drawing.Size(304, 20);
            this.textBoxCausa.TabIndex = 3;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(158, 90);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(239, 90);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FrmCausaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 122);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxCausa);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCausa);
            this.Controls.Add(this.labelCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCausaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Causa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelCausa;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxCausa;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}