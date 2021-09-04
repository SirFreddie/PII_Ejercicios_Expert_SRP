using System;
using System.Collections;

namespace SRP
{
    public class Biblioteca
    {
        // Array con los sectores de la biblioteca.
        private ArrayList sectores = new ArrayList();

        public string Nombre { get ; }

        public Biblioteca(String nombre)
        {
            this.Nombre = nombre;

            Console.WriteLine($"Biblioteca: {nombre} creada...");
        }

        // Metodo para agregar un sector a la biblioteca.
        public void AgregarSector(Sector sector)
        {
            this.sectores.Add(sector);
        }
    }
}
