using System;
using System.Collections;

namespace SRP
{
    public class Sector
    {
        // Array con las estanterias del sector.
        private ArrayList estanterias = new ArrayList();

        public string Nombre { get ; }

        public Sector(String nombre)
        {
            this.Nombre = nombre;

            Console.WriteLine($"Sector: {nombre} creado...");
        }

        // Metodo para agregar una estanteria a un sector.
        public void AgregarEstanteria(Estanteria estanteria)
        {
            this.estanterias.Add(estanteria);
        }
    }
}
