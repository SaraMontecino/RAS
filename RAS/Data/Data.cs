using System;
using System.Data.SqlClient;

namespace RAS.Data
{
    public abstract class Data : IDisposable
    {
        //Atributo: vai nos permitir conectar com o Banco de Dados
        protected SqlConnection connectionDB;
        //Construtor
        public Data()
        {
            try
            {
                //string de conexão com o Banco de Dados
                string strConexao = @"Data Source = DESKTOP-R0DQJ08;
                            Initial Catalog = RAS4;
                            Integrated Security = false;    
                            User Id=sa; 
                            Password=rafa123521";     

                connectionDB = new SqlConnection(strConexao);

                connectionDB.Open();
            }
            catch (SqlException er)
            {
                Console.WriteLine("Erro do banco " + er);
            }
        }

        public void Dispose()
        {
            connectionDB.Close();
        }
    }
}
