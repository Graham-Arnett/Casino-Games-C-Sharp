namespace YahtzeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Yahtzee App!");
            Random random = new Random();
            string choice;
            do
            {

                //funny story, I don't know the rules of yahtzee, so what I'm gonna do is just make the skeleton structure tonight, and do the rest tomorrow
                for(int i = 0; i < 5; i++)
                {
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
