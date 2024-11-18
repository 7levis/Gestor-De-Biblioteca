using GestorDeBiblioteca.models;

namespace GestorDeBiblioteca.services
{
    public class LivroService
    {
        private List<Livro> _livros = new List<Livro>();

        public void AdicionarLivro()
        {
            Console.WriteLine("Digite o titulo do Livro: ");
            int id = int.Parse(Console.ReadLine());
            string titulo = Console.ReadLine();
            string autor = Console.ReadLine();
            Livro livro = new Livro(id,titulo,autor);
            _livros.Add(livro);
            Console.WriteLine($"{livro.ID}, {livro.Titulo}, {livro.Autor} ");
        }

        public void ListarLivros()
        {
            Console.WriteLine("Livros Listado(s): ");
            foreach (var livro in _livros)
            {
                Console.WriteLine($"Livro: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}");
            }
            
        }
    }
}