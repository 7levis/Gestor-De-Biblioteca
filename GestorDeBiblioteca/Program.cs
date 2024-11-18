using System;

namespace GestorDeBiblioteca
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("\nSistema de Biblioteca");
            Console.WriteLine("\n1. Adicionar Livro.");
            Console.WriteLine("2. Listar Livros.");
            Console.WriteLine("3. Emprestar Livro.");
            Console.WriteLine("4. Devolver Livro.");
            Console.WriteLine("5. Sair.");
            
            Console.WriteLine("Digite uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarLivro();
                    break;
                case 2:
                    ListarLivros();
                    break;
                case 3:
                    EmpretarLivro();
                    break;
                case 4:
                    DevolverLivro();
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
            }

        }
    }
} 

