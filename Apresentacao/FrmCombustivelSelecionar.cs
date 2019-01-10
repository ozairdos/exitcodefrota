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
    public partial class FrmCombustivelSelecionar : Form
    {
        public FrmCombustivelSelecionar()
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
            CombustivelNegocios combustivelNegocios = new CombustivelNegocios();

            CombustivelColecao combustivelColecao = new CombustivelColecao();
            combustivelColecao = combustivelNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = combustivelColecao;

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
                MessageBox.Show("Nenhuma opção selecionada.");
                return;
            }

            //Perguntar se realmente quer excluir

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            //Pegar o cliente selecionado no grid
            Combustivel combustivelSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Combustivel);

            //Instânciar a regra de negócio
            CombustivelNegocios combustivelNegocios = new CombustivelNegocios();

            //Chamar o método para excluir
            string retorno = combustivelNegocios.Excluir(combustivelSelecionado);

            //Verificar se excluiu com sucesso
            //Se o retorno for um número é porque deu certo, senão é a mensagem de erro

            try
            {
                int idCombustivel = Convert.ToInt32(retorno);

                MessageBox.Show("Excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                FrmCombustivelCadastrar frmCombustivelCadastrar = new FrmCombustivelCadastrar(AcaoNaTela.Inserir, null);
                DialogResult dialogResult = frmCombustivelCadastrar.ShowDialog();
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
                MessageBox.Show("Nenhuma opção selecionada.");
                return;
            }

            //Pegar o cliente selecionado no grid
            Combustivel combustivelSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Combustivel);

            //Instanciar o formulário de cadastro
            FrmCombustivelCadastrar frmCombustivelCadastrar = new FrmCombustivelCadastrar(AcaoNaTela.Alterar, combustivelSelecionado);

            DialogResult resultado = frmCombustivelCadastrar.ShowDialog();
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
                MessageBox.Show("Nenhuma opção selecionada.");
                return;
            }

            //Pegar o cliente selecionado no grid
            Combustivel combustivelSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Combustivel);
            
            //Instanciar o formulário de cadastro
            FrmCombustivelCadastrar frmCombustivelCadastrar = new FrmCombustivelCadastrar(AcaoNaTela.Consultar, combustivelSelecionado);
            frmCombustivelCadastrar.ShowDialog();
        }
        
    }
}
