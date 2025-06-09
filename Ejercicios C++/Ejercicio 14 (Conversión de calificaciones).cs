using System;

class GradeConverter
{
    static void Main()
    {
        Console.WriteLine("Ingrese la calificación numérica del estudiante (0-100):");

        string input = Console.ReadLine();
        if (!int.TryParse(input, out int grade) || grade < 0 || grade > 100)
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número entero entre 0 y 100.");
            return;
        }

        // Variable para almacenar la letra de la calificación
        char letterGrade;

        // Determinar la letra de la calificación usando if-else
        if (grade >= 90)
        {
            letterGrade = 'A';
        }
        else if (grade >= 80)
        {
            letterGrade = 'B';
        }
        else if (grade >= 70)
        {
            letterGrade = 'C';
        }
        else if (grade >= 60)
        {
            letterGrade = 'D';
        }
        else // grade < 60
        {
            letterGrade = 'F';
        }

        // Usar switch para mostrar el resultado
        switch (letterGrade)
        {
            case 'A':
                Console.WriteLine($"La calificación es: {letterGrade} (90-100)");
                break;
            case 'B':
                Console.WriteLine($"La calificación es: {letterGrade} (80-89)");
                break;
            case 'C':
                Console.WriteLine($"La calificación es: {letterGrade} (70-79)");
                break;
            case 'D':
                Console.WriteLine($"La calificación es: {letterGrade} (60-69)");
                break;
            case 'F':
                Console.WriteLine($"La calificación es: {letterGrade} (0-59)");
                break;
            default:
                Console.WriteLine("Calificación desconocida.");
                break;
        }
    }
}
