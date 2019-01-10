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
using System.Data.SqlClient;


namespace Apresentacao
{
    public partial class FrmLogin : Form
    {
        //conexao banco
        SqlConnection sqlConn = null;
        private string strConn = @"Data Source=.\SQLEXPRESS2016;Initial Catalog=ExitCodeFrotaBD;Persist Security Info=True;User ID=sa;Password=123456";
        private string _Sql = string.Empty;

        public bool logado = false;

        public FrmLogin()
        {
            InitializeComponent();
           
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Logar();

        }
        private void Logar()
        {
            sqlConn = new SqlConnection(strConn);
            string usu, pwd;

            try
            {
                usu = textBoxUsuario.Text;
                pwd = textBoxSenha.Text;

                _Sql = "SELECT COUNT (*) FROM TBCADUSUARIO WHERE CADUSUARIO = @CADUSUARIO AND CADSENHA = @CADSENHA";
                
                SqlCommand cmd = new SqlCommand(_Sql,sqlConn);
                                
                cmd.Parameters.Add("@CADUSUARIO", SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@CADSENHA", SqlDbType.VarChar).Value = pwd;
                
                sqlConn.Open();

                int v = (int)cmd.ExecuteScalar();
                if (v > 0)
                {                    
                    logado = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválido.");
                    logado = false;
                }
            }
            catch (SqlException errro)
            {
                MessageBox.Show(errro + "No banco.");
            }
                {

            }
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }

        private void textBoxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }         
    }
}
