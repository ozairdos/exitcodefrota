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
    public class CombustivelNegocios
    {
        //Instanciar = criar um novo baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Combustivel combustivel)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADCOMBUSTIVEL", combustivel.CADCOMBUSTIVEL);
                string IDCADCOMBUSTIVEL = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADCOMBUSTIVELInserir").ToString();
                return IDCADCOMBUSTIVEL;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Combustivel combustivel)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADCOMBUSTIVEL", combustivel.IDCADCOMBUSTIVEL);
                acessoDadosSqlServer.AdicionarParametros("@CADCOMBUSTIVEL", combustivel.CADCOMBUSTIVEL);
                string IDCADCOMBUSTIVEL = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADCOMBUSTIVELAlterar").ToString();
                return IDCADCOMBUSTIVEL;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }            
        }

        public string Excluir(Combustivel combustivel)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADCOMBUSTIVEL", combustivel.IDCADCOMBUSTIVEL);
                string IDCADCOMBUSTIVEL = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADCOMBUSTIVELExcluir").ToString();
                return IDCADCOMBUSTIVEL;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public CombustivelColecao ConsultarPorNome(string nome)
        {
            try
            {
                CombustivelColecao combustivelColecao = new CombustivelColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADCOMBUSTIVEL", nome);

                DataTable dataTableCombustivel = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADCOMBUSTIVELConsultarPorNome");
                foreach (DataRow linha in dataTableCombustivel.Rows)
                {
                    Combustivel combustivel = new Combustivel();

                    combustivel.IDCADCOMBUSTIVEL = Convert.ToInt32(linha["IDCADCOMBUSTIVEL"]);
                    combustivel.CADCOMBUSTIVEL = Convert.ToString(linha["CADCOMBUSTIVEL"]);

                    combustivelColecao.Add(combustivel);
                }

                return combustivelColecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Não foi possível consultar o combustível por nome. Detalhes: " + exception);       
            }
        }

        public CombustivelColecao ConsultarPorId(int IDCADCOMBUSTIVEL)
        {
            try
            {
                CombustivelColecao combustivelColecao = new CombustivelColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADCOMBUSTIVEL", IDCADCOMBUSTIVEL);

                DataTable dataTableCombustivel = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADCOMBUSTIVELConsultarPorID");
                foreach (DataRow dataRowLinha in dataTableCombustivel.Rows)
                {
                    Combustivel combustivel = new Combustivel();

                    combustivel.IDCADCOMBUSTIVEL = Convert.ToInt32(dataRowLinha["IDCADCOMBUSTIVEL"]);
                    combustivel.CADCOMBUSTIVEL = Convert.ToString(dataRowLinha["CADCOMBUSTIVEL"]);

                    combustivelColecao.Add(combustivel);
                }

                return combustivelColecao;

            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o combustível por código. Detalhes: " + exception.Message);
            }

        }

    }
}
