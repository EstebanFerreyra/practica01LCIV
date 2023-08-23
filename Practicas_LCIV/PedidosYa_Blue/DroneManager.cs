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

        public void AgregarDron(int id)
        {
            _drones.Add(_factory.CrearRepartidor(id));
            Console.WriteLine("Dron agregado");
        }

        public void BorrrarDron(int id)
        {
            Repartidor dron = _drones.FirstOrDefault(f => f.Id == id);
            _drones.Remove(dron);
        }

        public void MostrarDrones()
        {
            Console.WriteLine("Drones disponibles:");
            foreach (var dron in _drones)
            {
                Console.WriteLine($"{dron.GetType().Name} y su id es {dron.Id}");
            }
        }
    }
}
