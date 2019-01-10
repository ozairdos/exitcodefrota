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
    public partial class FrmMovAbastecimentoSelecionar : Form
    {
        public FrmMovAbastecimentoSelecionar()
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
            MovAbastecimentoNegocios movAbastecimentoNegocios = new MovAbastecimentoNegocios();

            MovAbastecimentoColecao movAbastecimentoColecao = new MovAbastecimentoColecao();
            movAbastecimentoColecao = movAbastecimentoNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = movAbastecimentoColecao;

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
                MessageBox.Show("Nenhum movimento selecionado.");
                return;
            }

            //Perguntar se realmente quer excluir
            
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            //Pegar o cliente selecionado no grid
            MovAbastecimento movAbastecimentoSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as MovAbastecimento);

            //Instânciar a regra de negócio
            MovAbastecimentoNegocios movAbastecimentoNegocios = new MovAbastecimentoNegocios();

            //Chamar o método para excluir
            string retorno = movAbastecimentoNegocios.Excluir(movAbastecimentoSelecionado);
            
            //Verificar se excluiu com sucesso
            //Se o retorno for um número é porque deu certo, senão é a mensagem de erro

            try
            {
                int idAbaFrota = Convert.ToInt32(retorno);

                MessageBox.Show("Movimento excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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
                FrmMovAbastecimentoCadastrar frmMovAbastecimentoCadastrar = new FrmMovAbastecimentoCadastrar(AcaoNaTela.Inserir, null);
                DialogResult dialogResult = frmMovAbastecimentoCadastrar.ShowDialog();
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
                MessageBox.Show("Nenhum movimento selecionado.");
                return;
            }

            //Pegar o cliente selecionado no grid
            MovAbastecimento movAbastecimentoSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as MovAbastecimento);
            
            //Instanciar o formulário de cadastro
            FrmMovAbastecimentoCadastrar frmMovAbastecimentoCadastrar = new FrmMovAbastecimentoCadastrar(AcaoNaTela.Alterar, movAbastecimentoSelecionado);

            DialogResult resultado = frmMovAbastecimentoCadastrar.ShowDialog();
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
                MessageBox.Show("Nenhum movimento selecionado.");
                return;
            }

            //Pegar o cliente selecionado no grid
            MovAbastecimento movAbastecimentoSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as MovAbastecimento);
            
            //Instanciar o formulário de cadastro
            FrmMovAbastecimentoCadastrar frmMovAbastecimentoCadastrar = new FrmMovAbastecimentoCadastrar(AcaoNaTela.Consultar, movAbastecimentoSelecionado);
            frmMovAbastecimentoCadastrar.ShowDialog();
        }
                
    }
}
