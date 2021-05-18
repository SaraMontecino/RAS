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
                string strConexao = @"Data Source = localhost;
                            Initial Catalog = BDRAS;
                            Integrated Security = true";    //Autenticação do Windows
                                                            //User Id=sa; Password=dba;     //Autenticação SQL Server

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
