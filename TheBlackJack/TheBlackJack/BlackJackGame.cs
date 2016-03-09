﻿using System;
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
           
            while (true)
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
            }
            }

           
        }  
}
}
