using System;

namespace ComparandoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoalA = new Pessoa(1,"Nicolas Rocha de Oliveira");
            var pessoalB = new Pessoa(1,"Davi Rocha de Oliveira");

            Console.WriteLine(pessoalA == pessoalB);
            Console.WriteLine(pessoalA.Id == pessoalB.Id);
            Console.WriteLine(pessoalA.Nome == pessoalB.Nome);
        }

        public class Pessoa
        {
            public Pessoa(int id, string nome)
            {
                Id = id;
                Nome = nome;
            }

            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
