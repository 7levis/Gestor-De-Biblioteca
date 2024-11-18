using System;
using GestorDeBiblioteca.services;

namespace GestorDeBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            LivroService livroService = new LivroService();
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nSistema de Biblioteca");
                Console.WriteLine("\n1. Adicionar Livro.");
                Console.WriteLine("2. Listar Livros.");
                Console.WriteLine("3. Emprestar Livro.");
                Console.WriteLine("4. Devolver Livro.");
                Console.WriteLine("5. Cadastrar Cliente.");
                Console.WriteLine("0. Sair.");

                Console.WriteLine("Digite uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        livroService.AdicionarLivro();
                        break;
                    case 2:
                        livroService.ListarLivros();
                        break;
                    case 3:
                        //  EmprestarLivro();
                    case 4:
                        //  DevolverLivro();
                    case 5:
                        //   cliente.CadastrarCliente();
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                }

            }
        }
    }
}