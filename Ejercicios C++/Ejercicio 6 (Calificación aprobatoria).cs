using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, ingresa tu edad: ");
        string input = Console.ReadLine();
        int edad;

        if (int.TryParse(input, out edad) && edad >= 0)
        {
            // Usando if-else
            if (edad > 60)
            {
                Console.WriteLine("Aplicas para un descuento del 50% (usando if-else).");
            }
            else
            {
                Console.WriteLine("No aplicas para el descuento (usando if-else).");
            }

            // Usando switch
            switch (edad)
            {
                case int n when n > 60:
                    Console.WriteLine("Aplicas para un descuento del 50% (usando switch).");
                    break;
                default:
                    Console.WriteLine("No aplicas para el descuento (usando switch).");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa una edad válida.");
        }
    }
}