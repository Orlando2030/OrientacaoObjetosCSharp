using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando obsjeto
            var pagamento = new Pagamento();
            // Fechando intancia, mas essa implementação depende de ser colocada pelo programador
            pagamento.Dispose();

            // Existe uma outra forma de Instanciar um objeto e o mesmo seja fechado automaticamente
            // Mas só é possivel pq na classe Pagamento implementamos a interface IDisposable
            //using( var pagamento = new Pagamento())
            //{}
        }

        public class Pagamento : IDisposable 
        {
            // Construtor é sempre iniciado ao intanciar a classe
            public Pagamento()
            {
                Console.WriteLine("Iniciando o Pagamento .....");
            }

            // Esse metodo é implentado apos herda a interfa IDisposable
            // Ele é responsavel por destruir a classe, fechar conexoes etc

            public void Dispose()
            {
                Console.WriteLine("Fechando o Pagamento .....");
            }
        }
    }
}
