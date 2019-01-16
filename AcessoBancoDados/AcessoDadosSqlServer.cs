using System;
using System.Data;
using System.Data.SqlClient;

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //Cria a conexão
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
        }

        //Parâmetro que vão para banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }


        //Persistência - Inserir, Alterar, Excluir
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //Criar conexão
                SqlConnection sqlConnection = CriarConexao();
                //Abrir conexão
                sqlConnection.Open();
                //Criar o comando que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando (dentro da caixa que vai trafegar na conexão )
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; //Em Segundos

                //Adicionar os parâmetros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Executar o comando, ou seja, mandar o comando ir até o banco de dados.
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
                      
        }

        //Consultar registros do banco de dados
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //Criar conexão
                SqlConnection sqlConnection = CriarConexao();
                //Abrir conexão
                sqlConnection.Open();
                //Criar o comando que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando (dentro da caixa que vai trafegar na conexão )
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; //Em Segundos

                //Adicionar os parâmetros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Criando um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                
                //DataTable = Tabela de Dados vazia onde vou colocar os dados que vem do banco
                DataTable dataTable = new DataTable();

                //Mandar o comando ir até o banco buscar os dados e o adaptador preencher o datatable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
