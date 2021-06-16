using System;

namespace UpcastDowncast
{
    class Program
    {
        static void Main(string[] args)
        {
            // Upcast - A classe filha tem todas as informações da classe Pai
           // var pessoa = new Pessoa();
           // pessoa = new PessoaFisica();
            //pessoa = new PessoaJuridica();

            // Downcast
            var pessoa = new Pessoa();
            var pessoaF = new PessoaFisica();
            var pessoaJ = new PessoaJuridica();

            // Conversão explicita > pessoaF = (PessoaFisica)pessoa
            // Converção implicita não funciona > pessoaF = pessoa
            pessoaF = (PessoaFisica)pessoa;
            
        }
        public class Pessoa
        {
            public string Nome { get; set; }
        }

        public class PessoaFisica : Pessoa
        {
            public string Cpf { get; set; }
        }

        public class PessoaJuridica : Pessoa
        {
            public string  Cnoj { get; set; }

        }
    }
}
