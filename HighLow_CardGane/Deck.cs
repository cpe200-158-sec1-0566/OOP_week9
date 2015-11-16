using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow_CardGane
{
    class Deck
    {
        //a card deck :52 cards
        Stack<Card> card_deck;

        public Deck()
        {
        }

        public Deck(int numofcard = 0)
        {
           card_deck = new Stack<Card>(numofcard);

            //add card to deck
            if (numofcard == 52)
            {
                for (int j = 1; j <= 13; j++)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        card_deck.Push(new Card(j));
                    }
                }
            }

        }

        //shuffle cards
        public void shuffle( )
        {
            Random r = new Random();
            for (int n = card_deck.Count-1 ; n > 0; --n)
            {
                int k = r.Next(n + 1);
                Card temp = card_deck.ElementAt(n);
                card_deck.ElementAt(n).copycard(card_deck.ElementAt(k));
                card_deck.ElementAt(k).copycard(temp);          
        }
    }


        public Card deal()//pop the card
        {
            return card_deck.Pop();
        }

        public void get_card(Card getcard)
        {
            card_deck.Push(getcard);
        }


        //tell size of deck
        public int getsize_card()
        {
            return card_deck.Count;
        }
    }
}
