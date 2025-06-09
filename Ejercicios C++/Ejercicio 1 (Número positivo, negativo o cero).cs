using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, ingresa un número: ");
        string input = Console.ReadLine();
        double numero;

        // Intentar convertir la entrada a un número
        if (double.TryParse(input, out numero))
        {
            // Usando if-else
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }

            // Usando switch
            switch (Math.Sign(numero))
            {
                case 1:
                    Console.WriteLine("Usando switch: El número es positivo.");
                    break;
                case -1:
                    Console.WriteLine("Usando switch: El número es negativo.");
                    break;
                case 0:
                    Console.WriteLine("Usando switch: El número es cero.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
        }
    }
}