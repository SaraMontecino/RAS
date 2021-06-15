using RAS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RAS.Data
{
    public class ItemData : Data
    {
        public List<Item> Read(int id)
        {
            List<Item> lista = new List<Item>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = base.connectionDB;
            cmd.CommandText = @"Select * FROM v_produtosPedidos  produtos_id = @Codigo";

            cmd.Parameters.AddWithValue("@Codigo", id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) //Percorre a tablea até o EOF
            {
                Item item = new Item();
                item.Pedidos_id = (int)reader["Pedidos"];

                item.Produto = new Produto
                {
                    Produtos_id = (int)reader["Codigo"],
                    Descricao   = (string)reader["Produto"]
                };

                item.Qtd = (int)reader["Qtd_Vendida"];
                item.Valor = (decimal)reader["Preco_Unitario"] * (int)reader["Qtd_Vendida"];

                lista.Add(item);
            }

            return lista;
        }
    }
}