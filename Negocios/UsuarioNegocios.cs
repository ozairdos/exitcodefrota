using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class UsuarioNegocios
    {
        //Instanciar = criar um novo baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADUSUARIO", usuario.CADUSUARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADSENHA", usuario.CADSENHA);
                string IDCADUSUARIO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADUSUARIOInserir").ToString();
                return IDCADUSUARIO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADUSUARIO", usuario.IDCADUSUARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADUSUARIO", usuario.CADUSUARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADSENHA", usuario.CADSENHA);
                string IDCADUSUARIO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADUSUARIOAlterar").ToString();
                return IDCADUSUARIO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }            
        }

        public string Excluir(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADUSUARIO", usuario.IDCADUSUARIO);
                string IDCADUSUARIO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADUSUARIOExcluir").ToString();
                return IDCADUSUARIO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public UsuarioColecao ConsultarPorNome(string nome)
        {
            try
            {
                UsuarioColecao usuarioColecao = new UsuarioColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADUSUARIO", nome);

                DataTable dataTableUsuario = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADUSUARIOConsultarPorNome");
                foreach (DataRow linha in dataTableUsuario.Rows)
                {
                    Usuario usuario = new Usuario();

                    usuario.IDCADUSUARIO = Convert.ToInt32(linha["IDCADUSUARIO"]);
                    usuario.CADUSUARIO = Convert.ToString(linha["CADUSUARIO"]);
                    usuario.CADSENHA = Convert.ToString(linha["CADSENHA"]);

                    usuarioColecao.Add(usuario);
                }

                return usuarioColecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Não foi possível consultar o usuário por nome. Detalhes: " + exception);       
            }
        }

        public UsuarioColecao ConsultarPorId(int IDCADUSUARIO)
        {
            try
            {
                UsuarioColecao usuarioColecao = new UsuarioColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADUSUARIO", IDCADUSUARIO);

                DataTable dataTableUsuario = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADUSUARIOConsultarPorID");
                foreach (DataRow dataRowLinha in dataTableUsuario.Rows)
                {
                    Usuario usuario = new Usuario();

                    usuario.IDCADUSUARIO = Convert.ToInt32(dataRowLinha["IDCADUSUARIO"]);
                    usuario.CADUSUARIO = Convert.ToString(dataRowLinha["CADUSUARIO"]);
                    usuario.CADSENHA = Convert.ToString(dataRowLinha["CADSENHA"]);

                    usuarioColecao.Add(usuario);
                }

                return usuarioColecao;

            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o usuário por código. Detalhes: " + exception.Message);
            }

        }

    }
}
