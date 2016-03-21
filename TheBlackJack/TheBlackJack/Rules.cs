using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBlackJack
{
    class Rules
    {
        private Dealer _dealer;
           

        public Rules(Dealer dealer)
        {
            this._dealer = dealer;
            
        }

        public int DealerTooHigh(List<Card> dealerCard)
        {
            int result = 0;
            foreach (var item in dealerCard)
            {
                result += item._value;
            }
            if (result > 21)
            {
                Console.WriteLine("BUSTED!!! Player Wins");
            }
            return result;
        }
        public int PlayerTooHigh(List<Card> playerCard)
        {
            int result = 0;
            foreach (var item in playerCard)
            {
                result += item._value;
               
            }
           if(result<21)
            {
                Console.WriteLine("You're not too high. You have: " + result);
            }
            if (result > 21)
            {
                Console.WriteLine($"You got {result}, and that means you are BUSTED!!! and Dealer Wins!!");
            }
            return result;
        }
        public void DealerMustDraw(List<Card> dealerCard)
        {
            int result = 0;
            foreach (var item in dealerCard)
            {
                result += item._value;
            }
            if (result < 17)
            {
                _dealer.DealerGetCard();
            }
            else
            {
                _dealer.PrintDealerCard();
            }

        }
        public void EqualsCardFive(List<Card> dealerCard, List<Card> playerCard)
        {

        }
        public void WhoWin(List<Card> dealerCard, List<Card> playerCard)
        {
            int playercard = 0;
            int dealercard = 0;
            foreach (var item in dealerCard)
            {
                dealercard += item._value;
            }
            foreach (var item in playerCard)
            {
                playercard += item._value;

            }
            if (dealercard < playercard)
            {
                Console.WriteLine("Player Wins!!");
            }
            else if (dealercard > playercard)
            {
                Console.WriteLine("Dealer Wins!!");
            }
            else if(dealercard == playercard)
            {
                if(playerCard.Count>=5)
                {
                    Console.WriteLine("Player Wins!!");
                }
                else if(playerCard.Count<5)
                {
                    Console.WriteLine("Dealer Wins!!");
                }
            }
        }

    }
}
