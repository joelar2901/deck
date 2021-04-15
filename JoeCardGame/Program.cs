using System;

namespace JoeCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            deck newDeck = new deck();
            Drawcards(newdeck);
        }
        static void Drawcards(deck deck)
        {
            Console.WriteLine("shuffle your cards?");
            while (true)
            {
                String option = Console.ReadLine();
                if (option.ToLower().Trim() == "yes")
                    // The .trim means that yes can be any typed in lower or uppercase
                {
                    deck.shuffle();
                    Console.WriteLine("deck has been shuffled just for you!");
                    break;
                }
                else if (option.ToLower().Trim() == "no")
                {
                    Console.WriteLine("Deck has not been shuffled");
                    break;
                }
                else
                {
                    Console.WriteLine("choose an answer please");
                }
            }
            
            // this while loop will allow you to draw a card until,
            // there are none left or you choose not to draw.
            while (true)
            {
                Console.WriteLine("Draw a card?");
                string answer = Console.ReadLine();
                if (deck.IsEmpty())
                {
                    Console.WriteLine("Deck is empty, Bye! ");
                      break;
                }
                else if (answer.ToLower().Trim() == "yes")
                {
                    Console.WriteLine(deck.Deal());
                }
                else if (answer.ToLower().Trim() == "no")
                {
                    Console.WriteLine(" App will now close");
                    break;
                }
                else
                {
                    Console.WriteLine(" Please enter a valid option ");
                }

            }
        }

    }
}

