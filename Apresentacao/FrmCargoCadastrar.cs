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
    public partial class FrmCargoCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        //Construtor
        public FrmCargoCadastrar(AcaoNaTela acaoNaTela, Cargo cargo)
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

                textBoxCodigo.Text = cargo.IDCADCARGO.ToString();
                textBoxCargo.Text = cargo.CADCARGO;
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Manutenção";

                //Carregar campos da tela
                textBoxCodigo.Text = cargo.IDCADCARGO.ToString();
                textBoxCargo.Text = cargo.CADCARGO;

                //Desabilitar campos da tela
                textBoxCargo.ReadOnly = true;
                textBoxCargo.TabStop = false;

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
                Cargo cargo = new Cargo();

                cargo.CADCARGO = textBoxCargo.Text;

                CargoNegocios cargoNegocios = new CargoNegocios();

                string retorno = cargoNegocios.Inserir(cargo);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idcargo = Convert.ToInt32(retorno);
                    MessageBox.Show("Cargo inserido com sucesso." + idcargo.ToString());
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
                Cargo cargo = new Cargo();

                //Coloco os campos da tela no objeto clliente, e envio para alterar no banco

                cargo.IDCADCARGO = Convert.ToInt32(textBoxCodigo.Text);
                cargo.CADCARGO = textBoxCargo.Text;

                CargoNegocios cargoNegocios = new CargoNegocios();

                string retorno = cargoNegocios.Alterar(cargo);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idcargo = Convert.ToInt32(retorno);
                    MessageBox.Show("Cargo alterado com sucesso." + idcargo.ToString());
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
