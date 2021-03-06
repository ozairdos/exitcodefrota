﻿using System;
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
    public partial class FrmFuncionarioSelecionar : Form
    {
        public FrmFuncionarioSelecionar()
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
            FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();

            FuncionarioColecao funcionarioColecao = new FuncionarioColecao();
            funcionarioColecao = funcionarioNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = funcionarioColecao;

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
                MessageBox.Show("Nenhum funcionário selecionado.");
                return;
            }

            //Perguntar se realmente quer excluir
            
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            //Pegar o cliente selecionado no grid
            Funcionario funcionarioSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Funcionario);

            //Instânciar a regra de negócio
            FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();

            //Chamar o método para excluir
            string retorno = funcionarioNegocios.Excluir(funcionarioSelecionado);
            
            //Verificar se excluiu com sucesso
            //Se o retorno for um número é porque deu certo, senão é a mensagem de erro

            try
            {
                int idFuncionario = Convert.ToInt32(retorno);

                MessageBox.Show("Funcionário excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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
                FrmFuncionarioCadastrar frmFuncionarioCadastrar = new FrmFuncionarioCadastrar(AcaoNaTela.Inserir, null);
                DialogResult dialogResult = frmFuncionarioCadastrar.ShowDialog();
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
                MessageBox.Show("Nenhum funcionário selecionado.");
                return;
            }

            //Pegar o cliente selecionado no grid
            Funcionario funcionarioSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Funcionario);
            
            //Instanciar o formulário de cadastro
            FrmFuncionarioCadastrar frmFuncionarioCadastrar = new FrmFuncionarioCadastrar(AcaoNaTela.Alterar, funcionarioSelecionado);
            
            DialogResult resultado = frmFuncionarioCadastrar.ShowDialog();
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
                MessageBox.Show("Nenhum funcionário selecionado.");
                return;
            }

            //Pegar o cliente selecionado no grid
            Funcionario funcionarioSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Funcionario);
            
            //Instanciar o formulário de cadastro
            FrmFuncionarioCadastrar frmFuncionarioCadastrar = new FrmFuncionarioCadastrar(AcaoNaTela.Consultar, funcionarioSelecionado);
            frmFuncionarioCadastrar.ShowDialog();
        }
                
    }
}
