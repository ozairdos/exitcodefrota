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
    public class CargoNegocios
    {
        //Instanciar = criar um novo baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        
        public string Inserir(Cargo cargo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADCARGO",cargo.CADCARGO);
                string IDCADCARGO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADCARGOInserir").ToString();
                return IDCADCARGO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Cargo cargo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADCARGO", cargo.IDCADCARGO);
                acessoDadosSqlServer.AdicionarParametros("@CADCARGO", cargo.CADCARGO);
                string IDCADCARGO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADCARGOAlterar").ToString();
                return IDCADCARGO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }            
        }

        public string Excluir(Cargo cargo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADCARGO", cargo.IDCADCARGO);
                string IDCADCARGO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADCARGOExcluir").ToString();
                return IDCADCARGO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public CargoColecao ConsultarPorNome(string nome)
        {
            try
            {
                CargoColecao cargoColecao = new CargoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADCARGO", nome);

                DataTable dataTableCargo = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADCARGOConsultarPorNome");
                foreach (DataRow linha in dataTableCargo.Rows)
                {
                    Cargo cargo = new Cargo();

                    cargo.IDCADCARGO = Convert.ToInt32(linha["IDCADCARGO"]);
                    cargo.CADCARGO = Convert.ToString(linha["CADCARGO"]);

                    cargoColecao.Add(cargo);
                }

                return cargoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Não foi possível consultar o cargo por nome. Detalhes: " + exception);       
            }
        }

        public CargoColecao ConsultarPorId(int IDCADCARGO)
        {
            try
            {
                CargoColecao cargoColecao = new CargoColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADCARGO", IDCADCARGO);

                DataTable dataTableCargo = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADCARGOConsultarPorID");
                foreach (DataRow dataRowLinha in dataTableCargo.Rows)
                {
                    Cargo cargo = new Cargo();

                    cargo.IDCADCARGO = Convert.ToInt32(dataRowLinha["IDCADCARGO"]);
                    cargo.CADCARGO = Convert.ToString(dataRowLinha["CADCARGO"]);

                    cargoColecao.Add(cargo);
                }

                return cargoColecao;

            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o cargo por código. Detalhes: " + exception.Message);
            }

        }
    }
}
