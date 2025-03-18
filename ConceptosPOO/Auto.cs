using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class Auto
    { // Atributos privados
        private string marca;
        private string modelo;
        private int año;

        // Método Setter (Asigna un valor al atributo)
        public void SetMarca(string nuevaMarca)
        {
            marca = nuevaMarca;
        }
        public void SetModelo(string nuevoModelo)
        {
            modelo = nuevoModelo;
        }
        public void SetAño(int nuevoAño)
        {
            año = nuevoAño;
        }

        // Método Getter (Obtiene el valor del atributo)
        public string GetMarca()
        {
            return marca;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public int GetAño()
        {
            return año;
        }
                
        // Método para mostrar la información del auto
        public void MostrarInfo()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Año: " + año);
        }
    }
}
