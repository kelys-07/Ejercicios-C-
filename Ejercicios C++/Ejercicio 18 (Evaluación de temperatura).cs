using System;

class TemperatureChecker
{
    static void Main()
    {
        Console.WriteLine("Ingrese la temperatura en grados Celsius:");

        string input = Console.ReadLine();
        if (!double.TryParse(input, out double temperature))
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
            return;
        }

        // Variable para almacenar el mensaje
        string message;

        // Determinar el rango de temperatura usando if-else
        if (temperature < 0)
        {
            message = "Hace mucho frío";
        }
        else if (temperature >= 0 && temperature <= 20)
        {
            message = "Clima fresco";
        }
        else if (temperature >= 21 && temperature <= 30)
        {
            message = "Clima agradable";
        }
        else // temperature > 30
        {
            message = "Hace mucho calor";
        }

        // Usar switch para mostrar el mensaje
        switch (message)
        {
            case "Hace mucho frío":
                Console.WriteLine(message);
                break;
            case "Clima fresco":
                Console.WriteLine(message);
                break;
            case "Clima agradable":
                Console.WriteLine(message);
                break;
            case "Hace mucho calor":
                Console.WriteLine(message);
                break;
            default:
                Console.WriteLine("Mensaje desconocido.");
                break;
        }
    }
}
