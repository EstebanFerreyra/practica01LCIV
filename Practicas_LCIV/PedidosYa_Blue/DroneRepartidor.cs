namespace PedidosYaBlue
{
    class DronRepartidor : Repartidor
    {
        public DronRepartidor(int _id)
        {
            Id = _id;
        }

        public override int Id { get; set; }

        public override void EntregarPedido()
        {
            Console.WriteLine("Entregando pedido con dron");
        }

    }
}
