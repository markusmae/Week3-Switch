using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mis hinde kasutaja sai;

            Console.WriteLine("Sisesta oma hinne.");
            char userresult = Convert.ToChar(Console.ReadLine().ToUpper());
            //kui kasutaja sai "A", konsool kuvab "Suurepärane";
            if (userresult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            //"B">> "Väga hea";
            else if (userresult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            //"C" >> "Hea";
            else if (userresult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            //"D" >> "Rahuldav";
            else if (userresult == 'D')
            {
                Console.WriteLine("Rahuldav.");
            }
            //"E" >> "Kasin";
            else if (userresult == 'E')
            {
                Console.WriteLine("Kasin.");
            }
            //"F" >> "Puudulik";
            else if (userresult == 'F')
            {
                Console.WriteLine("Puudulik.");
            }
            //"*" >> "Vale väärtus";
            else
            {
                Console.WriteLine("Vale väärtus.");
            }
        }
    }
}
