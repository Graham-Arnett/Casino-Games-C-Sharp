﻿namespace YahtzeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Yahtzee App!");
            Random random = new Random();
            string choice;
            int rounds = 13;//apparently yahtzee is 13 rounds long
            int points = 0;//initialize points at zero, different combos are worth different amounts
            do
            {

                //funny story, I don't know the rules of yahtzee, so what I'm gonna do is just make the skeleton structure tonight, and do the rest tomorrow
                for(int i = 0; i < 5; i++)
                {
                    //this forloop should probably be inside another dowhile since it says a player can roll their dice up to 3 times on their turn
                    //so like itd have the counter for the times in the condition, as well as if they say 'y' to the prompt
                    int roll = random.Next(1,7);//lower bound is inclusive, upper is exclusive so its 1-6 really
                    Console.Write($"\tYour roll: {roll}"); //eventually I want to print out ascii dice here
                    //should the other player have a separate forloop? nah probably not
                    int botRolls = random.Next(1, 7);//this probably violates DRY, but I'm still learning so its ok
                    Console.Write($"\tThe other player rolled: {botRolls}");//ok this formatting needs work
                }
                Console.Write("\n\nWould you like to play again? (y/n): ");
            choice= Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
