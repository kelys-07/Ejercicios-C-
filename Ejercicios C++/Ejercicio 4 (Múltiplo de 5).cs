using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, ingresa un número: ");
        string input = Console.ReadLine();
        int numero;

        if (int.TryParse(input, out numero))
        {
            // Usando if-else
            if (numero % 5 == 0)
            {
                Console.WriteLine("El número es múltiplo de 5 (usando if-else).");
            }
            else
            {
                Console.WriteLine("El número no es múltiplo de 5 (usando if-else).");
            }

            // Usando switch
            switch (numero % 5)
            {
                case 0:
                    Console.WriteLine("El número es múltiplo de 5 (usando switch).");
                    break;
                default:
                    Console.WriteLine("El número no es múltiplo de 5 (usando switch).");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
        }
    }
}