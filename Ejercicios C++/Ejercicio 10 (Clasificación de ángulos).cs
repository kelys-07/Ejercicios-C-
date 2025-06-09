using System;

class AngleClassification
{
    static void Main()
    {
        Console.WriteLine("Ingrese el valor de un ángulo en grados (0 a 180):");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out int angle))
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
            return;
        }

        // Validar que el ángulo esté en el rango correcto usando if-else
        if (angle < 0 || angle > 180)
        {
            Console.WriteLine("El ángulo debe estar entre 0 y 180 grados.");
            return;
        }

        // Categorizar el ángulo con if-else para determinar la clave para el switch
        string categoryKey;
        if (angle < 90)
        {
            categoryKey = "agudo";
        }
        else if (angle == 90)
        {
            categoryKey = "recto";
        }
        else if (angle > 90 && angle < 180)
        {
            categoryKey = "obtuso";
        }
        else // angle == 180
        {
            categoryKey = "llano";
        }

        // Clasificar usando switch con la categoría obtenida
        switch (categoryKey)
        {
            case "agudo":
                Console.WriteLine($"El ángulo de {angle}° es agudo (menor que 90°).");
                break;
            case "recto":
                Console.WriteLine($"El ángulo de {angle}° es recto (igual a 90°).");
                break;
            case "obtuso":
                Console.WriteLine($"El ángulo de {angle}° es obtuso (mayor que 90° y menor que 180°).");
                break;
            case "llano":
                Console.WriteLine($"El ángulo de {angle}° es llano (igual a 180°).");
                break;
            default:
                Console.WriteLine("Clasificación desconocida.");
                break;
        }
    }
}

