namespace PedidosYaBlue
{
    class DronRepartidorFactory : RepartidorFactory
    {
        public override Repartidor CrearRepartidor(int id)
        {
            return new DronRepartidor(id);
        }
    }
}
