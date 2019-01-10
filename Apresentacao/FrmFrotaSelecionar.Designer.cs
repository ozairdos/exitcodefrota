namespace Apresentacao
{
    partial class FrmFrotaSelecionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFrotaSelecionar));
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.dataGridViewPrincipal = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Location = new System.Drawing.Point(7, 7);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(62, 13);
            this.labelPesquisa.TabIndex = 0;
            this.labelPesquisa.Text = "Documento";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisa.Location = new System.Drawing.Point(92, 7);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(506, 20);
            this.textBoxPesquisa.TabIndex = 1;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(604, 4);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 2;
            this.buttonPesquisar.Text = "&Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(575, 332);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 4;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(658, 332);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 5;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(741, 332);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 6;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(824, 332);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 7;
            this.buttonConsultar.Text = "&Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(907, 332);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 8;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // dataGridViewPrincipal
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colTipoVeiculo,
            this.colVeiculo,
            this.colPlaca,
            this.colCor,
            this.colAno,
            this.colDocumentacao,
            this.colDataVencimento,
            this.colStatus,
            this.colDataCadastro});
            this.dataGridViewPrincipal.Location = new System.Drawing.Point(3, 36);
            this.dataGridViewPrincipal.MultiSelect = false;
            this.dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            this.dataGridViewPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrincipal.Size = new System.Drawing.Size(990, 290);
            this.dataGridViewPrincipal.TabIndex = 3;
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "IDCADFROTA";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Format = "#,##0";
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 60;
            // 
            // colTipoVeiculo
            // 
            this.colTipoVeiculo.DataPropertyName = "CADTIPODEVEICULO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colTipoVeiculo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTipoVeiculo.HeaderText = "Tipo Veículo";
            this.colTipoVeiculo.Name = "colTipoVeiculo";
            this.colTipoVeiculo.ReadOnly = true;
            this.colTipoVeiculo.Width = 200;
            // 
            // colVeiculo
            // 
            this.colVeiculo.DataPropertyName = "CADVEICULO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colVeiculo.DefaultCellStyle = dataGridViewCellStyle4;
            this.colVeiculo.HeaderText = "Veículo";
            this.colVeiculo.Name = "colVeiculo";
            this.colVeiculo.ReadOnly = true;
            this.colVeiculo.Width = 200;
            // 
            // colPlaca
            // 
            this.colPlaca.DataPropertyName = "CADPLACA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colPlaca.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPlaca.HeaderText = "Placa";
            this.colPlaca.Name = "colPlaca";
            this.colPlaca.ReadOnly = true;
            this.colPlaca.Width = 80;
            // 
            // colCor
            // 
            this.colCor.DataPropertyName = "CADCOR";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colCor.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCor.HeaderText = "Cor";
            this.colCor.Name = "colCor";
            this.colCor.ReadOnly = true;
            this.colCor.Width = 80;
            // 
            // colAno
            // 
            this.colAno.DataPropertyName = "CADANO";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colAno.DefaultCellStyle = dataGridViewCellStyle7;
            this.colAno.HeaderText = "Ano";
            this.colAno.Name = "colAno";
            this.colAno.ReadOnly = true;
            this.colAno.Width = 60;
            // 
            // colDocumentacao
            // 
            this.colDocumentacao.DataPropertyName = "CADDOCUMENTACAO";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colDocumentacao.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDocumentacao.HeaderText = "Documentação";
            this.colDocumentacao.Name = "colDocumentacao";
            this.colDocumentacao.ReadOnly = true;
            this.colDocumentacao.Width = 150;
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.DataPropertyName = "CADDATAVENCIMENTO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "dd/MM/yyyy";
            dataGridViewCellStyle9.NullValue = null;
            this.colDataVencimento.DefaultCellStyle = dataGridViewCellStyle9;
            this.colDataVencimento.HeaderText = "Vencimento";
            this.colDataVencimento.Name = "colDataVencimento";
            this.colDataVencimento.ReadOnly = true;
            this.colDataVencimento.Width = 70;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "CADSTATUS";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colStatus.DefaultCellStyle = dataGridViewCellStyle10;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 60;
            // 
            // colDataCadastro
            // 
            this.colDataCadastro.DataPropertyName = "CADDATACADASTROFROTA";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "dd/MM/yyyy";
            this.colDataCadastro.DefaultCellStyle = dataGridViewCellStyle11;
            this.colDataCadastro.HeaderText = "Data Cadastro";
            this.colDataCadastro.Name = "colDataCadastro";
            this.colDataCadastro.ReadOnly = true;
            this.colDataCadastro.Width = 70;
            // 
            // FrmFrotaSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 361);
            this.Controls.Add(this.dataGridViewPrincipal);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.labelPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFrotaSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Frota";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.DataGridView dataGridViewPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCadastro;
    }
}