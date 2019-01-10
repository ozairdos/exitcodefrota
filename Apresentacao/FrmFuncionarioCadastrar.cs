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
using System.Data.SqlClient;

namespace Apresentacao
{
    public partial class FrmFuncionarioCadastrar : Form
    {

        AcaoNaTela acaoNaTelaSelecionada;        
        

        //Construtor
        public FrmFuncionarioCadastrar(AcaoNaTela acaoNaTela, Funcionario funcionario)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Funcionario";
                dateDataCadastro.Enabled = false;
                 
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Funcionario";                           
               
                textBoxCodigo.Text = funcionario.IDCADFUNCIONARIO.ToString();
                textBoxNome.Text = funcionario.CADNOMEFUNCIONARIO;
                textBoxEndereco.Text = funcionario.CADENDFUNCIONARIO;
                textBoxTelefone.Text = funcionario.CADTELFUNCIONARIO;
                textBoxCPF.Text = funcionario.CADCPFFUNCIONARIO;
                textBoxRG.Text = funcionario.CADRGFUNCIONARIO;
                dateNascimento.Value = funcionario.CADDATANASCFUNCIONARIO;
                comboBoxCargo.Text = funcionario.CADCARGOFUNCIONARIO;
                dateDataCadastro.Value = funcionario.CADDATACADASTROFUNCIONARIO;

                dateDataCadastro.Enabled = false;
                            
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Funcionario";

                //Carregar campos da tela

                textBoxCodigo.Text = funcionario.IDCADFUNCIONARIO.ToString();
                textBoxNome.Text = funcionario.CADNOMEFUNCIONARIO;
                textBoxEndereco.Text = funcionario.CADENDFUNCIONARIO;
                textBoxTelefone.Text = funcionario.CADTELFUNCIONARIO;
                textBoxCPF.Text = funcionario.CADCPFFUNCIONARIO;
                textBoxRG.Text = funcionario.CADRGFUNCIONARIO;
                dateNascimento.Value = funcionario.CADDATANASCFUNCIONARIO;
                comboBoxCargo.Text = funcionario.CADCARGOFUNCIONARIO;
                dateDataCadastro.Value = funcionario.CADDATACADASTROFUNCIONARIO;
                
                //Desabilitar campos da tela
                textBoxNome.ReadOnly = true;
                textBoxNome.TabStop = false;

                textBoxEndereco.ReadOnly = true;
                textBoxEndereco.TabStop = false;

                textBoxTelefone.ReadOnly = true;
                textBoxTelefone.TabStop = false;

                textBoxCPF.ReadOnly = true;
                textBoxCPF.TabStop = false;

                textBoxRG.ReadOnly = true;
                textBoxRG.TabStop = false;

                dateNascimento.Enabled = false;   

                comboBoxCargo.Enabled = false;
                comboBoxCargo.TabStop = false;

                dateDataCadastro.Enabled = false;
                
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
                Funcionario funcionario = new Funcionario();
                               
                funcionario.CADNOMEFUNCIONARIO = textBoxNome.Text;
                funcionario.CADENDFUNCIONARIO = textBoxEndereco.Text;
                funcionario.CADTELFUNCIONARIO = textBoxTelefone.Text;
                funcionario.CADCPFFUNCIONARIO = textBoxCPF.Text;
                funcionario.CADRGFUNCIONARIO = textBoxRG.Text;
                funcionario.CADDATANASCFUNCIONARIO = dateNascimento.Value;
                funcionario.CADCARGOFUNCIONARIO = comboBoxCargo.Text;
                funcionario.CADDATACADASTROFUNCIONARIO = dateDataCadastro.Value;
                                
                FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();
                
                string retorno = funcionarioNegocios.Inserir(funcionario);
                
                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idFuncionario = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com sucesso." + idFuncionario.ToString());
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
                Funcionario funcionario = new Funcionario();

                //Coloco os campos da tela no objeto clliente, e envio para alterar no banco

                funcionario.IDCADFUNCIONARIO = Convert.ToInt32(textBoxCodigo.Text);

                funcionario.CADNOMEFUNCIONARIO = textBoxNome.Text;
                funcionario.CADENDFUNCIONARIO = textBoxEndereco.Text;
                funcionario.CADTELFUNCIONARIO = textBoxTelefone.Text;
                funcionario.CADCPFFUNCIONARIO = textBoxCPF.Text;
                funcionario.CADRGFUNCIONARIO = textBoxRG.Text;
                funcionario.CADDATANASCFUNCIONARIO = dateNascimento.Value;
                funcionario.CADCARGOFUNCIONARIO = comboBoxCargo.Text;
                funcionario.CADDATACADASTROFUNCIONARIO = dateDataCadastro.Value;

                FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();

                string retorno = funcionarioNegocios.Alterar(funcionario);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idFuncionario = Convert.ToInt32(retorno);
                    MessageBox.Show("Alterado com sucesso." + idFuncionario.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possível alterar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
                
            }
        }

        private void FrmFuncionarioCadastrar_Load(object sender, EventArgs e)
        {
            AtualizarCombo();
        }

        private void AtualizarCombo()
        {
            SqlConnection cs = new SqlConnection(@"Data Source=.\SQL1;Initial Catalog=ExitCodeFrotaBD;Persist Security Info=True;User ID=sa;Password=masterkey");
            SqlDataAdapter da = new SqlDataAdapter("SELECT CADCARGO FROM TBCADCARGO ORDER BY CADCARGO", cs);
            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxCargo.Items.Add(dt.Rows[i]["CADCARGO"]);                
            }
        }
         
    }
}
