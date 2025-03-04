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
                    //apparently you use 5 dice, so I figure each time this goes you roll one of the dice?
                    //also I want to try my hand at printing out ascii images of the dice faces when I have everything else working
                }
                Console.Write("Would you like to play again? (y/n): ");
            choice= Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
