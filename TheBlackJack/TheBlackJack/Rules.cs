﻿using System;
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
                Console.WriteLine("BUSTED!!!");
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
                Console.WriteLine("You have: " + result);
            }
            if (result > 21)
            {
                Console.WriteLine($"You got {result}, and that means you are BUSTED!!!");
            }
            if(result==21)
            {
                Console.WriteLine("You got: "+result);
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
            if (playercard > dealercard && playercard <= 21)
            {
                Console.WriteLine("Player Wins!!");
                
            }
            else if (dealercard > playercard && dealercard<=21)
            {
                Console.WriteLine("Dealer Wins!!");
            }
            if (playercard > dealercard && playercard > 21&&dealercard<=21)
            {
                Console.WriteLine("Dealer Wins!!");
            }
            else if (dealercard > playercard && dealercard > 21 && playercard <= 21)
            {
                Console.WriteLine("Player Wins!!");
            }
            if(playercard>21&&dealercard>21)
            {
                Console.WriteLine("Nobody wins");
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
