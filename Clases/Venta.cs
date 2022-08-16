public class Venta
{
    private int _id;
    private string _comentarios;

    public Venta()
    {
        Id = 0;
        Comentarios = "";
    }
    public Venta(int id, string comentarios)
    {
        Id = id;
        Comentarios = comentarios;
    }

    public int Id { get => _id; set => _id = value; }
    public string Comentarios { get => _comentarios; set => _comentarios = value; }

    public override string ToString()
    {
        return "Id = " + Id +
            "\nComentarios = " + Comentarios;
    }
}
