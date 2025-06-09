using System;

class DiscountCalculator
{
    static void Main()
    {
        Console.WriteLine("Ingrese el precio del producto:");

        string input = Console.ReadLine();
        if (!decimal.TryParse(input, out decimal price) || price < 0)
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número válido mayor o igual a 0.");
            return;
        }

        // Variable para almacenar el porcentaje de descuento
        decimal discountPercentage = 0m;

        // Determinar el porcentaje de descuento usando if-else
        if (price < 50)
        {
            discountPercentage = 0m; // Sin descuento
        }
        else if (price >= 50 && price <= 100)
        {
            discountPercentage = 0.05m; // 5% de descuento
        }
        else // price > 100
        {
            discountPercentage = 0.10m; // 10% de descuento
        }

        // Calcular el descuento y el precio final
        decimal discountAmount = price * discountPercentage;
        decimal finalPrice = price - discountAmount;

        // Usar switch para mostrar el resultado
        switch (discountPercentage)
        {
            case 0m:
                Console.WriteLine("No se aplica descuento.");
                break;
            case 0.05m:
                Console.WriteLine("Se aplica un descuento del 5%.");
                break;
            case 0.10m:
                Console.WriteLine("Se aplica un descuento del 10%.");
                break;
            default:
                Console.WriteLine("Descuento desconocido.");
                break;
        }

        // Mostrar el precio final
        Console.WriteLine($"Precio original: {price:C2}");
        Console.WriteLine($"Descuento aplicado: {discountAmount:C2}");
        Console.WriteLine($"Precio final: {finalPrice:C2}");
    }
}
