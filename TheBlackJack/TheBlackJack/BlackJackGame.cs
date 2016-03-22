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
        Rules rules;
        Amount amount = new Amount();

        public BlackJackGame()
        {
            rules = new Rules(dealer);
        }



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
            var newDeck = deck.giveDeck();
            dealer.ShuffleCard(newDeck);
            dealer.SetDeck(newDeck);
            HitANewCard();
            dealer.DealerGetCard();
            HitANewCard();

            dealer.PrintDealerCard();
            Console.WriteLine("---------------");
            player.PrintPlayerCard();

            bool choice = true;
            while (choice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[H]it or [S]tay?");
                Console.ForegroundColor = ConsoleColor.White;
                var val = Console.ReadLine();
                switch (val.ToUpper())
                {
                    case "H":
                        HitANewCard();
                        player.PrintPlayerCard();
                        var playerresult = rules.PlayerTooHigh(player.PlayerCard);
                        if (playerresult > 21)
                        {
                            choice = false;
                        }
                        
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
            dealer.PrintDealerCard();
            Console.WriteLine("------------");
            rules.DealerMustDraw(dealer.DealerCard);
            var dealerresult = rules.DealerTooHigh(dealer.DealerCard);
            dealer.PrintDealerCard();
            Console.WriteLine("DealerResult is: " + dealerresult);
            if (dealerresult < 17)
            {
                rules.DealerMustDraw(dealer.DealerCard);
            }

            rules.WhoWin(dealer.DealerCard, player.PlayerCard);
            amount.CheckValue();

            Console.ReadKey();
        }
        public void HitANewCard()
        {

            var card = dealer.GiveAwayCard();
            player.AddCard(card);

        }
    }
}
