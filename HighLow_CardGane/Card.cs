using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow_CardGane
{
    class Card
    {
        //set value of cards (name of card)
        public string cardname;
        //number on card
        public int rank;
        //constructor
        public Card()
        {
            rank = 12;
            cardname = "Ace";

        }
        public Card(int input_rank)
        {
            rank = input_rank;
            
            switch(input_rank)
            {
                
                case 1:
                    cardname = "2";
                    break;
                case 2:
                    cardname = "3";
                    break;
                case 3:
                    cardname = "4";
                    break;
                case 4:
                    cardname = "5";
                    break;
                case 5:
                    cardname = "6";
                    break;
                case 6:
                    cardname = "7";
                    break;
                case 7:
                    cardname = "8";
                    break;
                case 8:
                    cardname = "9";
                    break;
                case 9:
                    cardname = "Jack";
                    break;
                case 10:
                    cardname = "Queen";
                    break;
                case 11:
                    cardname = "King";
                    break;
                case 12:
                    cardname = "Ace";// most value
                    break;
            }
        }

        public string card_name(){
            return cardname;
        }

        public int get_rank()
        {
            return rank;
        }

        public string get_name()
        {
            return cardname;
        }

        public void set_rank(int rank)
        {
            if (rank < 1 || rank > 12 )
            {
                this.rank = 1;
            }
            else
            {
                this.rank = rank;
            }
        }

        public void copycard(Card c)
        {
            this.cardname = c.get_name();
            this.rank= c.get_rank();

        }
    }
}
