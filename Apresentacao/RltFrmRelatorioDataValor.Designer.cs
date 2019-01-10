namespace Apresentacao
{
    partial class RltFrmRelatorioDataValor
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RltFrmRelatorioDataValor));
            this.TBMOVABASTECIMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExitCodeFrotaBDDataSet = new Apresentacao.ExitCodeFrotaBDDataSet();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.TBMOVABASTECIMENTOTableAdapter = new Apresentacao.ExitCodeFrotaBDDataSetTableAdapters.TBMOVABASTECIMENTOTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.comboBoxPlaca = new System.Windows.Forms.ComboBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.labelDataInicial = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.TBMOVABASTECIMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitCodeFrotaBDDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBMOVABASTECIMENTOBindingSource
            // 
            this.TBMOVABASTECIMENTOBindingSource.DataMember = "TBMOVABASTECIMENTO";
            this.TBMOVABASTECIMENTOBindingSource.DataSource = this.ExitCodeFrotaBDDataSet;
            // 
            // ExitCodeFrotaBDDataSet
            // 
            this.ExitCodeFrotaBDDataSet.DataSetName = "ExitCodeFrotaBDDataSet";
            this.ExitCodeFrotaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPesquisar.ForeColor = System.Drawing.Color.White;
            this.buttonPesquisar.Location = new System.Drawing.Point(608, 3);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 24);
            this.buttonPesquisar.TabIndex = 0;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // dateInicial
            // 
            this.dateInicial.CustomFormat = "dd/MM/yyyy";
            this.dateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInicial.Location = new System.Drawing.Point(185, 8);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(80, 20);
            this.dateInicial.TabIndex = 1;
            // 
            // dateFinal
            // 
            this.dateFinal.CustomFormat = "dd/MM/yyyy";
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinal.Location = new System.Drawing.Point(335, 7);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(80, 20);
            this.dateFinal.TabIndex = 2;
            // 
            // TBMOVABASTECIMENTOTableAdapter
            // 
            this.TBMOVABASTECIMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPlaca);
            this.panel1.Controls.Add(this.comboBoxPlaca);
            this.panel1.Controls.Add(this.buttonFechar);
            this.panel1.Controls.Add(this.labelDataFinal);
            this.panel1.Controls.Add(this.labelDataInicial);
            this.panel1.Controls.Add(this.dateInicial);
            this.panel1.Controls.Add(this.buttonPesquisar);
            this.panel1.Controls.Add(this.dateFinal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 30);
            this.panel1.TabIndex = 4;
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(421, 14);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(37, 13);
            this.labelPlaca.TabIndex = 9;
            this.labelPlaca.Text = "Placa:";
            // 
            // comboBoxPlaca
            // 
            this.comboBoxPlaca.FormattingEnabled = true;
            this.comboBoxPlaca.Location = new System.Drawing.Point(464, 7);
            this.comboBoxPlaca.Name = "comboBoxPlaca";
            this.comboBoxPlaca.Size = new System.Drawing.Size(107, 21);
            this.comboBoxPlaca.TabIndex = 8;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(697, 3);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 24);
            this.buttonFechar.TabIndex = 5;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.Location = new System.Drawing.Point(271, 14);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(58, 13);
            this.labelDataFinal.TabIndex = 4;
            this.labelDataFinal.Text = "Data Final:";
            // 
            // labelDataInicial
            // 
            this.labelDataInicial.AutoSize = true;
            this.labelDataInicial.Location = new System.Drawing.Point(116, 14);
            this.labelDataInicial.Name = "labelDataInicial";
            this.labelDataInicial.Size = new System.Drawing.Size(63, 13);
            this.labelDataInicial.TabIndex = 3;
            this.labelDataInicial.Text = "Data Inicial:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMovimentoFrota";
            reportDataSource1.Value = this.TBMOVABASTECIMENTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao.RtlMovimentoPorDataValor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 531);
            this.reportViewer1.TabIndex = 5;
            // 
            // RltFrmRelatorioDataValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RltFrmRelatorioDataValor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Frota Valor por data";
            this.Load += new System.EventHandler(this.RltFrmRelatorioData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBMOVABASTECIMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitCodeFrotaBDDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.BindingSource TBMOVABASTECIMENTOBindingSource;
        private ExitCodeFrotaBDDataSet ExitCodeFrotaBDDataSet;
        private ExitCodeFrotaBDDataSetTableAdapters.TBMOVABASTECIMENTOTableAdapter TBMOVABASTECIMENTOTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.Label labelDataInicial;
        private System.Windows.Forms.Button buttonFechar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.ComboBox comboBoxPlaca;
    }
}