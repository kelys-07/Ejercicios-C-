using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, ingresa un número del 1 al 7: ");
        string input = Console.ReadLine();
        int dia;

        if (int.TryParse(input, out dia) && dia >= 1 && dia <= 7)
        {
            // Usando if-else
            if (dia == 1)
            {
                Console.WriteLine("Lunes (usando if-else).");
            }
            else if (dia == 2)
            {
                Console.WriteLine("Martes (usando if-else).");
            }
            else if (dia == 3)
            {
                Console.WriteLine("Miércoles (usando if-else).");
            }
            else if (dia == 4)
            {
                Console.WriteLine("Jueves (usando if-else).");
            }
            else if (dia == 5)
            {
                Console.WriteLine("Viernes (usando if-else).");
            }
            else if (dia == 6)
            {
                Console.WriteLine("Sábado (usando if-else).");
            }
            else // dia == 7
            {
                Console.WriteLine("Domingo (usando if-else).");
            }

            // Usando switch
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes (usando switch).");
                    break;
                case 2:
                    Console.WriteLine("Martes (usando switch).");
                    break;
                case 3:
                    Console.WriteLine("Miércoles (usando switch).");
                    break;
                case 4:
                    Console.WriteLine("Jueves (usando switch).");
                    break;
                case 5:
                    Console.WriteLine("Viernes (usando switch).");
                    break;
                case 6:
                    Console.WriteLine("Sábado (usando switch).");
                    break;
                case 7:
                    Console.WriteLine("Domingo (usando switch).");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido entre 1 y 7.");
        }
    }
}