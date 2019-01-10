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
    public partial class FrmManutencaoCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        //Construtor
        public FrmManutencaoCadastrar(AcaoNaTela acaoNaTela, Manutencao manutencao)
        {
            InitializeComponent();
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Manutenção";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Manutenção";

                textBoxCodigo.Text = manutencao.IDCADMANUTENCAO.ToString();
                textBoxManutencao.Text = manutencao.CADMANUTENCAO;
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Manutenção";

                //Carregar campos da tela
                textBoxCodigo.Text = manutencao.IDCADMANUTENCAO.ToString();
                textBoxManutencao.Text = manutencao.CADMANUTENCAO;

                //Desabilitar campos da tela
                textBoxManutencao.ReadOnly = true;
                textBoxManutencao.TabStop = false;

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
                Manutencao manutencao = new Manutencao();

                manutencao.CADMANUTENCAO = textBoxManutencao.Text;

                ManutencaoNegocios manutencaoNegocios = new ManutencaoNegocios();

                string retorno = manutencaoNegocios.Inserir(manutencao);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idmanutencao = Convert.ToInt32(retorno);
                    MessageBox.Show("Manutenção inserido com sucesso." + idmanutencao.ToString());
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
                Manutencao manutencao = new Manutencao();

                //Coloco os campos da tela no objeto clliente, e envio para alterar no banco

                manutencao.IDCADMANUTENCAO = Convert.ToInt32(textBoxCodigo.Text);
                manutencao.CADMANUTENCAO = textBoxManutencao.Text;

                ManutencaoNegocios manutencaoNegocios = new ManutencaoNegocios();

                string retorno = manutencaoNegocios.Alterar(manutencao);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idmanutencao = Convert.ToInt32(retorno);
                    MessageBox.Show("Manutenção alterado com sucesso." + idmanutencao.ToString());
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
