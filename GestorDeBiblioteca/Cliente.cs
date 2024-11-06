using System;
using System.Collections.Generic;
using System.Dynamic;

namespace GestorDeBiblioteca
{
    public class Cliente
    {
        public int ID {get; set; }
        public string Nome {get; set; }
        public string End {get; set;}
        public DateTime DataDeNascimento {get; set; }
        public string Email {get; set; }
        public string Tel {get; set; }

        public Cliente(int id, string nome, string end, DateTime dataDeNascimento, string email, string tel)
        {
            ID = id;
            Nome = nome;
            End = end;
            DataDeNascimento = dataDeNascimento;
            Email = email;
            Tel = tel;

        }
    }
}