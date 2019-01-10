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
    public class MovAbastecimentoNegocios
    {
        //Instanciar = criar um novo baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(MovAbastecimento movAbastecimento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@ABADATAFROTA", movAbastecimento.ABADATAFROTA );
                acessoDadosSqlServer.AdicionarParametros("@ABAVEICULO", movAbastecimento.ABAVEICULO);
                acessoDadosSqlServer.AdicionarParametros("@ABAPOSTO", movAbastecimento.ABAPOSTO);
                acessoDadosSqlServer.AdicionarParametros("@ABACOMBUSTIVEL", movAbastecimento.ABACOMBUSTIVEL);
                acessoDadosSqlServer.AdicionarParametros("@ABAVALORUNITARIO", movAbastecimento.ABAVALORUNITARIO);
                acessoDadosSqlServer.AdicionarParametros("@ABATOTALPAGO", movAbastecimento.ABATOTALPAGO);
                acessoDadosSqlServer.AdicionarParametros("@ABAQUANTIDADE", movAbastecimento.ABAQUANTIDADE);
                acessoDadosSqlServer.AdicionarParametros("@ABAKMINICIAL", movAbastecimento.ABAKMINICIAL);
                acessoDadosSqlServer.AdicionarParametros("@ABAKMFINAL", movAbastecimento.ABAKMFINAL);
                acessoDadosSqlServer.AdicionarParametros("@ABAKMTOTAL", movAbastecimento.ABAKMTOTAL);
                acessoDadosSqlServer.AdicionarParametros("@ABAMOTORISTA", movAbastecimento.ABAMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@ABAORIGEM", movAbastecimento.ABAORIGEM);
                acessoDadosSqlServer.AdicionarParametros("@ABADESTINO", movAbastecimento.ABADESTINO);
                acessoDadosSqlServer.AdicionarParametros("@ABATOTALCUSTO", movAbastecimento.ABATOTALCUSTO);
                acessoDadosSqlServer.AdicionarParametros("@ABADATACADASTRO", movAbastecimento.ABADATACADASTRO);
                acessoDadosSqlServer.AdicionarParametros("@ABAPLACA", movAbastecimento.ABAPLACA);
                string IDABAFROTA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMOVABASTECIMENTOInserir").ToString();
                return IDABAFROTA;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(MovAbastecimento movAbastecimento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDABAFROTA", movAbastecimento.IDABAFROTA);                
                acessoDadosSqlServer.AdicionarParametros("@ABADATAFROTA", movAbastecimento.ABADATAFROTA);
                acessoDadosSqlServer.AdicionarParametros("@ABAVEICULO", movAbastecimento.ABAVEICULO);
                acessoDadosSqlServer.AdicionarParametros("@ABAPOSTO", movAbastecimento.ABAPOSTO);
                acessoDadosSqlServer.AdicionarParametros("@ABACOMBUSTIVEL", movAbastecimento.ABACOMBUSTIVEL);
                acessoDadosSqlServer.AdicionarParametros("@ABAVALORUNITARIO", movAbastecimento.ABAVALORUNITARIO);
                acessoDadosSqlServer.AdicionarParametros("@ABATOTALPAGO", movAbastecimento.ABATOTALPAGO);
                acessoDadosSqlServer.AdicionarParametros("@ABAQUANTIDADE", movAbastecimento.ABAQUANTIDADE);
                acessoDadosSqlServer.AdicionarParametros("@ABAKMINICIAL", movAbastecimento.ABAKMINICIAL);
                acessoDadosSqlServer.AdicionarParametros("@ABAKMFINAL", movAbastecimento.ABAKMFINAL);
                acessoDadosSqlServer.AdicionarParametros("@ABAKMTOTAL", movAbastecimento.ABAKMTOTAL);
                acessoDadosSqlServer.AdicionarParametros("@ABAMOTORISTA", movAbastecimento.ABAMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@ABAORIGEM", movAbastecimento.ABAORIGEM);
                acessoDadosSqlServer.AdicionarParametros("@ABADESTINO", movAbastecimento.ABADESTINO);
                acessoDadosSqlServer.AdicionarParametros("@ABATOTALCUSTO", movAbastecimento.ABATOTALCUSTO);
                acessoDadosSqlServer.AdicionarParametros("@ABADATACADASTRO", movAbastecimento.ABADATACADASTRO);
                acessoDadosSqlServer.AdicionarParametros("@ABAPLACA", movAbastecimento.ABAPLACA);
                string IDABAFROTA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMOVABASTECIMENTOAlterar").ToString();
                return IDABAFROTA;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(MovAbastecimento movAbastecimento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("IDABAFROTA", movAbastecimento.IDABAFROTA);
                string IDABAFROTA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMOVABASTECIMENTOExcluir").ToString();
                return IDABAFROTA;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public MovAbastecimentoColecao ConsultarPorNome(string nome)
        {
            try
            {
                MovAbastecimentoColecao movAbastecimentoColecao = new MovAbastecimentoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@ABAPLACA", nome);

                DataTable dataTableMovAbastecimento = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspMOVABASTECIMENTOConsultarPorNome");
                foreach (DataRow linha in dataTableMovAbastecimento.Rows)
                {
                    MovAbastecimento movAbastecimento = new MovAbastecimento();

                    movAbastecimento.IDABAFROTA = Convert.ToInt32(linha["IDABAFROTA"]);
                    movAbastecimento.ABADATAFROTA = Convert.ToDateTime(linha["ABADATAFROTA"]);
                    movAbastecimento.ABAVEICULO = Convert.ToString(linha["ABAVEICULO"]);
                    movAbastecimento.ABAPOSTO = Convert.ToString(linha["ABAPOSTO"]);
                    movAbastecimento.ABACOMBUSTIVEL = Convert.ToString(linha["ABACOMBUSTIVEL"]);
                    movAbastecimento.ABAVALORUNITARIO = Convert.ToDecimal(linha["ABAVALORUNITARIO"]);
                    movAbastecimento.ABATOTALPAGO = Convert.ToDecimal(linha["ABATOTALPAGO"]);
                    movAbastecimento.ABAQUANTIDADE = Convert.ToDecimal(linha["ABAQUANTIDADE"]);
                    movAbastecimento.ABAKMINICIAL = Convert.ToDecimal(linha["ABAKMINICIAL"]);
                    movAbastecimento.ABAKMFINAL = Convert.ToDecimal(linha["ABAKMFINAL"]);
                    movAbastecimento.ABAKMTOTAL = Convert.ToDecimal(linha["ABAKMTOTAL"]);
                    movAbastecimento.ABAMOTORISTA = Convert.ToString(linha["ABAMOTORISTA"]);
                    movAbastecimento.ABAORIGEM = Convert.ToString(linha["ABAORIGEM"]);
                    movAbastecimento.ABADESTINO = Convert.ToString(linha["ABADESTINO"]);
                    movAbastecimento.ABATOTALCUSTO = Convert.ToDecimal(linha["ABATOTALCUSTO"]);
                    movAbastecimento.ABADATACADASTRO = Convert.ToDateTime(linha["ABADATACADASTRO"]);
                    movAbastecimento.ABAPLACA = Convert.ToString(linha["ABAPLACA"]);

                    movAbastecimentoColecao.Add(movAbastecimento);
                }

                return movAbastecimentoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Não foi possível consultar o movimento por nome. Detalhes: " + exception);
            }
        }

        public MovAbastecimentoColecao ConsultarPorId(int IDABAFROTA)
        {
            try
            {
                MovAbastecimentoColecao movAbastecimentoColecao = new MovAbastecimentoColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDABAFROTA", IDABAFROTA);

                DataTable dataTableMovAbastecimento = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspMOVABASTECIMENTOConsultarPorID");
                foreach (DataRow dataRowLinha in dataTableMovAbastecimento.Rows)
                {
                    MovAbastecimento movAbastecimento = new MovAbastecimento();

                    movAbastecimento.IDABAFROTA = Convert.ToInt32(dataRowLinha["IDABAFROTA"]);
                    movAbastecimento.ABADATAFROTA = Convert.ToDateTime(dataRowLinha["ABADATAFROTA"]);
                    movAbastecimento.ABAVEICULO = Convert.ToString(dataRowLinha["ABAVEICULO"]);
                    movAbastecimento.ABAPOSTO = Convert.ToString(dataRowLinha["ABAPOSTO"]);
                    movAbastecimento.ABACOMBUSTIVEL = Convert.ToString(dataRowLinha["ABACOMBUSTIVEL"]);
                    movAbastecimento.ABAVALORUNITARIO = Convert.ToDecimal(dataRowLinha["ABAVALORUNITARIO"]);
                    movAbastecimento.ABATOTALPAGO = Convert.ToDecimal(dataRowLinha["ABATOTALPAGO"]);
                    movAbastecimento.ABAQUANTIDADE = Convert.ToDecimal(dataRowLinha["ABAQUANTIDADE"]);
                    movAbastecimento.ABAKMINICIAL = Convert.ToDecimal(dataRowLinha["ABAKMINICIAL"]);
                    movAbastecimento.ABAKMFINAL = Convert.ToDecimal(dataRowLinha["ABAKMFINAL"]);
                    movAbastecimento.ABAKMTOTAL = Convert.ToDecimal(dataRowLinha["ABAKMTOTAL"]);
                    movAbastecimento.ABAMOTORISTA = Convert.ToString(dataRowLinha["ABAMOTORISTA"]);
                    movAbastecimento.ABAORIGEM = Convert.ToString(dataRowLinha["ABAORIGEM"]);
                    movAbastecimento.ABADESTINO = Convert.ToString(dataRowLinha["ABADESTINO"]);
                    movAbastecimento.ABATOTALCUSTO = Convert.ToDecimal(dataRowLinha["ABATOTALCUSTO"]);
                    movAbastecimento.ABADATACADASTRO = Convert.ToDateTime(dataRowLinha["ABADATACADASTRO"]);
                    movAbastecimento.ABAPLACA = Convert.ToString(dataRowLinha["ABAPLACA"]);

                    movAbastecimentoColecao.Add(movAbastecimento);
                }

                return movAbastecimentoColecao;

            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o movimento por código. Detalhes: " + exception.Message);
            }

        }

    }
}
