using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculo = new Veiculo[2];

            veiculo[0] = new Automovel("Ferrari");
            veiculo[1] = new Aeronave("Lamborguini");

            MovimentarVeiculo(veiculo[0]);
            MovimentarVeiculo(veiculo[1]);

            Console.WriteLine("");

            PararVeiculo(veiculo[0]);
            PararVeiculo(veiculo[1]);

            Console.WriteLine("");

            //var automovel =  new Automovel("Vw");
            //MovimentarVeiculo(automovel);

            //Console.ReadKey();
        }
        
        public static void MovimentarVeiculo(Veiculo veiculo)
        {
            Console.WriteLine(veiculo.Tipo);
            veiculo.Mover();
        }

        public static void PararVeiculo(Veiculo veiculo)
        {
            Console.WriteLine(veiculo.Tipo);
            veiculo.Parar();
        }
    }
}
