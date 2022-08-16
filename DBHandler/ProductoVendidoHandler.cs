using System.Data.SqlClient;

public class ProdutoVenidoHandler
{
    public const string ConnectionString = "Server=KUPO-PC;Database=SistemaGestion;Trusted_Connection=True;";

    public List<ProductoVendido> getProductosVendidosDB()
    {
        List<ProductoVendido> listaproductosVendidos = new List<ProductoVendido>();
        String query = "select * from ProductoVendido";
        using (SqlConnection conect = new SqlConnection(ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(query, conect))
            {
                conect.Open();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ProductoVendido productoVendido = new ProductoVendido();
                            productoVendido.Id = Convert.ToInt32(dr["Id"]);
                            productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                            productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                            productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                            listaproductosVendidos.Add(productoVendido);
                        }
                    }

                }
                conect.Close();
            }
        }

        return listaproductosVendidos;
    }
}
