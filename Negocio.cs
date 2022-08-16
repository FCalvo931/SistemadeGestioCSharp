public class Negocio
{
    ProductoHandler produtoHandler = new ProductoHandler();
    UsuarioHandler usuarioHandler = new UsuarioHandler();
    ProdutoVenidoHandler produtoVenidoHandler = new ProdutoVenidoHandler();
    VentaHandler ventaHandler = new VentaHandler();

	public Boolean IngresarUsuario(String NombreUsuario, String Contraseña)
	{
        List<Usuario> usuarios = usuarioHandler.getUsuariosDB();
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.NombreUsuario == NombreUsuario && usuario.Password == Contraseña)
            {
                return true;
            }
        }
		return false;
	}

    public void mostrarProductos()
    {
        List<Producto> productos = produtoHandler.getProductosDB();
        Console.WriteLine("---Productos---");
        foreach (Producto producto in productos)
        {
            Console.WriteLine(producto.ToString());
            Console.WriteLine("--------");
        }
    }

    public void mostrarUsuarios()
    {
        List<Usuario> usuarios = usuarioHandler.getUsuariosDB();
        Console.WriteLine("---Usuarios---");
        foreach (Usuario usuario in usuarios)
        {
            Console.WriteLine(usuario.ToString());
            Console.WriteLine("--------");
        }

    }

    public void mostrarVentas()
    {
        List<Venta> venta = ventaHandler.getVentasDB();
        Console.WriteLine("---Venta---");
        foreach (Venta venta1 in venta)
        {
            Console.WriteLine(venta1.ToString());
            Console.WriteLine("--------");
        }
    }

    public void mostrarProductosVendidos()
    {
        List<ProductoVendido> productosVendidos = produtoVenidoHandler.getProductosVendidosDB();
        Console.WriteLine("---ProductosVendidos---");
        foreach (ProductoVendido productoVendido in productosVendidos)
        {
            Console.WriteLine(productoVendido.ToString());
            Console.WriteLine("--------");
        }
    }
}
