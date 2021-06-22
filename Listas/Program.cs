using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a Lista de Pagamentos
            var pagamentos = new List<Pagamento>();
            
            // Inserido 5 ids na lista
            for(int item = 0; item < 5; item++)
            {
                pagamentos.Add(new Pagamento(item));
                Console.WriteLine(pagamentos[item].Id);
            }
            Console.WriteLine("");
            // Retornando oas pagamentos igual a 3
            // Where ele traz uma lista
            //var pagamento_w = pagamentos.Where(x=>x.Id ==3);
            //Console.WriteLine(pagamento_w[].Id);
            Console.WriteLine("");
            // Retornando oas pagamentos igual a 3
            // First retorna um unico item
            var pagamento_f = pagamentos.First(x=>x.Id ==3);
            Console.WriteLine(pagamento_f.Id);

            Console.WriteLine("");
            // Removendo o pagamento 3
            pagamentos.Remove(pagamento_f);

            Console.WriteLine("");
            // VPrintando todos os itens da lista
            foreach(var itemLista in pagamentos)
            {
                Console.WriteLine(itemLista.Id);
            }

            // Verificando se exite um pagamento
            Console.WriteLine("existe o id 3");
            var existe = pagamentos.Any(x=> x.Id == 3);
            Console.WriteLine(existe);
            
            // Verificando se exite um pagamento
            Console.WriteLine("existe o id 2");
            var existe_ = pagamentos.Any(x=> x.Id == 2);
            Console.WriteLine(existe_);

            // contando
            Console.WriteLine("contando quantidade do id 2");
            var existe_q = pagamentos.Count(x=> x.Id == 2);
            Console.WriteLine(existe_q);


            Console.WriteLine("Limpando a lista");
            // Limpando a Lista
            pagamentos.Clear();

            // VPrintando todos os itens da lista
            foreach(var itemLista in pagamentos)
            {
                Console.WriteLine(itemLista.Id);
            }

        }
    

        public class Pagamento
        {
            public int Id { get; set; }

            public Pagamento(int id)
            {
                Id = id;
            }
        }
    }
}
