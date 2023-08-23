namespace PedidosYaBlue
{
    class DronRepartidorFactory : RepartidorFactory
    {
        public override Repartidor CrearRepartidor()
        {
            return new DronRepartidor();
        }
    }
}
