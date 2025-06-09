using System;

class LeapYearChecker
{
    static void Main()
    {
        Console.WriteLine("Ingrese un año:");

        string input = Console.ReadLine();
        if (!int.TryParse(input, out int year))
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
            return;
        }

        // Variable para determinar si es bisiesto
        bool isLeapYear = false;

        // Determinar si el año es bisiesto usando if-else
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    isLeapYear = true; // Divisible por 400
                }
            }
            else
            {
                isLeapYear = true; // Divisible por 4 pero no por 100
            }
        }

        // Usar switch para mostrar el resultado
        switch (isLeapYear)
        {
            case true:
                Console.WriteLine($"{year} es un año bisiesto.");
                break;
            case false:
                Console.WriteLine($"{year} no es un año bisiesto.");
                break;
        }
    }
}
