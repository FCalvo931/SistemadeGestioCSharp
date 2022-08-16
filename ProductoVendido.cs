﻿public class ProductoVendido
{
    private int _id;
    private int _idProducto;
    private int _stock;
    private int _idVenta;

    public ProductoVendido()
    {
        Id = 0;
        IdProducto = 0;
        Stock = 0;
        IdVenta = 0;
    }
    public ProductoVendido(int id, int idProducto, int stock, int idVenta)
    {
        Id = id;
        IdProducto = idProducto;
        Stock = stock;
        IdVenta = idVenta;
    }

    public int Id { get => _id; set => _id = value; }
    public int IdProducto { get => _idProducto; set => _idProducto = value; }
    public int Stock { get => _stock; set => _stock = value; }
    public int IdVenta { get => _idVenta; set => _idVenta = value; }

    public override string ToString()
    {
        return "Id = " + Id +
            "\nIdProducto = " + IdProducto +
            "\nStock = " + Stock +
            "\nIdVenta = " + IdVenta;
    }
}