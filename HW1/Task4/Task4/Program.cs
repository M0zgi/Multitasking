using System;
using System.Threading;

namespace Task1
{
    class Program
    {

        private static int Count(string path, string word, ConsoleColor color)
        {

            Console.WriteLine($"ID Вторичного потока: {Thread.CurrentThread.ManagedThreadId} \n");
           
            Console.ForegroundColor = color;

            int count = 0;

            string[] keys = new string[] {word};

            try
            {
                using (var file = new StreamReader(path))

                    while (!file.EndOfStream)
                    {
                        count +=  KeyWords(file.ReadLine(), keys);
                    }

                Console.WriteLine($"\nСлово {word} встречается в файле {count} раз.\n");
            }
            catch (IOException eх)
            {
                Console.WriteLine(eх);
            }

            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"\nВторичный поток {Thread.CurrentThread.ManagedThreadId} завершился.\n");

            return count;
        }

        public static int KeyWords(string text, string[] keys)
        {

            string[] words = text.Split(spliters, StringSplitOptions.RemoveEmptyEntries);
 
            int count = 0;

            foreach (string word in words)
            foreach (string key in keys)
                if (word.ToLower().Contains(key.ToLower()))
                    count++;
            return count;
        }

        private static char[] spliters = "\r\n ,.?—:;!\"".ToCharArray();

        static void Main()
        {
            string path = @"file.txt";
            string word = "bicycle";

            Console.WriteLine($"ID Первичного потока: {Thread.CurrentThread.GetHashCode()} \n");
            Console.WriteLine("Запуск нового потока...");

            var thread = new Thread(() => Count(path, word, ConsoleColor.Yellow));

            thread.Start();
            thread.Join();

            Console.WriteLine($"\nПервичный поток {Thread.CurrentThread.GetHashCode()} завершился.\n");

        }
    }
}