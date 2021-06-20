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

            cmd.CommandText = @"exec cad_Pedido @consumidor, @colaborador;";

            cmd.Parameters.AddWithValue("@consumidor", pedido.Consumidores_id);
            cmd.Parameters.AddWithValue("@colaborador", pedido.Colaboradores_id);

            cmd.ExecuteNonQuery();

            SqlCommand cmdId = new SqlCommand();
            cmdId.Connection = base.connectionDB;

            cmdId.CommandText = @"select max(id) as id from pedidos;";

            cmdId.Parameters.AddWithValue("@consumidor", pedido.Consumidores_id);
            cmdId.Parameters.AddWithValue("@colaborador", pedido.Colaboradores_id);

            SqlDataReader reader = cmdId.ExecuteReader();
            int idPedido = 0;

            if (reader.Read())
            {
                idPedido = (int)reader["Id"];
            }


            foreach (var item in pedido.Itens)
            {
                SqlCommand cmdItem = new SqlCommand();
                cmdItem.Connection = connectionDB;
                cmdItem.CommandText = @"exec cad_ProdutosPedidos @pedido, @produto, @qtd, @valor";

                cmdItem.Parameters.AddWithValue("@pedido", idPedido);
                cmdItem.Parameters.AddWithValue("@produto", item.Produto.Produtos_id);
                cmdItem.Parameters.AddWithValue("@qtd", item.Qtd);
                cmdItem.Parameters.AddWithValue("@valor", item.Produto.Valor);

                cmdItem.ExecuteNonQuery();

                SqlCommand cmdBaixa = new SqlCommand();
                cmdBaixa.Connection = connectionDB;
                cmdBaixa.CommandText = @"exec baixarEstoque @produto, @qtd";

                cmdBaixa.Parameters.AddWithValue("@produto", item.Produto.Produtos_id);
                cmdBaixa.Parameters.AddWithValue("@qtd", item.Qtd);

                cmdBaixa.ExecuteNonQuery();
            }

            SqlCommand cmdTotal = new SqlCommand();
            cmdTotal.Connection = base.connectionDB;

            cmdTotal.CommandText = @"exec totalCompra @pedido";

            cmdTotal.Parameters.AddWithValue("@pedido", idPedido);

            cmdTotal.ExecuteNonQuery();

        }

        public List<PedidoViewModel> Read()
        {
            List<PedidoViewModel> lista = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = base.connectionDB;

                cmd.CommandText = "select Id, Cliente, Data, Colaborador, Total from v_pedidos";

                SqlDataReader reader = cmd.ExecuteReader();

                lista = new List<PedidoViewModel>();
                while (reader.Read())
                {
                    PedidoViewModel pedido = new PedidoViewModel();
                    pedido.Id = (int)reader["Id"];
                    pedido.NomeCliente = (string)reader["Cliente"];
                    pedido.Data = (DateTime)reader["Data"];
                    pedido.NomeColaborador = (string)reader["Colaborador"];
                    pedido.Total = (decimal)reader["Total"];

                    List<ProdutoPedidoViewModel> listaProdutoPedido = new List<ProdutoPedidoViewModel>();


                    SqlCommand cmdPi = new SqlCommand();
                    cmdPi.Connection = base.connectionDB;

                    cmdPi.CommandText = "select Produto, Qtd_Vendida from v_produtosPedidos where Pedido = @pedido";
                    cmdPi.Parameters.AddWithValue("@pedido", pedido.Id);

                    SqlDataReader readerPi = cmdPi.ExecuteReader();

                    while (readerPi.Read())
                    {
                        ProdutoPedidoViewModel produtoPedido = new ProdutoPedidoViewModel();
                        produtoPedido.Nome = (string)readerPi["Produto"];
                        produtoPedido.Qtd = (int)readerPi["Qtd_Vendida"];

                        listaProdutoPedido.Add(produtoPedido);
                    }

                    pedido.Itens = listaProdutoPedido;

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
                    Consumidores_id = (int)reader["Consumidores_id"],
                    Colaboradores_id = (int)reader["Colaboradores_id"],

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
