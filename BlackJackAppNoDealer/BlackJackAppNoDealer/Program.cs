namespace BlackJackAppNoDealer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Blackjack App");
            Console.WriteLine("This is the version with just the player, I'll make a different one with a dealer.");

            string choice;
            //not sure if handling the array of cards like this makes sense. Do I make it all 52? what about strings?
            //listen we're just gonna make this simple and a bit bastardized and the one with a dealer will be closer to the actual logic
            //I'm a new programmer afterall, programming at all is the priority for me here
            int[] cards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 11 }; //I know this is still inaccurate, but I figure that there are 3 facecards worth 10 points, so that puts the probability a little closer
            Random random = new Random();
            string hitChoice;
            do
            {
                bool victory = false;
                int total = 0;
                
                do
                {
                    int cardPick = random.Next(cards.Length);
                    int card = cards[cardPick];
                    total += card;
                    Console.Write($"Your total is {total},would you like to hit? (y/n): ");
                    hitChoice = Console.ReadLine().ToLower();

                } while (total < 21 && hitChoice == "y");
                if(total > 21)
                {
                    Console.WriteLine("You lost!");
                }
                Console.Write("Would you like to play again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
