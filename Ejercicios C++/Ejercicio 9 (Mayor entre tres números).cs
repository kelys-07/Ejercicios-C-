using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, ingresa el primer número: ");
        string input1 = Console.ReadLine();
        Console.Write("Por favor, ingresa el segundo número: ");
        string input2 = Console.ReadLine();
        Console.Write("Por favor, ingresa el tercer número: ");
        string input3 = Console.ReadLine();

        int numero1, numero2, numero3;

        if (int.TryParse(input1, out numero1) && int.TryParse(input2, out numero2) && int.TryParse(input3, out numero3))
        {
            // Usando if-else
            if (numero1 >= numero2 && numero1 >= numero3)
            {
                Console.WriteLine($"El número mayor es: {numero1} (usando if-else).");
            }
            else if (numero2 >= numero1 && numero2 >= numero3)
            {
                Console.WriteLine($"El número mayor es: {numero2} (usando if-else).");
            }
            else
            {
                Console.WriteLine($"El número mayor es: {numero3} (usando if-else).");
            }

            // Usando switch
            switch (numero1.CompareTo(numero2))
            {
                case 1: // numero1 es mayor que numero2
                    switch (numero1.CompareTo(numero3))
                    {
                        case 1:
                            Console.WriteLine($"El número mayor es: {numero1} (usando switch).");
                            break;
                        case 0:
                            Console.WriteLine($"El número mayor es: {numero1} (usando switch, es igual a {numero3}).");
                            break;
                        case -1:
                            Console.WriteLine($"El número mayor es: {numero3} (usando switch).");
                            break;
                    }
                    break;
                case -1: // numero1 es menor que numero2
                    switch (numero2.CompareTo(numero3))
                    {
                        case 1:
                            Console.WriteLine($"El número mayor es: {numero2} (usando switch).");
                            break;
                        case 0:
                            Console.WriteLine($"El número mayor es: {numero2} (usando switch, es igual a {numero3}).");
                            break;
                        case -1:
                            Console.WriteLine($"El número mayor es: {numero3} (usando switch).");
                            break;
                    }
                    break;
                case 0: // numero1 es igual a numero2
                    switch (numero1.CompareTo(numero3))
                    {
                        case 1:
                            Console.WriteLine($"El número mayor es: {numero1} (usando switch, es igual a {numero2}).");
                            break;
                        case 0:
                            Console.WriteLine($"Los números son iguales: {numero1}, {numero2}, {numero3} (usando switch).");
                            break;
                        case -1:
                            Console.WriteLine($"El número mayor es: {numero3} (usando switch).");
                            break;
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa números válidos.");
        }
    }
}