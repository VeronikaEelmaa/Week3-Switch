using System;

namespace PersonalityTestSwitch
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
            string userColor = Console.ReadLine().ToLower();

            //Punane, Sinine, RoHElinE

            switch (userColor)
            {

                case "punane": //if(userColor == "punane)
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber.");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;

            }

            Console.WriteLine("Kena päeva!");
        }   
    }
}
