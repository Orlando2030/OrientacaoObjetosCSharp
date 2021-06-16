using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            pagamento.PropriedadeBoleto = "Estanciando a Propriedade do partial Boleto";
            pagamento.PropriedadeCartao = "Estanciando a Propriedade do partial Cartão";

            Console.WriteLine(pagamento.PropriedadeBoleto);
            Console.WriteLine(pagamento.PropriedadeCartao);
            

        }
    }
}
