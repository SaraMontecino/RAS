using System;
using System.Collections.Generic;
using RAS.Models;
using System.Data.SqlClient;

namespace RAS.Data
{
    public class ColaboradorData : Data
    {
        // TENHO QUE PASSAR A PESSO AQUI 
        //COMO PASSA DUAS HERANÇAS

        public void Create(Colaborador colaborador)
        {
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = base.connectionDB;

            // tenho que passar pessoa_id no insert ?
            cmd.CommandText = @"INSERT into colaboradores VALUES (@remuneracao, @comissao, @login, @senha)";

            
            cmd.Parameters.AddWithValue("@remuneracao", colaborador.Remuneracao);
            cmd.Parameters.AddWithValue("@comissao", colaborador.Comissao);
            cmd.Parameters.AddWithValue("@login", colaborador.Login);
            cmd.Parameters.AddWithValue("@senha", colaborador.Senha);
            
            cmd.ExecuteNonQuery();
        }

        public List<Colaborador> Read()
        {
            List<Colaborador> lista = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = base.connectionDB;
                
                cmd.CommandText = "SELECT * FROM colaboradores";

                SqlDataReader reader = cmd.ExecuteReader();

                lista = new List<Colaborador>();
                while (reader.Read())
                {
                    Colaborador colaborador     = new Colaborador();
                    colaborador.Pessoas_id      = (int)reader["Pessoas_id"];
                    colaborador.Remuneracao     = (int)reader["Remuneracao"];
                    colaborador.Comissao        = (double)reader["Comissao"];
                    colaborador.Login           = (string)reader["Login"];
                    colaborador.Senha           = (string)reader["Senha"];
                    
                    lista.Add(colaborador);
                }
            }
            catch (SqlException sqlerror)
            {

            }
            return lista;
        }

        // Preciso fazer um read id ?

        public void Update(Colaborador colaborador)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = base.connectionDB;

            //Pessoas_id
            cmd.CommandText = @"UPDATE colaboradores
                                SET Remuneracao = @remuneracao, Comissao = @comissao, Login = @login, Senha = @senha 
                                WHERE pessoas_id = @id";

            cmd.Parameters.AddWithValue("@id", colaborador.Pessoas_id);
            cmd.Parameters.AddWithValue("@remuneracao", colaborador.Remuneracao);
            cmd.Parameters.AddWithValue("@comissao", colaborador.Comissao);
            cmd.Parameters.AddWithValue("@login", colaborador.Login);
            cmd.Parameters.AddWithValue("@senha", colaborador.Senha);
            

            cmd.ExecuteNonQuery();
        }

        // Preciso do delete ? 

    }
}
