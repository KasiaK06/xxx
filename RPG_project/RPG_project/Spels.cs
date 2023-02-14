using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Spels
    {
        public static int[] SpelsBook(int[] character, int mxaHp, int maxMoc)
        {
            Console.WriteLine("1 - Lecznie \t 2 - Zwiększenie ataku");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "1":
                    return Heal(character, mxaHp, maxMoc);               
                case "2":
                    return Atack(character, maxMoc);
                default:
                    return character;
            }
        }

        public static int[] Heal(int[] character, int mxaHp, int maxMoc)
        {
            if (character[2] >= 100)
            {
                character[0] = mxaHp;
                character[2] -= 100;
                Console.WriteLine("Masz max hp");
                return character;
            }
            else
            {
                Console.WriteLine("Brak mocy");
            }

            return character;
        }

        public static int[] Atack(int[] character, int maxMoc)
        {
            if (character[2] >= 150)
            {
                character[1] += 15;
                character[2] -= 100;
                Console.WriteLine("Zyskałeś +15 do ataku");
                return character;
            }
            else
            {
                Console.WriteLine("Brak mocy");
            }

            return character;
        }





    }
}
