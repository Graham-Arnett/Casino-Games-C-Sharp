namespace YahtzeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Yahtzee App!");//continue tomorrow
            Random random = new Random();
            string choice;
           
            
            do
            {
                int rounds = 13;//apparently yahtzee is 13 rounds long
                int points = 0;//initialize points at zero, different combos are worth different amounts
                int[] roundRolls = new int[5];
                Console.WriteLine($"Your rolls: ");
                //funny story, I don't know the rules of yahtzee, so what I'm gonna do is just make the skeleton structure tonight, and do the rest tomorrow
                for (int i = 0; i < 5; i++)
                {
                    //this forloop should probably be inside another dowhile since it says a player can roll their dice up to 3 times on their turn
                    //so like itd have the counter for the times in the condition, as well as if they say 'y' to the prompt
                    int roll = random.Next(1,7);//lower bound is inclusive, upper is exclusive so its 1-6 really
                    roundRolls[i] = roll;
                    Console.Write($"{roundRolls[i]}\t");
                    
                }
                if (roundRolls[1] == roundRolls[0] + 1 && roundRolls[2] == roundRolls[1] + 1 && roundRolls[3] == roundRolls[2] + 1 && roundRolls[4] == roundRolls[3] + 1)
                {
                    //I think my logic for a straight is incorrect
                    //I need a new way to check logic for win conditions
                    Console.WriteLine("You got a STRAIGHT!");
                }
                Console.Write("\n\nWould you like to play again? (y/n): ");
            choice= Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
