using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mis hinde kasutaja sai
            //kui kasutaja sai 'A', siis kuvab konsool "Suurepärane!"
            //kui kasutaja sai 'B', siis kuvab konsool "Väga hea!"
            //kui kasutaja sai 'C', siis kuvab konsool "Hea!"
            //kui kasutaja sai 'D', siis kuvab konsool "Rahuldav."
            //kui kasutaja sai 'E', siis kuvab konsool "Kasin."
            //kui kasutaja sai 'F', siis kuvab konsool "Puudulik."
            //kui kasutajs sisestab midagi muud, kuvab konsool "vale väärtus"

            //kasutame SWITCH

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            string userResult = Console.ReadLine().ToUpper();

            switch (userResult)
            {
                case "A":
                    Console.WriteLine("Suurepärane!");
                    break;
                case "B":
                    Console.WriteLine("Väga hea!");
                    break;
                case "C":
                    Console.WriteLine("Hea!");
                    break;
                case "D":
                    Console.WriteLine("Rahuldav.");
                    break;
                case "E":
                    Console.WriteLine("Kasin.");
                    break;
                case "F":
                    Console.WriteLine("Puudulik.");
                    break;
                default:
                    Console.WriteLine($"vale väärtus");
                    break;
            }



        }
    }
}
