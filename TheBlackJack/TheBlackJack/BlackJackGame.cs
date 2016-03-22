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
        Amount amount = new Amount(100);

        public BlackJackGame()
        {
            rules = new Rules(dealer);
        }

        
        public void HitANewCard()
        {

            var card = dealer.GiveAwayCard();
            player.AddCard(card);

        }
        public void PlayAgain()
        {
            player.PlayerCard.Clear();
            dealer.DealerCard.Clear();
            Meny();
            GameOn();
        }

        public void Meny()
        {
            //amount._myAmount = 100;
            Console.WriteLine("Welcome to Black Jack");
            Console.WriteLine("You start at " + amount._myAmount + " coins.");
            Console.WriteLine("How much do you wanna bet?");

            int bet = 0;
            int.TryParse(Console.ReadLine(), out bet);
            amount.PlayerBet = bet;
            

            while (bet > amount._myAmount)
            {
                Console.WriteLine("You don't have that much of amount");
                Console.WriteLine("How much do you wanna bet?");
                bet = 0;
                int.TryParse(Console.ReadLine(), out bet);
                amount.PlayerBet = bet;
                
            }

            Console.WriteLine("You've betted " + amount.PlayerBet);
            amount._myAmount -= amount.PlayerBet;


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
            Console.WriteLine("----------------");
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
                        Console.WriteLine("-----------------");
                        choice = false;
                        break;

                    default:
                        break;
                }
            }
            dealer.DealerGetCard();
            dealer.PrintDealerCard();
            Console.WriteLine("-----------------");
            rules.DealerMustDraw(dealer.DealerCard);
            var dealerresult = rules.DealerTooHigh(dealer.DealerCard);
           
            while (dealerresult < 17)
            {
                rules.DealerMustDraw(dealer.DealerCard);
                if (dealerresult > 17)
                {
                    dealerresult = rules.DealerTooHigh(dealer.DealerCard);
                    break; 
                }
                break;
            }
            
            
            Console.WriteLine("-----------------");
            Console.WriteLine("DealerResult is: " + dealerresult);
            rules.WhoWin(dealer.DealerCard, player.PlayerCard);
            
            if (rules.win == true)
            {
                amount.Win(amount.PlayerBet);
            }
            if (rules.win == false)
            {
                amount.Loose(amount.PlayerBet);
            }
            
            var myAmount=amount._myAmount;
            Console.WriteLine(amount.CheckValue());
            Console.WriteLine("Do you want to play again? (Y/N)");
            var answer = Console.ReadLine();
            if(answer.ToUpper()=="Y")
            {
                Console.Clear();
                PlayAgain();
            }
            else
            {
                Console.WriteLine("Bye Bye!!!");
                Console.ReadKey();
                Environment.Exit(0);
            }
           
            Console.ReadKey();
            
        }
        
    }
}
