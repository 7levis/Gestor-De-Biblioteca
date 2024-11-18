using System.Dynamic;
using System.Reflection.Metadata;

namespace GestorDeBiblioteca
{
    public class Livro
    {
        public int ID {get; set; }
        public string Titulo{get; set; }
        public string Autor {get; set; }
        public int Ano {get; set; }
        public string Genero {get; set; }
        public int NumeroDePaginas {get; set; }
        public bool Disponivel {get; private set; }
        public Cliente ClienteNovo {get; set; }

        public Livro(int id, string titulo, string autor)
        {
            ID = id;
            Titulo = titulo;
            Autor = autor;
            Disponivel = false;
            ClienteNovo = null;
        }

        public bool EmprestarLivro(Cliente cliente)
        {
            if (Disponivel)
            {
                Console.WriteLine($"O livro'{Titulo}' já está emprestado a {ClienteNovo.Nome}.");
            }
            else
            {
                Disponivel = true;
                ClienteNovo = cliente;
                Console.WriteLine($"O livro '{Titulo}' foi emprestado a {cliente.Nome}, ID: {cliente.ID}.");
                return true;
            }
        }

        public bool DevolverLivro()
        {
            if (!Disponivel)
            {
                Console.WriteLine($"O livro '{Titulo}' não está emprestado!");
                return false;
            }
            else
            {
                Console.WriteLine($"O livro '{Titulo}' foi devolvido por {ClienteNovo.Nome} (ID: {ClienteNovo.ID}).");
                Disponivel = false;
                ClienteNovo = null;
                return true;
            }
        }
    }

}