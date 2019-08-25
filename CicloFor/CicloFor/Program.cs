using System;

namespace kokko
{
    class Program
    {
        static void Main(string[] args)
        {
            int z, x, y;
            Console.WriteLine("Imprime los numeros de x a y o viceversa segun cual es mayor y menor");
            Console.WriteLine("Donde arrancamos el ciclo: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Donde terminamos el ciclo: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto: ");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                for (int i = x; i > y; i -= z)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            else if(x < y)
            {
                for (int i = x; i < y; i += z)
                {
                    Console.WriteLine("i = " + i);
                }
            }
        }
    }
}
