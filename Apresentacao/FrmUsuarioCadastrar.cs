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
    public partial class FrmUsuarioCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        //Construtor
        public FrmUsuarioCadastrar(AcaoNaTela acaoNaTela, Usuario usuario)
        {
            InitializeComponent();
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Usuário";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Usuário";

                textBoxCodigo.Text = usuario.IDCADUSUARIO.ToString();
                textBoxUsuario.Text = usuario.CADUSUARIO;
                textBoxSenha.Text = usuario.CADSENHA;
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Usuário";

                //Carregar campos da tela
                textBoxCodigo.Text = usuario.IDCADUSUARIO.ToString();
                textBoxUsuario.Text = usuario.CADUSUARIO;
                textBoxSenha.Text = usuario.CADSENHA;

                //Desabilitar campos da tela
                textBoxUsuario.ReadOnly = true;
                textBoxUsuario.TabStop = false;

                textBoxSenha.ReadOnly = true;
                textBoxSenha.TabStop = false;

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
                Usuario usuario = new Usuario();

                usuario.CADUSUARIO = textBoxUsuario.Text;
                usuario.CADSENHA = textBoxSenha.Text;

                UsuarioNegocios usuarioNegocios = new UsuarioNegocios();

                string retorno = usuarioNegocios.Inserir(usuario);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idUsuario = Convert.ToInt32(retorno);
                    MessageBox.Show("Usuário inserido com sucesso." + idUsuario.ToString());
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
                Usuario usuario = new Usuario();

                //Coloco os campos da tela no objeto clliente, e envio para alterar no banco

                usuario.IDCADUSUARIO = Convert.ToInt32(textBoxCodigo.Text);
                usuario.CADUSUARIO = textBoxUsuario.Text;
                usuario.CADSENHA= textBoxSenha.Text;

                UsuarioNegocios usuarioNegocios = new UsuarioNegocios();

                string retorno = usuarioNegocios.Alterar(usuario);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idUsuario = Convert.ToInt32(retorno);
                    MessageBox.Show("Usuário alterado com sucesso." + idUsuario.ToString());
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
