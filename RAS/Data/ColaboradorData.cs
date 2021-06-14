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

                cmd.CommandText = "SELECT * FROM v_colaboradores";

                SqlDataReader reader = cmd.ExecuteReader();

                lista = new List<Colaborador>();
                while (reader.Read())
                {
                    Colaborador colaborador = new Colaborador();
                    colaborador.Pessoas_id = (int)reader["Id"];
                    colaborador.Remuneracao = (decimal)reader["Salario"];
                    colaborador.Comissao = (decimal)reader["Comissao"];
                    colaborador.Login = (string)reader["Login"];
                    colaborador.Senha = (string)reader["Senha"];
                    colaborador.Nome = (string)reader["Colaborador"];
                    colaborador.Cpf =(string)reader["CPF"];

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
                    Pessoas_id = (int)reader["Id"],
                    Nome = (string)reader["Colaborador"],
                    Cpf = (string)reader["CPF"],
                    DataNascimento = (DateTime)reader["Data_Nascimento"],
                    Email = (string)reader["Email"],
                    Sexo = (string)reader["Sexo"],
                    Telefone = (string)reader["Telefone"],
                    Remuneracao = (decimal)reader["Salario"],
                    Comissao = (decimal)reader["Comissao"],
                    Login = (string)reader["Login"],
                    Senha = (string)reader["Senha"],
                    Status = (int)reader["Situacao"],

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

        public Colaborador Read(ColaboradorViewModel model)
        {
            //declarando um objeto Colaborador e inicializando como null

            Colaborador colaborador = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB;//conexão com o Banco de Dados

            //string SQL para ser executada no Banco de Dados
            cmd.CommandText = @"select p.id Id, p.nome Colaborador, p.cpf CPF, p.data_nascimento Data_Nascimento, p.email Email, p.sexo Sexo, p.telefone Telefone,
                                        c.remuneracao Salario, c.comissao Comissao, c.login Login, c.senha Senha, p.status Situacao
                                from pessoas p, colaboradores c
                                where p.id = c.pessoas_id
                                and c.login = @login and c.senha = @senha";

            //inserindo o valor do id recebido a string SQL
            cmd.Parameters.AddWithValue("@login", model.Login);
            cmd.Parameters.AddWithValue("@senha", model.Senha);

            //Executando o comando SQL no Banco de Dados
            SqlDataReader reader = cmd.ExecuteReader();

            //verificando se, após a consulta, retornou um registro
            if (reader.Read())
            {
                //instanciando o objeto Colaborador declarado anteriormente
                //e colocando os dados do registro da tabela no objeto

                colaborador = new Colaborador
                {
                    Pessoas_id = (int)reader["Id"],
                    Nome = (string)reader["Colaborador"],
                    Cpf = (string)reader["CPF"],
                    DataNascimento = (DateTime)reader["Data_Nascimento"],
                    Email = (string)reader["Email"],
                    Sexo = (string)reader["Sexo"],
                    Telefone = (string)reader["Telefone"],
                    Remuneracao = (decimal)reader["Salario"],
                    Comissao = (decimal)reader["Comissao"],
                    Login = (string)reader["Login"],
                    Senha = (string)reader["Senha"],
                    Status = (int)reader["Situacao"],
                };
            }

            //retornando o objeto Colaborador, que pode ser null ou com as informações
            //recebidas na consulta
            return colaborador;
        }//consulta id

    }
}
