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
    public class ServicoNegocios
    {
        //Instanciar = criar um novo baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Servico servico)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADSERVICO", servico.CADSERVICO);
                string IDCADSERVICO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADSERVICOInserir").ToString();
                return IDCADSERVICO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Servico servico)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADSERVICO", servico.IDCADSERVICO);
                acessoDadosSqlServer.AdicionarParametros("@CADSERVICO", servico.CADSERVICO);
                string IDCADSERVICO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADSERVICOAlterar").ToString();
                return IDCADSERVICO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }            
        }

        public string Excluir(Servico servico)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADSERVICO", servico.IDCADSERVICO);
                string IDCADSERVICO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADSERVICOExcluir").ToString();
                return IDCADSERVICO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public ServicoColecao ConsultarPorNome(string nome)
        {
            try
            {
                ServicoColecao servicoColecao = new ServicoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADSERVICO", nome);

                DataTable dataTableServico = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADSERVICOConsultarPorNome");
                foreach (DataRow linha in dataTableServico.Rows)
                {
                    Servico servico = new Servico();

                    servico.IDCADSERVICO = Convert.ToInt32(linha["IDCADSERVICO"]);
                    servico.CADSERVICO = Convert.ToString(linha["CADSERVICO"]);

                    servicoColecao.Add(servico);
                }

                return servicoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Não foi possível consultar o serviço por nome. Detalhes: " + exception);       
            }
        }

        public ServicoColecao ConsultarPorId(int IDCADSERVICO)
        {
            try
            {
                ServicoColecao servicoColecao = new ServicoColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADSERVICO", IDCADSERVICO);

                DataTable dataTableServico = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADSERVICOConsultarPorID");
                foreach (DataRow dataRowLinha in dataTableServico.Rows)
                {
                    Servico servico = new Servico();

                    servico.IDCADSERVICO = Convert.ToInt32(dataRowLinha["IDCADSERVICO"]);
                    servico.CADSERVICO = Convert.ToString(dataRowLinha["CADSERVICO"]);

                    servicoColecao.Add(servico);
                }

                return servicoColecao;

            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o serviço por código. Detalhes: " + exception.Message);
            }

        }

    }
}
