using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada oma lemmikvärv;
            //kui kasutaja sisestab "punane", kuvab konsool "oled romantiline";
            //kui kasutaja sisestab "sinine", kuvab konsool "oled töökas";
            //kui kasutaja sisestab "roheline", kuvab konsool "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, kuvab konsool "oled {userColor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine();

            if(userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if(userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if(userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
