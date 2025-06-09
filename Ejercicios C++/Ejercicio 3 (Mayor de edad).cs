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
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad (usando if-else).");
            }
            else
            {
                Console.WriteLine("Eres menor de edad (usando if-else).");
            }

            // Usando switch (evaluando con una variable)
            int esMayor = edad >= 18 ? 1 : 0;

            switch (esMayor)
            {
                case 1:
                    Console.WriteLine("Eres mayor de edad (usando switch).");
                    break;
                case 0:
                    Console.WriteLine("Eres menor de edad (usando switch).");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa una edad válida.");
        }
    }
}