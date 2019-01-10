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
    public partial class FrmCombustivelCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        //Construtor
        public FrmCombustivelCadastrar(AcaoNaTela acaoNaTela, Combustivel combustivel)
        {
            InitializeComponent();
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Combustível";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Combustível";

                textBoxCodigo.Text = combustivel.IDCADCOMBUSTIVEL.ToString();
                textBoxCombustivel.Text = combustivel.CADCOMBUSTIVEL;
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Combustível";

                //Carregar campos da tela
                textBoxCodigo.Text = combustivel.IDCADCOMBUSTIVEL.ToString();
                textBoxCombustivel.Text = combustivel.CADCOMBUSTIVEL;

                //Desabilitar campos da tela
                textBoxCombustivel.ReadOnly = true;
                textBoxCombustivel.TabStop = false;

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
                Combustivel combustivel = new Combustivel();

                combustivel.CADCOMBUSTIVEL = textBoxCombustivel.Text;

                CombustivelNegocios combustivelNegocios = new CombustivelNegocios();

                string retorno = combustivelNegocios.Inserir(combustivel);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idCombustivel = Convert.ToInt32(retorno);
                    MessageBox.Show("Combustível inserido com sucesso." + idCombustivel.ToString());
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
                Combustivel combustivel = new Combustivel();

                //Coloco os campos da tela no objeto clliente, e envio para alterar no banco

                combustivel.IDCADCOMBUSTIVEL = Convert.ToInt32(textBoxCodigo.Text);
                combustivel.CADCOMBUSTIVEL = textBoxCombustivel.Text;

                CombustivelNegocios combustivelNegocios = new CombustivelNegocios();

                string retorno = combustivelNegocios.Alterar(combustivel);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idCombustivel = Convert.ToInt32(retorno);
                    MessageBox.Show("Combustível alterado com sucesso." + idCombustivel.ToString());
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
