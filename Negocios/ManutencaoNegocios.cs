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
    public class ManutencaoNegocios
    {
        //Instanciar = criar um novo baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Manutencao manutencao)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADMANUTENCAO",manutencao.CADMANUTENCAO);
                string IDCADMANUTENCAO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADMANUTENCAOInserir").ToString();
                return IDCADMANUTENCAO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Manutencao manutencao)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADMANUTENCAO", manutencao.IDCADMANUTENCAO);
                acessoDadosSqlServer.AdicionarParametros("@CADMANUTENCAO", manutencao.CADMANUTENCAO);
                string IDCADMANUTENCAO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADMANUTENCAOAlterar").ToString();
                return IDCADMANUTENCAO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }            
        }

        public string Excluir(Manutencao manutencao)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADMANUTENCAO", manutencao.IDCADMANUTENCAO);
                string IDCADMANUTENCAO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADMANUTENCAOExcluir").ToString();
                return IDCADMANUTENCAO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public ManutencaoColecao ConsultarPorNome(string nome)
        {
            try
            {
                ManutencaoColecao manutencaoColecao = new ManutencaoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADMANUTENCAO", nome);

                DataTable dataTableManutencao = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADMANUTENCAOConsultarPorNome");
                foreach (DataRow linha in dataTableManutencao.Rows)
                {
                    Manutencao manutencao = new Manutencao();

                    manutencao.IDCADMANUTENCAO = Convert.ToInt32(linha["IDCADMANUTENCAO"]);
                    manutencao.CADMANUTENCAO = Convert.ToString(linha["CADMANUTENCAO"]);

                    manutencaoColecao.Add(manutencao);
                }

                return manutencaoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Não foi possível consultar a manutencao por nome. Detalhes: " + exception);       
            }
        }

        public ManutencaoColecao ConsultarPorId(int IDCADMANUTENCAO)
        {
            try
            {
                ManutencaoColecao manutencaoColecao = new ManutencaoColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADMANUTENCAO", IDCADMANUTENCAO);

                DataTable dataTableManutencao = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADMANUTENCAOConsultarPorID");
                foreach (DataRow dataRowLinha in dataTableManutencao.Rows)
                {
                    Manutencao manutencao = new Manutencao();

                    manutencao.IDCADMANUTENCAO = Convert.ToInt32(dataRowLinha["IDCADMANUTENCAO"]);
                    manutencao.CADMANUTENCAO = Convert.ToString(dataRowLinha["CADMANUTENCAO"]);

                    manutencaoColecao.Add(manutencao);
                }

                return manutencaoColecao;

            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar a manutencao por código. Detalhes: " + exception.Message);
            }

        }

    }
}
