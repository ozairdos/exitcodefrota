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
    public class FuncionarioNegocios
    {
        //Instanciar = criar um novo baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Funcionario funcionario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADNOMEFUNCIONARIO", funcionario.CADNOMEFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADENDFUNCIONARIO", funcionario.CADENDFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADTELFUNCIONARIO", funcionario.CADTELFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADCPFFUNCIONARIO", funcionario.CADCPFFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADRGFUNCIONARIO", funcionario.CADRGFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADDATANASCFUNCIONARIO", funcionario.CADDATANASCFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADCARGOFUNCIONARIO", funcionario.CADCARGOFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADDATACADASTROFUNCIONARIO", funcionario.CADDATACADASTROFUNCIONARIO);
                string IDFUNCIONARIO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADFUNCIONARIOInserir").ToString();

                return IDFUNCIONARIO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Funcionario funcionario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADFUNCIONARIO", funcionario.IDCADFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADNOMEFUNCIONARIO", funcionario.CADNOMEFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADENDFUNCIONARIO", funcionario.CADENDFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADTELFUNCIONARIO", funcionario.CADTELFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADCPFFUNCIONARIO", funcionario.CADCPFFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADRGFUNCIONARIO", funcionario.CADRGFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADDATANASCFUNCIONARIO", funcionario.CADDATANASCFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADCARGOFUNCIONARIO", funcionario.CADCARGOFUNCIONARIO);
                acessoDadosSqlServer.AdicionarParametros("@CADDATACADASTROFUNCIONARIO", funcionario.CADDATACADASTROFUNCIONARIO);
                string IDCADFUNCIONARIO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADFUNCIONARIOAlterar").ToString();
                return IDCADFUNCIONARIO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Funcionario funcionario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADFUNCIONARIO", funcionario.IDCADFUNCIONARIO);
                string IDCADFUNCIONARIO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADFUNCIONARIOExcluir").ToString();
                return IDCADFUNCIONARIO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public FuncionarioColecao ConsultarPorNome(string nome)
        {
            try
            {
                //Criar uma coleção nova de clientes (aqui ela está vazia)
                FuncionarioColecao funcionarioColecao = new FuncionarioColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADNOMEFUNCIONARIO", nome);
                
                //Data=Dados e Table=Tabela
                DataTable dataTableFuncionario = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADFUNCIONARIOConsultarPorNome");

                //Percorrer o DataTable e transformar em coleção de cliente
                //Cada linha do DataTable é uma cliente.
                //Data=Dados e Row=Linha
                //For=Para e Each=Cada
                foreach (DataRow linha in dataTableFuncionario.Rows)
                {
                    //Criar um cliente vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleção
                    Funcionario funcionario = new Funcionario();

                    funcionario.IDCADFUNCIONARIO = Convert.ToInt32(linha["IDCADFUNCIONARIO"]);
                    funcionario.CADNOMEFUNCIONARIO = Convert.ToString(linha["CADNOMEFUNCIONARIO"]);
                    funcionario.CADENDFUNCIONARIO = Convert.ToString(linha["CADENDFUNCIONARIO"]);
                    funcionario.CADTELFUNCIONARIO = Convert.ToString(linha["CADTELFUNCIONARIO"]);
                    funcionario.CADCPFFUNCIONARIO = Convert.ToString(linha["CADCPFFUNCIONARIO"]);
                    funcionario.CADRGFUNCIONARIO = Convert.ToString(linha["CADRGFUNCIONARIO"]);
                    funcionario.CADDATANASCFUNCIONARIO = Convert.ToDateTime(linha["CADDATANASCFUNCIONARIO"]);
                    funcionario.CADCARGOFUNCIONARIO = Convert.ToString(linha["CADCARGOFUNCIONARIO"]);
                    funcionario.CADDATACADASTROFUNCIONARIO = Convert.ToDateTime(linha["CADDATACADASTROFUNCIONARIO"]);

                    funcionarioColecao.Add(funcionario);
                }


                return funcionarioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o cliente por nome. Detalhes: " + ex.Message);
            }
        }

        public FuncionarioColecao ConsultaPorId(int IDCADFUNCIONARIO)
        {
            try
            {
                FuncionarioColecao funcionarioColecao = new FuncionarioColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADFUNCIONARIO", IDCADFUNCIONARIO);

                DataTable dataTableFuncionario = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADFUNCIONARIOConsultarPorID");

                foreach (DataRow dataRowLinha in dataTableFuncionario.Rows)
                {
                    Funcionario funcionario = new Funcionario();

                    funcionario.IDCADFUNCIONARIO = Convert.ToInt32(dataRowLinha["IDCADFUNCIONARIO"]);
                    funcionario.CADNOMEFUNCIONARIO = Convert.ToString(dataRowLinha["CADNOMEFUNCIONARIO"]);
                    funcionario.CADENDFUNCIONARIO = Convert.ToString(dataRowLinha["CADENDFUNCIONARIO"]);
                    funcionario.CADTELFUNCIONARIO = Convert.ToString(dataRowLinha["CADTELFUNCIONARIO"]);
                    funcionario.CADCPFFUNCIONARIO = Convert.ToString(dataRowLinha["CADCPFFUNCIONARIO"]);
                    funcionario.CADRGFUNCIONARIO = Convert.ToString(dataRowLinha["CADRGFUNCIONARIO"]);
                    funcionario.CADDATANASCFUNCIONARIO = Convert.ToDateTime(dataRowLinha["CADDATANASCFUNCIONARIO"]);
                    funcionario.CADCARGOFUNCIONARIO = Convert.ToString(dataRowLinha["CADCARGOFUNCIONARIO"]);
                    funcionario.CADDATACADASTROFUNCIONARIO = Convert.ToDateTime(dataRowLinha["CADDATACADASTROFUNCIONARIO"]);

                    funcionarioColecao.Add(funcionario);
                }


                return funcionarioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o cliente por código. Detalhes: " + ex.Message);
            }
        }

    }
}