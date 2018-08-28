using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQual a sua idade? ");
            var age = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nOlá, tenho {age}, em {date:d} as {date:t}!");
            Console.Write("\nClique para sair...");
            Console.ReadKey(true);
        }
    }
}
