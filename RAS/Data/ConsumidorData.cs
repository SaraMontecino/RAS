using System;
using System.Collections.Generic;
using RAS.Models;
using System.Data.SqlClient;

namespace RAS.Data
{
    public class ConsumidorData : Data
    {
        // TENHO QUE PASSAR A PESSO AQUI 
        //COMO PASSA DUAS HERANÇAS

        public void Create(Consumidor consumidor)
        {
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = base.connectionDB;

            // tenho que passar pessoa_id no insert ?
            cmd.CommandText = @"INSERT into consumidores VALUES (@cashback, @faixa_etaria)";

            
            cmd.Parameters.AddWithValue("@cashback", consumidor.Cashback);
            cmd.Parameters.AddWithValue("@faixa_etaria", consumidor.Faixa_etaria);
            
            cmd.ExecuteNonQuery();
        }

        public List<Consumidor> Read()
        {
            List<Consumidor> lista = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = base.connectionDB;
                
                cmd.CommandText = "SELECT * FROM consumidores";

                SqlDataReader reader = cmd.ExecuteReader();

                lista = new List<Consumidor>();
                while (reader.Read())
                {
                    Consumidor consumidor = new Consumidor();
                    consumidor.Cashback = (int)reader["Cashback"];
                    consumidor.Faixa_etaria = (string)reader["Faixa_etaria"];
                    
                    lista.Add(consumidor);
                }
            }
            catch (SqlException sqlerror)
            {

            }
            return lista;
        }

        public void Update(Consumidor consumidor)
        {
            // Criando o cmd ( comando SQL) para executar um comando SQL no banco de dados
            SqlCommand cmd = new SqlCommand();
            // Conexao com o Banco de Dados
            cmd.Connection = base.connectionDB;
            //Criada astring SQL (comando SQL)

            //IDPessoa
            cmd.CommandText = @"UPDATE consumidores
                                SET Cashback = @cashback, Faixa_etaria = @faixa_etaria 
                                WHERE IdCliente = @id";

            //cmd.Parameters.AddWithValue("@id", consumidor.IdPessoa);
            

            cmd.ExecuteNonQuery();
        }

    }
}
