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
            
            Console.WriteLine("Welcome to Black Jack");
            Console.WriteLine("You start at " + player._PlayerAmount + " coins.");

            
                Console.WriteLine("How much do you wanna bet?");
                int bet = 0;
                int.TryParse(Console.ReadLine(), out bet);
                player._PlayerBet = bet;
                while (player._PlayerBet > player._PlayerAmount)
                {
                    Console.WriteLine("Du har inte så mycket");
                    Console.WriteLine("How much do you wanna bet?");
                    bet = 0;
                    int.TryParse(Console.ReadLine(), out bet);
                    player._PlayerBet = bet;
                }
                
                    Console.WriteLine("You've betted " + player._PlayerBet);
               
            

        }  

        public void GameOn()
        {
            var newDeck=deck.giveDeck();
            dealer.ShuffleCard(newDeck);
            dealer.SetDeck(newDeck);
            HitANewCard();
            HitANewCard();

            player.PrintPlayerCard();

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
