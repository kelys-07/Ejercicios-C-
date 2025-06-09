using System;

class NumberSignClassification
{
    enum Classification
    {
        AllPositive,
        AllNegative,
        ContainsZero,
        Mixed
    }

    static void Main()
    {
        Console.WriteLine("Ingrese tres números enteros separados por espacios:");

        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Entrada vacía. Por favor, ingrese tres números.");
            return;
        }

        string[] parts = input.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length != 3)
        {
            Console.WriteLine("Debe ingresar exactamente tres números.");
            return;
        }

        int[] numbers = new int[3];
        for (int i = 0; i < 3; i++)
        {
            if (!int.TryParse(parts[i], out numbers[i]))
            {
                Console.WriteLine($"Entrada inválida en la posición {i + 1}: '{parts[i]}' no es un número entero válido.");
                return;
            }
        }

        // Count positives, negatives and zeros
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;

        foreach (int num in numbers)
        {
            if (num > 0)
                positiveCount++;
            else if (num < 0)
                negativeCount++;
            else
                zeroCount++;
        }

        Classification classification;

        // Determine classification using if-else
        if (zeroCount > 0)
        {
            classification = Classification.ContainsZero;
        }
        else if (positiveCount == 3)
        {
            classification = Classification.AllPositive;
        }
        else if (negativeCount == 3)
        {
            classification = Classification.AllNegative;
        }
        else
        {
            classification = Classification.Mixed;
        }

        // Output the result using switch statement
        switch (classification)
        {
            case Classification.AllPositive:
                Console.WriteLine("Los tres números son todos positivos.");
                break;

            case Classification.AllNegative:
                Console.WriteLine("Los tres números son todos negativos.");
                break;

            case Classification.ContainsZero:
                Console.WriteLine("Al menos uno de los números es cero.");
                break;

            case Classification.Mixed:
                Console.WriteLine("Los números son mixtos (mezcla de positivos y negativos).");
                break;

            default:
                Console.WriteLine("Clasificación desconocida.");
                break;
        }
    }
}


