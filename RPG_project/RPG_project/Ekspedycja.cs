using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class Ekspedycja
    {
        public static int[] Place(int[] character)
        {
            Console.WriteLine("Gdzie chcesz iść?");
            Console.WriteLine("1 - Jaskinia \t 2 - Pustynia");
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return Jaskinia(character);
                case 2:
                    return Pustynia(character);
            }
            Console.WriteLine("Wracasz z ekspedycji");
            return character;
        }

        public static int[] Jaskinia(int[] character)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 4);          
            if (a > 0)
            {
                Console.WriteLine($"Znalazłeś {a} diaxy");
                character[4] += a;

            }
            else if (a == 0)
            {
                Console.WriteLine("Nic nie znalazłeś");
            }
            return character;
        }


        public static int[] Pustynia(int[] character)
        {
            Random rnd = new Random();
            int a = rnd.Next(10, 20);           
            if (a > 0)
            {
                Console.WriteLine($"Znalazłeś {a} kłów");
                character[5] += a;

            
            }
            return character;
        }
    }
}
