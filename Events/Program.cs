using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma Sala com 3 assentos
            var sala = new Sala(3);
            // Delegando SalaEsgotadaEvent para SalaEsgotada
            sala.SalaEsgotadaEvent += OnSalaEsgotada;

            // Resenvando os assentos
            sala.ResevaAssento();
            sala.ResevaAssento();
            sala.ResevaAssento();
            
            sala.ResevaAssento();
            sala.ResevaAssento();

        }

        // Delegando o Evento
        static void OnSalaEsgotada(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada!");
        }
    }

    public class Sala
    {
        //Os construtores são tipos especiais de métodos usados ​​para 
        //criar e inicializar objetos. ... Dessa forma se você não definir 
        //nenhum construtor para a classe, o C# vai criar um construtor 
        //padrão que instancia o objeto e define valores padrão para os membros da classe.
        public Sala(int assentos)
        {
            Assentos = assentos;
            acentoEmUso = 0;
        }
        
        public int Assentos { get; set; }

        public int acentoEmUso = 0;

        public void ResevaAssento()
        {
            acentoEmUso++;
            if(acentoEmUso > (Assentos))
            {
                // Chamando o Evento AoSalaEsgotada
                // O argumento é (EventArgs.Empty), pq não há nenhum argumento a ser passado
                AoSalaEsgotada(EventArgs.Empty);
            }else
            {
                Console.WriteLine("Assento reservado");
            }
        }

        // Definição do Evento > Os Eventos são apenas uma assinatura
        // Esse evento vai acontecer sempre que a sala estiver completa

        public event EventHandler SalaEsgotadaEvent;

        // Execução do Evento > Manipulador do evento
        // virtual pois os eventos não possui retorno
        // Gerlamente é usado Ao + o Nome do evento (AoSalaEsgotada)
        // Podemos Receber argumentos (EventArgs e)
        protected virtual void AoSalaEsgotada(EventArgs e)
        {
            // 
            EventHandler handler = SalaEsgotadaEvent;
            // Envocando o Evento
            // Boa pratica colocar o ?, pois o evento pode vim nulo
            // Toda vez que vc chama o Invoke vai se solicitado os arquimentos.
            // "this" é o proprio objeto, "e" é o proprio argumento
            handler?.Invoke(this, e);
        }

    }
}
