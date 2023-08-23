namespace PedidosYaBlue
{
    class DronManager
    {
        private List<Repartidor> _drones = new List<Repartidor>();
        private RepartidorFactory _factory;

        public DronManager(RepartidorFactory factory)
        {
            _factory = factory;
        }

        public void AgregarDron()
        {
            _drones.Add(_factory.CrearRepartidor());
            Console.WriteLine("Dron agregado");
        }

        public void MostrarDrones()
        {
            Console.WriteLine("Drones disponibles:");
            foreach (var dron in _drones)
            {
                Console.WriteLine(dron.GetType().Name);
            }
        }
    }
}
