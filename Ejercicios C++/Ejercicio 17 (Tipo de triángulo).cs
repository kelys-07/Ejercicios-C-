using System;

class TriangleTypeChecker
{
    static void Main()
    {
        Console.WriteLine("Ingrese tres longitudes (separadas por espacios):");
        string input = Console.ReadLine();
        string[] parts = input.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length != 3)
        {
            Console.WriteLine("Debe ingresar exactamente tres longitudes.");
            return;
        }

        double[] sides = new double[3];
        for (int i = 0; i < 3; i++)
        {
            if (!double.TryParse(parts[i], out sides[i]) || sides[i] <= 0)
            {
                Console.WriteLine($"Entrada inválida en la posición {i + 1}: '{parts[i]}'. Debe ser un número positivo.");
                return;
            }
        }

        double a = sides[0], b = sides[1], c = sides[2];

        // Verificar que las longitudes formen un triángulo válido usando if-else
        if (!(a + b > c && a + c > b && b + c > a))
        {
            Console.WriteLine("Las longitudes no forman un triángulo válido.");
            return;
        }

        // Determinar el tipo de triángulo
        string triangleType;

        if (a == b && b == c)
        {
            triangleType = "Equilátero";
        }
        else if (a == b || b == c || a == c)
        {
            triangleType = "Isósceles";
        }
        else
        {
            triangleType = "Escaleno";
        }

        // Usar switch para mostrar el resultado
        switch (triangleType)
        {
            case "Equilátero":
                Console.WriteLine("El triángulo es equilátero (tres lados iguales).");
                break;
            case "Isósceles":
                Console.WriteLine("El triángulo es isósceles (dos lados iguales).");
                break;
            case "Escaleno":
                Console.WriteLine("El triángulo es escaleno (todos los lados diferentes).");
                break;
            default:
                Console.WriteLine("Tipo de triángulo desconocido.");
                break;
        }
    }
}
