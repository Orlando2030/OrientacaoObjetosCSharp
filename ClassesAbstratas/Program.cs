using System;

namespace ClassesAbstratas
{
 class Program
    {
        
        // Diferença entre Interface e Classe Abstrata
        // A classe Abstrata pode ter uma implementação que serve de basae para outas classes
        // A In=terface é um contrato que defini o que tem que ser feito
        static void Main(string[] args)
        {
            // clase abstrata não pode ser instanciada só herdada
            // como no exemplo a baixo quanto tentamos implementar a classe Pagamento,
            // temos erro
            //var pagamento = new Pagamento();
            //pagamento.Pagar(100);

            var pagamentoB = new PagamentoBoleto();
            pagamentoB.Pagar(100.00);

            var pagamentoC = new PagamentoCartao();
            pagamentoC.Pagar(200.00);            
        }


        // A classe pagamento está como abstrata, pq de fato ela não faz nada
        // Ela é a classe mae dos outros tipod de pagamento e não a a necessidade 
        // ser instanciada
        public abstract class Pagamento : IPagamento
        {
            public DateTime Vencimento { get;set; }

            // O virtal no metodo siginfica que o mesmo pode ser sobrescrito
            // quando implementedo nas classes fillhas
            public virtual void Pagar(double valor)
            {
                Console.WriteLine("Pago o valor de "+ valor);
            }
        }

        public class PagamentoBoleto : Pagamento
        {
            // Para o metodo ser sobrescrito da classe mae nas classes filhas
            // é necessario colocar o override
             public override void Pagar(double valor)
            {
                Console.WriteLine("Pago o valor de "+ valor);
            }

        }

        public class PagamentoCartao : Pagamento
        {
            // Para o metodo ser sobrescrito da classe mae nas classes filhas
            // é necessario colocar o override            
            public override void Pagar(double valor)
            {
                Console.WriteLine("Pago o valor de "+ valor);
            }

        }

        public interface IPagamento
        {
            DateTime Vencimento { get; set; }

            void Pagar(double valor);
        }
    }
}
