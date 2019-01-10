namespace Apresentacao
{
    partial class FrmSobreSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSobreSistema));
            this.labelVersao = new System.Windows.Forms.Label();
            this.labelSistema = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelContato1 = new System.Windows.Forms.Label();
            this.pictureBoxSistema = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVersao
            // 
            this.labelVersao.AutoSize = true;
            this.labelVersao.Location = new System.Drawing.Point(12, 239);
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.Size = new System.Drawing.Size(58, 13);
            this.labelVersao.TabIndex = 0;
            this.labelVersao.Text = "Versão 1.0";
            // 
            // labelSistema
            // 
            this.labelSistema.AutoSize = true;
            this.labelSistema.Location = new System.Drawing.Point(12, 9);
            this.labelSistema.Name = "labelSistema";
            this.labelSistema.Size = new System.Drawing.Size(348, 13);
            this.labelSistema.TabIndex = 1;
            this.labelSistema.Text = "Exit Code Controle de Frota - Sistema inteligente para controlar sua frota.";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(12, 195);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(126, 13);
            this.labelAutor.TabIndex = 2;
            this.labelAutor.Text = "Criador: OZAIR SANTOS";
            // 
            // labelContato1
            // 
            this.labelContato1.AutoSize = true;
            this.labelContato1.Location = new System.Drawing.Point(12, 215);
            this.labelContato1.Name = "labelContato1";
            this.labelContato1.Size = new System.Drawing.Size(277, 13);
            this.labelContato1.TabIndex = 3;
            this.labelContato1.Text = "Contato: (11) 98795-1642 - E-mail: ozairdos@hotmail.com";
            // 
            // pictureBoxSistema
            // 
            this.pictureBoxSistema.Image = global::Apresentacao.Properties.Resources.Sistema;
            this.pictureBoxSistema.Location = new System.Drawing.Point(12, 25);
            this.pictureBoxSistema.Name = "pictureBoxSistema";
            this.pictureBoxSistema.Size = new System.Drawing.Size(360, 164);
            this.pictureBoxSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSistema.TabIndex = 4;
            this.pictureBoxSistema.TabStop = false;
            // 
            // FrmSobreSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.pictureBoxSistema);
            this.Controls.Add(this.labelContato1);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelSistema);
            this.Controls.Add(this.labelVersao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSobreSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre o sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVersao;
        private System.Windows.Forms.Label labelSistema;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelContato1;
        private System.Windows.Forms.PictureBox pictureBoxSistema;
    }
}