using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using RAS.Models;

namespace RAS.Data
{
    public class PessoaData : Data
    {
        public void Create(Pessoa pessoa)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB;

            cmd.CommandText = @"INSERT INTO pessoas VALUES (@nome, @cpf, @data_nascimento, @email, @sexo, @telefone, @status) ";

            cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
            cmd.Parameters.AddWithValue("@cpf", pessoa.Cpf);
            cmd.Parameters.AddWithValue("@data_nascimento", pessoa.Data_nascimento);
            cmd.Parameters.AddWithValue("@email", pessoa.Email);
            cmd.Parameters.AddWithValue("@sexo", pessoa.Sexo);
            cmd.Parameters.AddWithValue("@telefone", pessoa.Telefone);
            cmd.Parameters.AddWithValue("@status", pessoa.Status);

            cmd.ExecuteNonQuery();
        }

        public List<Pessoa> Read()
        {
            List<Pessoa> lista = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = base.connectionDB;

                cmd.CommandText = "SELECT * FROM pessoas ORDER BY Nome";

                SqlDataReader reader = cmd.ExecuteReader();

                lista = new List<Pessoa>();
                while (reader.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Pessoas_id       = (int)reader["Pessoas_id"];
                    pessoa.Nome             = (string)reader["Nome"];
                    pessoa.Cpf              = (string)reader["CPF"];
                    pessoa.Data_nascimento  = (DateTime)reader["Data de Nascimento"];
                    pessoa.Email            = (string)reader["Email"];
                    pessoa.Sexo             = (string)reader["Sexo"];
                    pessoa.Telefone         = (string)reader["Telefone"];
                    pessoa.Status           = (int)reader["Status"];

                    lista.Add(pessoa);
                }
            }
            catch (SqlException sqlerror)
            {
                
            }
            return lista;
        }

        public Pessoa Read(int id)
        {
            
            Pessoa pessoa = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB; 

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                pessoa = new Pessoa
                {
                    Pessoas_id      = (int)reader["Pessoas_id"],
                    Nome            = (string)reader["Nome"],
                    Cpf             = (string)reader["CPF"],
                    Data_nascimento = (DateTime)reader["Data de Nascimento"],
                    Email           = (string)reader["Email"],
                    Sexo            = (string)reader["Sexo"],
                    Telefone        = (string)reader["Telefone"],
                    Status          = (int)reader["Status"]
                };
            }

            return pessoa;
        }


        public Pessoa Read(string cpf)
        {
            Pessoa pessoa = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB; 

            cmd.CommandText = @"SELECT * FROM pessoa WHERE cpf = @cpf";

            cmd.Parameters.AddWithValue("@cpf", cpf);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                pessoa = new Pessoa
                {
                    Pessoas_id      = (int)reader["Pessoas_id"],
                    Nome            = (string)reader["Nome"],
                    Cpf             = (string)reader["CPF"],
                    Data_nascimento = (DateTime)reader["Data de Nascimento"],
                    Email           = (string)reader["Email"],
                    Sexo            = (string)reader["Sexo"],
                    Telefone        = (string)reader["Telefone"],
                    Status          = (int)reader["Status"]
                };
            }

            return pessoa;
        }


        public void Update(Pessoa pessoa)
        {
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = base.connectionDB;
            
            cmd.CommandText = @"UPDATE pessoas
                                SET Nome = @nome, Cpf = @cpf, Data_nascimento = @data_nascimento, Email = @email, Sexo = @sexo, Telefone = @telefone, Status = @status 
                                WHERE pessoas_id = @id";

            cmd.Parameters.AddWithValue("@id", pessoa.Pessoas_id);
            cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
            cmd.Parameters.AddWithValue("@cpf", pessoa.Cpf);
            cmd.Parameters.AddWithValue("@data_nascimento", pessoa.Data_nascimento);
            cmd.Parameters.AddWithValue("@email", pessoa.Email);
            cmd.Parameters.AddWithValue("@sexo", pessoa.Sexo);
            cmd.Parameters.AddWithValue("@telefone", pessoa.Telefone);
            cmd.Parameters.AddWithValue("@status", pessoa.Status);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = base.connectionDB;

            cmd.CommandText = @"DELETE FROM pessoas WHERE pessoas_id =@id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
