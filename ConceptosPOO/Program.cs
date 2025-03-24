using ConceptosPOO;
using ConceptosPOO.RetoDos;
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



Gerente gerente = new Gerente("Juan", 35, 50000, "Gerente", "Finanzas");
Desarrollador desarrollador = new Desarrollador("Pedro", 28, 40000, "Desarrollador", "C#");

gerente.MostrarInfo();
desarrollador.MostrarInfo();


//RetoDos

List<Figura> figuras = new List<Figura>();

figuras.Add(new Cuadrado() { Lado = 5 });
figuras.Add(new Circulo() { radio = 5 });
figuras.Add(new Triangulo(5, 5));
figuras.Add(new Triangulo(5, 5, 5));

foreach (Figura figura in figuras)
{
    figura.MostrarInfo();
}
