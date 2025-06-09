using System;

class SalaryTaxCalculator
{
    static void Main()
    {
        Console.WriteLine("Ingrese su salario mensual:");

        string input = Console.ReadLine();
        if (!decimal.TryParse(input, out decimal salario))
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
            return;
        }

        if (salario < 0)
        {
            Console.WriteLine("El salario no puede ser negativo.");
            return;
        }

        decimal tasaImpuesto = 0m;

        // Determinar la tasa de impuesto usando if-else
        if (salario < 10000m)
        {
            tasaImpuesto = 0m;
        }
        else if (salario >= 10000m && salario <= 30000m)
        {
            tasaImpuesto = 0.10m;
        }
        else // salario > 30000
        {
            tasaImpuesto = 0.20m;
        }

        // Usar switch para mostrar mensaje basado en la tasa de impuesto
        switch (tasaImpuesto)
        {
            case 0m:
                Console.WriteLine("Su salario está exento de impuestos (0%).");
                break;
            case 0.10m:
                Console.WriteLine("Se aplica un 10% de impuesto a su salario.");
                break;
            case 0.20m:
                Console.WriteLine("Se aplica un 20% de impuesto a su salario.");
                break;
            default:
                Console.WriteLine("No se pudo determinar la tasa de impuesto.");
                break;
        }

        decimal impuesto = salario * tasaImpuesto;
        decimal salarioNeto = salario - impuesto;

        Console.WriteLine($"Salario bruto: {salario:C2}");
        Console.WriteLine($"Impuesto a pagar: {impuesto:C2}");
        Console.WriteLine($"Salario neto después de impuestos: {salarioNeto:C2}");
    }
}

