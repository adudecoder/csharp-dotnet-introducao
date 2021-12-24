namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;

            Calculadora.EventoCalculadora += EventHandler; // Evento da Calculadora
        }

        public void Somar()
        {
            Calculadora.Somar(X, Y); // Chamando o metodo somar
        }

        public void EventHandler() // Increvendo o metodo Handler no Evento da Calculadora
        {
            System.Console.WriteLine("Metodo executado!");
        }
    }
}