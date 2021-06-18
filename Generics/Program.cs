using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instaniando Pessoa, Pagamento e Assinatura
            var pessoa = new Pessoa();
            var pagamento = new Pagamento();
            var assinatura = new Assinatura();

            // Instanciando o DataContext, nesse casso ele espara os Tipo 
            // no caso <Pessoa, Pagamento, Assinatura>
            var context = new DataContext<Pessoa, Pagamento, Assinatura>();
            context.Salvar(pessoa);
            context.Salvar(pagamento);
            context.Salvar(assinatura);
        }
    }

    // Essa classe esta definida como generica <>
    // Esses tipos genenricos consguimos definir o tipo de entrada <P>
    // Pode ter um <P> ou <P, Pa, A>
    public class DataContext<P, Pa, A>
    // Posso 
    where P : Pessoa
    where Pa: Pagamento
    where A : Assinatura
    {
        // No metodo vc tem que passar o 
        public void Salvar(P entiny)
        {
            Console.WriteLine("Pessoa");
        }

        public void Salvar(Pa entiny)
        {
            Console.WriteLine("Pagamento");
        }

        public void Salvar(A entiny)
        {
            Console.WriteLine("Assinatura");
        }

    }
    public class Pessoa
    {}

    public class Pagamento
    {}

    public class Assinatura
    {}
}
