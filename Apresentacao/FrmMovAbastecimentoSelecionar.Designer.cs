namespace Apresentacao
{
    partial class FrmMovAbastecimentoSelecionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovAbastecimentoSelecionar));
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
            this.colDataMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCombustivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKmInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKmFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Location = new System.Drawing.Point(7, 7);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(78, 13);
            this.labelPesquisa.TabIndex = 0;
            this.labelPesquisa.Text = "Código / Placa";
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
            this.colDataMovimento,
            this.colPlaca,
            this.colVeiculo,
            this.colMotorista,
            this.colPosto,
            this.colCombustivel,
            this.colValorUnidade,
            this.colQuantidade,
            this.colValorTotal,
            this.colKmInicial,
            this.colKmFinal,
            this.colKmTotal,
            this.colCustoTotal,
            this.colOrigem,
            this.colDestino,
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
            this.colCodigo.DataPropertyName = "IDABAFROTA";
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
            // colDataMovimento
            // 
            this.colDataMovimento.DataPropertyName = "ABADATAFROTA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.colDataMovimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDataMovimento.HeaderText = "Movimento";
            this.colDataMovimento.Name = "colDataMovimento";
            this.colDataMovimento.ReadOnly = true;
            this.colDataMovimento.Width = 70;
            // 
            // colPlaca
            // 
            this.colPlaca.DataPropertyName = "ABAPLACA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colPlaca.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPlaca.HeaderText = "Placa";
            this.colPlaca.Name = "colPlaca";
            this.colPlaca.ReadOnly = true;
            this.colPlaca.Width = 80;
            // 
            // colVeiculo
            // 
            this.colVeiculo.DataPropertyName = "ABAVEICULO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colVeiculo.DefaultCellStyle = dataGridViewCellStyle5;
            this.colVeiculo.HeaderText = "Veículo";
            this.colVeiculo.Name = "colVeiculo";
            this.colVeiculo.ReadOnly = true;
            // 
            // colMotorista
            // 
            this.colMotorista.DataPropertyName = "ABAMOTORISTA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colMotorista.DefaultCellStyle = dataGridViewCellStyle6;
            this.colMotorista.HeaderText = "Motorista";
            this.colMotorista.Name = "colMotorista";
            this.colMotorista.ReadOnly = true;
            this.colMotorista.Width = 200;
            // 
            // colPosto
            // 
            this.colPosto.DataPropertyName = "ABAPOSTO";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.NullValue = null;
            this.colPosto.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPosto.HeaderText = "Posto";
            this.colPosto.Name = "colPosto";
            this.colPosto.ReadOnly = true;
            this.colPosto.Width = 250;
            // 
            // colCombustivel
            // 
            this.colCombustivel.DataPropertyName = "ABACOMBUSTIVEL";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colCombustivel.DefaultCellStyle = dataGridViewCellStyle8;
            this.colCombustivel.HeaderText = "Combustível";
            this.colCombustivel.Name = "colCombustivel";
            this.colCombustivel.ReadOnly = true;
            this.colCombustivel.Width = 150;
            // 
            // colValorUnidade
            // 
            this.colValorUnidade.DataPropertyName = "ABAVALORUNITARIO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.colValorUnidade.DefaultCellStyle = dataGridViewCellStyle9;
            this.colValorUnidade.HeaderText = "Valor Unidade";
            this.colValorUnidade.Name = "colValorUnidade";
            this.colValorUnidade.ReadOnly = true;
            this.colValorUnidade.Width = 70;
            // 
            // colQuantidade
            // 
            this.colQuantidade.DataPropertyName = "ABAQUANTIDADE";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.NullValue = null;
            this.colQuantidade.DefaultCellStyle = dataGridViewCellStyle10;
            this.colQuantidade.HeaderText = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            this.colQuantidade.Width = 70;
            // 
            // colValorTotal
            // 
            this.colValorTotal.DataPropertyName = "ABATOTALPAGO";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.colValorTotal.DefaultCellStyle = dataGridViewCellStyle11;
            this.colValorTotal.HeaderText = "Valor Total";
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.ReadOnly = true;
            this.colValorTotal.Width = 70;
            // 
            // colKmInicial
            // 
            this.colKmInicial.DataPropertyName = "ABAKMINICIAL";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.NullValue = null;
            this.colKmInicial.DefaultCellStyle = dataGridViewCellStyle12;
            this.colKmInicial.HeaderText = "Km Inicial";
            this.colKmInicial.Name = "colKmInicial";
            this.colKmInicial.ReadOnly = true;
            this.colKmInicial.Width = 70;
            // 
            // colKmFinal
            // 
            this.colKmFinal.DataPropertyName = "ABAKMFINAL";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colKmFinal.DefaultCellStyle = dataGridViewCellStyle13;
            this.colKmFinal.HeaderText = "Km Final";
            this.colKmFinal.Name = "colKmFinal";
            this.colKmFinal.ReadOnly = true;
            this.colKmFinal.Width = 70;
            // 
            // colKmTotal
            // 
            this.colKmTotal.DataPropertyName = "ABAKMTOTAL";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colKmTotal.DefaultCellStyle = dataGridViewCellStyle14;
            this.colKmTotal.HeaderText = "Km Total";
            this.colKmTotal.Name = "colKmTotal";
            this.colKmTotal.ReadOnly = true;
            this.colKmTotal.Width = 70;
            // 
            // colCustoTotal
            // 
            this.colCustoTotal.DataPropertyName = "ABATOTALCUSTO";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.NullValue = null;
            this.colCustoTotal.DefaultCellStyle = dataGridViewCellStyle15;
            this.colCustoTotal.HeaderText = "Km Médio";
            this.colCustoTotal.Name = "colCustoTotal";
            this.colCustoTotal.ReadOnly = true;
            this.colCustoTotal.Width = 70;
            // 
            // colOrigem
            // 
            this.colOrigem.DataPropertyName = "ABAORIGEM";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colOrigem.DefaultCellStyle = dataGridViewCellStyle16;
            this.colOrigem.HeaderText = "Origem";
            this.colOrigem.Name = "colOrigem";
            this.colOrigem.ReadOnly = true;
            this.colOrigem.Width = 150;
            // 
            // colDestino
            // 
            this.colDestino.DataPropertyName = "ABADESTINO";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colDestino.DefaultCellStyle = dataGridViewCellStyle17;
            this.colDestino.HeaderText = "Destino";
            this.colDestino.Name = "colDestino";
            this.colDestino.ReadOnly = true;
            this.colDestino.Width = 150;
            // 
            // colDataCadastro
            // 
            this.colDataCadastro.DataPropertyName = "ABADATACADASTRO";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "dd/MM/yyyy";
            dataGridViewCellStyle18.NullValue = null;
            this.colDataCadastro.DefaultCellStyle = dataGridViewCellStyle18;
            this.colDataCadastro.HeaderText = "Cadastro";
            this.colDataCadastro.Name = "colDataCadastro";
            this.colDataCadastro.ReadOnly = true;
            this.colDataCadastro.Width = 70;
            // 
            // FrmMovAbastecimentoSelecionar
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
            this.Name = "FrmMovAbastecimentoSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Movimento";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCombustivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKmInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKmFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKmTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCadastro;
    }
}