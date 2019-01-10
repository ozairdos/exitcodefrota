using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        
        private void menuFuncionario_Click(object sender, EventArgs e)
        {
           

        }

        private void menuCargo_Click(object sender, EventArgs e)
        {
            FrmCargoSelecionar frmCargoSelecionar = new FrmCargoSelecionar();

            frmCargoSelecionar.MdiParent = this;

            frmCargoSelecionar.Show();
        }

        private void menuCausa_Click(object sender, EventArgs e)
        {
            FrmCausaSelecionar frmCausaSelecionar = new FrmCausaSelecionar();

            frmCausaSelecionar.MdiParent = this;

            frmCausaSelecionar.Show();
        }

        private void menuCombustivel_Click(object sender, EventArgs e)
        {
            FrmCombustivelSelecionar frmCombustivelSelecionar = new FrmCombustivelSelecionar();

            frmCombustivelSelecionar.MdiParent = this;

            frmCombustivelSelecionar.Show();
        }

        private void menuFrota_Click(object sender, EventArgs e)
        {
            FrmFrotaSelecionar frmFrotaSelecionar = new FrmFrotaSelecionar();

            frmFrotaSelecionar.MdiParent = this;

            frmFrotaSelecionar.Show();
        }

        private void menuManutencao_Click(object sender, EventArgs e)
        {
            FrmManutencaoSelecionar frmManutencaoSelecionar = new FrmManutencaoSelecionar();

            frmManutencaoSelecionar.MdiParent = this;

            frmManutencaoSelecionar.Show();
        }

        private void menuMotorista_Click(object sender, EventArgs e)
        {
            FrmMotoristaSelecionar frmMotoristaSelecionar = new FrmMotoristaSelecionar();

            frmMotoristaSelecionar.MdiParent = this;

            frmMotoristaSelecionar.Show();
        }

        private void menuPosto_Click(object sender, EventArgs e)
        {
            FrmPostoSelecionar frmPostoSelecionar = new FrmPostoSelecionar();

            frmPostoSelecionar.MdiParent = this;

            frmPostoSelecionar.Show();
        }

        private void menuServico_Click(object sender, EventArgs e)
        {
            FrmServicoSelecionar frmServicoSelecionar = new FrmServicoSelecionar();

            frmServicoSelecionar.MdiParent = this;

            frmServicoSelecionar.Show();

        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarioSelecionar frmUsuarioSelecionar = new FrmUsuarioSelecionar();

            frmUsuarioSelecionar.MdiParent = this;

            frmUsuarioSelecionar.Show();
        }
        
        private void menuSobre_Click(object sender, EventArgs e)
        {
            FrmSobreSistema frmSobreSistema = new FrmSobreSistema();

            frmSobreSistema.MdiParent = this;

            frmSobreSistema.Show();
        }

        private void buttonMovimentoFrota_Click(object sender, EventArgs e)
        {
            
        }    

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuRltMovimentoDaFrota_Click(object sender, EventArgs e)
        {
            RltFrmRelatorioDataValor rltFrmRelatorioDataValor = new RltFrmRelatorioDataValor();

            rltFrmRelatorioDataValor.MdiParent = this;

            rltFrmRelatorioDataValor.Show();

        }

        private void movimentoFrotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovAbastecimentoSelecionar frmMovAbastecimentoSelecionar = new FrmMovAbastecimentoSelecionar();

            frmMovAbastecimentoSelecionar.MdiParent = this;

            frmMovAbastecimentoSelecionar.Show();
        }

        private void menuMovimentoFrotaDataValor_Click(object sender, EventArgs e)
        {
            RltFrmRelatorioDataValor rltFrmRelatorioDataValor = new RltFrmRelatorioDataValor();

            rltFrmRelatorioDataValor.MdiParent = this;

            rltFrmRelatorioDataValor.Show();
        }

        private void menuMovimentoFrotaDataKm_Click(object sender, EventArgs e)
        {
            RltFrmRelatorioDataKm rltFrmRelatorioDataKm = new RltFrmRelatorioDataKm();

            rltFrmRelatorioDataKm.MdiParent = this;

            rltFrmRelatorioDataKm.Show();
        }     
    }
}
