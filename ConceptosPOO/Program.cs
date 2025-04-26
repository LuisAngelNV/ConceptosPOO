using ConceptosPOO;
using ConceptosPOO.ClasesAbstractas;
using ConceptosPOO.ClasesAbstractas.PruebaDos;
using ConceptosPOO.ClasesAbstractas.PruebaUno;
using ConceptosPOO.DispositivosElectronicos;
using ConceptosPOO.InterfaceRetoDos;
using ConceptosPOO.InterfacesRetoTres;

//using ConceptosPOO.InterfaceRetoUno;
using ConceptosPOO.Intrefaces;
using ConceptosPOO.Intrefaces.Notificaciones;
using ConceptosPOO.RetoDos;
using ConceptosPOO.RetoTres;
using ConceptosPOO.RetoUno;
// Instanciación de la clase Auto o conocida como objeto
Auto miAuto = new Auto();
miAuto.AsignarMarca("Toyota");
miAuto.NumeroPuertas = 4;
miAuto.MostrarMarca();
miAuto.CambiarMarca("Nissan");


// Instanciación de la clase Auto o conocida como objeto
Moto miMoto = new Moto();
miMoto.AsignarMarca("Yamaha");
//miMoto.Modelo = "YZF-R3";
miMoto.TieneCasco = true;
miMoto.MostrarMarca();


#region Retos de programación
// Reto uno
Gerente gerente = new Gerente("Juan", 35, 50000, "Gerente", "Finanzas");
Desarrollador desarrollador = new Desarrollador("Pedro", 28, 40000, "Desarrollador", "C#");

gerente.MostrarInfo();
desarrollador.MostrarInfo();

//Reto Dos

List<Figura> figuras = new List<Figura>();

figuras.Add(new Cuadrado() { Lado = 5 });
figuras.Add(new Circulo() { radio = 5 });
figuras.Add(new Triangulo(5, 5));
figuras.Add(new Triangulo(5, 5, 5));

foreach (Figura figura in figuras)
{
    figura.MostrarInfo();
}


//Reto Tres
//Perro perro = new Perro();
//perro.HacerSonido();

//Gato gato = new Gato();
//gato.HacerSonido();


//// Mejora
//List<Animal> animales = new List<Animal>();

//animales.Add(new Perro());
//animales.Add(new Gato());
//animales.Add(new Perro());

//foreach (Animal animal in animales)
//{
//    animal.HacerSonido();
//}
#endregion

#region 'Implementar una inteface
IConducible vehiculo1 = new Auto();
IConducible vehiculo2 = new Moto();

vehiculo1.Conducir(); // Conduciendo un auto...
vehiculo2.Conducir(); // Conduciendo una moto...

Telefono miTelefono = new Telefono();

miTelefono.Llamar("555-1234");
miTelefono.Navegar("www.google.com");
miTelefono.TomarFoto();
#endregion

// Prueba 1. Interfaces y heredar
/* El error que se tiene aqui es de que solo funciona con IEncendible => Encender, ya que solo trae para encender y al querer llamar a apagar, este no exiete en este contexto
     solucion:

IEncendible encendible = new Refrigerador("LG");
IEncendible encendible1 = new Televisor("Samsung");


encendible.Encender();
encendible.Apagar();

encendible1.Encender();
encendible1.Apagar();

Crear una instanciación de Refrigerador o Television.
Solo Así funcionara

*/

// solución
//IApagable refri = new Refrigerador("LG");
//refri.Apagar(); // ✅ Ahora puedes acceder a Apagar()

//IEncendible tele = new Televisor("Samsung");
//tele.Encender(); // ✅ Puedes usar Encender()

//// O mejor:
//Refrigerador r = new Refrigerador("LG");
//r.Encender();
//r.Apagar();


//Alerta alerta1 = new Alerta(new EmailNotificador());
//Alerta alerta2 = new Alerta(new SmsNotificador());
//Alerta alerta3 = new Alerta(new PushNotificador());

