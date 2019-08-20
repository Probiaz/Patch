using System;

namespace kokko
{
    class Program
    {
        static void Main(string[] args)
        {
            int z, x, y;
            Console.WriteLine("Imprime los numeros del x hasta el y de -1");
            Console.WriteLine("Donde arrancamos el ciclo(mayor): ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Donde arrancamos el ciclo(menor): ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto: ");
            z = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i <= y; i -= z)
            {
                Console.WriteLine("i = " + i);
            }
        }
    }
}
