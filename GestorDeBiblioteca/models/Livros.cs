using System.Dynamic;
using System.Reflection.Metadata;

namespace GestorDeBiblioteca.models
{
    public class Livro
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string Genero { get; set; }
        public int NumeroDePaginas { get; set; }
        public bool Disponivel { get; private set; }
        public Cliente ClienteNovo { get; set; }

        public Livro(int id, string titulo, string autor)
        {
            ID = id;
            Titulo = titulo;
            Autor = autor;
            Disponivel = false;
            ClienteNovo = null;
        }
    }
}