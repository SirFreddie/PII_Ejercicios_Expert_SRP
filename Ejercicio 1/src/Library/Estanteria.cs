using System;
using System.Collections;

namespace SRP
{
    public class Estanteria
    {
        // Array con los libros de la estanteria.
        private ArrayList libros = new ArrayList();

        public string Nombre { get ; }

        public Estanteria(String nombre)
        {
            this.Nombre = nombre;
        }

        // Metodo para agregar un libro a la estanteria.
        public void AlmacenarLibro(Libro libro)
        {
            this.libros.Add(libro);

            Console.WriteLine($"{libro.Titulo} almacenado!");
        }
    }
}
