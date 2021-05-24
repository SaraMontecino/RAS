﻿using System;
using System.Collections.Generic;
using RAS.Models;
using System.Data.SqlClient;

namespace RAS.Data
{
    public class ProdutoData : Data
    {
        
        public void Create(Produto produto)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB;

            cmd.CommandText = @"exec cad_Produto @tipo, @descricao, @estoque, @valor ";
            
            cmd.Parameters.AddWithValue("@tipo", produto.Tipo);
            cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
            cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
            cmd.Parameters.AddWithValue("@valor", produto.Valor);

            cmd.ExecuteNonQuery();
        }

        public List<Produto> Read()
        {
            List<Produto> lista = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = base.connectionDB;

                cmd.CommandText = "SELECT * FROM produtos";

                SqlDataReader reader = cmd.ExecuteReader();

                lista = new List<Produto>();
                while (reader.Read())
                {
                    Produto produto     = new Produto();
                    produto.Produtos_id = (int)reader["Produtos_id"];
                    produto.Tipo        = (int)reader["Tipo"];
                    produto.Descricao   = (string)reader["Descricao"];
                    produto.Estoque     = (int)reader["Estoque"];
                    produto.Valor       = (double)reader["Valor"];

                    lista.Add(produto);
                }
            }
            catch (SqlException sqlerror)
            {
                
            }
            return lista;
        }

        public Produto Read(int id)
        {
            
            Produto produto = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB; 

            cmd.CommandText = @"SELECT * FROM v_produtos ";

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                produto = new Produto
                {
                    Produtos_id     = (int)reader["Produtos_id"],
                    Tipo            = (int)reader["Tipo"], //nao ta na view
                    Descricao       = (string)reader["Descricao"],
                    Estoque         = (int)reader["Estoque"],
                    Valor           = (double)reader["Valor"]
                };
            }

            return produto;
        }

        public void Update(Produto produto)
        {
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = base.connectionDB;
            
            cmd.CommandText = @"exec alt_Produto @produto_id int, @tipo, @descricao, @estoque, @valor";

            cmd.Parameters.AddWithValue("@id", produto.Produtos_id);
            cmd.Parameters.AddWithValue("@tipo", produto.Tipo);
            cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
            cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
            cmd.Parameters.AddWithValue("@valor", produto.Valor);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = base.connectionDB;

            cmd.CommandText = @"exec del_Produto @id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

    }
}