//alerta1.EnviarAlerta(); // Usa Email
//alerta2.EnviarAlerta(); // Usa SMS
//alerta3.EnviarAlerta(); // Usa SMS


// Prueba 2. Polimorfismo Avanzado con Interfaces en C# 

// Usar el espacio de nombres completo para desambiguar
ConceptosPOO.InterfaceRetoDos.Alerta alerta1 = new ConceptosPOO.InterfaceRetoDos.Alerta(new ConceptosPOO.InterfaceRetoDos.EmailNotificador());
ConceptosPOO.InterfaceRetoDos.Alerta alerta2 = new ConceptosPOO.InterfaceRetoDos.Alerta(new ConceptosPOO.InterfaceRetoDos.SmsNotificador());
ConceptosPOO.InterfaceRetoDos.Alerta alerta3 = new ConceptosPOO.InterfaceRetoDos.Alerta(new ConceptosPOO.InterfaceRetoDos.PushNotificador());

alerta1.Enviar("¡Bienvenido al sistema!"); // Usa Email
alerta2.Enviar("¡Bienvenido al sistema!"); // Usa SMS
alerta3.Enviar("¡Bienvenido al sistema!"); // Usa Push


// Prueba 3. Interfaces y heredar
Checkout checkout = new Checkout(new PagoTarjeta());
Checkout checkout2 = new Checkout(new PagoPayPal());
Checkout checkout3 = new Checkout(new PagoCripto());

checkout.RealizarPago(150.50m); // Usa tarjeta de crédito
checkout2.RealizarPago(80.25m); // usa PayPal
checkout3.RealizarPago(0.015m); // Usa Criptomonedas

List<Checkout> checkouts = new List<Checkout>
{
    new Checkout(new PagoTarjeta()),
    new Checkout(new PagoPayPal()),
    new Checkout(new PagoCripto())
};

foreach (var pago in checkouts)
{
    pago.RealizarPago(100.00m);
}


CAAnimal miPerro = new ConceptosPOO.ClasesAbstractas.Perro();
miPerro.Nombre = "Max";
miPerro.Comer();       // de la clase base
miPerro.HacerSonido(); // de la clase hija


// Instanciación de la clase Gato o conocida como objeto
Persona persona = new Obrero("Martinez", 22);
Persona persona2 = new Programador("Lopez", 58);

persona.Presentarse();
persona.Trabajar();

persona2.Presentarse();
persona2.Trabajar();
((Programador)persona2).TrabajarDesdeCasa();
((Programador)persona2).HacerHorasExtra();




List<DispositivoInteligente> dispositivos = new List<DispositivoInteligente>
{
    new LamparaInteligente("Lampara"),
    new CafeteraInteligente("Cafetera"),
    new RobotAspiradora("Robot Aspiradora"),
};
foreach (var dispositivo in dispositivos)
{
    dispositivo.Encender();
    dispositivo.FuncionPrincipal();

    if (dispositivo is IConectividad conectividad)
    {
        conectividad.ConectarInternet();
    }

    if (dispositivo is ITemporizador temporizador)
    {
        temporizador.ProgramarTemporizador(30);
    }

    dispositivo.Apagar();
}

Console.WriteLine("____Robots Automaticos____");
// Instanciar clase robot
List<RobotAutonomo> robots = new List<RobotAutonomo>
{
   new RobotRescatista("RescateX"),
   new RobotAereo("Scout2000"),
   new RobotDeCombate("CombatOne")
};

foreach (var robot in robots)
{
    robot.Iniciar();
    robot.RealizarTarea();
    if (robot is IVolador volador)
    {
        volador.Volar();
    }
    if (robot is INadador nadador)
    {
        nadador.Nadar();
    }
    if (robot is IArtillero artillero)
    {
        artillero.Disparar();
    }
    robot.Detener();
}