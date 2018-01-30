using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone_Dust_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hearthstone dust counter! Enter 1 if you want to enter the rareties,\nor 2 if you want to enter the names(2 doesn't work yet)");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much dust do you have kid");
            int dust = Convert.ToInt32(Console.ReadLine());
            int decklistDust = 0;
            int playerDust = 0;

            if (answer == 1)
            {
                decklistDust = RarityDust(decklistDust);
                Console.WriteLine($"The decklist requires {decklistDust} dust\nPress enter to continue");
                Console.ReadLine();
                playerDust = PlayerDust(playerDust);
                int remainingDust = dust - decklistDust;
                Console.WriteLine($"Ok, you have {playerDust} dust already completed from owned cards\nMaking this deck will leave you with {remainingDust} dust left");
                Console.ReadLine();
            }
        }
        static int RarityDust(int dustCount)
        {
            Console.Write("Enter required basic cards: ");
            Console.ReadLine();
            Console.WriteLine("No one cares");
            Console.Write("Enter required common cards: ");
            int originalC = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter required rare cards: ");
            int originalR = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter required epic cards: ");
            int originalE = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter required legendary cards: ");
            int originalL = Convert.ToInt32(Console.ReadLine());
            originalC = originalC * 40;
            originalR = originalR * 100;
            originalE = originalE * 400;
            originalL = originalL * 1600;
            dustCount = originalC + originalR + originalE + originalL;
            return dustCount;
        }
        static int PlayerDust(int dustCount)
        {
            Console.Write("So, how many required basic cards do you have: ");
            Console.ReadLine();
            Console.WriteLine("Still, no one cares");
            Console.Write("How many required common cards do you have: ");
            int originalC = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many required rare cards do you have: ");
            int originalR = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many required epic cards do you have: ");
            int originalE = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many required legendary cards do you have: ");
            int originalL = Convert.ToInt32(Console.ReadLine());
            originalC = originalC * 40;
            originalR = originalR * 100;
            originalE = originalE * 400;
            originalL = originalL * 1600;
            dustCount = originalC + originalR + originalE + originalL;
            return dustCount;
        }
    }
}
