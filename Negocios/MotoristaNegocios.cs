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
    public class MotoristaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Motorista motorista)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADNOMEMOTORISTA", motorista.CADNOMEMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADENDMOTORISTA", motorista.CADENDMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADTELMOTORISTA", motorista.CADTELMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADCPFMOTORISTA", motorista.CADCPFMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADRGMOTORISTA", motorista.CADRGMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADCNHMOTORISTA", motorista.CADCNHMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADDATANASCMOTORISTA", motorista.CADDATANASCMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADDATACADASTROMOTORISTA", motorista.CADDATACADASTROMOTORISTA);
                string IDCADMOTORISTA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADMOTORISTAInserir").ToString();
                return IDCADMOTORISTA;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Motorista motorista)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADMOTORISTA", motorista.IDCADMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADNOMEMOTORISTA", motorista.CADNOMEMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADENDMOTORISTA", motorista.CADENDMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADTELMOTORISTA", motorista.CADTELMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADCPFMOTORISTA", motorista.CADCPFMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADRGMOTORISTA", motorista.CADRGMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADCNHMOTORISTA", motorista.CADCNHMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADDATANASCMOTORISTA", motorista.CADDATANASCMOTORISTA);
                acessoDadosSqlServer.AdicionarParametros("@CADDATACADASTROMOTORISTA", motorista.CADDATACADASTROMOTORISTA);
                string IDCADMOTORISTA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADMOTORISTAAlterar").ToString();
                return IDCADMOTORISTA;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Motorista motorista)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADMOTORISTA", motorista.IDCADMOTORISTA);
                string IDCADMOTORISTA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADMOTORISTAExcluir").ToString();
                return IDCADMOTORISTA;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public MotoristaColecao ConsultarPorNome(string nome)
        {
            try
            {
                MotoristaColecao motoristaColecao = new MotoristaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADNOMEMOTORISTA", nome);

                DataTable dataTableMotorista = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADMOTORISTAConsultarPorNome");

                foreach (DataRow linha in dataTableMotorista.Rows)
                {
                    Motorista motorista = new Motorista();

                    motorista.IDCADMOTORISTA = Convert.ToInt32(linha["IDCADMOTORISTA"]);
                    motorista.CADNOMEMOTORISTA = Convert.ToString(linha["CADNOMEMOTORISTA"]);
                    motorista.CADENDMOTORISTA = Convert.ToString(linha["CADENDMOTORISTA"]);
                    motorista.CADTELMOTORISTA = Convert.ToString(linha["CADTELMOTORISTA"]);
                    motorista.CADCPFMOTORISTA = Convert.ToString(linha["CADCPFMOTORISTA"]);
                    motorista.CADRGMOTORISTA = Convert.ToString(linha["CADRGMOTORISTA"]);
                    motorista.CADCNHMOTORISTA = Convert.ToString(linha["CADCNHMOTORISTA"]);
                    motorista.CADDATANASCMOTORISTA = Convert.ToDateTime(linha["CADDATANASCMOTORISTA"]);
                    motorista.CADDATACADASTROMOTORISTA = Convert.ToDateTime(linha["CADDATACADASTROMOTORISTA"]);
                    motoristaColecao.Add(motorista);
                }
                return motoristaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o motorista por nome. Detalhes: " + ex.Message);
            }
        }

        public MotoristaColecao ConsultarPorId(int IDCADMOTORISTA)
        {
            try
            {
                MotoristaColecao motoristaColecao = new MotoristaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADNOMEMOTORISTA", IDCADMOTORISTA);

                DataTable dataTableMotorista = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADMOTORISTAConsultarPorID");

                foreach (DataRow linha in dataTableMotorista.Rows)
                {
                    Motorista motorista = new Motorista();

                    motorista.IDCADMOTORISTA = Convert.ToInt32(linha["IDCADMOTORISTA"]);
                    motorista.CADNOMEMOTORISTA = Convert.ToString(linha["CADNOMEMOTORISTA"]);
                    motorista.CADENDMOTORISTA = Convert.ToString(linha["CADENDMOTORISTA"]);
                    motorista.CADTELMOTORISTA = Convert.ToString(linha["CADTELMOTORISTA"]);
                    motorista.CADCPFMOTORISTA = Convert.ToString(linha["CADCPFMOTORISTA"]);
                    motorista.CADRGMOTORISTA = Convert.ToString(linha["CADRGMOTORISTA"]);
                    motorista.CADCNHMOTORISTA = Convert.ToString(linha["CADCNHMOTORISTA"]);
                    motorista.CADDATANASCMOTORISTA = Convert.ToDateTime(linha["CADDATANASCMOTORISTA"]);
                    motorista.CADDATACADASTROMOTORISTA = Convert.ToDateTime(linha["CADDATACADASTROMOTORISTA"]);
                    motoristaColecao.Add(motorista);
                }
                return motoristaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o motorista por código. Detalhes: " + ex.Message);
            }
        }
    }
}
