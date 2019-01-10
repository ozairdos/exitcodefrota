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
    public partial class FrmMotoristaCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmMotoristaCadastrar(AcaoNaTela acaoNaTela, Motorista motorista)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Motorista";
                dateCadastro.Enabled = false;
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Motorista";
                textBoxCodigo.Text = motorista.IDCADMOTORISTA.ToString();
                textBoxNome.Text = motorista.CADNOMEMOTORISTA;
                textBoxEndereco.Text = motorista.CADENDMOTORISTA;
                textBoxTelefone.Text = motorista.CADTELMOTORISTA;
                textBoxCPF.Text = motorista.CADCPFMOTORISTA;
                textBoxRG.Text = motorista.CADRGMOTORISTA;
                textBoxCNH.Text = motorista.CADCNHMOTORISTA;
                dateNascimento.Value = motorista.CADDATANASCMOTORISTA;
                dateCadastro.Value = motorista.CADDATACADASTROMOTORISTA;

                dateCadastro.Enabled = false;

            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Motorista";
                //Carregar campos da tela

                textBoxCodigo.Text = motorista.IDCADMOTORISTA.ToString();
                textBoxNome.Text = motorista.CADNOMEMOTORISTA;
                textBoxEndereco.Text = motorista.CADENDMOTORISTA;
                textBoxTelefone.Text = motorista.CADTELMOTORISTA;
                textBoxCPF.Text = motorista.CADCPFMOTORISTA;
                textBoxRG.Text = motorista.CADRGMOTORISTA;
                textBoxCNH.Text = motorista.CADCNHMOTORISTA;
                dateNascimento.Value = motorista.CADDATANASCMOTORISTA;
                dateCadastro.Value = motorista.CADDATACADASTROMOTORISTA;

                //Desabilitar campos da tela
                textBoxNome.ReadOnly = true;
                textBoxNome.TabStop = false;

                textBoxEndereco.ReadOnly = true;
                textBoxEndereco.TabStop = false;

                textBoxTelefone.ReadOnly = true;
                textBoxTelefone.TabStop = false;

                textBoxCPF.ReadOnly = true;
                textBoxCPF.TabStop = false;

                textBoxRG.ReadOnly = true;
                textBoxRG.TabStop = false;
                                
                textBoxCNH.ReadOnly = true;
                textBoxCNH.TabStop = false;

                dateNascimento.Enabled = false;

                dateCadastro.Enabled = false;

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
                Motorista motorista = new Motorista();

                motorista.CADNOMEMOTORISTA = textBoxNome.Text;
                motorista.CADENDMOTORISTA = textBoxEndereco.Text;
                motorista.CADTELMOTORISTA = textBoxTelefone.Text;
                motorista.CADCPFMOTORISTA = textBoxCPF.Text;
                motorista.CADRGMOTORISTA = textBoxRG.Text;
                motorista.CADCNHMOTORISTA = textBoxCNH.Text;
                motorista.CADDATANASCMOTORISTA = dateNascimento.Value;
                motorista.CADDATACADASTROMOTORISTA = dateCadastro.Value;

                MotoristaNegocios motoristaNegocios = new MotoristaNegocios();
                string retorno = motoristaNegocios.Inserir(motorista);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do motorista
                //Se der errado tem a mensagem de erro

                try
                {
                    int idMotorista = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com sucesso." + idMotorista.ToString());
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
                // Crio um motorista
                Motorista motorista = new Motorista();

                //Coloco os campos da tela no objeto clliente, e envio para alterar no banco
                
                motorista.IDCADMOTORISTA = Convert.ToInt32(textBoxCodigo.Text);

                motorista.CADNOMEMOTORISTA = textBoxNome.Text;
                motorista.CADENDMOTORISTA = textBoxEndereco.Text;
                motorista.CADTELMOTORISTA = textBoxTelefone.Text;
                motorista.CADCPFMOTORISTA = textBoxCPF.Text;
                motorista.CADRGMOTORISTA = textBoxRG.Text;
                motorista.CADCNHMOTORISTA = textBoxCNH.Text;
                motorista.CADDATANASCMOTORISTA = dateNascimento.Value;
                motorista.CADDATACADASTROMOTORISTA = dateCadastro.Value;

                MotoristaNegocios motoristaNegocios = new MotoristaNegocios();
                string retorno = motoristaNegocios.Alterar(motorista);
                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do motorista
                //Se der errado tem a mensagem de erro

                try
                {
                    int idMotorista = Convert.ToInt32(retorno);
                    MessageBox.Show("Alterado com sucesso." + idMotorista.ToString());
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
