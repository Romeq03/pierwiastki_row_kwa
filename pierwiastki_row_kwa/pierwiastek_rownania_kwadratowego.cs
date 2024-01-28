using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współczynniki równania kwadratowego ax^2 + bx + c = 0:");
        
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"Równanie ma dwa pierwiastki rzeczywiste: x1 = {x1:F2}, x2 = {x2:F2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Równanie ma jeden pierwiastek rzeczywisty: x = {x:F2}");
        }
        else
        {
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }

        Console.ReadLine();    }
}
