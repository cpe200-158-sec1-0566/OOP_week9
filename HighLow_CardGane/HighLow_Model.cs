using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow_CardGane
{
    class HighLow_Model
    {
        Deck player1_deck = new Deck(0); //deck of player1
        Deck player2_deck = new Deck(0); //deck of player2
        Deck bot = new Deck(52);
        Card player1_card = new Card();
        Card player2_card = new Card();
        Stack<Card> remember_p1 = new Stack<Card>(0);
        Stack<Card> remember_p2 = new Stack<Card>(0);


        protected int number_card; //defalut is 52

        public HighLow_Model() : this(52)
        {
            //defalut number of cards

        }

        public HighLow_Model(int num_card)
        {
            number_card = num_card;//set number of card
            Deal_card();//deal cards to two player
            //begin

        }

        private void Deal_card()//ues when program run only
        {
            bot.shuffle();
            for (int i=0;i<26;i++)
            {
                player1_deck.get_card(bot.deal());
                player2_deck.get_card(bot.deal());
            }          
        }

        //play แต่ละ turn
        public string[] process_game()
        {
            string[] value_player = new string[2]; // value_player[0] = card that player1 pop ,value_player[1] = card that player2 pop

            //player1
            player1_card = player1_deck.deal();
            value_player[0] = ""+player1_card.get_rank();

            //player2
            player2_card = player2_deck.deal();
            value_player[1] = ""+player2_card.get_rank();

            if (player1_card.get_rank()==player2_card.get_rank())
            {   //equal score

                for (int i = 0; i < player1_card.get_rank(); i++)
                {
                    player1_deck.shuffle();
                    player2_deck.shuffle();
                    //player1
                    remember_p1.Push(player1_deck.deal());
                    //player2
                    remember_p2.Push(player2_deck.deal());                  
                }   

                //
                if (remember_p1.ElementAt(remember_p1.Count - 1).get_rank() != remember_p2.ElementAt(remember_p2.Count - 1).get_rank())
                {
                    for (int i = 0; i < player1_card.get_rank(); i++)
                    {
                        //player1
                        player1_deck.get_card(remember_p1.ElementAt(i));
                        //player2
                        player2_deck.get_card(remember_p2.ElementAt(i));
                    }


                    player1_deck.get_card(player1_card); 
                    player2_deck.get_card(player2_card);

                    player1_deck.shuffle();
                    player2_deck.shuffle();
                    //การ์ดกลับกอง
                }
                else if (remember_p1.ElementAt(remember_p1.Count - 1).get_rank() != remember_p2.ElementAt(remember_p2.Count - 1).get_rank())
                {
                    if (remember_p1.ElementAt(remember_p1.Count - 1).get_rank() > remember_p2.ElementAt(remember_p1.Count - 1).get_rank())
                    {
                        //player1 win
                        for (int i = 0; i < player1_card.get_rank(); i++)
                        {
                            //player1
                            player1_deck.get_card(remember_p1.ElementAt(i));
                            //player2
                            player1_deck.get_card(remember_p2.ElementAt(i));
                        }


                        player1_deck.get_card(player1_card); //return card
                        player1_deck.get_card(player2_card); //get card from player2
                        //เอาการ์ดที่เก็บมา
                    }
                    else
                    {
                        //player2 win

                        for (int i = 0; i < player1_card.get_rank(); i++)
                        {
                            //player1
                            player2_deck.get_card(remember_p1.ElementAt(i));
                            //player2
                            player2_deck.get_card(remember_p2.ElementAt(i));
                        }

                        player2_deck.get_card(player1_card); //return card
                        player2_deck.get_card(player2_card); //get card from player1
                        //เอาการ์ดที่เก็บมา

                    }
                }

            }
            else if(player1_card.get_rank() != player2_card.get_rank())
            {
                if (player1_card.get_rank() > player2_card.get_rank())
                {
                    //player1 win
                    player1_deck.get_card(player1_card); //return card
                    player1_deck.get_card(player2_card); //get card from player2
                }else
                {
                    //player2 win
                    player2_deck.get_card(player1_card); //return card
                    player2_deck.get_card(player2_card); //get card from player1

                }

                player1_deck.shuffle();
                player2_deck.shuffle();
            }
              if(player1_deck.getsize_card() == 0 || player2_deck.getsize_card() == 0)
            {
                if(player1_deck.getsize_card()==0)
                {
                    value_player[0] = "Player1 Win!!";
                    value_player[1] = "Player2 Loss!!";
                }
                else if (player2_deck.getsize_card() == 0)
                {
                    value_player[0] = "Player1 Loss!!";
                    value_player[1] = "Player2 Win!!";
                }                            
            }

            player1_deck.shuffle();
            player2_deck.shuffle();

            return value_player;
        }

    }
}
