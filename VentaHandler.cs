using System.Data.SqlClient;

public class VentaHandler
{
    public const string ConnectionString = "Server=KUPO-PC;Database=SistemaGestion;Trusted_Connection=True;";

    public List<Venta> getVentasDB()
    {
        List<Venta> listaVentas = new List<Venta>();
        String query = "select * from Venta";
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
                            Venta venta = new Venta();
                            venta.Id = Convert.ToInt32(dr["Id"]);
                            venta.Comentarios = dr["Comentarios"].ToString();
                            listaVentas.Add(venta);
                        }
                    }

                }
                conect.Close();
            }
        }

        return listaVentas;
    }
}
