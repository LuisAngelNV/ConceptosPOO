using ConceptosPOO;
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
