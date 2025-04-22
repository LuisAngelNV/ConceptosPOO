using ConceptosPOO;
using ConceptosPOO.DispositivosElectronicos;
using ConceptosPOO.InterfaceRetoUno;
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
Perro perro = new Perro();
perro.HacerSonido();

Gato gato = new Gato();
gato.HacerSonido();


// Mejora
List<Animal> animales = new List<Animal>();

animales.Add(new Perro());
animales.Add(new Gato());
animales.Add(new Perro());

foreach (Animal animal in animales)
{
    animal.HacerSonido();
}
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
IApagable refri = new Refrigerador("LG");
refri.Apagar(); // ✅ Ahora puedes acceder a Apagar()

IEncendible tele = new Televisor("Samsung");
tele.Encender(); // ✅ Puedes usar Encender()

// O mejor:
Refrigerador r = new Refrigerador("LG");
r.Encender();
r.Apagar();


Alerta alerta1 = new Alerta(new EmailNotificador());
Alerta alerta2 = new Alerta(new SmsNotificador());
Alerta alerta3 = new Alerta(new PushNotificador());

alerta1.EnviarAlerta(); // Usa Email
alerta2.EnviarAlerta(); // Usa SMS
alerta3.EnviarAlerta(); // Usa SMS

