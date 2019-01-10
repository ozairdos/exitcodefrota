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
    public partial class FrmServicoCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        //Construtor
        public FrmServicoCadastrar(AcaoNaTela acaoNaTela, Servico servico)
        {
            InitializeComponent();
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Serviço";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Serviço";

                textBoxCodigo.Text = servico.IDCADSERVICO.ToString();
                textBoxServico.Text = servico.CADSERVICO;
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Serviço";

                //Carregar campos da tela
                textBoxCodigo.Text = servico.IDCADSERVICO.ToString();
                textBoxServico.Text = servico.CADSERVICO;

                //Desabilitar campos da tela
                textBoxServico.ReadOnly = true;
                textBoxServico.TabStop = false;

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
                Servico servico = new Servico();

                servico.CADSERVICO = textBoxServico.Text;

                ServicoNegocios servicoNegocios = new ServicoNegocios();

                string retorno = servicoNegocios.Inserir(servico);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idServico = Convert.ToInt32(retorno);
                    MessageBox.Show("Serviço inserido com sucesso." + idServico.ToString());
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
                Servico servico = new Servico();

                //Coloco os campos da tela no objeto clliente, e envio para alterar no banco

                servico.IDCADSERVICO = Convert.ToInt32(textBoxCodigo.Text);
                servico.CADSERVICO = textBoxServico.Text;

                ServicoNegocios servicoNegocios = new ServicoNegocios();

                string retorno = servicoNegocios.Alterar(servico);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idServico = Convert.ToInt32(retorno);
                    MessageBox.Show("Serviço alterado com sucesso." + idServico.ToString());
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
