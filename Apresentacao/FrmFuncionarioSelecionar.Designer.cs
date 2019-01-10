namespace Apresentacao
{
    partial class FrmFuncionarioSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionarioSelecionar));
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
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Location = new System.Drawing.Point(7, 7);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(79, 13);
            this.labelPesquisa.TabIndex = 0;
            this.labelPesquisa.Text = "Código / Nome";
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
            this.colNome,
            this.colEndereco,
            this.colTelefone,
            this.colCPF,
            this.colRG,
            this.colDataNascimento,
            this.colCargo,
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
            this.colCodigo.DataPropertyName = "IDCADFUNCIONARIO";
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
            // colNome
            // 
            this.colNome.DataPropertyName = "CADNOMEFUNCIONARIO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colNome.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 200;
            // 
            // colEndereco
            // 
            this.colEndereco.DataPropertyName = "CADENDFUNCIONARIO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colEndereco.DefaultCellStyle = dataGridViewCellStyle4;
            this.colEndereco.HeaderText = "Endereço";
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.ReadOnly = true;
            this.colEndereco.Width = 200;
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "CADTELFUNCIONARIO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.NullValue = null;
            this.colTelefone.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Width = 80;
            // 
            // colCPF
            // 
            this.colCPF.DataPropertyName = "CADCPFFUNCIONARIO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colCPF.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            this.colCPF.ReadOnly = true;
            // 
            // colRG
            // 
            this.colRG.DataPropertyName = "CADRGFUNCIONARIO";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colRG.DefaultCellStyle = dataGridViewCellStyle7;
            this.colRG.HeaderText = "RG";
            this.colRG.Name = "colRG";
            this.colRG.ReadOnly = true;
            this.colRG.Width = 80;
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.DataPropertyName = "CADDATANASCFUNCIONARIO";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "dd/MM/yyyy";
            this.colDataNascimento.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDataNascimento.HeaderText = "Data Nascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            this.colDataNascimento.ReadOnly = true;
            this.colDataNascimento.Width = 70;
            // 
            // colCargo
            // 
            this.colCargo.DataPropertyName = "CADCARGOFUNCIONARIO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colCargo.DefaultCellStyle = dataGridViewCellStyle9;
            this.colCargo.HeaderText = "Cargo";
            this.colCargo.Name = "colCargo";
            this.colCargo.ReadOnly = true;
            this.colCargo.Width = 200;
            // 
            // colDataCadastro
            // 
            this.colDataCadastro.DataPropertyName = "CADDATACADASTROFUNCIONARIO";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "dd/MM/yyyy";
            this.colDataCadastro.DefaultCellStyle = dataGridViewCellStyle10;
            this.colDataCadastro.HeaderText = "Data Cadastro";
            this.colDataCadastro.Name = "colDataCadastro";
            this.colDataCadastro.ReadOnly = true;
            this.colDataCadastro.Width = 70;
            // 
            // FrmFuncionarioSelecionar
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
            this.Name = "FrmFuncionarioSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Funcionário";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCadastro;
    }
}