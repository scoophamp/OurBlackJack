using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

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
            player.PlayerCard.Clear();//Tar bort korten som spelaren hade förra omgången på handen
            dealer.DealerCard.Clear();//Tar bort korten som dealern hade förra omgången på handen
            Meny();
            GameOn();
        }

        public void Meny()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("             Black Jack");
            Console.WriteLine("");
            Console.WriteLine("____________________________________");
            Console.WriteLine("You have " + amount._myAmount + " coins.");
            Console.WriteLine("How much do you wanna bet?");
            Console.WriteLine("____________________________________");
            Console.ForegroundColor = ConsoleColor.White;
            int bet = 0;
            int.TryParse(Console.ReadLine(), out bet);//Gör om inputen till en int och kollar så att det är en siffra som har skrivits in
            amount.PlayerBet = bet;
            

            while (bet > amount._myAmount || bet == 0)
            {
                if (bet == 0)
                {
                    Console.WriteLine("You can't bet 0");
                }
                else
                {
                    Console.WriteLine("You don't have that much of amount");
                }
                
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
            
            var newDeck = deck.giveDeck();//Hämtar ny korlek
            dealer.ShuffleCard(newDeck);//Skickar kortleken till dealern som blandar den
            dealer.SetDeck(newDeck);//Dealern tar kortleken och lägger den till sin
            HitANewCard();//Player får ett nytt kort
            dealer.DealerGetCard();//Dealern får ett nytt kort
            HitANewCard();

            dealer.PrintDealerCard();//Skriver ut dealerns kort som den har på handen
            Console.WriteLine("----------------");
            player.PrintPlayerCard();//Skriver ut spelarens kort som den har på handen

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
                        var playerresult = rules.PlayerTooHigh(player.PlayerCard);//Kollar om spelarens kort är högre än 21
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
            rules.DealerMustDraw(dealer.DealerCard);//Skickar in dealerns korthand och ser om den är under 17 då måste den dra ett kort
            var dealerresult = rules.DealerTooHigh(dealer.DealerCard);
           //Här kollas dealerns kort om dem är under 17 eller inte
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

            dealerresult = rules.DealerTooHigh(dealer.DealerCard);
            Console.WriteLine("-----------------");
            Console.WriteLine("DealerResult is: " + dealerresult);
            rules.WhoWin(dealer.DealerCard, player.PlayerCard);//Här skickas båda händerna in för att kolla vem som vann
            //Här kollas det om spelaren har vunnit eller förlorat
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
            if (amount._myAmount == 0)
            {
                Console.WriteLine("You're out of money, good luck next time!");
                Console.WriteLine();
                Environment.Exit(0);

            }
            else
            {

                Console.WriteLine("Do you want to play again? (Y/N)");
                var answer = Console.ReadLine();
                //Om man vill spela en gång till så anropas metoden som kör spelet igen
                if (answer.ToUpper() == "Y")
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
            }
            
           
            Console.ReadKey();
            
        }
        
    }
}
