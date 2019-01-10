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
    public partial class FrmFrotaSelecionar : Form
    {
        public FrmFrotaSelecionar()
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
            FrotaNegocios frotaNegocios = new FrotaNegocios();

            FrotaColecao frotaColecao = new FrotaColecao();
            frotaColecao = frotaNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = frotaColecao;

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
            Frota frotaSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Frota);

            //Instânciar a regra de negócio
            FrotaNegocios frotaNegocios = new FrotaNegocios();

            //Chamar o método para excluir
            string retorno = frotaNegocios.Excluir(frotaSelecionado);
            
            //Verificar se excluiu com sucesso
            //Se o retorno for um número é porque deu certo, senão é a mensagem de erro

            try
            {
                int idFrota = Convert.ToInt32(retorno);

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
                FrmFrotaCadastrar frmFrotaCadastrar = new FrmFrotaCadastrar(AcaoNaTela.Inserir, null);
                DialogResult dialogResult = frmFrotaCadastrar.ShowDialog();
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
            Frota frotaSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Frota);
            
            //Instanciar o formulário de cadastro
            FrmFrotaCadastrar frmFrotaCadastrar = new FrmFrotaCadastrar(AcaoNaTela.Alterar, frotaSelecionado);
            
            DialogResult resultado = frmFrotaCadastrar.ShowDialog();
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
            Frota frotaSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Frota);
            
            //Instanciar o formulário de cadastro
            FrmFrotaCadastrar frmFrotaCadastrar = new FrmFrotaCadastrar(AcaoNaTela.Consultar, frotaSelecionado);
            frmFrotaCadastrar.ShowDialog();
        }
    }
}
