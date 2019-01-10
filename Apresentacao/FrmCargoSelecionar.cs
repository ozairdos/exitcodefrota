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
    public partial class FrmCargoSelecionar : Form
    {
        public FrmCargoSelecionar()
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
            CargoNegocios cargoNegocios = new CargoNegocios();

            CargoColecao cargoColecao = new CargoColecao();
            cargoColecao = cargoNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = cargoColecao;

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
                MessageBox.Show("Nenhum cargo selecionado.");
                return;
            }

            //Perguntar se realmente quer excluir

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            //Pegar o cliente selecionado no grid
            Cargo cargoSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cargo);

            //Instânciar a regra de negócio
            CargoNegocios cargoNegocios = new CargoNegocios();

            //Chamar o método para excluir
            string retorno = cargoNegocios.Excluir(cargoSelecionado);

            //Verificar se excluiu com sucesso
            //Se o retorno for um número é porque deu certo, senão é a mensagem de erro

            try
            {
                int idCargo = Convert.ToInt32(retorno);

                MessageBox.Show("Cargo excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                FrmCargoCadastrar frmCargoCadastrar = new FrmCargoCadastrar(AcaoNaTela.Inserir, null);
                DialogResult dialogResult = frmCargoCadastrar.ShowDialog();
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
                MessageBox.Show("Nenhum cargo selecionado.");
                return;
            }

            //Pegar o cliente selecionado no grid
            Cargo cargoSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cargo);

            //Instanciar o formulário de cadastro
            FrmCargoCadastrar frmCargoCadastrar = new FrmCargoCadastrar(AcaoNaTela.Alterar, cargoSelecionado);

            DialogResult resultado = frmCargoCadastrar.ShowDialog();
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
                MessageBox.Show("Nenhum cargo selecionado.");
                return;
            }

            //Pegar o cliente selecionado no grid
            Cargo cargoSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cargo);
            
            //Instanciar o formulário de cadastro
            FrmCargoCadastrar frmCargoCadastrar = new FrmCargoCadastrar(AcaoNaTela.Consultar, cargoSelecionado);
            frmCargoCadastrar.ShowDialog();
        }
        
    }
}
