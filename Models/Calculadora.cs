namespace Construtores_Propriedades_Delegates_e_Eventos_em_.NET.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();

        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y)
        {
            if(EventoCalculadora != null)
            {
            System.Console.WriteLine($"Adição : {x + y}");
            EventoCalculadora();
            Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito:");
            }
        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração : {x - y}");
            Console.ReadLine();

        }
    }
}