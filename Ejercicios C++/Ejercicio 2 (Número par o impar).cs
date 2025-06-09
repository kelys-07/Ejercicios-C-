using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, ingresa un número entero: ");
        string input = Console.ReadLine();
        int numero;

        if (int.TryParse(input, out numero))
        {
            // Usando if-else
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par (usando if-else).");
            }
            else
            {
                Console.WriteLine("El número es impar (usando if-else).");
            }

            // Usando switch
            switch (numero % 2)
            {
                case 0:
                    Console.WriteLine("El número es par (usando switch).");
                    break;
                case 1:
                case -1:
                    Console.WriteLine("El número es impar (usando switch).");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número entero válido.");
        }
    }
}
