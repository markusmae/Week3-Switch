using System;

namespace PeronalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema lemmikvärv;
            Console.WriteLine("Sisesta oma lemmikvärv:");
            string usercolor = Console.ReadLine();
            //kui kasutaja sisestab "punane", siis konsool kuvab "oled romantiline";
            if (usercolor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            //kui kasutaja sisestab "sinine", siis konsool kuvab "oled töökas";
            else if (usercolor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            //kui kasutaja sisestab "roheline", siis konsool kuvab "oled loodusesõber";
            else if (usercolor == "roheline")
            {
                Console.WriteLine("Oled loodusesõber.");
            }
            //kui kasutaja sisestab midagi muudu, siis konsool kuvab "oled {usercolor} ükssarvik";
            else
            {
                Console.WriteLine($"Oled {usercolor} ükssarvik.");           
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
