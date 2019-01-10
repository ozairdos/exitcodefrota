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
    public partial class FrmCausaCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        //Construtor
        public FrmCausaCadastrar(AcaoNaTela acaoNaTela, Causa causa)
        {
            InitializeComponent();
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Causa";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Causa";

                textBoxCodigo.Text = causa.IDCADCAUSA.ToString();
                textBoxCausa.Text = causa.CADCAUSA;
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Causa";

                //Carregar campos da tela
                textBoxCodigo.Text = causa.IDCADCAUSA.ToString();
                textBoxCausa.Text = causa.CADCAUSA;

                //Desabilitar campos da tela
                textBoxCausa.ReadOnly = true;
                textBoxCausa.TabStop = false;

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
                Causa causa = new Causa();

                causa.CADCAUSA = textBoxCausa.Text;

                CausaNegocios causaNegocios = new CausaNegocios();

                string retorno = causaNegocios.Inserir(causa);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idCausa = Convert.ToInt32(retorno);
                    MessageBox.Show("Causa inserido com sucesso." + idCausa.ToString());
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
                Causa causa = new Causa();

                //Coloco os campos da tela no objeto clliente, e envio para alterar no banco

                causa.IDCADCAUSA = Convert.ToInt32(textBoxCodigo.Text);
                causa.CADCAUSA = textBoxCausa.Text;

                CausaNegocios causaNegocios = new CausaNegocios();

                string retorno = causaNegocios.Alterar(causa);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idCausa = Convert.ToInt32(retorno);
                    MessageBox.Show("Causa alterado com sucesso." + idCausa.ToString());
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
