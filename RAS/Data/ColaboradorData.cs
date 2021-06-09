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
            cmd.CommandText = @"exec cad_Colaborador @nome, @cpf, @data_nascimento, @email, @sexo, @telefone, @status,   
                                @remuneracao, @comissao, @login, @senha";
            

            cmd.Parameters.AddWithValue("@nome", colaborador.Nome);
            cmd.Parameters.AddWithValue("@cpf", colaborador.Cpf);
            cmd.Parameters.AddWithValue("@data_nascimento", colaborador.DataNascimento);
            cmd.Parameters.AddWithValue("@email", colaborador.Email);
            cmd.Parameters.AddWithValue("@sexo", colaborador.Sexo);
            cmd.Parameters.AddWithValue("@telefone", colaborador.Telefone);
            cmd.Parameters.AddWithValue("@status", colaborador.Status);
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
                    colaborador.Remuneracao     = (decimal)reader["Remuneracao"];
                    colaborador.Comissao        = (decimal)reader["Comissao"];
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


        public Colaborador Read(int id)
        {
            
            Colaborador colaborador = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB; 

            cmd.CommandText = @"SELECT * FROM v_colaboradores where id = @id";

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                colaborador = new Colaborador
                {
                    Pessoas_id      = (int)reader["Id"],
                    Nome            = (string)reader["Colaborador"],
                    Cpf             = (string)reader["CPF"],
                    DataNascimento  = (DateTime)reader["Data_Nascimento"],
                    Email           = (string)reader["Email"],
                    Sexo            = (string)reader["Sexo"],
                    Telefone        = (string)reader["Telefone"],
                    Remuneracao     = (decimal)reader["Salario"],
                    Comissao        = (decimal)reader["Comissao"],
                    Login           = (string)reader["Login"],
                    Senha           = (string)reader["Senha"],
                    Status          = (int)reader["Situacao"],
                    
                };
            }

            return colaborador;
        }

        public void Update(Colaborador colaborador)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = base.connectionDB;
            
            cmd.CommandText = @"exec alt_Colaborador @id, @nome, @cpf, @data_nascimento,@email, @sexo, @telefone, @status,   
                                @remuneracao, @comissao, @login, @senha";

            cmd.Parameters.AddWithValue("@id", colaborador.Pessoas_id);
            cmd.Parameters.AddWithValue("@nome", colaborador.Nome);
            cmd.Parameters.AddWithValue("@cpf", colaborador.Cpf);
            cmd.Parameters.AddWithValue("@data_nascimento", colaborador.DataNascimento);
            cmd.Parameters.AddWithValue("@email", colaborador.Email);
            cmd.Parameters.AddWithValue("@sexo", colaborador.Sexo);
            cmd.Parameters.AddWithValue("@telefone", colaborador.Telefone);
            cmd.Parameters.AddWithValue("@status", colaborador.Status);
            cmd.Parameters.AddWithValue("@remuneracao", colaborador.Remuneracao);
            cmd.Parameters.AddWithValue("@comissao", colaborador.Comissao);
            cmd.Parameters.AddWithValue("@login", colaborador.Login);
            cmd.Parameters.AddWithValue("@senha", colaborador.Senha);
            

            cmd.ExecuteNonQuery();
        }

         public void Delete(int id)
        {
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = base.connectionDB;

            cmd.CommandText = @"exec del_Colaborador @id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

    }
}
