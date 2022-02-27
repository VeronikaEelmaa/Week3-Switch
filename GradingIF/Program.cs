using System;

namespace GradingIF
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

            //kasutame IF

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav.");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin.");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik.");
            }
            else
            {
                Console.WriteLine("vale väärtus");
            }
        }
    }
}
