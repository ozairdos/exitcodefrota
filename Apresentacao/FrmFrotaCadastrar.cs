using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmFrotaCadastrar : Form
    {

        AcaoNaTela acaoNaTelaSelecionada;

        //Construtor
        public FrmFrotaCadastrar(AcaoNaTela acaoNaTela, Frota frota)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Frota";
                dateDataCadastro.Enabled = false;
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Frota";

                textBoxCodigo.Text = frota.IDCADFROTA.ToString();
                textBoxTipoVeiculo.Text = frota.CADTIPODEVEICULO;
                textBoxVeiculo.Text = frota.CADVEICULO;
                textBoxPlaca.Text = frota.CADPLACA;
                textBoxCor.Text = frota.CADCOR;
                textBoxAno.Text = frota.CADANO;
                textBoxDocumentacao.Text = frota.CADDOCUMENTACAO;
                dateVencimento.Value = frota.CADDATAVENCIMENTO;
                comboBoxStatus.Text = frota.CADSTATUS;
                dateDataCadastro.Value = frota.CADDATACADASTROFROTA;

                dateDataCadastro.Enabled = false;
            
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Frota";

                //Carregar campos da tela

                textBoxCodigo.Text = frota.IDCADFROTA.ToString();
                textBoxTipoVeiculo.Text = frota.CADTIPODEVEICULO;
                textBoxVeiculo.Text = frota.CADVEICULO;
                textBoxPlaca.Text = frota.CADPLACA;
                textBoxCor.Text = frota.CADCOR;
                textBoxAno.Text = frota.CADANO;
                textBoxDocumentacao.Text = frota.CADDOCUMENTACAO;
                dateVencimento.Value = frota.CADDATAVENCIMENTO;
                comboBoxStatus.Text = frota.CADSTATUS;
                dateDataCadastro.Value = frota.CADDATACADASTROFROTA;
                
                //Desabilitar campos da tela
                textBoxTipoVeiculo.ReadOnly = true;
                textBoxTipoVeiculo.TabStop = false;

                textBoxVeiculo.ReadOnly = true;
                textBoxVeiculo.TabStop = false;

                textBoxVeiculo.ReadOnly = true;
                textBoxVeiculo.TabStop = false;

                textBoxPlaca.ReadOnly = true;
                textBoxPlaca.TabStop = false;

                textBoxCor.ReadOnly = true;
                textBoxCor.TabStop = false;

                textBoxAno.ReadOnly = true;
                textBoxAno.TabStop = false;

                textBoxDocumentacao.ReadOnly = true;
                textBoxDocumentacao.TabStop = false;

                comboBoxStatus.Enabled = false;
                comboBoxStatus.TabStop = false;

                dateVencimento.Enabled = false;                            
                
                dateDataCadastro.Enabled = false;

                buttonSalvar.Visible = false;
                buttonCancelar.Text = "&Fechar";

                buttonCancelar.Focus();
                
            }
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Verificar se é inserção ou alteração
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                Frota frota = new Frota();

                frota.CADTIPODEVEICULO = textBoxTipoVeiculo.Text;
                frota.CADVEICULO = textBoxVeiculo.Text;
                frota.CADPLACA = textBoxPlaca.Text;
                frota.CADCOR = textBoxCor.Text;
                frota.CADANO = textBoxAno.Text;
                frota.CADDOCUMENTACAO = textBoxDocumentacao.Text;
                frota.CADDATAVENCIMENTO = dateVencimento.Value;
                frota.CADSTATUS = comboBoxStatus.Text;
                frota.CADDATACADASTROFROTA = dateDataCadastro.Value;
                                
                FrotaNegocios frotaNegocios = new FrotaNegocios();
                
                string retorno = frotaNegocios.Inserir(frota);
                
                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idFrota = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com sucesso." + idFrota.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possível inserir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }


            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                // Crio um cliente
                Frota frota = new Frota();

                //Coloco os campos da tela no objeto clliente, e envio para alterar no banco

                frota.IDCADFROTA = Convert.ToInt32(textBoxCodigo.Text);

                frota.CADTIPODEVEICULO = textBoxTipoVeiculo.Text;
                frota.CADVEICULO = textBoxVeiculo.Text;
                frota.CADPLACA = textBoxPlaca.Text;
                frota.CADCOR = textBoxCor.Text;
                frota.CADANO = textBoxAno.Text;
                frota.CADDOCUMENTACAO = textBoxDocumentacao.Text;
                frota.CADDATAVENCIMENTO = dateVencimento.Value;
                frota.CADSTATUS = comboBoxStatus.Text;
                frota.CADDATACADASTROFROTA = dateDataCadastro.Value;

                FrotaNegocios frotaNegocios = new FrotaNegocios();

                string retorno = frotaNegocios.Alterar(frota);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idFrota = Convert.ToInt32(retorno);
                    MessageBox.Show("Alterado com sucesso." + idFrota.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possível alterar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
        }
    }
}
