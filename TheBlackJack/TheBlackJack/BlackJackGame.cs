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
                    Console.WriteLine("You don't have that much of amount");
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
            dealer.DealerGetCard();
            HitANewCard();
           
            dealer.PrintDealerCard();
            player.PrintPlayerCard();
            
            bool choice =true;
            while (choice)
            {
                Console.WriteLine("[H]it or [S]tay?");
                var val = Console.ReadLine();
                switch (val.ToUpper())
                {
                    case "H":
                        Console.WriteLine("You got: ");
                        HitANewCard();
                        player.PrintPlayerCard();
                        break;

                    case "S":
                        player.Stay();
                        choice = false;
                        break;

                    default:
                        break;
                }
            }
            dealer.DealerGetCard();

            Console.ReadKey();
        }
        public void HitANewCard()
        {

            var card=dealer.GiveAwayCard();
            player.AddCard(card);
            
        }
    }
}
