using System;
using System.Threading;

namespace Task1
{
    class Program
    {

        private static double Sum(double a, double b, char oper, ConsoleColor color)
        {

            Console.WriteLine($"ID Вторичного потока: {Thread.CurrentThread.ManagedThreadId} \n");
           
            Console.ForegroundColor = color;

            double total =0;

            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
            }

            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
            }

            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"\nВторичный поток {Thread.CurrentThread.ManagedThreadId} завершился.\n");

            return total;
        }

        static void Main()
        {
            double a = 3;
            double b = 7;

            Console.WriteLine($"ID Первичного потока: {Thread.CurrentThread.GetHashCode()} \n");
            Console.WriteLine("Запуск нового потока...");

            var thread = new Thread(() => Sum(a, b, '+', ConsoleColor.Yellow));

            thread.Start();
            thread.Join();

            Console.WriteLine($"\nПервичный поток {Thread.CurrentThread.GetHashCode()} завершился.\n");

        }
    }
}