using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] svar = new string[10] { "Ja", "Nej", "Kanske", "Troligt", "Inte troligt", "Sällan sant", "Oftast sant", "sant", "icke sant", "maybe" };
            Random slump = new Random();
            while (true)
            {
                Console.WriteLine("Ställ en fråga, skriv \"a\" för att avsluta:");
                string x = Console.ReadLine();
                if (x != "a")
                {
                    string slumpmässigt = svar[slump.Next(10)];
                    Console.WriteLine(slumpmässigt);
                }
                else
                {
                    break;
                }

            }
        }
    }
}