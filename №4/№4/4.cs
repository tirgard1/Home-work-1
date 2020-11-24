using System;

namespace _4
{
    class Program
    { 
        static double chislo()
    {
        double number = 1;
        try
        {
            number = double.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка: " + e.Message);


            Environment.Exit(1);
        }

        return number;
    }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент a:");
            double a = chislo();

            Console.WriteLine("Введите коэффициент b:");
            double b = chislo();

            Console.WriteLine("Введите коэффициент с:");
            double c = chislo();    

            double x, x1, x2;
            
            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Первый корень:{x1}");
                Console.WriteLine($"Второй корень:{x2}");
            }
            else if (D == 0)
            {
                x = -b / 2 * a;
                Console.WriteLine($"Корень уравнения:{x}");
            }
            else if (D < 0)
            {
                Console.WriteLine("Уравнение не имеет корней");
            }


        }
    }
}
