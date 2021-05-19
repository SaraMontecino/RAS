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
                    Colaborador colaborador = new Colaborador();
                    colaborador.Remuneracao = (int)reader["Remuneracao"];
                    colaborador.Comissao = (double)reader["Comissao"];
                    colaborador.Login = (string)reader["Login"];
                    colaborador.Senha = (string)reader["Senha"];
                    
                    lista.Add(colaborador);
                }
            }
            catch (SqlException sqlerror)
            {

            }
            return lista;
        }

        public void Update(Colaborador colaborador)
        {
            // Criando o cmd ( comando SQL) para executar um comando SQL no banco de dados
            SqlCommand cmd = new SqlCommand();
            // Conexao com o Banco de Dados
            cmd.Connection = base.connectionDB;
            //Criada astring SQL (comando SQL)

            //IDPessoa
            cmd.CommandText = @"UPDATE colaboradores
                                SET Remuneracao = @remuneracao, Comissao = @comissao, Login = @login, Senha = @senha 
                                WHERE IdCliente = @id";

            //cmd.Parameters.AddWithValue("@id", consumidor.IdPessoa);
            

            cmd.ExecuteNonQuery();
        }

    }
}
