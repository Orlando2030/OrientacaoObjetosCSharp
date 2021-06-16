using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            pagamento.Pagar(100);
        }


        // Na classe Pagamento esta sendo implementada a Interface IPagamento
        // Diferente da herança a interface é obrigado a implementear as propriedade e os metodos
        // da interface
        public class Pagamento : IPagamento
        {
            public DateTime Vencimento { get;set; }

            public void Pagar(double valor)
            {
                Console.WriteLine("Pago o valor de "+ valor);
            }
        }

        // Interface = Contrato, define o que a classe Pagamento vai fazer
        // Mas não fala como será feito
        public interface IPagamento
        {
            DateTime Vencimento { get; set; }

            void Pagar(double valor);
        }
    }
}
