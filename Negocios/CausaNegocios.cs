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
    public class CausaNegocios
    {
        //Instanciar = criar um novo baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        
        public string Inserir(Causa causa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADCAUSA",causa.CADCAUSA);
                string IDCADCAUSA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADCAUSAInserir").ToString();
                return IDCADCAUSA;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Causa causa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADCAUSA", causa.IDCADCAUSA);
                acessoDadosSqlServer.AdicionarParametros("@CADCAUSA", causa.CADCAUSA);
                string IDCADCAUSA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADCAUSAAlterar").ToString();
                return IDCADCAUSA;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }            
        }

        public string Excluir(Causa causa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADCAUSA", causa.IDCADCAUSA);
                string IDCADCAUSA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCADCAUSAExcluir").ToString();
                return IDCADCAUSA;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public CausaColecao ConsultarPorNome(string nome)
        {
            try
            {
                CausaColecao causaColecao = new CausaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CADCAUSA", nome);

                DataTable dataTableCausa = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADCAUSAConsultarPorNome");
                foreach (DataRow linha in dataTableCausa.Rows)
                {
                    Causa causa = new Causa();

                    causa.IDCADCAUSA = Convert.ToInt32(linha["IDCADCAUSA"]);
                    causa.CADCAUSA = Convert.ToString(linha["CADCAUSA"]);

                    causaColecao.Add(causa);
                }

                return causaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Não foi possível consultar a causa por nome. Detalhes: " + exception);       
            }
        }

        public CausaColecao ConsultarPorId(int IDCADCAUSA)
        {
            try
            {
                CausaColecao causaColecao = new CausaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDCADCAUSA", IDCADCAUSA);

                DataTable dataTableCausa = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCADCAUSAConsultarPorID");
                foreach (DataRow dataRowLinha in dataTableCausa.Rows)
                {
                    Causa causa = new Causa();

                    causa.IDCADCAUSA = Convert.ToInt32(dataRowLinha["IDCADCAUSA"]);
                    causa.CADCAUSA = Convert.ToString(dataRowLinha["CADCAUSA"]);

                    causaColecao.Add(causa);
                }

                return causaColecao;

            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar a causa por código. Detalhes: " + exception.Message);
            }

        }

    }
}
