using System;
using System.Threading;

namespace Task1
{
    class Program
    {
        private static  void Procedure()
        {
            Console.WriteLine($"ID Вторичного потока: {Thread.CurrentThread.ManagedThreadId} \n");

            bool reset = false;

            while (!reset)
            {
                try
                {
                    for (int i = 0; i <= 160; i++)
                    {
                        Thread.Sleep(20);
                        Console.Write("2");

                        if(i == 160)
                            reset = true;
                    }
                }
                catch (ThreadInterruptedException ex)
                {
                    Console.WriteLine("\nThreadAbortException\n");
                    Console.WriteLine(ex);
                    reset = true;
                }
            }

            Console.WriteLine($"\nВторичный поток {Thread.CurrentThread.ManagedThreadId} завершился.\n");
        }

        static void Main()
        {
            Console.WriteLine($"ID Первичного потока: {Thread.CurrentThread.GetHashCode()} \n");
            Console.WriteLine("Запуск нового потока...");

            // Создание нового потока.
            var thread = new Thread((Procedure)); //Предположние делегата new ThreadStart

            Console.WriteLine("Для прерывания выполнения вторичного потока нажмите 0 и Enter");
            
            thread.Start();

            int a;

            a = Console.Read();

            if (a == 48)
            {
                thread.Interrupt();
            }

            // Ждать завершения потока.
            thread.Join();

            Console.WriteLine($"\nПервичный поток {Thread.CurrentThread.GetHashCode()} завершился.\n");
        }
    }
}