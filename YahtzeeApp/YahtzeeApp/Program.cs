namespace YahtzeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Yahtzee App!");//continue tomorrow
            Random random = new Random();
            string choice;
            int rounds = 13;//apparently yahtzee is 13 rounds long
            int points = 0;//initialize points at zero, different combos are worth different amounts
            int[] roundRolls = new int[5]; //the idea is you can have stuff like straights in yahtzee, so order is important, therefore we can do the checking on index value
            string[] dice = {"--------\n" +
                             "|      |\n" +
                             "|   O  |\n" +
                             "|      |\n" +
                             "--------",
                                "--------" +
                                "|   O  |\n" +
                                "|      |\n" +
                                "|   O  |\n" +
                                "--------"};
            //Console.WriteLine($"{dice[0]} \t {dice[1]}");
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
                   
                    //switch (roll)
                    //{
                    //    case 1:
                    //        Console.Write("\t" +
                    //            "--------\n" +
                    //            "|      |\n" +
                    //            "|   O  |\n" +
                    //            "|      |\n" +
                    //            "--------\n" );
                    //        break;
                    //    case 2:
                    //        Console.Write("" +
                    //            "--------\n" +
                    //            "|   O  |\n" +
                    //            "|      |\n" +
                    //            "|   O  |\n" +
                    //            "--------\n");
                    //        break;
                    //    case 3:
                    //        Console.Write("\t" +
                    //            "--------\n" +
                    //            "|   O  |\n" +
                    //            "|   O  |\n" +
                    //            "|   O  |\n" +
                    //            "--------\n");
                    //        break;
                    //    case 4:
                    //        Console.Write("\t" +
                    //            "--------\n" +
                    //            "| O  O |\n" +
                    //            "|      |\n" +
                    //            "| O  O |\n" +
                    //            "--------\n");
                    //        break;
                    //    case 5:
                    //        Console.Write("\t" +
                    //            "--------\n" +
                    //            "| O  O |\n" +
                    //            "|   O  |\n" +
                    //            "| O  O |\n" +
                    //            "--------\n");
                    //        break;
                    //    case 6:
                    //        Console.Write("\t" +
                    //            "--------\n" +
                    //            "| O  O |\n" +
                    //            "| O  O |\n" +
                    //            "| O  O |\n" +
                    //            "--------\n");
                    //        break;
                    //}
                }
                Console.Write("\n\nWould you like to play again? (y/n): ");
            choice= Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
