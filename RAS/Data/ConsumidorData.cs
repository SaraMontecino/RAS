using System;
using System.Collections.Generic;
using RAS.Models;
using System.Data.SqlClient;

namespace RAS.Data
{
    public class ConsumidorData : Data
    {
        
        public void Create(Consumidor consumidor)
        {
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = base.connectionDB;

            cmd.CommandText = @"exec cad_Consumidor @nome, @cpf, @data_nascimento,@email, @sexo, @telefone, @status,
                                @cashback, @faixa_etaria";

            
            cmd.Parameters.AddWithValue("@nome", consumidor.Nome);
            cmd.Parameters.AddWithValue("@cpf", consumidor.Cpf);
            cmd.Parameters.AddWithValue("@data_nascimento", consumidor.DataNascimento);
            cmd.Parameters.AddWithValue("@email", consumidor.Email);
            cmd.Parameters.AddWithValue("@sexo", consumidor.Sexo);
            cmd.Parameters.AddWithValue("@telefone", consumidor.Telefone);
            cmd.Parameters.AddWithValue("@status", consumidor.Status);
            cmd.Parameters.AddWithValue("@cashback", consumidor.Cashback);
            cmd.Parameters.AddWithValue("@faixa_etaria", consumidor.FaixaEtaria);
            
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
                    Consumidor consumidor     = new Consumidor();
                    consumidor.Pessoas_id     = (int)reader["Pessoas_id"];
                    //consumidor.Cashback       =(decimal)reader["Pontos_Acumulados"];
                    consumidor.FaixaEtaria    = (int)reader["Faixa_etaria"];
                    
                    lista.Add(consumidor);
                }
            }
            catch (SqlException sqlerror)
            {

            }
            return lista;
        }

        public Consumidor Read(int id)
        {
            
            Consumidor consumidor = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB; 

            cmd.CommandText = @"SELECT * FROM v_consumidores where id = @id";

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                consumidor = new Consumidor
                {
                    Pessoas_id      = (int)reader["Id"],
                    Nome            = (string)reader["Cliente"],
                    Cpf             = (string)reader["CPF"],
                    DataNascimento  = (DateTime)reader["Data_Nascimento"],
                    Email           = (string)reader["Email"],
                    Sexo            = (string)reader["Sexo"],
                    Telefone        = (string)reader["Telefone"],
                    Cashback        = (decimal)reader["Pontos_Acumulados"],
                    FaixaEtaria     = (int)reader["Idade"],
                    Status          = (int)reader["Situacao"],
                };
            }

            return consumidor;
        }

        public void Update(Consumidor consumidor)
        {
            
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = base.connectionDB;

            cmd.CommandText = @"exec alt_Consumidor @id, @nome, @cpf, @data_nascimento,@email, @sexo, @telefone, @status,
                                @cashback, @faixa_etaria";

            cmd.Parameters.AddWithValue("@id", consumidor.Pessoas_id);
            cmd.Parameters.AddWithValue("@nome", consumidor.Nome);
            cmd.Parameters.AddWithValue("@cpf", consumidor.Cpf);
            cmd.Parameters.AddWithValue("@data_nascimento", consumidor.DataNascimento);
            cmd.Parameters.AddWithValue("@email", consumidor.Email);
            cmd.Parameters.AddWithValue("@sexo", consumidor.Sexo);
            cmd.Parameters.AddWithValue("@telefone", consumidor.Telefone);
            cmd.Parameters.AddWithValue("@status", consumidor.Status);
            cmd.Parameters.AddWithValue("@cashback", consumidor.Cashback);
            cmd.Parameters.AddWithValue("@faixa_etaria", consumidor.FaixaEtaria);


            cmd.ExecuteNonQuery();
        }

         public void Delete(int id)
        {
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = base.connectionDB;

            cmd.CommandText = @"exec del_Consumidor @id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
