namespace Apresentacao
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.barraStatusPrincipal = new System.Windows.Forms.StatusStrip();
            this.labelVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCausa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCombustivel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFrota = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManutencao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMotorista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPosto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServico = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentoFrota = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentoFrotaDataValor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentoFrotaDataKm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLigarDesligar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.barraStatusPrincipal.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraStatusPrincipal
            // 
            this.barraStatusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelVersao});
            this.barraStatusPrincipal.Location = new System.Drawing.Point(0, 339);
            this.barraStatusPrincipal.Name = "barraStatusPrincipal";
            this.barraStatusPrincipal.Size = new System.Drawing.Size(784, 22);
            this.barraStatusPrincipal.TabIndex = 1;
            this.barraStatusPrincipal.Text = "statusStrip1";
            // 
            // labelVersao
            // 
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.Size = new System.Drawing.Size(59, 17);
            this.labelVersao.Text = "Versao 1.0";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.menuMovimentos,
            this.menuRelatorio,
            this.menuAjuda,
            this.menuLigarDesligar});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCargo,
            this.menuCausa,
            this.menuCombustivel,
            this.menuFrota,
            this.menuManutencao,
            this.menuMotorista,
            this.menuPosto,
            this.menuServico});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(66, 20);
            this.menuCadastro.Text = "&Cadastro";
            // 
            // menuCargo
            // 
            this.menuCargo.Name = "menuCargo";
            this.menuCargo.Size = new System.Drawing.Size(141, 22);
            this.menuCargo.Text = "Cargo";
            this.menuCargo.Click += new System.EventHandler(this.menuCargo_Click);
            // 
            // menuCausa
            // 
            this.menuCausa.Name = "menuCausa";
            this.menuCausa.Size = new System.Drawing.Size(141, 22);
            this.menuCausa.Text = "Causa";
            this.menuCausa.Click += new System.EventHandler(this.menuCausa_Click);
            // 
            // menuCombustivel
            // 
            this.menuCombustivel.Name = "menuCombustivel";
            this.menuCombustivel.Size = new System.Drawing.Size(141, 22);
            this.menuCombustivel.Text = "Combustível";
            this.menuCombustivel.Click += new System.EventHandler(this.menuCombustivel_Click);
            // 
            // menuFrota
            // 
            this.menuFrota.Name = "menuFrota";
            this.menuFrota.Size = new System.Drawing.Size(141, 22);
            this.menuFrota.Text = "Frota";
            this.menuFrota.Click += new System.EventHandler(this.menuFrota_Click);
            // 
            // menuManutencao
            // 
            this.menuManutencao.Name = "menuManutencao";
            this.menuManutencao.Size = new System.Drawing.Size(141, 22);
            this.menuManutencao.Text = "Manutenção";
            this.menuManutencao.Click += new System.EventHandler(this.menuManutencao_Click);
            // 
            // menuMotorista
            // 
            this.menuMotorista.Name = "menuMotorista";
            this.menuMotorista.Size = new System.Drawing.Size(141, 22);
            this.menuMotorista.Text = "Motorista";
            this.menuMotorista.Click += new System.EventHandler(this.menuMotorista_Click);
            // 
            // menuPosto
            // 
            this.menuPosto.Name = "menuPosto";
            this.menuPosto.Size = new System.Drawing.Size(141, 22);
            this.menuPosto.Text = "Posto";
            this.menuPosto.Click += new System.EventHandler(this.menuPosto_Click);
            // 
            // menuServico
            // 
            this.menuServico.Name = "menuServico";
            this.menuServico.Size = new System.Drawing.Size(141, 22);
            this.menuServico.Text = "Serviço";
            this.menuServico.Click += new System.EventHandler(this.menuServico_Click);
            // 
            // menuMovimentos
            // 
            this.menuMovimentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMovimentoFrota});
            this.menuMovimentos.Name = "menuMovimentos";
            this.menuMovimentos.Size = new System.Drawing.Size(86, 20);
            this.menuMovimentos.Text = "Movimentos";
            // 
            // menuMovimentoFrota
            // 
            this.menuMovimentoFrota.Name = "menuMovimentoFrota";
            this.menuMovimentoFrota.Size = new System.Drawing.Size(166, 22);
            this.menuMovimentoFrota.Text = "Movimento Frota";
            this.menuMovimentoFrota.Click += new System.EventHandler(this.movimentoFrotaToolStripMenuItem_Click);
            // 
            // menuRelatorio
            // 
            this.menuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMovimentoFrotaDataValor,
            this.menuMovimentoFrotaDataKm});
            this.menuRelatorio.Name = "menuRelatorio";
            this.menuRelatorio.Size = new System.Drawing.Size(71, 20);
            this.menuRelatorio.Text = "&Relatórios";
            // 
            // menuMovimentoFrotaDataValor
            // 
            this.menuMovimentoFrotaDataValor.Name = "menuMovimentoFrotaDataValor";
            this.menuMovimentoFrotaDataValor.Size = new System.Drawing.Size(242, 22);
            this.menuMovimentoFrotaDataValor.Text = "Movimento Frota por data Valor";
            this.menuMovimentoFrotaDataValor.Click += new System.EventHandler(this.menuMovimentoFrotaDataValor_Click);
            // 
            // menuMovimentoFrotaDataKm
            // 
            this.menuMovimentoFrotaDataKm.Name = "menuMovimentoFrotaDataKm";
            this.menuMovimentoFrotaDataKm.Size = new System.Drawing.Size(242, 22);
            this.menuMovimentoFrotaDataKm.Text = "Movimento Frota por data Km";
            this.menuMovimentoFrotaDataKm.Click += new System.EventHandler(this.menuMovimentoFrotaDataKm_Click);
            // 
            // menuAjuda
            // 
            this.menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuSobre});
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(50, 20);
            this.menuAjuda.Text = "&Ajuda";
            // 
            // menuUsuario
            // 
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(114, 22);
            this.menuUsuario.Text = "Usuário";
            this.menuUsuario.Click += new System.EventHandler(this.menuUsuario_Click);
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(114, 22);
            this.menuSobre.Text = "Sobre";
            this.menuSobre.Click += new System.EventHandler(this.menuSobre_Click);
            // 
            // menuLigarDesligar
            // 
            this.menuLigarDesligar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrocarUsuario,
            this.menuSair});
            this.menuLigarDesligar.Name = "menuLigarDesligar";
            this.menuLigarDesligar.Size = new System.Drawing.Size(92, 20);
            this.menuLigarDesligar.Text = "&Ligar/Desligar";
            // 
            // menuTrocarUsuario
            // 
            this.menuTrocarUsuario.Name = "menuTrocarUsuario";
            this.menuTrocarUsuario.Size = new System.Drawing.Size(149, 22);
            this.menuTrocarUsuario.Text = "Trocar usuário";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(149, 22);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.barraStatusPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmMenu";
            this.Text = "Exit Code Controle de Frota";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barraStatusPrincipal.ResumeLayout(false);
            this.barraStatusPrincipal.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraStatusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel labelVersao;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuLigarDesligar;
        private System.Windows.Forms.ToolStripMenuItem menuCargo;
        private System.Windows.Forms.ToolStripMenuItem menuCausa;
        private System.Windows.Forms.ToolStripMenuItem menuCombustivel;
        private System.Windows.Forms.ToolStripMenuItem menuFrota;
        private System.Windows.Forms.ToolStripMenuItem menuManutencao;
        private System.Windows.Forms.ToolStripMenuItem menuMotorista;
        private System.Windows.Forms.ToolStripMenuItem menuPosto;
        private System.Windows.Forms.ToolStripMenuItem menuServico;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuSobre;
        private System.Windows.Forms.ToolStripMenuItem menuTrocarUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentos;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentoFrota;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentoFrotaDataKm;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentoFrotaDataValor;
    }
}