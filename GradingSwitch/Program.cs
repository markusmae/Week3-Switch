using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma hinne.");
            char userresult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userresult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane");
                    break;

                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;

                case 'C':
                    Console.WriteLine("Rahuldav.");
                    break;

                case 'D':
                    Console.WriteLine("Kasin.");
                    break;

                case 'E':
                    Console.WriteLine("Puudulik.");
                    break;

                default:
                    Console.WriteLine("Vale väärtus!");
                    break;

                    
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
