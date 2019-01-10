using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Apresentacao
{
    public partial class RltFrmRelatorioDataValor : Form
    {
        public RltFrmRelatorioDataValor()
        {
            InitializeComponent();
        }       

        private void RltFrmRelatorioData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ExitCodeFrotaBDDataSet.TBMOVABASTECIMENTO' table. You can move, or remove it, as needed.
            this.TBMOVABASTECIMENTOTableAdapter.Fill(this.ExitCodeFrotaBDDataSet.TBMOVABASTECIMENTO);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

            SqlConnection cs = new SqlConnection(@"Data Source=.\SQLEXPRESS2016;Initial Catalog=ExitCodeFrotaBD;User ID=sa;Password=123456");
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT CADPLACA FROM TBCADFROTA ORDER BY CADPLACA", cs);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                comboBoxPlaca.Items.Add(dt1.Rows[i]["CADPLACA"]);
            }

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FiltrarPlaca()
        {
            
                        
        }       

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            String datainicial = String.Format("{0:dd/MM/yyyy}", dateInicial.Value);
            ReportParameter reportparameter = new ReportParameter("DTI", datainicial);
            reportViewer1.LocalReport.SetParameters(reportparameter);

            String dataFinal = String.Format("{0:dd/MM/yyyy}", dateFinal.Value);
            ReportParameter reportparameter2 = new ReportParameter("DTF", dataFinal);
            reportViewer1.LocalReport.SetParameters(reportparameter2);
            reportViewer1.RefreshReport();

            ReportParameter reportparameter3 = new ReportParameter("PLACA", comboBoxPlaca.Text);
            reportViewer1.LocalReport.SetParameters(reportparameter3);
            reportViewer1.RefreshReport();
        }
                                    
    }
}
