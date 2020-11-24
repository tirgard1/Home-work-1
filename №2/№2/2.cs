using System;

namespace _2
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

        static double div(double a, double b) 
        {
            double c = a / b;
            return c;
        }


        static void Main(string[] args)
        { 
            Console.Write("Введите делимое:");
            double a = chislo();
         
            Console.Write("Введите делитель:");
            double b = chislo();

            if (b == 0)
            {
                Console.WriteLine("Деление на ноль невозможно");          
            }
            else
            {
                
                Console.WriteLine($"{div(a, b)}");
            }

           
        }
    }
}
