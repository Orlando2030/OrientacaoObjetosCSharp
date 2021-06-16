using System;

namespace ClasseSeladas
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        // A classe selada não é possivel estender a classe
        // Não é possivel herda dessa clase
        public sealed class Pagamento 
        {
            public string numeroPagamento { get; set; }
        }

        // Como comentado anteriormente não é possivel a classe PagamentoBoleto
        // herda da classe Pagamento pela classe de pagamentos ser selada
        public class PagamentoBoleto : Pagamento
        {

        }
    }
}
