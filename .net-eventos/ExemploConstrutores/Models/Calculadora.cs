namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        // Delegate
        public delegate void DelegateCalculadora();

        // Evento
        public static event DelegateCalculadora EventoCalculadora; // Calculadora tem um evento que outros objetos podem se increver nesse evento

        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null) // Se tive inscritos
            {
                System.Console.WriteLine($"Adição: {x + y}"); // Realizar a adição
                EventoCalculadora(); // Executar o evento
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito!");
            }
        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtrair: {x - y}");
        }
    }
}