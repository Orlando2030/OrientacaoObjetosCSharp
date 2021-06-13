using System;

namespace OrientacaoObjetosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.numeroBoleto = "00000000011111111111222222222222333" ;
            pagamentoBoleto.vencimento = DateTime.Now;

            var pagamentoCartao = new PagamentoCartao();
            pagamentoCartao.Pagar();
            pagamentoCartao.numeroCartao = "0000111122223333";
            pagamentoCartao.vencimento = DateTime.Now;

            Console.WriteLine("Aperte enter para sair");
            var tecla = Console.ReadLine();

            if(tecla != null) 
            System.Environment.Exit(0);
        }

        //Classe Pai
        class Pagameto
        {
            public DateTime vencimento;
            public virtual void Pagar()
            {
                Console.WriteLine("Pagamento com vencimento " + vencimento + " Efetuado");
            }

            public override string ToString()
            {
                return vencimento.ToString("dd/mm/yy") ;
            }

        }

        //Classe Filha
        class PagamentoBoleto: Pagameto
        {
            public string numeroBoleto;

            public override void Pagar()
            {
                //Regra boleto
                Console.WriteLine("Pagamento com vencimento " + vencimento + " Efetuado / Boleto");
            }
        }

        //Classe Filha
        class PagamentoCartao: Pagameto
        {
            public string numeroCartao;
            public override void Pagar()
            {
                //Regra Cartão
                Console.WriteLine("Pagamento com vencimento " + vencimento + " Efetuado / Cartão");
            }
        }

    }
}
