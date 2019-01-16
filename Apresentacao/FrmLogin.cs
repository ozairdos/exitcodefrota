using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;


namespace Apresentacao
{
    public partial class FrmLogin : Form
    {
        
        //Criar conexão        
        SqlConnection sqlConn = null;        
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
            sqlConn = CriarConexao();
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

        //Cria a conexão
        private SqlConnection CriarConexao()
        {
            String conn = String.Empty;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(System.Environment.CurrentDirectory + "\\ConnectionStrings.xml");// xml contendo as connectionStrings encryptadas

            XmlNodeList xNodeList = xmlDoc.GetElementsByTagName("ConnectiosStrings");
            foreach (XmlNode xNode in xNodeList)
                conn = xNode["StringBD"].InnerText;// lendo a connectionstring

            return new SqlConnection(conn);
        }
    }
}
