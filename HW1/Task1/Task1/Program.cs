using System;
using System.Threading;

namespace Task1
{
    class Program
    {
        // Метод выполяняющийся во Вторичном потоке.
        private static void Func()
        {
            Console.WriteLine($"ID Вторичного потока: {Thread.CurrentThread.ManagedThreadId} \n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 160; i++ )
            {                
                Thread.Sleep(20);//замедляем вывод значений
                Console.Write("2");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nВторичный поток {Thread.CurrentThread.ManagedThreadId} завершился.\n");
        }


        static void Main()
        {
            Console.WriteLine($"ID Первичного потока: {Thread.CurrentThread.GetHashCode()} \n");
            Console.WriteLine("Запуск нового потока...");

            // Создание нового потока.
            var thread = new Thread(new ThreadStart(Func)); //Предположние делегата new ThreadStart можно убрать
            thread.Start();

            Console.WriteLine($"\nСообщаем планировщику потоков (через thread.Join();) остановить выполнение первичного потока {Thread.CurrentThread.GetHashCode()}\n");

            // Ожидание первичным потоком, завершения работы вторичного потока.
            thread.Join();
            
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < 160; i++)
            {                
                Thread.Sleep(20);//замедляем вывод значений
                Console.Write("1");
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"\nПервичный поток {Thread.CurrentThread.GetHashCode()} завершился.\n");
            
        }
    }
}