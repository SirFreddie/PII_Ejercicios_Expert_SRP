using System;

namespace SRP
{
    public class Libro
    {
        /*
        Los datos a conocer del libro deberian ser:
        - Titulo
        - Autor
        - Codigo
        */

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }

        // El sector y el estante no deberian ser datos que el libro pueda proveer ni conocer.
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        /*
        Considero que tanto los sectores como los estantes no deberian ser algo 
        a ser alamacenado en esta clase.
        Crearia una clase para el sector y otra para cada una de las estanterias.
        La biblioteca estaria compuesta de instancias de sectores, cada instancia de sector
        estaria compuesta por instancias de estanterias y cada estanteria estaria compuesta 
        por instancias de libros.
        */
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
