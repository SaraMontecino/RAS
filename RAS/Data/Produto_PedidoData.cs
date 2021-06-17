using System;
using System.Collections.Generic;
using RAS.Models;
using System.Data.SqlClient;
namespace RAS.Data
{
    public class Produto_PedidoData : Data
    {
        // public void Create(Produto_Pedido produto_pedido)
        // {
        //     SqlCommand cmd = new SqlCommand();
        //     cmd.Connection = base.connectionDB;

        //     cmd.CommandText = @"exec cad_ProdutosPedidos @pedido, @produto, @qtd, @valor

        //     cmd.Parameters.AddWithValue("@pedido", produto_pedido.Produtos_id);
        //     cmd.Parameters.AddWithValue("@produto", produto_pedido.Pedidos_id);
        //     cmd.Parameters.AddWithValue("@qtd", produto_pedido.Qtd);
        //     cmd.Parameters.AddWithValue("@valor", produto_pedido.Valor);

        //     cmd.ExecuteNonQuery();
        // }

        //     public List<Produto_Pedido> Read()
        //     {
        //         List<Produto_Pedido> lista = null;

        //         try
        //         {
        //             SqlCommand cmd = new SqlCommand();
        //             cmd.Connection = base.connectionDB;

        //             cmd.CommandText = "SELECT * FROM produtos_pedidos";

        //             SqlDataReader reader = cmd.ExecuteReader();

        //             lista = new List<Produto_Pedido>();
        //             while (reader.Read())
        //             {
        //                 Produto_Pedido produto_pedido = new Produto_Pedido();
        //                 produto_pedido.Produtos_id = (int)reader["Produtos_id"];
        //                 produto_pedido.Pedidos_id = (int)reader["Pedidos_id"];
        //                 produto_pedido.Qtd = (int)reader["Qtd"];
        //                 produto_pedido.Valor = (decimal)reader["Valor"];

        //                 lista.Add(produto_pedido);
        //             }
        //         }
        //         catch (SqlException sqlerror)
        //         {

        //         }
        //         return lista;
        //     }

        //     public Produto_Pedido Read(int id)
        //     {

        //         Produto_Pedido produto_pedido = null;

        //         SqlCommand cmd = new SqlCommand();
        //         cmd.Connection = base.connectionDB;

        //         cmd.CommandText = @"SELECT * FROM v_produtosPedidos where produtos_id = @Codigo ";

        //         cmd.Parameters.AddWithValue("@Codigo", id);

        //         SqlDataReader reader = cmd.ExecuteReader();

        //         if (reader.Read())
        //         {
        //             produto_pedido = new Produto_Pedido
        //             {
        //                 Produtos_id = (int)reader["Codigo"],
        //                 Pedidos_id = (int)reader["Pedido"],
        //                 Qtd = (int)reader["Qtd_Vendida"],
        //                 Valor = (decimal)reader["Valor_Produto"]
        //             };
        //         }

        //         return produto_pedido;
        //     }

        //     public void Update(Produto_Pedido produto_pedido)
        //     {

        //         SqlCommand cmd = new SqlCommand();

        //         cmd.Connection = base.connectionDB;

        //         cmd.CommandText = @"exec alt_ProdutosPedidos @pedido, @produto, @qtd ";

        //         cmd.Parameters.AddWithValue("@pedido", produto_pedido.Pedidos_id);
        //         cmd.Parameters.AddWithValue("@produto", produto_pedido.Produtos_id);
        //         cmd.Parameters.AddWithValue("@qtd", produto_pedido.Qtd);

        //         cmd.ExecuteNonQuery();
        //     }

        //     public void Delete(int? pedido_id, int? produto_id)
        //     {

        //         SqlCommand cmd = new SqlCommand();

        //         cmd.Connection = base.connectionDB;

        //         cmd.CommandText = @"exec del_Produto_Pedido @pedido_id, @produto_id";

        //         cmd.Parameters.AddWithValue("@pedido_id", pedido_id);
        //         cmd.Parameters.AddWithValue("@produto_id", produto_id);

        //         cmd.ExecuteNonQuery();
        //     }
    }
}
