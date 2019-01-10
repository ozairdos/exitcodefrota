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
    public class PostoNegocios
    {
        //Instanciar = criar um novo baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Posto posto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADPOSTO", posto.CADPOSTO);
                string IDCADPOSTO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADPOSTOInserir").ToString();
                return IDCADPOSTO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Posto posto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADPOSTO", posto.IDCADPOSTO);
                acessoDadosSqlServer.AdicionarParametros("@CADPOSTO", posto.CADPOSTO);
                string IDCADPOSTO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADPOSTOAlterar").ToString();
                return IDCADPOSTO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }            
        }

        public string Excluir(Posto posto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADPOSTO", posto.IDCADPOSTO);
                string IDCADPOSTO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADPOSTOExcluir").ToString();
                return IDCADPOSTO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public PostoColecao ConsultarPorNome(string nome)
        {
            try
            {
                PostoColecao postoColecao = new PostoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADPOSTO", nome);

                DataTable dataTablePosto = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADPOSTOConsultarPorNome");
                foreach (DataRow linha in dataTablePosto.Rows)
                {
                    Posto posto = new Posto();

                    posto.IDCADPOSTO = Convert.ToInt32(linha["IDCADPOSTO"]);
                    posto.CADPOSTO = Convert.ToString(linha["CADPOSTO"]);

                    postoColecao.Add(posto);
                }

                return postoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Não foi possível consultar o posto por nome. Detalhes: " + exception);       
            }
        }

        public PostoColecao ConsultarPorId(int IDCADPOSTO)
        {
            try
            {
                PostoColecao postoColecao = new PostoColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADPOSTO", IDCADPOSTO);

                DataTable dataTablePosto = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADPOSTOConsultarPorID");
                foreach (DataRow dataRowLinha in dataTablePosto.Rows)
                {
                    Posto posto = new Posto();

                    posto.IDCADPOSTO = Convert.ToInt32(dataRowLinha["IDCADPOSTO"]);
                    posto.CADPOSTO = Convert.ToString(dataRowLinha["CADPOSTO"]);

                    postoColecao.Add(posto);
                }

                return postoColecao;

            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o posto por código. Detalhes: " + exception.Message);
            }

        }

    }
}
