using System.Data.SqlClient;

public class ProductoHandler
{
	public const string ConnectionString = "Server=KUPO-PC;Database=SistemaGestion;Trusted_Connection=True;";

	public List<Producto> getProductosDB()
    {
        List<Producto> listaproductos = new List<Producto>();
        String query = "select * from Producto";
        using (SqlConnection conect = new SqlConnection(ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(query,conect))
            {
                conect.Open();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Producto producto = new Producto();
                            producto.Id = Convert.ToInt32(dr["Id"]);
                            producto.Descripcion = dr["Descripciones"].ToString();
                            producto.Costo = Convert.ToDouble(dr["Costo"]);
                            producto.PrecioDeVenta = Convert.ToDouble(dr["PrecioVenta"]);
                            producto.Stock = Convert.ToInt32(dr["Stock"]);
                            producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                            listaproductos.Add(producto);
                        }
                    }

                }
                conect.Close();
            }
        }

    return listaproductos;
    }
}
