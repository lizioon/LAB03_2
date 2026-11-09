using System;
namespace LAB03_2 { internal class Program { static void Main(string[] args) { Console.Write("Введите первую сторону: "); double a = double.Parse(Console.ReadLine());
        Console.Write("Введите вторую сторону: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите третью сторону: ");
        double c = double.Parse(Console.ReadLine());

        double perimeter = a + b + c;
        double p = perimeter / 2 ;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        Console.WriteLine($"Периметр: {perimeter}");
        Console.WriteLine($"Площадь: {area:F2}");
    }
}
}