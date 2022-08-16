using System.Data.SqlClient;

public class UsuarioHandler
{
    public const string ConnectionString = "Server=KUPO-PC;Database=SistemaGestion;Trusted_Connection=True;";

    public List<Usuario> getUsuariosDB()
    {
        List<Usuario> listausuario = new List<Usuario>();
        String query = "select * from Usuario";
        using (SqlConnection conect = new SqlConnection(ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(query, conect))
            {
                conect.Open();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read()) {
                            Usuario usuario = new Usuario();
                            usuario.Id = Convert.ToInt32(dr["Id"]);
                            usuario.Nombre = dr["Nombre"].ToString();
                            usuario.Apellido = dr["Apellido"].ToString();
                            usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                            usuario.Password = dr["Contraseña"].ToString();
                            usuario.Email = dr["Mail"].ToString();
                            listausuario.Add(usuario);
                        }
                    }

                }
                conect.Close();
            }
        }

        return listausuario;
    }
}