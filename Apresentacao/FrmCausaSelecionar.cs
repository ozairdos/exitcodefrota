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
    public partial class FrmCausaSelecionar : Form
    {
        public FrmCausaSelecionar()
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
            CausaNegocios causaNegocios = new CausaNegocios();

            CausaColecao causaColecao = new CausaColecao();
            causaColecao = causaNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = causaColecao;

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
            Causa causaSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Causa);

            //Instânciar a regra de negócio
            CausaNegocios causaNegocios = new CausaNegocios();

            //Chamar o método para excluir
            string retorno = causaNegocios.Excluir(causaSelecionado);

            //Verificar se excluiu com sucesso
            //Se o retorno for um número é porque deu certo, senão é a mensagem de erro

            try
            {
                int idCausa = Convert.ToInt32(retorno);

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
                FrmCausaCadastrar frmCausaCadastrar = new FrmCausaCadastrar(AcaoNaTela.Inserir, null);
                DialogResult dialogResult = frmCausaCadastrar.ShowDialog();
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
            Causa causaSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Causa);

            //Instanciar o formulário de cadastro
            FrmCausaCadastrar frmCausaCadastrar = new FrmCausaCadastrar(AcaoNaTela.Alterar, causaSelecionado);

            DialogResult resultado = frmCausaCadastrar.ShowDialog();
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
            Causa causaSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Causa);
            
            //Instanciar o formulário de cadastro
            FrmCausaCadastrar frmCausaCadastrar = new FrmCausaCadastrar(AcaoNaTela.Consultar, causaSelecionado);
            frmCausaCadastrar.ShowDialog();
        }
        
    }
}
