using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBlackJack
{
    class BlackJackGame
    {
        Card card = new Card();
        Dealer dealer = new Dealer();
        Deck deck = new Deck();
        Player player = new Player();
        Rules rules = new Rules();
        Amount amount = new Amount();

        string val;

        public void Meny()
        {
            dealer.getDeck(deck.giveDeck());
            Console.WriteLine("Welcome to Black Jack");
            Console.WriteLine("You start at " + player._PlayerAmount + " coins.");
           
            while (val != "Q")
            {
                Console.WriteLine("How much do you wanna bet?");

                player._PlayerBet = int.Parse(Console.ReadLine());
            if (player._PlayerBet > player._PlayerAmount)
            
                while (player._PlayerBet > player._PlayerAmount)
                {
                    Console.WriteLine("You can't bet more than your amount");
                    break;
                }
                
            else
            {
                Console.WriteLine("You've betted " + player._PlayerBet);
                    break;
            }

            }
          
        }  

        public void GameOn()
        {
            deck.giveDeck();
            
            
            Console.WriteLine(dealer.GiveAwayCard());
            Console.WriteLine("[H]it or [S]tay?");
            val = Console.ReadLine();
            switch (val.ToUpper())
            {
                case "H":
                    Console.WriteLine("You got: ");
                    player.PrintPlayerCard();
                    HitANewCard();
                break;

                case "S":
                    player.Stay();
                    break;

                default:
                    break;
            }


            Console.ReadKey();
        }
        public void HitANewCard()
        {

            var card=dealer.GiveAwayCard();
            player.AddCard(card);
        }
    }
}
