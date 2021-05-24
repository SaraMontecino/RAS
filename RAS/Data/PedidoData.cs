using System;
using System.Collections.Generic;
using RAS.Models;
using System.Data.SqlClient;

namespace RAS.Data
{
    public class PedidoData : Data
    {
        public void Create(Pedido pedido)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB;

            cmd.CommandText = @"exec cad_Pedido @consumidor, @colaborador ";
            
            cmd.Parameters.AddWithValue("@consumidor", pedido.Consumidores_id);
            cmd.Parameters.AddWithValue("@colaborador", pedido.Colaboradores_id);

            cmd.ExecuteNonQuery();
        }

        public List<Pedido> Read()
        {
            List<Pedido> lista = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = base.connectionDB;

                cmd.CommandText = "SELECT * FROM pedidos";

                SqlDataReader reader = cmd.ExecuteReader();

                lista = new List<Pedido>();
                while (reader.Read())
                {
                    Pedido pedido            = new Pedido();
                    pedido.Consumidores_id   = (int)reader["Consumidores_id"];
                    pedido.Colaboradores_id  = (int)reader["Colaboradores_id"];

                    lista.Add(pedido);
                }
            }
            catch (SqlException sqlerror)
            {
                
            }
            return lista;
        }

        public Pedido Read(int id)
        {
            
            Pedido pedido = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB; 

            cmd.CommandText = @"SELECT * FROM v_pedidos ";

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                pedido = new Pedido
                {
                    Consumidores_id     = (int)reader["Consumidores_id"],
                    Colaboradores_id    = (int)reader["Colaboradores_id"],
                    
                };
            }

            return pedido;
        }

        public void Update(Pedido pedido)
        {
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = base.connectionDB;
            
            cmd.CommandText = @"exec alt_Pedido @pedido_id, @valor, @desconto, @consumidores_id, @colaboradores_id";

            cmd.Parameters.AddWithValue("@id", pedido.Pedidos_id);
            cmd.Parameters.AddWithValue("@valor", pedido.Valor);
            cmd.Parameters.AddWithValue("@desconto", pedido.Desconto);
            cmd.Parameters.AddWithValue("@consumidores_id", pedido.Consumidores_id);
            cmd.Parameters.AddWithValue("@colaboradores_id", pedido.Colaboradores_id);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = base.connectionDB;

            cmd.CommandText = @"exec del_Pedido @id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
