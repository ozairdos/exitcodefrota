using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmMotoristaSelecionar : Form
    {
        public FrmMotoristaSelecionar()
        {
            InitializeComponent();
            //Não gerar linhas automaticamente
            dataGridViewPrincipal.AutoGenerateColumns = false;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        //Criando um método atualizar grid
        private void AtualizarGrid()
        {
            MotoristaNegocios motoristaNegocios = new MotoristaNegocios();

            MotoristaColecao motoristaColecao = new MotoristaColecao();
            motoristaColecao = motoristaNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = motoristaColecao;

            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //Verificar se tem algum registro selecionado

            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum motorista selecionado.");
                return;
            }

            //Perguntar se realmente quer excluir

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            //Pegar o cliente selecionado no grid
            Motorista motoristaSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Motorista);

            //Instânciar a regra de negócio
            MotoristaNegocios motoristaNegocios = new MotoristaNegocios();

            //Chamar o método para excluir
            string retorno = motoristaNegocios.Excluir(motoristaSelecionado);

            //Verificar se excluiu com sucesso
            //Se o retorno for um número é porque deu certo, senão é a mensagem de erro

            try
            {
                int idMotorista = Convert.ToInt32(retorno);

                MessageBox.Show("Motorista excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGrid();

            }
            catch
            {
                MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            {
                //Instanciar o formulário de cadastro
                FrmMotoristaCadastrar frmMotoristaCadastrar = new FrmMotoristaCadastrar(AcaoNaTela.Inserir, null);
                DialogResult dialogResult = frmMotoristaCadastrar.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    AtualizarGrid();
                }
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            //Verificar se tem algum registro selecionado
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum motorista selecionado.");
                return;
            }

            //Pegar o cliente selecionado no grid
            Motorista motoristaSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Motorista);

            //Instanciar o formulário de cadastro
            FrmMotoristaCadastrar frmMotoristaCadastrar = new FrmMotoristaCadastrar(AcaoNaTela.Alterar, motoristaSelecionado);

            DialogResult resultado = frmMotoristaCadastrar.ShowDialog();
            if (resultado == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            //Verificar se tem algum registro selecionado
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum motorista selecionado.");
                return;
            }

            //Pegar o cliente selecionado no grid
            Motorista motoristaSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Motorista);

            //Instanciar o formulário de cadastro
            FrmMotoristaCadastrar frmMotoristaCadastrar = new FrmMotoristaCadastrar(AcaoNaTela.Consultar, motoristaSelecionado);
            frmMotoristaCadastrar.ShowDialog();
        }
    }
}
