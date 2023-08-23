using PedidosYaBlue;

RepartidorFactory dronFactory = new DronRepartidorFactory();
DronManager dronManager = new DronManager(dronFactory);

dronManager.AgregarDron();
dronManager.AgregarDron();

dronManager.MostrarDrones();