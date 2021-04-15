using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeCardGame
{
    public class card
    {
        public string Suit { get; private set; }
        public string Value { get; private set; }

        
        public card(string suit, string value)
         // here we set the parameters for a card.
        {
            Suit = suit;
            Value = value;

        }
        public override string ToString() => $"{Value} of {Suit}";
        // this allows us to call tostring and format the value and suit.
    }
}
