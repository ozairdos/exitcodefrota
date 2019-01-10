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
    public partial class FrmMovAbastecimentoCadastrar : Form
    {
        
        AcaoNaTela acaoNaTelaSelecionada;               


        //Construtor
        public FrmMovAbastecimentoCadastrar(AcaoNaTela acaoNaTela, MovAbastecimento movAbastecimento)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Movimento";

                dateDataCadastro.Enabled = false;
                textBoxValorTotal.Enabled = false;
                textBoxKmTotal.Enabled = false;
                textBoxTotalCusto.Enabled = false;
                 
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Movimento";

                textBoxCodigo.Text = movAbastecimento.IDABAFROTA.ToString();
                dateAbastecimento.Value = movAbastecimento.ABADATAFROTA;                
                comboBoxVeiculo.Text = movAbastecimento.ABAVEICULO;
                comboBoxPosto.Text = movAbastecimento.ABAPOSTO;
                comboBoxCombustivel.Text = movAbastecimento.ABACOMBUSTIVEL;
                textBoxValorUnitario.Text = movAbastecimento.ABAVALORUNITARIO.ToString();
                textBoxValorTotal.Text = movAbastecimento.ABATOTALPAGO.ToString();
                textBoxQuantidade.Text = movAbastecimento.ABAQUANTIDADE.ToString();
                textBoxKmInicial.Text = movAbastecimento.ABAKMINICIAL.ToString();
                textBoxKmFinal.Text = movAbastecimento.ABAKMFINAL.ToString();
                textBoxKmTotal.Text = movAbastecimento.ABAKMTOTAL.ToString();
                comboBoxMotorista.Text = movAbastecimento.ABAMOTORISTA;
                textBoxOrigem.Text = movAbastecimento.ABAORIGEM;
                textBoxDestino.Text = movAbastecimento.ABADESTINO;
                textBoxTotalCusto.Text = movAbastecimento.ABATOTALCUSTO.ToString();
                dateDataCadastro.Value = movAbastecimento.ABADATACADASTRO;
                comboBoxPlaca.Text = movAbastecimento.ABAPLACA;

                dateDataCadastro.Enabled = false;
                textBoxValorTotal.Enabled = false;
                textBoxKmTotal.Enabled = false;
                textBoxTotalCusto.Enabled = false;
                                            
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Movimento";

                //Carregar campos da tela

                textBoxCodigo.Text = movAbastecimento.IDABAFROTA.ToString();
                dateAbastecimento.Value = movAbastecimento.ABADATAFROTA;
                comboBoxVeiculo.Text = movAbastecimento.ABAVEICULO;
                comboBoxPosto.Text = movAbastecimento.ABAPOSTO;
                comboBoxCombustivel.Text = movAbastecimento.ABACOMBUSTIVEL;
                textBoxValorUnitario.Text = movAbastecimento.ABAVALORUNITARIO.ToString();
                textBoxValorTotal.Text = movAbastecimento.ABATOTALPAGO.ToString();
                textBoxQuantidade.Text = movAbastecimento.ABAQUANTIDADE.ToString();
                textBoxKmInicial.Text = movAbastecimento.ABAKMINICIAL.ToString();
                textBoxKmFinal.Text = movAbastecimento.ABAKMFINAL.ToString();
                textBoxKmTotal.Text = movAbastecimento.ABAKMTOTAL.ToString();
                comboBoxMotorista.Text = movAbastecimento.ABAMOTORISTA;
                textBoxOrigem.Text = movAbastecimento.ABAORIGEM;
                textBoxDestino.Text = movAbastecimento.ABADESTINO;
                textBoxTotalCusto.Text = movAbastecimento.ABATOTALCUSTO.ToString();
                dateDataCadastro.Value = movAbastecimento.ABADATACADASTRO;
                comboBoxPlaca.Text = movAbastecimento.ABAPLACA;
                
                //Desabilitar campos da tela

                dateAbastecimento.Enabled = false;

                comboBoxVeiculo.Enabled = false;
                comboBoxVeiculo.TabStop = false;

                comboBoxPosto.Enabled = false;
                comboBoxPosto.TabStop = false;

                comboBoxCombustivel.Enabled = false;
                comboBoxCombustivel.TabStop = false;

                textBoxValorUnitario.ReadOnly = true;
                textBoxValorUnitario.TabStop = false;

                textBoxDestino.ReadOnly = true;
                textBoxDestino.TabStop = false;

                textBoxValorUnitario.ReadOnly = true;
                textBoxValorUnitario.TabStop = false;

                textBoxValorTotal.ReadOnly = true;
                textBoxValorTotal.TabStop = false;
                           
                textBoxQuantidade.ReadOnly = true;
                textBoxQuantidade.TabStop = false;

                textBoxKmInicial.ReadOnly = true;
                textBoxKmInicial.TabStop = false;

                textBoxKmFinal.ReadOnly = true;
                textBoxKmFinal.TabStop = false;

                textBoxKmTotal.ReadOnly = true;
                textBoxKmTotal.TabStop = false;

                comboBoxMotorista.Enabled = false;
                comboBoxMotorista.TabStop = false;

                textBoxOrigem.ReadOnly = true;
                textBoxOrigem.TabStop = false;

                textBoxDestino.ReadOnly = true;
                textBoxDestino.TabStop = false;

                textBoxTotalCusto.ReadOnly = true;
                textBoxTotalCusto.TabStop = false;
                
                dateDataCadastro.Enabled = false;


                comboBoxPlaca.Enabled = false;
                comboBoxPlaca.TabStop = false;
                
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
                MovAbastecimento movAbastecimento = new MovAbastecimento();

                movAbastecimento.ABADATAFROTA = dateAbastecimento.Value;
                movAbastecimento.ABAVEICULO = comboBoxVeiculo.Text;
                movAbastecimento.ABAPOSTO = comboBoxPosto.Text;
                movAbastecimento.ABACOMBUSTIVEL = comboBoxCombustivel.Text;
                movAbastecimento.ABAVALORUNITARIO = Convert.ToDecimal(textBoxValorUnitario.Text);
                movAbastecimento.ABATOTALPAGO = Convert.ToDecimal(textBoxValorUnitario.Text) * Convert.ToDecimal(textBoxQuantidade.Text);
                movAbastecimento.ABAQUANTIDADE = Convert.ToDecimal(textBoxQuantidade.Text);
                movAbastecimento.ABAKMINICIAL = Convert.ToDecimal(textBoxKmInicial.Text);
                movAbastecimento.ABAKMFINAL = Convert.ToDecimal(textBoxKmFinal.Text);
                movAbastecimento.ABAKMTOTAL = Convert.ToDecimal(textBoxKmFinal.Text) - Convert.ToDecimal(textBoxKmInicial.Text);
                movAbastecimento.ABAMOTORISTA = comboBoxMotorista.Text;
                movAbastecimento.ABAORIGEM = textBoxOrigem.Text;
                movAbastecimento.ABADESTINO = textBoxDestino.Text;
                movAbastecimento.ABATOTALCUSTO = Convert.ToDecimal(textBoxQuantidade.Text)*(11);
                movAbastecimento.ABADATACADASTRO = dateDataCadastro.Value;
                movAbastecimento.ABAPLACA = comboBoxPlaca.Text;

                MovAbastecimentoNegocios movAbastecimentoNegocios = new MovAbastecimentoNegocios();

                string retorno = movAbastecimentoNegocios.Inserir(movAbastecimento);
                
                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idAbaFrota = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com sucesso." + idAbaFrota.ToString());
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
                MovAbastecimento movAbastecimento = new MovAbastecimento();

                //Coloco os campos da tela no objeto clliente, e envio para alterar no banco

                movAbastecimento.IDABAFROTA = Convert.ToInt32(textBoxCodigo.Text);

                movAbastecimento.ABADATAFROTA = dateAbastecimento.Value;
                movAbastecimento.ABAVEICULO = comboBoxVeiculo.Text;
                movAbastecimento.ABAPOSTO = comboBoxPosto.Text;
                movAbastecimento.ABACOMBUSTIVEL = comboBoxCombustivel.Text;
                movAbastecimento.ABAVALORUNITARIO = Convert.ToDecimal(textBoxValorUnitario.Text);
                movAbastecimento.ABATOTALPAGO = Convert.ToDecimal(textBoxValorUnitario.Text) * Convert.ToDecimal(textBoxQuantidade.Text);
                movAbastecimento.ABAQUANTIDADE = Convert.ToDecimal(textBoxQuantidade.Text);
                movAbastecimento.ABAKMINICIAL = Convert.ToDecimal(textBoxKmInicial.Text);
                movAbastecimento.ABAKMFINAL = Convert.ToDecimal(textBoxKmFinal.Text);
                movAbastecimento.ABAKMTOTAL = Convert.ToDecimal(textBoxKmFinal.Text) - Convert.ToDecimal(textBoxKmInicial.Text);
                movAbastecimento.ABAMOTORISTA = comboBoxMotorista.Text;
                movAbastecimento.ABAORIGEM = textBoxOrigem.Text;
                movAbastecimento.ABADESTINO = textBoxDestino.Text;
                movAbastecimento.ABATOTALCUSTO = Convert.ToDecimal(textBoxQuantidade.Text) * (11);
                movAbastecimento.ABADATACADASTRO = dateDataCadastro.Value;
                movAbastecimento.ABAPLACA = comboBoxPlaca.Text; 

                MovAbastecimentoNegocios movAbastecimentoNegocios = new MovAbastecimentoNegocios();

                string retorno = movAbastecimentoNegocios.Alterar(movAbastecimento);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idAbaFrota = Convert.ToInt32(retorno);
                    MessageBox.Show("Alterado com sucesso." + idAbaFrota.ToString());
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
            SqlConnection cs = new SqlConnection(@"Data Source=.\SQLEXPRESS2016;Initial Catalog=ExitCodeFrotaBD;Persist Security Info=True;User ID=sa;Password=123456");
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT CADVEICULO,CADPLACA FROM TBCADFROTA ORDER BY CADVEICULO,CADPLACA", cs);
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT CADPOSTO FROM TBCADPOSTO ORDER BY CADPOSTO", cs);
            SqlDataAdapter da3 = new SqlDataAdapter("SELECT CADCOMBUSTIVEL FROM TBCADCOMBUSTIVEL ORDER BY CADCOMBUSTIVEL", cs);
            SqlDataAdapter da4 = new SqlDataAdapter("SELECT CADNOMEMOTORISTA FROM TBCADMOTORISTA ORDER BY CADNOMEMOTORISTA", cs);
                        
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
                        
            da1.Fill(dt1);
            da2.Fill(dt2);
            da3.Fill(dt3);
            da4.Fill(dt4);
            
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                comboBoxVeiculo.Items.Add(dt1.Rows[i]["CADVEICULO"]);
                comboBoxPlaca.Items.Add(dt1.Rows[i]["CADPLACA"]);
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                comboBoxPosto.Items.Add(dt2.Rows[i]["CADPOSTO"]);
            }
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                comboBoxCombustivel.Items.Add(dt3.Rows[i]["CADCOMBUSTIVEL"]);
            }
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                comboBoxMotorista.Items.Add(dt4.Rows[i]["CADNOMEMOTORISTA"]);
            }           
                                    
        }

        private void textBoxQuantidade_Leave(object sender, EventArgs e)
        {
            if (textBoxValorUnitario.Text == "" || textBoxQuantidade.Text == "")
            {
                MessageBox.Show("Valor unitário e quantidade não pode ser vázio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxValorUnitario.Text = "";
                textBoxQuantidade.Text = "";                

            }
            else
            {
                textBoxValorTotal.Text = Convert.ToString(Convert.ToDecimal(textBoxValorUnitario.Text) * Convert.ToDecimal(textBoxQuantidade.Text));
            }
        }

        private void textBoxKmFinal_Leave(object sender, EventArgs e)
        {
            if (textBoxKmInicial.Text == "" || textBoxKmFinal.Text == "")
            {
                MessageBox.Show("Km inicial e Km final não pode ser vázio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxKmInicial.Text = "";
                textBoxKmFinal.Text = "";

            }
            else
            {
                textBoxKmTotal.Text = Convert.ToString(Convert.ToDecimal(textBoxKmFinal.Text) - Convert.ToDecimal(textBoxKmInicial.Text));
                textBoxTotalCusto.Text = Convert.ToString(Convert.ToDecimal(textBoxQuantidade.Text) * (11));
            }
        }                     
    }
}
 ;