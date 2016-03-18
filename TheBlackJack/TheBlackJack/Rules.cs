using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBlackJack
{
    class Rules
    {
        Player player = new Player();
        Dealer dealer = new Dealer();


        public void TooHigh(List<Card>playerCard)
        {
            int result = 0;
            foreach (var item in playerCard)
            {
                result += item._value;
            }
            if(result>21)
            {
                Console.WriteLine("BUSTED!!!");
            }
        }
        public void DealerMustDraw(List<Card>dealerCard)
        {
            int result = 0;
            foreach (var item in dealerCard)
            {
                result += item._value;
            }
            if(result<17)
            {
                dealer.DealerGetCard();
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
            if(dealercard>playercard)
            {
                Console.WriteLine("Dealer Wins!!");
            }
            else if(dealercard < playercard)
            {
                Console.WriteLine("Player Wins!!");
            }
        }

    }
}
