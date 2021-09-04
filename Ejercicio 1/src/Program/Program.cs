using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca("Biblioteca UCU");
            Sector sectorA = new Sector("A");
            Sector sectorB = new Sector("B");
            
            Estanteria estanteria7 = new Estanteria("7");
            Estanteria estanteria6 = new Estanteria("6");

            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");

            biblioteca.AgregarSector(sectorA);
            biblioteca.AgregarSector(sectorB);

            biblioteca.AgregarEstanteriaEnSector(sectorA, estanteria7);
            biblioteca.AgregarEstanteriaEnSector(sectorB, estanteria6);

            biblioteca.AlmacenarLibroEnEstanteria(estanteria7, libro1);
            biblioteca.AlmacenarLibroEnEstanteria(estanteria6, libro2);
        }
    }
}
