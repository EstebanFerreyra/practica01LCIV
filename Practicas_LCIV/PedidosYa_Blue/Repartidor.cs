namespace PedidosYaBlue
{
    abstract class Repartidor
    {
        public abstract int Id { get; set; }
        public abstract void EntregarPedido();
    }
}
