using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will simulate a dice game similar to Yahtzee.");
            Console.WriteLine("Enter r to roll the dice.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();

            Die[] diceHand = new Die[5];
            for (int i = 0; i < diceHand.Length; i++)
            {
                diceHand[i] = new Die();
                Console.WriteLine(diceHand[i].FaceValue + " ");
                Thread.Sleep(1);
            }
            

            Console.ReadKey();
        }
    }
}
