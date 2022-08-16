public class Producto
{
    private int _id;
    private string _descripcion;
    private double _costo;
    private double _precioDeVenta;
    private int _stock;
    private int _idUsuario;

    public Producto()
    {
        Id = 0;
        Descripcion = "";
        Costo = 0;
        PrecioDeVenta = 0;
        Stock = 0;
        IdUsuario = 0;
    }

    public Producto(int id, string descripcion, double costo, double precioDeVenta, int stock, int idUsuario)
    {
        Id = id;
        Descripcion = descripcion;
        Costo = costo;
        PrecioDeVenta = precioDeVenta;
        Stock = stock;
        IdUsuario = idUsuario;
    }

    public int Id { get => _id; set => _id = value; }
    public string Descripcion { get => _descripcion; set => _descripcion = value; }
    public double Costo { get => _costo; set => _costo = value; }
    public double PrecioDeVenta { get => _precioDeVenta; set => _precioDeVenta = value; }
    public int Stock { get => _stock; set => _stock = value; }
    public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }

    public override string ToString()
    {
        return "Id = " + Id +
            "\nDescripcion = " + Descripcion +
            "\nCosto = " + Costo +
            "\nPreciodeVenta = " + PrecioDeVenta +
            "\nStock = " + Stock +
            "\nIdUsuario = " + IdUsuario;
    }
}