using System;

class BMICalculator
{
    static void Main()
    {
        Console.WriteLine("Ingrese su peso en kilogramos (kg):");
        string weightInput = Console.ReadLine();
        if (!double.TryParse(weightInput, out double weight) || weight <= 0)
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un peso válido mayor que 0.");
            return;
        }

        Console.WriteLine("Ingrese su altura en metros (m):");
        string heightInput = Console.ReadLine();
        if (!double.TryParse(heightInput, out double height) || height <= 0)
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese una altura válida mayor que 0.");
            return;
        }

        // Calcular el IMC
        double bmi = weight / (height * height);

        // Variable para almacenar la clasificación
        string classification;

        // Clasificar el IMC usando if-else
        if (bmi < 18.5)
        {
            classification = "Bajo peso";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            classification = "Normal";
        }
        else if (bmi >= 25 && bmi <= 29.9)
        {
            classification = "Sobrepeso";
        }
        else // bmi >= 30
        {
            classification = "Obesidad";
        }

        // Usar switch para mostrar el resultado
        switch (classification)
        {
            case "Bajo peso":
                Console.WriteLine($"Su IMC es {bmi:F2}. Clasificación: {classification}.");
                break;
            case "Normal":
                Console.WriteLine($"Su IMC es {bmi:F2}. Clasificación: {classification}.");
                break;
            case "Sobrepeso":
                Console.WriteLine($"Su IMC es {bmi:F2}. Clasificación: {classification}.");
                break;
            case "Obesidad":
                Console.WriteLine($"Su IMC es {bmi:F2}. Clasificación: {classification}.");
                break;
            default:
                Console.WriteLine("Clasificación desconocida.");
                break;
        }
    }
}
