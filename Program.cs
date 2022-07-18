using System;

namespace ConsoleAppPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper.WriteConsole(ConsoleColor.Blue, "select the option");
            
            Helper.WriteConsole(ConsoleColor.Yellow,"1- Create library,2-Get libfrary by id,3-Update library,4-Delete library");

            while (true)
            {
                string selectOption = Console.ReadLine();
                Console.WriteLine(selectOption);
            }
        }
    }
}
