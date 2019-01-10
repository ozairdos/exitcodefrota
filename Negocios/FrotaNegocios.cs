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
    public class FrotaNegocios
    {
        //Instanciar = criar um novo baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Frota frota)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADTIPODEVEICULO", frota.CADTIPODEVEICULO);
                acessoDadosSqlServer.AdicionarParametros("@CADVEICULO", frota.CADVEICULO);
                acessoDadosSqlServer.AdicionarParametros("@CADPLACA", frota.CADPLACA);
                acessoDadosSqlServer.AdicionarParametros("@CADCOR", frota.CADCOR);
                acessoDadosSqlServer.AdicionarParametros("@CADANO", frota.CADANO);
                acessoDadosSqlServer.AdicionarParametros("@CADDOCUMENTACAO", frota.CADDOCUMENTACAO);
                acessoDadosSqlServer.AdicionarParametros("@CADDATAVENCIMENTO", frota.CADDATAVENCIMENTO);
                acessoDadosSqlServer.AdicionarParametros("@CADSTATUS", frota.CADSTATUS);
                acessoDadosSqlServer.AdicionarParametros("@CADDATACADASTROFROTA", frota.CADDATACADASTROFROTA);
                string IDCADFROTA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADFROTAInserir").ToString();

                return IDCADFROTA;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Frota frota)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADFROTA", frota.IDCADFROTA);
                acessoDadosSqlServer.AdicionarParametros("@CADTIPODEVEICULO", frota.CADTIPODEVEICULO);
                acessoDadosSqlServer.AdicionarParametros("@CADVEICULO", frota.CADVEICULO);
                acessoDadosSqlServer.AdicionarParametros("@CADPLACA", frota.CADPLACA);
                acessoDadosSqlServer.AdicionarParametros("@CADCOR", frota.CADCOR);
                acessoDadosSqlServer.AdicionarParametros("@CADANO", frota.CADANO);
                acessoDadosSqlServer.AdicionarParametros("@CADDOCUMENTACAO", frota.CADDOCUMENTACAO);
                acessoDadosSqlServer.AdicionarParametros("@CADDATAVENCIMENTO", frota.CADDATAVENCIMENTO);
                acessoDadosSqlServer.AdicionarParametros("@CADSTATUS", frota.CADSTATUS);
                acessoDadosSqlServer.AdicionarParametros("@CADDATACADASTROFROTA", frota.CADDATACADASTROFROTA);
                string IDCADFROTA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADFROTAAlterar").ToString();
                return IDCADFROTA;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Frota frota)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADFROTA", frota.IDCADFROTA);
                string IDCADFROTA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADFROTAExcluir").ToString();
                return IDCADFROTA;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public FrotaColecao ConsultarPorNome(string nome)
        {
            try
            {
                //Criar uma coleção nova de clientes (aqui ela está vazia)
                FrotaColecao frotaColecao = new FrotaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADDOCUMENTACAO", nome);
                
                //Data=Dados e Table=Tabela
                DataTable dataTableFrota = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADFROTAConsultarPorNome");

                //Percorrer o DataTable e transformar em coleção de cliente
                //Cada linha do DataTable é uma cliente.
                //Data=Dados e Row=Linha
                //For=Para e Each=Cada
                foreach (DataRow linha in dataTableFrota.Rows)
                {
                    //Criar um cliente vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleção
                    Frota frota = new Frota();

                    frota.IDCADFROTA = Convert.ToInt32(linha["IDCADFROTA"]);
                    frota.CADTIPODEVEICULO = Convert.ToString(linha["CADTIPODEVEICULO"]);
                    frota.CADVEICULO = Convert.ToString(linha["CADVEICULO"]);
                    frota.CADPLACA = Convert.ToString(linha["CADPLACA"]);
                    frota.CADCOR = Convert.ToString(linha["CADCOR"]);
                    frota.CADANO = Convert.ToString(linha["CADANO"]);
                    frota.CADDOCUMENTACAO = Convert.ToString(linha["CADDOCUMENTACAO"]);
                    frota.CADDATAVENCIMENTO = Convert.ToDateTime(linha["CADDATAVENCIMENTO"]);
                    frota.CADSTATUS = Convert.ToString(linha["CADSTATUS"]);
                    frota.CADDATACADASTROFROTA = Convert.ToDateTime(linha["CADDATACADASTROFROTA"]);

                    frotaColecao.Add(frota);
                }


                return frotaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar frota por documento. Detalhes: " + ex.Message);
            }
        }

        public FrotaColecao ConsultaPorId(int IDCADFROTA)
        {
            try
            {
                FrotaColecao frotaColecao = new FrotaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADFROTA", IDCADFROTA);

                DataTable dataTableFrota = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADFROTAConsultarPorID");

                foreach (DataRow dataRowLinha in dataTableFrota.Rows)
                {
                    Frota frota = new Frota();

                    frota.IDCADFROTA = Convert.ToInt32(dataRowLinha["IDCADFROTA"]);
                    frota.CADTIPODEVEICULO = Convert.ToString(dataRowLinha["CADTIPODEVEICULO"]);
                    frota.CADVEICULO = Convert.ToString(dataRowLinha["CADVEICULO"]);
                    frota.CADPLACA = Convert.ToString(dataRowLinha["CADPLACA"]);
                    frota.CADCOR = Convert.ToString(dataRowLinha["CADCOR"]);
                    frota.CADANO = Convert.ToString(dataRowLinha["CADANO"]);
                    frota.CADDOCUMENTACAO = Convert.ToString(dataRowLinha["CADDOCUMENTACAO"]);
                    frota.CADDATAVENCIMENTO = Convert.ToDateTime(dataRowLinha["CADDATAVENCIMENTO"]);
                    frota.CADSTATUS = Convert.ToString(dataRowLinha["CADSTATUS"]);
                    frota.CADDATACADASTROFROTA = Convert.ToDateTime(dataRowLinha["CADDATACADASTROFROTA"]);

                    frotaColecao.Add(frota);
                }


                return frotaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar frota por código. Detalhes: " + ex.Message);
            }
        }

    }
}