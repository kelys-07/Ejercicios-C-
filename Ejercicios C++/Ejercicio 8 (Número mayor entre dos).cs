using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, ingresa el primer número: ");
        string input1 = Console.ReadLine();
        Console.Write("Por favor, ingresa el segundo número: ");
        string input2 = Console.ReadLine();

        int numero1, numero2;

        if (int.TryParse(input1, out numero1) && int.TryParse(input2, out numero2))
        {
            // Usando if-else
            if (numero1 > numero2)
            {
                Console.WriteLine($"El número mayor es: {numero1} (usando if-else).");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine($"El número mayor es: {numero2} (usando if-else).");
            }
            else
            {
                Console.WriteLine("Los números son iguales (usando if-else).");
            }

            // Usando switch
            switch (numero1.CompareTo(numero2))
            {
                case 1:
                    Console.WriteLine($"El número mayor es: {numero1} (usando switch).");
                    break;
                case -1:
                    Console.WriteLine($"El número mayor es: {numero2} (usando switch).");
                    break;
                case 0:
                    Console.WriteLine("Los números son iguales (usando switch).");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa números válidos.");
        }
    }
}