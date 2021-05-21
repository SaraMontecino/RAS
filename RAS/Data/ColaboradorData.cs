using System;
using System.Collections.Generic;
using RAS.Models;
using System.Data.SqlClient;

namespace RAS.Data
{
    public class ColaboradorData : Data
    {

        public void Create(Colaborador colaborador)
        {
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = base.connectionDB;

            // passsar a procedure 
            cmd.CommandText = @"exec cad_Colaborador @nome, @cpf, @sexo, @email, @remuneracao, @comissao, @login, @senha";
            

            cmd.Parameters.AddWithValue("@nome", colaborador.Nome);
            cmd.Parameters.AddWithValue("@cpf", colaborador.Cpf);
            cmd.Parameters.AddWithValue("@sexo", colaborador.Sexo);
            cmd.Parameters.AddWithValue("@email", colaborador.Email);
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

        public Pessoa Read(int id)
        {
            
            Colaborador colaborador = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB; 

            cmd.CommandText = @"SELECT * FROM v_colaboradores ";

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                colaborador = new Colaborador
                {
                    Pessoas_id      = (int)reader["Pessoas_id"],
                    Nome            = (string)reader["Nome"],
                    Cpf             = (string)reader["CPF"],
                    Remuneracao     = (double)reader["Remuneracao"],
                    Comissao        = (double)reader["Comissao"],
                    Status          = (int)reader["Status"],
                };
            }

            return colaborador;
        }

        public void Update(Colaborador colaborador)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = base.connectionDB;

            cmd.CommandText = @"exec alt_Colaborador @id, @nome, @cpf, @status, @remuneracao, @comissao";

            cmd.Parameters.AddWithValue("@id", colaborador.Pessoas_id);
            cmd.Parameters.AddWithValue("@nome", colaborador.Nome);
            cmd.Parameters.AddWithValue("@cpf", colaborador.Cpf);
            cmd.Parameters.AddWithValue("@status", colaborador.Status);
            cmd.Parameters.AddWithValue("@remuneracao", colaborador.Remuneracao);
            cmd.Parameters.AddWithValue("@comissao", colaborador.Comissao);
            

            cmd.ExecuteNonQuery();
        }

        // Preciso do delete ? 
        // Fazer uma procedure que deleta as coisas 

    }
}
