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
    public partial class FrmPostoCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        //Construtor
        public FrmPostoCadastrar(AcaoNaTela acaoNaTela, Posto posto)
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

                textBoxCodigo.Text = posto.IDCADPOSTO.ToString();
                textBoxPosto.Text = posto.CADPOSTO;
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Serviço";

                //Carregar campos da tela
                textBoxCodigo.Text = posto.IDCADPOSTO.ToString();
                textBoxPosto.Text = posto.CADPOSTO;

                //Desabilitar campos da tela
                textBoxPosto.ReadOnly = true;
                textBoxPosto.TabStop = false;

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
                Posto posto = new Posto();

                posto.CADPOSTO = textBoxPosto.Text;

                PostoNegocios postoNegocios = new PostoNegocios();

                string retorno = postoNegocios.Inserir(posto);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idPosto = Convert.ToInt32(retorno);
                    MessageBox.Show("Serviço inserido com sucesso." + idPosto.ToString());
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
                Posto posto = new Posto();

                //Coloco os campos da tela no objeto clliente, e envio para alterar no banco

                posto.IDCADPOSTO = Convert.ToInt32(textBoxCodigo.Text);
                posto.CADPOSTO = textBoxPosto.Text;

                PostoNegocios postoNegocios = new PostoNegocios();

                string retorno = postoNegocios.Alterar(posto);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idPosto = Convert.ToInt32(retorno);
                    MessageBox.Show("Serviço alterado com sucesso." + idPosto.ToString());
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
