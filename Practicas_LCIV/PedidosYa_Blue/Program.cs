using PedidosYaBlue;

RepartidorFactory dronFactory = new DronRepartidorFactory();
DronManager dronManager = new DronManager(dronFactory);

dronManager.AgregarDron();
dronManager.AgregarDron();

dronManager.MostrarDrones();

// En este pequeño programa intentamos aplicar patrones de diseño como factory method y inyeccion de dependecias.

// Factory method lo aplicamos para la creacion de repartidores (en este caso tipo Drone), lo que en un futuro
// nos facilitaria la implementacion de otro tipo de repartidor, haciendo el codigo mas escalable y mantenible.

// Inyeccion de dependencias lo utilizamos para inyectar una RepartidorFactory en la clase DroneManager.
