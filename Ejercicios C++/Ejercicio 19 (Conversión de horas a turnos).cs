using System;

class TimeOfDayChecker
{
    static void Main()
    {
        Console.WriteLine("Ingrese la hora (0-23):");

        string input = Console.ReadLine();
        if (!int.TryParse(input, out int hour) || hour < 0 || hour > 23)
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número entero entre 0 y 23.");
            return;
        }

        // Variable para almacenar el mensaje
        string timeOfDay;

        // Determinar el momento del día usando if-else
        if (hour >= 6 && hour <= 11)
        {
            timeOfDay = "Mañana";
        }
        else if (hour >= 12 && hour <= 17)
        {
            timeOfDay = "Tarde";
        }
        else if (hour >= 18 && hour <= 23)
        {
            timeOfDay = "Noche";
        }
        else // hour >= 0 && hour <= 5
        {
            timeOfDay = "Madrugada";
        }

        // Usar switch para mostrar el mensaje
        switch (timeOfDay)
        {
            case "Mañana":
                Console.WriteLine("Es Mañana.");
                break;
            case "Tarde":
                Console.WriteLine("Es Tarde.");
                break;
            case "Noche":
                Console.WriteLine("Es Noche.");
                break;
            case "Madrugada":
                Console.WriteLine("Es Madrugada.");
                break;
            default:
                Console.WriteLine("Momento del día desconocido.");
                break;
        }
    }
}

