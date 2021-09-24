using System;

namespace PersonalityTestSwittch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema lemmikvärv;
            Console.WriteLine("Sisesta oma lemmikvärv:");
            string usercolor = Console.ReadLine().ToLower();
            //kui kasutaja sisestab "punane", siis konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", siis konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", siis konsool kuvab "oled loodusessõber";
            //kui kasutaja sisestab midagi muudu, siis konsool kuvab "oled {usercolor} ükssarvik";
            
            switch (usercolor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline.");
                    break;
                
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                
                case "rohline":
                    Console.WriteLine("Oled loodusesõber.");
                    break;

                default:
                    Console.WriteLine($"Oled {usercolor} ükssarvik.");
                    break;

                    
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
