using System;

namespace ClasseEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Não é necessario instaciar uma classe estatica
            Configuracoes.ConectionStrig = "/kjjkshdkjas/dsdasd";
            Console.WriteLine(Configuracoes.ConectionStrig);
        }


        // Toda a classe Estatica, possui poucas informações e são sempre 
        //as mesma informações carregada quando é iniciado o programa
        public static class Configuracoes
        {
            // As classe estaticas possui seus metodos estaticos
            public static string ConectionStrig { get; set; }
        }
    }
}
