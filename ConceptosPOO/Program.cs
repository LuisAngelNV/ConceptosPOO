using ConceptosPOO;

//Instanciar un objeto de la clase Auto
Auto miAuto = new Auto();
miAuto.MostrarInfo();// Asignar valores a los atributos del objeto
// Usamos el Setter para asignar un valor
miAuto.SetMarca("Toyota");
miAuto.SetModelo("Corolla");
miAuto.SetAño(2020);

// Usamos el Getter para obtener el valor
Console.WriteLine("Marca: " + miAuto.GetMarca());
Console.WriteLine("Modelo: " + miAuto.GetModelo());
Console.WriteLine("Año: " + miAuto.GetAño());

// Mostrar la información del auto
miAuto.MostrarInfo();
