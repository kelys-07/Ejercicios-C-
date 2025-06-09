using System;

class TriangleChecker
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

        // Variables para almacenar las longitudes
        long side1, side2, side3;

        // Validar la entrada y convertir a long
        if (!long.TryParse(parts[0], out side1) ||
            !long.TryParse(parts[1], out side2) ||
            !long.TryParse(parts[2], out side3))
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese números enteros válidos.");
            return;
        }

        // Determinar si pueden formar un triángulo usando if-else
        bool canFormTriangle = false;

        if (side1 + side2 > side3 &&
            side1 + side3 > side2 &&
            side2 + side3 > side1)
        {
            canFormTriangle = true;
        }

        // Usar switch para mostrar el resultado
        switch (canFormTriangle)
        {
            case true:
                Console.WriteLine("Las longitudes pueden formar un triángulo.");
                break;
            case false:
                Console.WriteLine("Las longitudes no pueden formar un triángulo.");
                break;
        }
    }
}
