using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._3
{
    class Program //Средний уровень
    {
        static void Main(string[] args)
        {
            try
            {
                double y;
                Console.WriteLine("Введите число x для всех вариантов параметров: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число (k), чтобы выбрать вариант параметров: ");
                double k = double.Parse(Console.ReadLine());
                if (k == 1)
                {
                    double a = 0.3;
                    Console.WriteLine($"Число a = {a}");
                    double b = 0.9;
                    Console.WriteLine($"Число b = {b}");
                    double z = Math.Sin(Math.Pow(x, 2));
                    Console.WriteLine($"Число z = {z}");
                    switch (k)
                    {
                        case 1:
                            y = a + b * x + Math.Pow(Math.Sin(1), 2) * z * (Math.Pow(x, 3.5));
                            Console.WriteLine("При х<a y равен: " + y);
                            break;
                        case 2:
                            y = a + Math.Log10(Math.Abs(a * b - z * (Math.Pow(x, 3)))) + Math.Log10(x);
                            Console.WriteLine("При a<=x<= Math.Pow(b, 2) y равен: " + y);
                            break;
                        case 3:
                            y = Math.Sqrt(Math.Abs(a + Math.Tan(z * x))) + b * Math.Sin(1) * x;
                            Console.WriteLine("При х> Math.Pow(b,2) у равен: " + y);
                            break;
                    }
                }
                else if (k == 2)
                {
                    double a = 4.3;
                    Console.WriteLine($"Число a = {a}");
                    double b = 3.15;
                    Console.WriteLine($"Число b = {b}");
                    double z = Math.Sin(Math.Pow(x, 3));
                    Console.WriteLine($"Число z = {z}");
                    switch (k)
                    {
                        case 1:
                            y = a + b * x + Math.Pow(Math.Sin(1), 2) * z * (Math.Pow(x, 3.5));
                            Console.WriteLine("При х<a y равен: " + y);
                            break;
                        case 2:
                            y = a + Math.Log10(Math.Abs(a * b - z * (Math.Pow(x, 3)))) + Math.Log10(x);
                            Console.WriteLine("При a<=x<= Math.Pow(b, 2) y равен: " + y);
                            break;
                        case 3:
                            y = Math.Sqrt(Math.Abs(a + Math.Tan(z * x))) + b * Math.Sin(1) * x;
                            Console.WriteLine("При х> Math.Pow(b,2) у равен: " + y);
                            break;
                    }
                }
                else if (k == 3)
                {
                    double a = 6.5;
                    Console.WriteLine($"Число a = {a}");
                    double b = 3.5;
                    Console.WriteLine($"Число b = {b}");
                    double z = Math.Pow(Math.Sin(1), 2) * x;
                    Console.WriteLine($"Число z = {z}");
                    switch (k)
                    {
                        case 1:
                            y = a + b * x + Math.Pow(Math.Sin(1), 2) * z * (Math.Pow(x, 3.5));
                            Console.WriteLine("При х<a y равен: " + y);
                            break;
                        case 2:
                            y = a + Math.Log10(Math.Abs(a * b - z * (Math.Pow(x, 3)))) + Math.Log10(x);
                            Console.WriteLine("При a<=x<= Math.Pow(b, 2) y равен: " + y);
                            break;
                        case 3:
                            y = Math.Sqrt(Math.Abs(a + Math.Tan(z * x))) + b * Math.Sin(1) * x;
                            Console.WriteLine("При х> Math.Pow(b,2) у равен: " + y);
                            break;
                    }
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

